using System;
using System.Collections.Generic;
using System.Text;

namespace Socios_CamaraC
{
    public class SocioAnual
    {
        public Socio Socio { get; set; }
        public int Anio { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal ImportePorCuota { get; set; }

        //Datos Socio
        public int NumSocio => Socio?.NumSocio ?? 0;
        public string NombreCompleto => Socio?.NombreCompleto ?? "";
        public string DNI => Socio?.DNI ?? "";
        public string NumTelefono => Socio?.NumTelefono ?? "";
        public int CategoriaId => Socio?.CategoriaId ?? 0;
    }
}
