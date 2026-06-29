using System.Globalization;
using System.Text;

namespace Socios_CamaraC
{
    internal class NormalizadorTexto
    {
        public static string Normalizar(string texto) //normaliza texto (para Buscador)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;
            texto = texto.ToLower();

            string formD = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char c in formD)
            {
                if (Char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
