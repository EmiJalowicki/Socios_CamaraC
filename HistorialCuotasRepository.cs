using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Socios_CamaraC
{
    internal class HistorialCuotasRepository
    {
        public class Historial
        {
            public DateTime FechaPago { get; set; }
            public int NumSocio {  get; set; }
            public string NombreCompleto { get; set; } = string.Empty;
            public int Categoria { get; set; }
            public DateTime Periodo { get; set; }
            public decimal Importe { get; set; }
            public bool EsAnual {  get; set; }
            //Caso ANUAL_SOCIO
            public DateTime? PeriodoInicio { get; set; }
            public DateTime? FechaRegistro { get; set; }
            public decimal? ImporteTotal { get; set; }
            public decimal? ImportePorCuota { get; set; }

            public string PeriodoTexto
            {
                get
                {
                    var texto = Periodo.ToString("MMMM yyyy",
                        CultureInfo.GetCultureInfo("es-AR"));
                    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
                }
            }
            public string DescripcionPeriodo
            {
                get
                {
                    bool anualCompleto =
                        EsAnual &&
                        PeriodoInicio.HasValue &&
                        FechaRegistro.HasValue &&
                        PeriodoInicio.Value.Month == 1 &&
                        FechaRegistro.Value.Month == 1 &&
                        Periodo == PeriodoInicio.Value;
                    if (anualCompleto)
                    {
                        return $"Anual {Periodo.Year}";
                    }

                    return PeriodoTexto;
                }
            }

        }
        public List<Historial> ListarHistorialCuotas(
            int? anio, int? mes, int? diaDesde, int? diaHasta, bool ocultarAnuales)
        {
            var historialCuotas = new List<Historial>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT
                    FechaPago,
                    NumSocio,
                    NombreCompleto,
                    IdCategoria,
                    Periodo,
                    Importe,
                    EsAnual,
                    PeriodoInicio,
                    FechaRegistro,
                    ImporteTotal,
                    ImportePorCuota
                FROM VW_HISTORIAL_CUOTAS
                WHERE (@Anio IS NULL OR strftime('%Y', FechaPago) = @Anio)
                    AND (@Mes IS NULL OR strftime('%m', FechaPago) = @Mes)
                    AND (
                          @DiaDesde IS NULL OR @DiaHasta IS NULL
                          OR CAST(strftime('%d', FechaPago) AS INTEGER)
                              BETWEEN @DiaDesde AND @DiaHasta
                        )

                ORDER BY FechaPago ASC,
                         EsAnual DESC,
                         NumSocio ASC,
                         Periodo ASC;";
            cmd.Parameters.AddWithValue("@Anio",
                anio.HasValue ? anio.Value.ToString() : DBNull.Value);
            cmd.Parameters.AddWithValue("@Mes",
                mes.HasValue ? mes.Value.ToString("D2") : DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaDesde",
                diaDesde ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaHasta",
                diaHasta ?? (object)DBNull.Value);

            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                historialCuotas.Add(new Historial
                {
                    FechaPago = respuesta.GetDateTime(0),
                    NumSocio = respuesta.GetInt32(1),
                    NombreCompleto = respuesta.GetString(2),
                    Categoria = respuesta.GetInt32(3),
                    Periodo = respuesta.GetDateTime(4),
                    Importe = respuesta.GetDecimal(5),
                    EsAnual = respuesta.GetInt32(6) == 1,
                    //Caso ANUAL_SOCIO
                    PeriodoInicio = respuesta.IsDBNull(7) ? null : respuesta.GetDateTime(7),
                    FechaRegistro = respuesta.IsDBNull(8) ? null : respuesta.GetDateTime(8),
                    ImporteTotal = respuesta.IsDBNull(9) ? null : respuesta.GetDecimal(9),
                    ImportePorCuota = respuesta.IsDBNull(10) ? null : respuesta.GetDecimal(10),
                });
            }
            historialCuotas = ProcesarAnuales(historialCuotas);
            if (ocultarAnuales) //Filtro OcultarAnuales
            {
                historialCuotas = historialCuotas.Where(h => !h.EsAnual).ToList();
            }
            return historialCuotas;
        }
        private List<Historial> ProcesarAnuales(List<Historial> historialCuotas)
        {
            var resultado = new List<Historial>();

            foreach (var cuota in historialCuotas)
            {
                if (!cuota.EsAnual)
                {
                    resultado.Add(cuota);
                    continue;
                }

                if (!cuota.PeriodoInicio.HasValue ||
                    !cuota.FechaRegistro.HasValue)
                {
                    resultado.Add(cuota);
                    continue;
                }

                bool anualCompleto =
                    cuota.PeriodoInicio.Value.Month == 1 &&
                    cuota.FechaRegistro.Value.Month == 1;

                // Si NO es un anual completo registrado en enero,
                // mostrar las cuotas normalmente.
                if (!anualCompleto)
                {
                    resultado.Add(cuota);
                    continue;
                }

                // Anual completo registrado en enero:
                // mostrar una sola fila con el importe total.
                if (cuota.Periodo == cuota.PeriodoInicio.Value)
                {
                    cuota.Importe = cuota.ImporteTotal ?? cuota.Importe;
                    resultado.Add(cuota);
                }
            }

            return resultado;
        }

        public static List<(int Anio, int Mes)> ObtenerPeriodosPagos()
        {
            var periodosCuotas = new List<(int Anio, int Mes)>();
            using var conn = ConexionBD.AbrirConexion();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT DISTINCT 
                    strftime('%Y', FechaPago) AS Anio,
                    strftime('%m', FechaPago) AS Mes
                FROM CUOTA_SOCIO
                WHERE EstaPaga = 1
                ORDER BY Anio DESC, Mes DESC;";
            using var respuesta = cmd.ExecuteReader();
            while (respuesta.Read())
            {
                int anio = respuesta.GetInt32(0);
                int mes = respuesta.GetInt32(1);
                periodosCuotas.Add((anio, mes));
            }
            return periodosCuotas;
        }

    }
}
