namespace Socios_CamaraC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                using var conn = ConexionBD.AbrirConexion();
                CrearBD.Iniciar(conn); //Iniciar BD
                MigracionBD.Aplicar(conn); //Aplicar actualización de BD
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al inicializar la base de datos:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}