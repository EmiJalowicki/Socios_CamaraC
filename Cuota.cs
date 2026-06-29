using System.Globalization;

namespace Socios_CamaraC
{
    public class Cuota
    {
        public DateTime Periodo { get; set; }
        public decimal Importe { get; set; }
        public int CategoriaId { get; set; }
        public bool Aplicar { get; set; } = false;

        public int Anio => Periodo.Year;

        public string Mes =>
            CultureInfo
                .GetCultureInfo("es-AR")
                .TextInfo
                .ToTitleCase(Periodo.ToString("MMMM", new CultureInfo("es-AR")));
        public string MuestraImporte => Importe.ToString("C", new CultureInfo("es-AR"));

        //MESES PARA COMBOBOX
        public class MesItem
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }
        }

        public static List<MesItem> ObtenerMesesLista()
        {
            var nombres = new string[]
            {
                "Enero", "Febrero", "Marzo",
                "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre",
                "Octubre", "Noviembre", "Diciembre"
            };

            var lista = new List<MesItem>();
            for (int i = 0; i < nombres.Length; i++)
            {
                lista.Add(new MesItem
                {
                    Numero = i + 1,
                    Nombre = nombres[i]
                });
            }

            return lista;
        }

    }

}
