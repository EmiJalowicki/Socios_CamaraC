namespace Socios_CamaraC
{
    internal class EjecutarSQL
    {
        public static void DesdeArchivo(string rutaSQL)
        {
            if (!File.Exists(rutaSQL))
            {
                throw new FileNotFoundException("No existe el archivo SQL", rutaSQL);
            }
            string scriptSQL = File.ReadAllText(rutaSQL);
            Ejecutar(scriptSQL);
        }

        public static void Ejecutar(string scriptSQL)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = scriptSQL;
            cmd.ExecuteNonQuery();
        }
    }
}
