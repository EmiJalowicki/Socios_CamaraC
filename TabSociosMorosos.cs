using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class TabSociosMorosos : UserControl
    {
        bool cargando = false;
        public TabSociosMorosos()
        {
            InitializeComponent();
            v_SociosMorosos.AutoGenerateColumns = false;
            v_SociosMorosos.EnableHeadersVisualStyles = false;
            v_Cuotas.AutoGenerateColumns = false;
            //v_Cuotas.EnableHeadersVisualStyles = false;
            n_Cuotas.Minimum = 1;
            n_Cuotas.Maximum = 12;
            n_Cuotas.Value = 3;
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(v_SociosMorosos, true, null);

            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(v_Cuotas, true, null);
        }

        private void TabSociosInactivos_Load(object sender, EventArgs e)
        {
            btn_DarBaja.Enabled = false;

            this.BeginInvoke(new Action(() =>
            {
                ActualizarDatos();
            }));
        }
        public void ActualizarDatos()
        {
            CargarListaSocios();
            v_SociosMorosos.ClearSelection();
            v_SociosMorosos.CurrentCell = null;
            CargarListaCobranzas();
            ActualizarEstadoBoton();
        }
        //V_SOCIOS
        private void CargarListaSocios()
        {
            cargando = true;

            int cantidadCuotas = (int)n_Cuotas.Value;
            v_SociosMorosos.DataSource = null;
            var listaSocios = SocioServicio.SociosInactivosPorPago(cantidadCuotas);
            v_SociosMorosos.DataSource = listaSocios;

            cargando = false;
        }       
        //V_CUOTAS
        private void CargarListaCobranzas()
        {
            v_Cuotas.DataSource = null;
            Socio? socioSeleccionado = v_SociosMorosos.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado == null) return;

            cargando = true;
            var listaCuotasSocio =
                CuotaServicio.ListarCuotasSocio(socioSeleccionado);
            
            v_Cuotas.DataSource = listaCuotasSocio;
            v_Cuotas.Columns["Col_Importe"]!.DefaultCellStyle.Format = "C2";
            v_Cuotas.Columns["Col_Importe"]!.DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("es-AR");
            v_Cuotas.ClearSelection();
            v_Cuotas.CurrentCell = null;
            cargando = false;
            PintarCuotas();
        }
        private void PintarCuotas()
        {
            foreach (DataGridViewRow row in v_Cuotas.Rows)
            {
                if (row.DataBoundItem is CuotaSocio cuota && !cuota.EstaPaga)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        
        //Interacción con tablas
        private void n_Cuotas_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
            ActualizarEstadoBoton();
        }

        private void v_SociosMorosos_SelectionChanged(object sender, EventArgs e)
        {
            CargarListaCobranzas();
            ActualizarEstadoBoton();
        }

        //DAR DE BAJA
        private void btn_DarBaja_Click(object sender, EventArgs e)
        {
            Socio? socioSeleccionado = v_SociosMorosos.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado == null) return;
            var aviso = MessageBox.Show(
                $"Estás por dar de baja a: " +
                $"\n{socioSeleccionado.NumSocio}: {socioSeleccionado.NombreCompleto}" +
                $"\n ¿Estás seguro?", "Confirmar dada de baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (aviso == DialogResult.Yes)
            {
                SocioRepository.DarDeBaja(socioSeleccionado.NumSocio);
                ActualizarDatos();
            }
        }
        private void ActualizarEstadoBoton()
        {
            Socio? socioSeleccionado = v_SociosMorosos.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado == null)
            {
                btn_DarBaja.Enabled = false;
            }
            else
            {
                btn_DarBaja.Enabled = true;
            }
        }
    }
}
