using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class TabHistorialCobranzas : UserControl
    {
        private bool cargandoFormulario = false;
        private readonly HistorialCuotasRepository _repo = new HistorialCuotasRepository();
        public TabHistorialCobranzas()
        {
            InitializeComponent();
            typeof(DataGridView)
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .SetValue(v_HistorialCobranzas, true, null);
        }
        private void TabHistorialCobranzas_Load(object sender, EventArgs e)
        {
            cargandoFormulario = true;
            v_HistorialCobranzas.EnableHeadersVisualStyles = false;
            v_HistorialCobranzas.AutoGenerateColumns = false;
            CargarCMBQuincena();
            CargarPeriodosPagos();
            InicializarFiltros();

            this.BeginInvoke(new Action(() =>
            {
                v_HistorialCobranzas.Visible = false;
                CargarHistorial();
                v_HistorialCobranzas.Visible = true;
                v_HistorialCobranzas.ClearSelection();
                cargandoFormulario = false;
            }));

        }
        public void ActualizarDatos()
        {
            cargandoFormulario = true;
            CargarCMBQuincena();
            CargarPeriodosPagos();
            InicializarFiltros();
            CargarHistorial();
            v_HistorialCobranzas.ClearSelection();
            cargandoFormulario = false;
        }

        //Inicio de TAB
        private void CargarCMBQuincena()
        {
            cmb_Quincena.Items.Clear();
            cmb_Quincena.Items.Add("Primera");
            cmb_Quincena.Items.Add("Segunda");
            cmb_Quincena.SelectedIndex = 0;
            LlenarCamposFiltroDias();
        }
        private void LlenarCamposFiltroDias()
        {
            if (cmb_FMes.SelectedItem is not int mes)
            {
                return;
            }
            int anio = (int)num_FAnio.Value;
            int ultimoDiaMes = DateTime.DaysInMonth(anio, mes);
            int corte = (int)Math.Ceiling(DateTime.DaysInMonth(anio, mes) / 2.0);//Mitad de mes. Redondeado
            int diaCorte = ObtenerProximoLunes(anio, mes, corte);

            if (cmb_Quincena.SelectedIndex == 0)
            {
                txt_DDesde.Text = "1";
                txt_DHasta.Text = (diaCorte - 1).ToString();
            }
            else
            {
                txt_DDesde.Text = diaCorte.ToString();
                txt_DHasta.Text = ultimoDiaMes.ToString();
            }
            LimpiarErroresFiltroDia();
            CargarHistorial();
        }
        private int ObtenerProximoLunes(int anio, int mes, int diaFiltro)
        {
            DateTime fecha = new DateTime(anio, mes, diaFiltro);
            int diasHastaLunes = ((int)DayOfWeek.Monday - (int)fecha.DayOfWeek + 7) % 7;

            return fecha.AddDays(diasHastaLunes).Day;
        }
        private void CargarHistorial()
        {
            int? anio = null;

            if (chk_FiltrarAnio.Checked)
            {
                anio = (int)num_FAnio.Value;
            }

            int? mes = null;
            if (chk_FiltrarMes.Checked && cmb_FMes.SelectedItem is int mesValor)
            {
                mes = mesValor;
            }

            int? diaDesde = null;
            int? diaHasta = null;

            LimpiarErroresFiltroDia();
            if (chk_FiltrarDias.Checked)
            {
                if (!ValidarRangoDias(out diaDesde, out diaHasta))
                {
                    return;
                }
            }
            bool ocultarAnuales = chk_OcultarAnuales.Checked;

            var historialCuotas = _repo.ListarHistorialCuotas(
                anio, mes, diaDesde, diaHasta, ocultarAnuales);

            v_HistorialCobranzas.DataSource = null;
            v_HistorialCobranzas.DataSource = historialCuotas;
            if (v_HistorialCobranzas.Columns.Count == 0) return; //Seguridad por si null
            var colImporte = v_HistorialCobranzas.Columns["Col_ImporteH"];
            if (colImporte != null)
            {
                colImporte.DefaultCellStyle.Format = "C2";
                colImporte.DefaultCellStyle.FormatProvider =
                    new System.Globalization.CultureInfo("es-AR");
            }

            var colFecha = v_HistorialCobranzas.Columns["Col_FechaPagoH"];
            if (colFecha != null)
            {
                colFecha.DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            PintarHistorial();
            CargarTotalCuotas(historialCuotas);
            v_HistorialCobranzas.ClearSelection();
        }

        private void LimpiarErroresFiltroDia()
        {
            ep_AvisoError.SetError(txt_DDesde, "");
            ep_AvisoError.SetError(txt_DHasta, "");
        }

        //Carga de filtros
        private void cmb_Quincena_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            LlenarCamposFiltroDias();
        }
        private bool ValidarRangoDias(
            out int? diaDesde,
            out int? diaHasta)
        {
            diaDesde = null;
            diaHasta = null;

            LimpiarErroresFiltroDia();

            // Si el filtro de días NO está activo, no validamos nada
            if (!chk_FiltrarDias.Checked)
                return true;

            // Validar números
            if (!int.TryParse(txt_DDesde.Text, out int dDesde) || dDesde < 1)
            {
                ep_AvisoError.SetError(
                    txt_DDesde, "Ingrese un día válido (>= 1)");
                return false;
            }

            if (!int.TryParse(txt_DHasta.Text, out int dHasta) || dHasta < 1)
            {
                ep_AvisoError.SetError(
                    txt_DHasta, "Ingrese un día válido (>= 1)");
                return false;
            }

            // Si hay año y mes activos → validar contra el mes real
            if (chk_FiltrarAnio.Checked &&
                chk_FiltrarMes.Checked &&
                cmb_FMes.SelectedItem is int mes)
            {
                int anio = (int)num_FAnio.Value;
                int ultimoDiaMes = DateTime.DaysInMonth(anio, mes);

                if (dDesde > ultimoDiaMes)
                {
                    ep_AvisoError.SetError(
                        txt_DDesde, $"El mes tiene solo {ultimoDiaMes} días");
                    return false;
                }

                if (dHasta > ultimoDiaMes)
                {
                    ep_AvisoError.SetError(
                        txt_DHasta, $"El mes tiene solo {ultimoDiaMes} días");
                    return false;
                }
            }

            // Orden lógico
            if (dDesde > dHasta)
            {
                ep_AvisoError.SetError(
                    txt_DDesde, "'Desde' no puede ser mayor que 'Hasta'");
                ep_AvisoError.SetError(
                    txt_DHasta, "'Hasta' debe ser mayor o igual a 'Desde'");
                return false;
            }

            diaDesde = dDesde;
            diaHasta = dHasta;
            return true;
        }
        private void CargarPeriodosPagos()
        {
            cargandoFormulario = true;
            //Crea lista de periodos
            var periodos = HistorialCuotasRepository.ObtenerPeriodosPagos();
            if (periodos.Count == 0)
            {
                return;
            }
            var anios = periodos
                .Select(periodo => periodo.Anio)
                .Distinct()
                .OrderByDescending(anio => anio)
                .ToList();
            //Filtro Años
            num_FAnio.Minimum = anios.Min();
            num_FAnio.Maximum = anios.Max();
            num_FAnio.Value = anios.First(); // o el actual

            //Filtro Meses según Año seleccionado
            CargarFiltroMeses(anios.First());

            //Elijo el actual por default
            MarcarPeriodoActual(anios);

            cargandoFormulario = false;
        }
        private void CargarFiltroMeses(int anio)
        {
            cargandoFormulario = true;

            var periodos = HistorialCuotasRepository.ObtenerPeriodosPagos();
            var meses = periodos.Where(periodo => periodo.Anio == anio).
                        Select(periodo => periodo.Mes).Distinct().
                        OrderBy(mes => mes).ToList();
            cmb_FMes.DataSource = meses;

            cargandoFormulario = false;
        }
        private void MarcarPeriodoActual(List<int> aniosDisponibles)
        {
            int anioActual = DateTime.Today.Year;
            int mesActual = DateTime.Today.Month;
            //Marcar este año. Si no hay, elige el último.
            if (aniosDisponibles.Contains(anioActual))
            {
                num_FAnio.Value = anioActual;
            }
            else
            {
                num_FAnio.Value = aniosDisponibles.FirstOrDefault();
            }
            //Marcar este mes. Si no hay mes actual, elige el último.
            if (cmb_FMes.Items.Contains(mesActual))
            {
                cmb_FMes.SelectedItem = mesActual;
            }
            else if (cmb_FMes.Items.Count > 0)
            {
                cmb_FMes.SelectedIndex = cmb_FMes.Items.Count - 1;
            }
        }
        private void InicializarFiltros()
        {
            LimpiarErroresFiltroDia();
            chk_FiltrarAnio.Checked = true;
            chk_FiltrarMes.Checked = true;
            chk_FiltrarDias.Checked = false;
            cmb_Quincena.SelectedIndex = 0;
        }

        //[·] [·] [·] BOTONES [·] [·] [·]
        //Filtro año
        private void num_FAnio_ValueChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;

            CargarFiltroMeses((int)num_FAnio.Value);
            LlenarCamposFiltroDias();
            CargarHistorial();
        }
        private void chk_FiltrarAnio_CheckedChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            CargarHistorial();
        }
        private void chk_FiltrarMes_CheckedChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            CargarHistorial();
        }
        private void chk_FiltrarDias_CheckedChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            CargarHistorial();
        }
        private void chk_OcultarAnuales_CheckedChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            CargarHistorial();
        }

        private void cmb_FMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            LlenarCamposFiltroDias();
            CargarHistorial();
        }
        //Filtro dias
        private void txt_DDesde_TextChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }
        private void txt_DHasta_TextChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // TOTAL
        private void CargarTotalCuotas(List<HistorialCuotasRepository.Historial> historialCuotas)
        {
            decimal totalCuotas = historialCuotas.Sum(historial => historial.Importe);
            txt_Total.Text = totalCuotas.ToString("C2", new CultureInfo("es-AR"));
        }


        //Visuales
        private void PintarHistorial()
        {
            foreach (DataGridViewRow row in v_HistorialCobranzas.Rows)
            {
                if (row.DataBoundItem is HistorialCuotasRepository.Historial cuotaPaga
                    && cuotaPaga.EsAnual)
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }
        private void v_HistorialCobranzas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (v_HistorialCobranzas.Rows[e.RowIndex].DataBoundItem
                is HistorialCuotasRepository.Historial cuotaPaga)
            {
                if (cuotaPaga.EsAnual)
                    v_HistorialCobranzas.Rows[e.RowIndex].DefaultCellStyle.ForeColor =
                        Color.Green;
                else
                    v_HistorialCobranzas.Rows[e.RowIndex].DefaultCellStyle.ForeColor =
                        Color.Black;
            }
        }

    }
}
