using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Socios_CamaraC
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal ImporteBase { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
        public string CategoriaCMB => $"{IdCategoria} - {Descripcion}";
        public string MuestraImporteBase => ImporteBase.ToString("C", new CultureInfo("es-AR"));
    }
}
