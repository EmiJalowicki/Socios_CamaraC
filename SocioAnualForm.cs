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
    public partial class SocioAnualForm : Form
    {
        private decimal _importeTotalActual = 0m;
        public SocioAnualForm()
        {
            InitializeComponent();
            v_socios.AutoGenerateColumns = false;
            v_socios.EnableHeadersVisualStyles = false;
            btn_Agregar.Enabled = false;
        }
        private void SocioAnualForm_Load(object sender, EventArgs e)
        {
            CargarPeriodo();
            ActualizarDatos();

        }
        private void ActualizarDatos()
        {
            CargarSocios();
            ActualizarBotones();
            ActualizarImportes();
        }
        private void CargarSocios()
        {
            v_socios.DataSource = null;
            string filtro = txt_Buscador.Text.Trim();
            var listaSocios = SocioRepository.Listar(false, filtro);
            v_socios.DataSource = listaSocios;
        }
        private void CargarPeriodo()
        {
            Cuota? cuotaMasAntigua = CuotaServicio.ObtenerCuotaMasAntigua();
            int anioMinimo = cuotaMasAntigua?.Periodo.Year ?? DateTime.Now.Year;

            num_Anio.Minimum = anioMinimo;
            num_Anio.Maximum = num_Anio.Minimum + 5;
            num_Anio.Value = DateTime.Now.Year;
            cmb_Meses.DataSource = Cuota.ObtenerMesesLista();
            cmb_Meses.DisplayMember = "Nombre";
            cmb_Meses.ValueMember = "Numero";
            cmb_Meses.SelectedValue = DateTime.Now.Month;
        }
        private void ActualizarBotones()
        {
            bool haySocio = v_socios.SelectedRows.Count > 0;
            bool importeValido = _importeTotalActual > 0;
            btn_Agregar.Enabled = haySocio && importeValido;
        }
        private void ActualizarImportes()
        {
            if (!HayPeriodo() || v_socios.SelectedRows.Count == 0)
            {
                LimpiarImporte();
                _importeTotalActual = 0m;
                ActualizarBotones();
                return;
            }
            Socio? socioSeleccionado = v_socios.CurrentRow.DataBoundItem as Socio;
            if (socioSeleccionado == null)
            {
                LimpiarImporte();
                _importeTotalActual = 0m;
                ActualizarBotones();
                return;
            }

            int anio = (int)num_Anio.Value;
            int mes = (int)cmb_Meses.SelectedValue;
            DateTime periodoInicio = CuotaRepository.ObtenerPeriodoSeleccionado(anio, mes);
            decimal importeCuota = AnualServicio.ObtenerImporteCuota(
                periodoInicio, socioSeleccionado.CategoriaId);
            int mesesRestantes = AnualServicio.ObtenerMesesRestantes(periodoInicio);
            decimal importeTotal = AnualServicio.ObtenerImporteTotalCuota(
                importeCuota, mesesRestantes);

            _importeTotalActual = importeTotal;
            txt_ImporteCuota.Text = FormatearMoneda(importeCuota);
            txt_ImporteTotal.Text = FormatearMoneda(importeTotal);
        }
        private void LimpiarImporte()
        {
            txt_ImporteCuota.Text = string.Empty;
            txt_ImporteTotal.Text = string.Empty;
        }
        private void Validar()//Si no hay socio o cuota: apagar Agregar e importe = 0
        {
            if (v_socios.CurrentRow == null)
            {
                LimpiarImporte();
                _importeTotalActual = 0m;
            }
            else
            {
                ActualizarImportes();
            }
            ActualizarBotones();
        }
        //Finaliza la carga
        private void v_socios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            v_socios.ClearSelection();
            v_socios.CurrentCell = null;
        }
        private void SocioAnualForm_Shown(object sender, EventArgs e)
        {
            v_socios.ClearSelection();
            v_socios.CurrentCell = null;
            num_Anio.Focus();
        }

        //Interacciones
        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        private void pb_Lupa_Click(object sender, EventArgs e)
        {
            txt_Buscador.Focus();
            txt_Buscador.SelectAll();
        }
        private void v_socios_CurrentCellChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void cmb_Meses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }
        private void num_Anio_ValueChanged(object sender, EventArgs e)
        {
            Validar();
        }

        //[*] [*] [*] BOTONES [*] [*] [*] 
        //AGREGAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!HayPeriodo()) return;
            Socio? socioSeleccionado = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado == null) return;
            int anio = (int)num_Anio.Value;
            int mes = (int)cmb_Meses.SelectedValue;

            if (!ConfirmarSocioAnual(socioSeleccionado, anio)) return;
            DateTime periodoInicio = CuotaRepository.ObtenerPeriodoSeleccionado(anio, mes);
            AnualServicio.PagarAnual(socioSeleccionado, periodoInicio);
            MessageBox.Show("Pago anual registrado!", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ConfirmarSocioAnual(Socio socio, int anio)
        {
            var confirmacion = MessageBox.Show(
                $"Socio N°{socio.NumSocio}: {socio.NombreCompleto}" +
                $"\n Ha pagado por completo el año {anio}" +
                $"\n ¿Es correcto?", "Confirmar pago anual",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (confirmacion == DialogResult.Yes);
        }
        //CERRAR
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Auxiliares: Importe
        public static string FormatearMoneda(decimal valor)
        {
            return valor.ToString("C2", new CultureInfo("es-AR"));
        }
        private bool HayPeriodo()
        {
            return (cmb_Meses.SelectedValue != null);
        }

    }
}
