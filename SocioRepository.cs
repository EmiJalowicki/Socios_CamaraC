using System.Data;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace Socios_CamaraC
{
    internal class SocioRepository
    {
        //CRUD
        public static bool Existe(int numSocio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            SELECT 1
            FROM SOCIO 
            WHERE NumSocio = @NumSocio
            LIMIT 1;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);

            using var resultado = cmd.ExecuteReader();
            return resultado.Read();
        }
        public static void Agregar(Socio socio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                INSERT INTO SOCIO
                (NumSocio, Apellido, ApellidoNorm, Nombre, NombreNorm, DNI, Sexo, 
                 FechaNacimiento, NumTelefono, CalleNombre, CalleNum, Localidad, 
                 FechaAlta, Categoria, EstaActivo)
                VALUES
                (@NumSocio, @Apellido, @ApellidoNorm, @Nombre, @NombreNorm, @DNI, @Sexo, 
                 @FechaNacimiento, @NumTelefono, @CalleNombre, @CalleNum, @Localidad, 
                 @FechaAlta, @Categoria, 1)
                ";

            cmd.Parameters.AddWithValue("@NumSocio", socio.NumSocio);
            cmd.Parameters.AddWithValue("@Apellido", socio.Apellido);
            cmd.Parameters.AddWithValue("@ApellidoNorm",
                NormalizadorTexto.Normalizar(socio.Apellido));
            cmd.Parameters.AddWithValue("@Nombre", socio.Nombre);
            cmd.Parameters.AddWithValue("@NombreNorm",
                NormalizadorTexto.Normalizar(socio.Nombre));
            cmd.Parameters.AddWithValue("@DNI", socio.DNI ?? string.Empty);
            cmd.Parameters.AddWithValue("@Sexo", socio.Sexo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", socio.FechaNacimiento.HasValue
                                                                ? socio.FechaNacimiento.Value.ToString("yyyy-MM-dd")
                                                                : DBNull.Value);
            cmd.Parameters.AddWithValue("@NumTelefono", socio.NumTelefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@CalleNombre", socio.CalleNombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@CalleNum", DarValorInt(socio.CalleNum));
            cmd.Parameters.AddWithValue("@Localidad", socio.Localidad ?? string.Empty);
            cmd.Parameters.AddWithValue("@FechaAlta", socio.FechaAlta.HasValue
                                                        ? socio.FechaAlta.Value.ToString("yyyy-MM-dd")
                                                        : DBNull.Value);
            cmd.Parameters.AddWithValue("@Categoria", socio.CategoriaId);

            cmd.ExecuteNonQuery();

            //Asignarle cuota del mes actual (si existe)
            DateTime fechaActual = DateTime.Now;
            DateTime periodo = CuotaRepository.ObtenerPeriodoSeleccionado(
                fechaActual.Year,
                fechaActual.Month
                );
            using var cmdCuota = conn.CreateCommand();
            cmdCuota.CommandText = @"
                INSERT INTO CUOTA_SOCIO (NumSocio, Periodo, Categoria, EstaPaga)
                SELECT @NumSocio, c.Periodo, c.Categoria, 0
                FROM CUOTA c
                WHERE c.Periodo = @Periodo
                AND c.Categoria = @Categoria;
                ";

            cmdCuota.Parameters.AddWithValue("@NumSocio", socio.NumSocio);
            cmdCuota.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmdCuota.Parameters.AddWithValue("@Categoria", socio.CategoriaId);

            cmdCuota.ExecuteNonQuery();
        }

        //Aux Agregar()
        public static int ObtenerNumSocioSiguiente(SqliteConnection conn)
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IFNULL(MAX(NumSocio), 0) + 1 FROM SOCIO;";
            return Convert.ToInt32(cmd.ExecuteScalar()); //devuelve el valor (.obj) y convierte a int
        }
        private static object DarValorInt(int? valor) //cuando int puede ser null
        {
            return valor.HasValue ? valor.Value : DBNull.Value;
        }


        public static List<Socio> Listar(bool incluirInactivos, string filtro)
        {
            var listaSocios = new List<Socio>();

            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    NumSocio,
                    Apellido,
                    Nombre,
                    DNI,
                    Sexo,
                    FechaNacimiento,
                    NumTelefono,
                    CalleNombre,
                    CalleNum,
                    Localidad,
                    FechaAlta,
                    Categoria,
                    EstaActivo
                FROM SOCIO
                WHERE (@IncluirInactivos = 1 OR EstaActivo = 1)
                    AND (
                        @Filtro = ''
                        OR NumSocio LIKE @FiltroNum
                        OR DNI LIKE @FiltroNum
                        OR ApellidoNorm LIKE @FiltroNorm
                        OR NombreNorm LIKE @FiltroNorm
                        OR (ApellidoNorm || ' ' || NombreNorm) LIKE @FiltroNorm
                        OR (NombreNorm || ' ' || ApellidoNorm) LIKE @FiltroNorm
                    )
                ORDER BY NumSocio;
            ";
            //Filtro socios activos/inactivos
            cmd.Parameters.AddWithValue("@IncluirInactivos", incluirInactivos ? 1 : 0);
            // Filtrar resultados según Buscador
            cmd.Parameters.AddWithValue("@Filtro", filtro);
            cmd.Parameters.AddWithValue("@FiltroTxt", filtro + "%");
            cmd.Parameters.AddWithValue("@FiltroNum", filtro + "%");
            string filtroNorm = NormalizadorTexto.Normalizar(filtro);
            cmd.Parameters.AddWithValue("@FiltroNorm", filtroNorm + "%");

            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var socio = Mapear(respuesta);
                listaSocios.Add(socio);
            }
            return listaSocios;
        }

        public static List<Socio> ListarActivos()
        {
            return Listar(false, "");
        }

        public static List<Socio> ListarPorCategoria(
            SqliteConnection conn, SqliteTransaction transaction, int categoria)
        {
            var listaSocios = new List<Socio>();

            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                SELECT
                    NumSocio,
                    Apellido,
                    Nombre,
                    DNI,
                    Sexo,
                    FechaNacimiento,
                    NumTelefono,
                    CalleNombre,
                    CalleNum,
                    Localidad,
                    FechaAlta,
                    Categoria,
                    EstaActivo
                FROM SOCIO
                WHERE Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var socio = Mapear(respuesta);
                listaSocios.Add(socio);
            }
            return listaSocios;
        }

        //QUITAR
        public static void DarDeBaja(int numSocio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            UPDATE SOCIO
            SET EstaActivo = 0
            WHERE NumSocio = @NumSocio;
            ";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.ExecuteNonQuery();
        }

        //REINGRESAR
        public static void Reingresar(int numSocio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            UPDATE SOCIO
            SET EstaActivo = 1
            WHERE NumSocio = @NumSocio;
            ";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.ExecuteNonQuery();
        }

        //MODIFICAR
        public static void Modificar(Socio socio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                UPDATE SOCIO
                SET
                    Apellido = @Apellido,
                    ApellidoNorm = @ApellidoNorm,
                    Nombre = @Nombre,
                    NombreNorm = @NombreNorm,
                    DNI = @DNI,
                    Sexo = @Sexo,
                    FechaNacimiento = @FechaNacimiento,
                    NumTelefono = @NumTelefono,
                    CalleNombre = @CalleNombre,
                    CalleNum = @CalleNum,
                    Localidad = @Localidad,
                    FechaAlta = @FechaAlta
                WHERE NumSocio = @NumSocio;
            ";

            cmd.Parameters.AddWithValue("@NumSocio", socio.NumSocio);
            cmd.Parameters.AddWithValue("@Apellido", socio.Apellido);
            cmd.Parameters.AddWithValue("@ApellidoNorm",
                NormalizadorTexto.Normalizar(socio.Apellido));
            cmd.Parameters.AddWithValue("@Nombre", socio.Nombre);
            cmd.Parameters.AddWithValue("@NombreNorm",
                NormalizadorTexto.Normalizar(socio.Nombre));
            cmd.Parameters.AddWithValue("@DNI", socio.DNI ?? string.Empty);
            cmd.Parameters.AddWithValue("@Sexo", socio.Sexo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", socio.FechaNacimiento.HasValue
                                                                ? socio.FechaNacimiento.Value.ToString("yyyy-MM-dd")
                                                                : DBNull.Value);
            cmd.Parameters.AddWithValue("@NumTelefono", socio.NumTelefono ?? string.Empty);
            cmd.Parameters.AddWithValue("@CalleNombre", socio.CalleNombre ?? string.Empty);
            cmd.Parameters.AddWithValue("@CalleNum", DarValorInt(socio.CalleNum));
            cmd.Parameters.AddWithValue("@Localidad", socio.Localidad ?? string.Empty);
            cmd.Parameters.AddWithValue("@FechaAlta", socio.FechaAlta.HasValue
                                                        ? socio.FechaAlta.Value.ToString("yyyy-MM-dd")
                                                        : DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        //Borrar (DEFINITIVO!)
        public static void Borrar(Socio socio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                DELETE FROM SOCIO
                WHERE NumSocio = @NumSocio;";
            cmd.Parameters.AddWithValue("@NumSocio", socio.NumSocio);
            cmd.ExecuteNonQuery();
        }

        //Por utilidad:
        public static List<Socio> ListarMorosos(int cantidadCuotas)
        {
            var listaSocios = new List<Socio>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    s.NumSocio,
                    s.Apellido,
                    s.Nombre,
                    s.DNI,
                    s.Sexo,
                    s.FechaNacimiento,
                    s.NumTelefono,
                    s.CalleNombre,
                    s.CalleNum,
                    s.Localidad,
                    s.FechaAlta,
                    s.Categoria,
                    s.EstaActivo
                FROM SOCIO s
                WHERE s.EstaActivo = 1
                    AND (
                        SELECT COUNT(*)
                        FROM (
                            SELECT cs.EstaPaga
                            FROM CUOTA_SOCIO cs
                            WHERE cs.NumSocio = s.NumSocio
                            ORDER BY cs.Periodo DESC
                            LIMIT @CantidadCuotas
                        )
                    ) = @CantidadCuotas
                    AND (
                        SELECT SUM(cs.EstaPaga)
                        FROM (
                            SELECT cs.EstaPaga
                            FROM CUOTA_SOCIO cs
                            WHERE cs.NumSocio = s.NumSocio
                            ORDER BY cs.Periodo DESC
                            LIMIT @CantidadCuotas
                        ) cs
                    ) = 0;";

            cmd.Parameters.AddWithValue("@CantidadCuotas", cantidadCuotas);
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var socio = Mapear(respuesta);
                listaSocios.Add(socio);
            }
            return listaSocios;
        }
        public static List<Socio> ListarSociosPagoAnual()
        {
            var listaSociosPagoAnual = new List<Socio>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    s.NumSocio,
                    s.Apellido,
                    s.Nombre,
                    s.DNI,
                    s.Sexo,
                    s.FechaNacimiento,
                    s.NumTelefono,
                    s.CalleNombre,
                    s.CalleNum,
                    s.Localidad,
                    s.FechaAlta,
                    s.Categoria,
                    s.EstaActivo
                FROM SOCIO s
                WHERE EXISTS (
                    SELECT 1
                    FROM ANUAL_SOCIO a
                    WHERE a.NumSocio = s.NumSocio
                )
                ORDER BY s.NumSocio;";
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                var socio = Mapear(respuesta);
                listaSociosPagoAnual.Add(socio);
            }
            return listaSociosPagoAnual;
        }

        //Mapeo Socio
        private static Socio Mapear(SqliteDataReader r)
        {
            return new Socio
            {
                NumSocio = r.GetInt32(0),
                Apellido = r.GetString(1),
                Nombre = r.GetString(2),
                DNI = r.IsDBNull(3) ? null : r.GetString(3),
                Sexo = r.GetString(4),
                FechaNacimiento = r.IsDBNull(5) ? null : DateTime.Parse(r.GetString(5)),
                NumTelefono = r.IsDBNull(6) ? null : r.GetString(6),
                CalleNombre = r.IsDBNull(7) ? null : r.GetString(7),
                CalleNum = r.IsDBNull(8) ? null : r.GetInt32(8),
                Localidad = r.IsDBNull(9) ? null : r.GetString(9),
                FechaAlta = DateTime.Parse(r.GetString(10)),
                CategoriaId = r.GetInt32(11),
                EstaActivo = r.GetInt32(12) == 1
            };
        }

    }
}
