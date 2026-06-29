using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Socios_CamaraC
{
    internal class AnualServicio
    {
        //CRUD ANUAL
        public static bool ExisteAnual(
            SqliteConnection conn, SqliteTransaction transaction, int anio)
        {
            return (AnualRepository.Existe(conn, transaction, anio));
        }
        public static bool AnualCreado(
            SqliteConnection conn, SqliteTransaction transaction, int anio)
        {
            if (!ExisteAnual(conn, transaction, anio))
            {
                AnualRepository.Crear(conn, transaction, anio);
                return true;
            }
            return false;
        }
        
        public static List<Anual> ListarAnual()
        {
            return (AnualRepository.Listar());
        }
        public static bool AnualBorrado(int anio)
        {
            using var conn = ConexionBD.AbrirConexion();
            if (ExisteAnual(conn, null, anio))
            {
                AnualRepository.Borrar(anio);
                return true;
            }
            return false;
        }
        //CRUD ANUAL_SOCIO
        public static bool ExisteAnualSocio(
            SqliteConnection conn, SqliteTransaction transaction, 
            int numSocio, int anio)
        {
            if (!ExisteAnual(conn, transaction, anio)) return false;

            return (AnualSocioRepository.Existe(conn, transaction, numSocio, anio));
        }
        public static bool AnualSocioCreado(
            SqliteConnection conn, SqliteTransaction transaction, AnualSocio anualSocio)
        {
            AnualCreado(conn, transaction, anualSocio.Anio);
            if ( !ExisteAnualSocio(conn, transaction, 
                    anualSocio.NumSocio, anualSocio.Anio))
            {
                AnualSocioRepository.Crear(
                    conn, transaction, anualSocio.NumSocio, anualSocio.Anio,
                anualSocio.PeriodoInicio, anualSocio.FechaRegistro,
                anualSocio.ImporteTotal, anualSocio.ImportePorCuota);
                return true;
            }
            return false;
        }

        //Funcionalidades extra
        public static List<Socio> ListarSociosConAnual()
        {
            return SocioRepository.ListarSociosPagoAnual();
        }
        public static List<AnualSocio> ListarPagosAnualesSocio(int numSocio)
        {
            return (AnualSocioRepository.ListarAnualSocio(numSocio));
        }
        
        /* PAGAR ANUAL: Cada CuotaSocio desde periodoInicio -> estaPaga = 1
            (solo durante periodoInicio.Anio)*/
        public static void PagarAnual(Socio socio, DateTime periodoInicio)
        {
            decimal importeCuota = ObtenerImporteCuota(periodoInicio, socio.CategoriaId);
            int mesesRestantes = ObtenerMesesRestantes(periodoInicio);
            decimal importeTotal = importeCuota * mesesRestantes;

            var anualSocio = new AnualSocio(
                socio.NumSocio,
                periodoInicio.Year,
                periodoInicio,
                DateTime.Now,
                importeTotal,
                importeCuota);
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            try
            {
                AnualCreado(conn, transaction, anualSocio.Anio);
                AnualSocioCreado(conn, transaction, anualSocio);
                CuotaSocioRepository.ActualizarPagosAnuales(
                    conn, transaction,
                    socio, anualSocio);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            
        }
        public static decimal ObtenerImporteCuota(DateTime periodoInicio, int categoria)
        {
            Cuota? cuota = CuotaRepository.Obtener(periodoInicio, categoria);
            if (cuota == null) return 0m;
            return cuota.Importe;
        }
        public static int ObtenerMesesRestantes(DateTime periodoInicio)
        {
            return (12 - periodoInicio.Month + 1);
        }
        public static decimal ObtenerImporteTotalCuota(
            decimal importeCuota, int mesesRestantes)
        {
            return (importeCuota * mesesRestantes);
        }

        public static bool EstaDentroDeAnual(int numSocio, DateTime periodo)
        {
            var anualSocio = 
                AnualSocioRepository.ObtenerAnualSocio(numSocio, periodo.Year);
            if (anualSocio == null) return false;
            if (anualSocio.PeriodoInicio > periodo) return false;
            return true;
        }
    }
}
