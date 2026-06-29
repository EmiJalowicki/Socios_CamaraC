using System.Globalization;

namespace Socios_CamaraC
{
    internal class CuotaRepository
    {
        public static void Agregar(Cuota cuota)
        {
            using var conn = ConexionBD.AbrirConexion();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO CUOTA
                    (Periodo, Categoria, Importe)
                VALUES 
                    (@Periodo, @Categoria, @Importe);
                ";
            cmd.Parameters.AddWithValue("@Periodo", cuota.Periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", cuota.CategoriaId);
            cmd.Parameters.AddWithValue("@Importe", cuota.Importe);

            cmd.ExecuteNonQuery();
        }
        public static void Modificar(DateTime periodo, int categoria, decimal importe)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE CUOTA
                SET Importe = @Importe
                WHERE Periodo = @Periodo
                    AND Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@Importe", importe);

            cmd.ExecuteNonQuery();
        }
        public static bool ExisteCuota(DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT 1
                FROM CUOTA
                WHERE Periodo = @Periodo
                    AND Categoria = @Categoria
                LIMIT 1;";

            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            using var respuesta = cmd.ExecuteReader();
            return respuesta.Read();
        }

        public static Cuota? Obtener(DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Periodo, Categoria, Importe
                FROM CUOTA
                WHERE Periodo = @Periodo
                    AND Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);

            using var respuesta = cmd.ExecuteReader();
            if (!respuesta.Read())
            {
                return null;
            }

            return new Cuota //Si nada falla, se crea la cuota, se asigna y se hace return
            {
                Periodo = DateTime.ParseExact(
                    respuesta.GetString(0),
                    "yyyy-MM-dd", CultureInfo.InvariantCulture),
                CategoriaId = respuesta.GetInt32(1),
                Importe = respuesta.GetDecimal(2)
            };
        }
        public static void Borrar(DateTime periodo, int categoria)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                DELETE FROM CUOTA
                WHERE Periodo = @Periodo
                    AND Categoria = @Categoria;";
            cmd.Parameters.AddWithValue("@Periodo", periodo.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.ExecuteNonQuery();
        }

        public static DateTime ObtenerPeriodoSeleccionado(int anio, int mes)
        {
            if (anio < 1 || anio > 9999)
                throw new ArgumentOutOfRangeException(nameof(anio));

            if (mes < 1 || mes > 12)
                throw new ArgumentOutOfRangeException(nameof(mes));

            return new DateTime(anio, mes, 1, 0, 0, 0, DateTimeKind.Unspecified);
        }

        public static List<Cuota> ListarCuotasCategoria(int categoria)
        {
            var listaCuotas = new List<Cuota>();

            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT Periodo, Categoria, Importe
                FROM CUOTA
                WHERE Categoria = @Categoria
                ORDER BY Periodo DESC;";
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                listaCuotas.Add(new Cuota
                {
                    Periodo = respuesta.GetDateTime(0),
                    CategoriaId = respuesta.GetInt32(1),
                    Importe = Convert.ToDecimal(respuesta.GetDouble(2))
                });
            }
            return listaCuotas;
        }
        public static Cuota? ObtenerCuotaMasActual(int categoriaId)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT Periodo, Categoria, Importe
                FROM CUOTA
                WHERE Categoria = @Categoria
                ORDER BY Periodo DESC
                LIMIT 1;";
            cmd.Parameters.AddWithValue("@Categoria", categoriaId);

            using var respuesta = cmd.ExecuteReader();
            if (respuesta.Read())
            {
                return new Cuota
                {
                    Periodo = respuesta.GetDateTime(0),
                    CategoriaId = respuesta.GetInt32(1),
                    Importe = Convert.ToDecimal(respuesta.GetDouble(2))
                };
            }
            return null;
        }

        public static Cuota? ObtenerCuotaMasAntigua()
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT Periodo, Categoria, Importe
                FROM CUOTA
                ORDER BY Periodo ASC
                LIMIT 1;";

            using var respuesta = cmd.ExecuteReader();
            if (respuesta.Read())
            {
                return new Cuota
                {
                    Periodo = respuesta.GetDateTime(0),
                    CategoriaId = respuesta.GetInt32(1),
                    Importe = Convert.ToDecimal(respuesta.GetDouble(2))
                };
            }

            return null; // no hay cuotas
        }
    }
}
