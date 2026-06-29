using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Socios_CamaraC
{
    internal class SocioServicio
    {
        public static bool ExisteSocio(int numSocio)
        {
            return SocioRepository.Existe(numSocio);
        }
        public static bool CrearSocio(Socio socio)
        {
            if (ExisteSocio(socio.NumSocio))
            {
                return false;
            }
            SocioRepository.Agregar(socio);
            return true;

        }
        public static bool TieneCuotasPagas(Socio socio)
        {
            return CuotaSocioRepository.TieneCuotasPagas(socio.NumSocio);
        }
        public static void EliminarInactivo(Socio socio)
        {
            if (!TieneCuotasPagas(socio))
            {
                SocioRepository.Borrar(socio);
            }
        }
        public static List<Socio> SociosPorCategoria(
            SqliteConnection conn, SqliteTransaction transaction, int categoria)
        {
            return SocioRepository.ListarPorCategoria(
                conn, transaction, categoria);
        }
        public static List<Socio> SociosInactivosPorPago(int cantidadCuotas)
        {
            return SocioRepository.ListarMorosos(cantidadCuotas);
        }

    }
}
