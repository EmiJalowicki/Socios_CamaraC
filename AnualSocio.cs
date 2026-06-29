using System;
using System.Collections.Generic;
using System.Text;

namespace Socios_CamaraC
{
    internal class AnualSocio
    {
        public int NumSocio {  get; set; }
        public int Anio { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal ImportePorCuota { get; set; }

        //Constructor
        public AnualSocio(
            int numSocio,
            int anio,
            DateTime periodoInicio,
            DateTime fechaRegistro,
            decimal importeTotal,
            decimal importePorCuota
            )
        {
            //Comprobación
            if (importeTotal < 0)
                throw new ArgumentException("El total no puede ser negativo");

            if (importePorCuota < 0)
                throw new ArgumentException("El importe por cuota no puede ser negativo");
            //Asignar atributos
            NumSocio = numSocio;
            Anio = anio;
            PeriodoInicio = periodoInicio;
            FechaRegistro = fechaRegistro;
            ImporteTotal = importeTotal;
            ImportePorCuota = importePorCuota;
        }

        //Extras de diseño/visual

    }
}
