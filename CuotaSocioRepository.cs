using Microsoft.Data.Sqlite;
using System.Security.Cryptography;

namespace Socios_CamaraC
{
    internal class CuotaSocioRepository
    {
        public static void Asignar(int numSocio,
            DateTime periodo,
            int categoria,
            bool estaPaga)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            Asignar(conn, transaction, numSocio, periodo, categoria, estaPaga);
            transaction.Commit();
        }
        public static void Asignar(
            SqliteConnection conn,
            SqliteTransaction transaction,
            int numSocio, 
            DateTime periodo, 
            int categoria, 
            bool estaPaga
            )
        {
            bool tieneAnual = EsPeriodoAnual(conn, transaction, numSocio, periodo);
            bool estaFinalmentePaga = tieneAnual || estaPaga;
            object fechaPago = estaFinalmentePaga
                ? periodo.ToString("yyyy-MM-dd HH:mm:ss") //acá
                : DBNull.Value;
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            
            cmd.CommandText = @"
                INSERT OR IGNORE INTO CUOTA_SOCIO (NumSocio, Periodo, Categoria, EstaPaga, FechaPago)
                VALUES (@NumSocio, @Periodo, @Categoria, @EstaPaga, @FechaPago);";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@EstaPaga", estaFinalmentePaga ? 1 : 0);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);

            cmd.ExecuteNonQuery();
        }
        private static bool EsPeriodoAnual(
            SqliteConnection conn, 
            SqliteTransaction transaction,  
            int numSocio, DateTime periodo)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                SELECT 1
                FROM ANUAL_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Anio = @Anio
                    AND @Periodo >= PeriodoInicio
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Anio", periodo.Year);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));

            var resultado = cmd.ExecuteScalar();
            return (resultado != null);
        }

        public static void ActualizarPago(
            int numSocio, 
            DateTime periodo,
            int categoria,
            bool estaPaga)
        {
            object fechaPago = DarValorFechaPago(estaPaga);
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE CUOTA_SOCIO
                SET EstaPaga = @EstaPaga, FechaPago = @FechaPago
                WHERE NumSocio = @NumSocio
                    AND Periodo = @Periodo
                    AND Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@EstaPaga", estaPaga ? 1 : 0);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);

            cmd.ExecuteNonQuery();
        }

        public static void ActualizarPagosAnuales(
            SqliteConnection conn,
            SqliteTransaction transaction,
            Socio socio,
            AnualSocio anualSocio
            )
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                UPDATE CUOTA_SOCIO
                SET EstaPaga = 1,
                    FechaPago = @FechaPago
                WHERE NumSocio = @NumSocio
                    AND Periodo >= @PeriodoInicio
                    AND Categoria = @Categoria
                    AND strftime('%Y', Periodo) = @AnioStr
                    AND EstaPaga = 0;";
            cmd.Parameters.AddWithValue("@FechaPago",
                                        anualSocio.FechaRegistro.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@NumSocio", socio.NumSocio);
            cmd.Parameters.AddWithValue("@PeriodoInicio",
                                        anualSocio.PeriodoInicio.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", socio.CategoriaId);
            cmd.Parameters.AddWithValue("@AnioStr", anualSocio.Anio.ToString());

            cmd.ExecuteNonQuery();
        }

        public static void Borrar(int numSocio, DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                DELETE FROM CUOTA_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Periodo = @Periodo
                    AND Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            cmd.ExecuteNonQuery();
        }
        public static List<CuotaSocio> ListarCuotas(int numSocio, bool incluirImpagas)
        {
            var listaCuotas = new List<CuotaSocio>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT cs.NumSocio, cs.Periodo, cs.Categoria, cs.EstaPaga, cs.FechaPago,
                    COALESCE (a.ImportePorCuota, c.Importe) as ImporteFinal
                FROM CUOTA_SOCIO cs
                INNER JOIN CUOTA c ON cs.Periodo = c.Periodo AND cs.Categoria = c.Categoria
                LEFT JOIN ANUAL_SOCIO a ON cs.NumSocio = a.NumSocio
                    AND strftime('%Y', cs.Periodo) = CAST(a.Anio AS TEXT)
                    AND cs.Periodo >= a.PeriodoInicio
                WHERE cs.NumSocio = @NumSocio
                AND (@IncluirImpagas = 1 OR cs.EstaPaga = 1)
                ORDER BY cs.Periodo DESC;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            //Filtro pagas/impagas
            cmd.Parameters.AddWithValue("@IncluirImpagas", incluirImpagas ? 1 : 0);

            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                listaCuotas.Add(new CuotaSocio
                {
                    NumSocio = respuesta.GetInt32(0),
                    Periodo = respuesta.GetDateTime(1),
                    CategoriaId = respuesta.GetInt32(2),
                    EstaPaga = respuesta.GetInt32(3) == 1,
                    FechaPago = respuesta.IsDBNull(4) 
                        ? null : respuesta.GetDateTime(4),
                    Importe = respuesta.GetDecimal(5)
                });
            }

            return listaCuotas;
        }
        public static bool ExisteCuotaSocio(int numSocio, DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            bool existe = ExisteCuotaSocio(conn, transaction, 
                numSocio, periodo, categoria);
            transaction.Commit();
            return existe;
        }
        public static bool ExisteCuotaSocio(
            SqliteConnection conn, 
            SqliteTransaction transaction,
            int numSocio, DateTime periodo, int categoria) //Hay cuota asignada
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = @"
                SELECT 1
                FROM CUOTA_SOCIO
                WHERE NumSocio = @NumSocio
                    AND Periodo = @Periodo
                    AND Categoria = @Categoria
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            using var respuesta = cmd.ExecuteReader();
            return respuesta.Read();
        }
        public static bool EstaPaga(int numSocio, DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT EstaPaga
                FROM CUOTA_SOCIO
                WHERE NumSocio = @NumSocio
                  AND Periodo = @Periodo
                  AND Categoria = @Categoria;";

            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            var result = cmd.ExecuteScalar();
            return result != null && Convert.ToInt32(result) == 1;
        }

        public static bool TieneAlgunSocioPago(DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT 1
                FROM CUOTA_SOCIO
                WHERE Periodo = @Periodo
                    AND Categoria = @Categoria
                    AND EstaPaga = @EstaPaga 
                LIMIT 1;";

            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@EstaPaga", 1);

            using var respuesta = cmd.ExecuteReader();
            return respuesta.Read();
        }
        public static bool TieneCuotasPagas(int numSocio)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT 1
                FROM CUOTA_SOCIO
                WHERE NumSocio = @NumSocio
                    AND EstaPaga = @EstaPaga
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@NumSocio", numSocio);
            cmd.Parameters.AddWithValue("@EstaPaga", 1);

            using var respuesta = cmd.ExecuteReader();
            return respuesta.Read();
        }

        //Modulo
        private static object DarValorFechaPago(bool estaPaga)
        {
            return estaPaga ? (object)DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value;
        }

    }
}
