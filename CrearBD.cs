using Microsoft.Data.Sqlite;
using System.Reflection;

namespace Socios_CamaraC
{
    internal static class CrearBD
    {
        public static void Iniciar(SqliteConnection conn)
        {
            if (!EsBaseNueva(conn)) return;

            var assembly = Assembly.GetExecutingAssembly();

            // ⚠️ AJUSTAR si cambia carpeta / namespace
            const string recursoSql =
                "Socios_CamaraC.Archivos.CREATE_BD_camara.sql";

            using var stream = assembly.GetManifestResourceStream(recursoSql);
            using var reader = new StreamReader(stream!);

            string sql = reader.ReadToEnd();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public static bool EsBaseNueva(SqliteConnection conn)
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT COUNT(*) 
                FROM sqlite_master 
                WHERE type='table' 
                    AND name='SOCIO';";
            long cantidad = (long)cmd.ExecuteScalar()!;

            return cantidad == 0;
        }
    }
}