using System.Transactions;

namespace Socios_CamaraC
{
    internal class CuotaServicio
    {
        public static void CrearOAsignar(
            int numSocio,
            DateTime periodo,
            int categoria,
            decimal importe)
        {
            if (!ExisteCategoria(categoria))
            {
                throw new ArgumentException($"La categoria {categoria} no existe!");
            }
            if (!CuotaRepository.ExisteCuota(periodo, categoria))//Si no existe, se crea
            {
                ProcesarNuevaCuota(new Cuota
                {
                    Periodo = periodo,
                    CategoriaId = categoria,
                    Importe = importe
                });
            }
            AsignarCuotaASocio(numSocio, periodo, categoria, false);
        }
        public static void CrearYAsignarATodos(DateTime periodo, int categoria, decimal importe)
        {
            if (!ExisteCategoria(categoria)) //Si no existe Categoria
            {
                throw new ArgumentException($"La categoria {categoria} no existe!");
            }

            if (!CuotaRepository.ExisteCuota(periodo, categoria))//Si no existe Cuota, se crea
            {
                ProcesarNuevaCuota(new Cuota
                {
                    Periodo = periodo,
                    CategoriaId = categoria,
                    Importe = importe
                });
            }
            
            List<Socio> listaSociosActivos = SocioRepository.ListarActivos();

            // Solo asignar a socios cuya categoria coincida con la de la cuota
            foreach (var socio in listaSociosActivos.Where(s => s.CategoriaId == categoria))
            {
                AsignarCuotaASocio(socio.NumSocio, periodo, categoria, false);
            }
        }
        private static void ProcesarNuevaCuota(Cuota cuota)
        {
            CuotaRepository.Agregar(cuota);
            HallarNuevaCuotaMax(cuota);
        }
        private static void HallarNuevaCuotaMax(Cuota cuota)
        {
            var cuotaMasActual = CuotaRepository.ObtenerCuotaMasActual(cuota.CategoriaId);
            if (cuotaMasActual != null && cuota.Periodo == cuotaMasActual.Periodo)
            {
                CategoriaRepository.ActualizarImporteBase(cuota.CategoriaId, cuota.Importe);
            }
        }
        public static Cuota? ObtenerCuotaMasAntigua()
        {
            return (CuotaRepository.ObtenerCuotaMasAntigua());
        }
        public static void AsignarCuotaASocio(
            int numSocio,
            DateTime periodo,
            int categoria, 
            bool estaPaga)// Crea Cuota-Socio puntual
        {
            if (!CuotaSocioRepository.ExisteCuotaSocio(numSocio, periodo, categoria))
            {
                CuotaSocioRepository.Asignar(numSocio, periodo, categoria, estaPaga);
            }
        }
        public static List<CuotaSocio> ListarCuotasSocio(Socio socio)
        {
            return CuotaSocioRepository.ListarCuotas(socio.NumSocio, true);
        }
        public static void ModificarImporte(DateTime periodo, int categoria, decimal importe)
        {
            if (importe < 0) //Seguro. "importe" ya debería ser valido
                throw new ArgumentException("El importe debe ser mayor a cero.");
            CuotaRepository.Modificar(periodo, categoria, importe);
            var cuota = new Cuota
            {
                Periodo = periodo,
                CategoriaId = categoria,
                Importe = importe
            };
            HallarNuevaCuotaMax(cuota);
        }

        private static bool ExisteCategoria(int categoria)
        {
            return CategoriaRepository.Existe(categoria);
        }

        public static bool HaPagadoSocio(int numSocio, DateTime periodo, int categoria)
        {
            return (CuotaSocioRepository.EstaPaga(numSocio, periodo, categoria));
        }

        public static bool HaySocioPago(DateTime periodo, int categoria)
        {
            return (CuotaSocioRepository.TieneAlgunSocioPago(periodo, categoria));
        }

        public static void CambiarEstadoPago(
            int numSocio, 
            DateTime periodo, 
            int categoria, 
            bool estadoPago)
        {
            CuotaSocioRepository.ActualizarPago(numSocio, periodo, categoria, estadoPago);
        }

        public static void QuitarCuotaSocio(int numSocio, DateTime periodo, int categoria)
        {
            CuotaSocioRepository.Borrar(numSocio, periodo, categoria);
            BorrarCuotaInutil(periodo, categoria);
        }

        public static void BorrarCuotaInutil(DateTime periodo, int categoria)
        {
            if (!CuotaSocioRepository.TieneAlgunSocioPago(periodo, categoria))
            {
                CuotaRepository.Borrar(periodo, categoria);
            }
        }

        public static void AplicarCuotasASociosPorCategoria(List<Cuota> listaCuotas)
        {
            using var conn = ConexionBD.AbrirConexion();
            using var transaction = conn.BeginTransaction();
            try
            {
                foreach (var cuota in listaCuotas)
                {
                    var listaSocios = SocioServicio.SociosPorCategoria(
                        conn, transaction, cuota.CategoriaId);
                    foreach (var socio in listaSocios)
                    {
                        CuotaSocioRepository.Asignar(conn, transaction,
                            socio.NumSocio, cuota.Periodo, cuota.CategoriaId, false);
                    }
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}
