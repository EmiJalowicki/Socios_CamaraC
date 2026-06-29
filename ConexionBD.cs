using Microsoft.Data.Sqlite;

namespace Socios_CamaraC
{
    internal class ConexionBD
    {
        private static readonly string conectarDB = $"Data Source={RutasBD.archivoDb}";

        public static SqliteConnection AbrirConexion()
        {   //Abre
            var conn = new SqliteConnection(conectarDB);
            conn.Open();
            //Activa Fk en la Base de Datos
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "PRAGMA foreign_keys = ON;";
            cmd.ExecuteNonQuery();
            //Crea bd_Camara.db si no existe
            bool existeDb = File.Exists(RutasBD.archivoDb);
            if (!existeDb)
            {
                CrearBD.Iniciar(conn);
            }
            //Lectura mientras otro escribe el .db
            cmd.CommandText = "PRAGMA journal_mode = WAL;";
            cmd.ExecuteNonQuery();
            //Devuelve la conexión para que lo use quien lo solicita
            return conn;
        }
    }
}
