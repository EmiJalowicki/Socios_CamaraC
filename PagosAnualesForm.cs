using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class PagosAnualesForm : Form
    {
        public PagosAnualesForm()
        {
            InitializeComponent();
            v_SociosAnuales.AutoGenerateColumns = false;
            v_SociosAnuales.EnableHeadersVisualStyles = false;
            v_AniosPagos.AutoGenerateColumns = false;
            v_AniosPagos.EnableHeadersVisualStyles = false;
        }
        private void PagosAnuales_Load(object sender, EventArgs e)
        {
            CargarSociosAnuales();
            LimpiarDatosSocio();
            v_AniosPagos.DataSource = null;
        }
        private void ActualizarDatos(bool limpiar)
        {
            CargarSociosAnuales();
            if (limpiar)
            {
                v_SociosAnuales.ClearSelection();
                v_SociosAnuales.CurrentCell = null;
                v_AniosPagos.DataSource = null;
                LimpiarDatosSocio();
            }
        }
        //                              [v_SociosAnuales]
        private void CargarSociosAnuales()
        {
            v_SociosAnuales.DataSource = null;

            var listaSociosAnuales = AnualServicio.ListarSociosConAnual();
            v_SociosAnuales.DataSource = listaSociosAnuales;
        }
        private void MostrarDatosSocio(Socio socioAnual)
        {
            if (socioAnual == null)
            {
                LimpiarDatosSocio();
                return;
            }
            lbl_NumSocio_S.Text = socioAnual.NumSocio.ToString();
            lbl_Nombre_S.Text = socioAnual.NombreCompleto;
            lbl_Categoria_S.Text = socioAnual.CategoriaId.ToString();
            lbl_DNI_S.Text = string.IsNullOrWhiteSpace(
                socioAnual.DNI) ? "-" : socioAnual.DNI;
            lbl_NumTelefono_S.Text = string.IsNullOrWhiteSpace(
                socioAnual.NumTelefono) ? "-" : socioAnual.NumTelefono;

        }
        private void LimpiarDatosSocio()
        {
            lbl_NumSocio_S.Text = string.Empty;
            lbl_Nombre_S.Text = string.Empty;
            lbl_Categoria_S.Text = string.Empty;
            lbl_DNI_S.Text = string.Empty;
            lbl_NumTelefono_S.Text = string.Empty;
        }
        //                              [v_AniosPagos]
        private void CargarAniosPagos(Socio? socioSeleccionado)
        {
            v_AniosPagos.DataSource = null;
            if (socioSeleccionado != null)
            {
                var anualesSocio =
                    AnualSocioRepository.ListarAnualSocio(socioSeleccionado.NumSocio);
                v_AniosPagos.DataSource = anualesSocio;
            }
        }

        //Finaliza carga


        //Interacciones
        private void v_SociosAnuales_SelectionChanged(object sender, EventArgs e)
        {
            Socio? socioSeleccionado =
                v_SociosAnuales.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado != null)
            {
                MostrarDatosSocio(socioSeleccionado);
                CargarAniosPagos(socioSeleccionado);
                v_AniosPagos.ClearSelection();
            }
            else
            {
                LimpiarDatosSocio();
                v_AniosPagos.DataSource = null;
            }
        }

        //[·] [·] [·] BOTONES [·] [·] [·]
        //AGREGAR SOCIO
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            using var menuSocioAnual = new SocioAnualForm();
            menuSocioAnual.ShowDialog();
            ActualizarDatos(true);
        }

        private void PagosAnualesForm_Shown(object sender, EventArgs e)
        {
            v_SociosAnuales.ClearSelection();
            v_SociosAnuales.CurrentCell = null;
            LimpiarDatosSocio();
            v_AniosPagos.DataSource = null;
            btn_Agregar.Focus();
        }
        //CERRAR
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
