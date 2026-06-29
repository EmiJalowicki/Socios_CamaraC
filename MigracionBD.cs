using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.Reflection;

namespace Socios_CamaraC
{
    internal class MigracionBD
    {
        private const int VERSION_ACTUAL = 2; 
        public static void Aplicar(SqliteConnection conn)
        {
            int versionActual = ObtenerVersion(conn);
            if (versionActual > VERSION_ACTUAL)
            {
                throw new Exception(
                    $"La base de datos es más nueva que la aplicación. " +
                    $"Versión BD: {versionActual}, Versión App: {VERSION_ACTUAL}");
            }
            if (versionActual == VERSION_ACTUAL)
            {
                return;
            }

            for (int version = versionActual + 1;
                 version <= VERSION_ACTUAL;
                 version++)
            {
                EjecutarMigracion(conn, version);
            }

        }
        public static int ObtenerVersion(SqliteConnection conn)
        {
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "PRAGMA user_version;";
            object? resultado = cmd.ExecuteScalar();
            return Convert.ToInt32(resultado);
        }
        public static void EjecutarMigracion(SqliteConnection conn, int version)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string recursoSQL = $"Socios_CamaraC.Archivos.MIGRACION_V{version}.sql";
            using var stream = assembly.GetManifestResourceStream(recursoSQL);
            if (stream == null)
            {
                throw new Exception(
                    $"No se encontró recurso SQL: {recursoSQL}");
            }

            using var reader = new StreamReader(stream);
            string sql = reader.ReadToEnd();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

    }
}
