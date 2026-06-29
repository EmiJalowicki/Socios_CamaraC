namespace Socios_CamaraC
{
    internal class ValidarDatos
    {
        public static bool EsVacio(int numero)
        {
            return (numero == 0);
        }
        public static bool EsVacio(string? dato)
        {
            return (string.IsNullOrWhiteSpace(dato));
        }
        public static bool EsNumeroYValido(string? dato)
        {
            return (int.TryParse(dato, out int numero) && numero >= 0);
        }
        public static bool EsDNIValido(string dni)
        {
            return (dni.Length == 8);
        }
        public static bool EsImporteValido(decimal importe)
        {
            return (importe > 0);
        }
    }
}
