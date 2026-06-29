using System.Globalization;

namespace Socios_CamaraC
{
    internal class CuotaSocio
    {
        public int NumSocio { get; set; }
        public DateTime Periodo { get; set; }
        public int CategoriaId { get; set; }
        public bool EstaPaga { get; set; }
        public DateTime? FechaPago { get; set; }
        public decimal Importe { get; set; }

        public int Anio => Periodo.Year;

        public string Mes =>
            CultureInfo
                .GetCultureInfo("es-AR")
                .TextInfo
                .ToTitleCase(Periodo.ToString("MMMM", new CultureInfo("es-AR")));
        public string MuestraImporte => Importe.ToString("C", new CultureInfo("es-AR"));
    }

}
