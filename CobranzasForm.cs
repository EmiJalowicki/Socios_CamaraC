using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class CobranzasForm : Form
    {
        private bool cargando = false;
        public CobranzasForm()
        {
            InitializeComponent();
            v_Cobranzas.AutoGenerateColumns = false;
        }
        private void CobranzasForm_Load(object sender, EventArgs e)
        {
            btn_ModificarImporte.Enabled = false;
            btn_Eliminar.Enabled = false;
            CargarCategorias();
            CargarListaCobranzas();
            ActualizarEstadoBotones();
        }
        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListaCobranzas();
            v_Cobranzas.ClearSelection();
            ActualizarEstadoBotones();
        }

        private void CargarCategorias()
        {
            var categorias = CategoriaRepository.Listar();
            cmb_Categorias.DataSource = categorias;
            cmb_Categorias.DisplayMember = "CategoriaCMB";
            cmb_Categorias.ValueMember = "IdCategoria";
        }
        private void CargarListaCobranzas()
        {
            cargando = true;
            if (cmb_Categorias.SelectedValue is not int categoriaId)
            {
                cargando = false;
                return;
            }

            v_Cobranzas.DataSource = null;
            var listaCobranzas = CuotaRepository.ListarCuotasCategoria(categoriaId);
            v_Cobranzas.DataSource = listaCobranzas;

            v_Cobranzas.ClearSelection();
            v_Cobranzas.CurrentCell = null;
            cargando = false;

            ActualizarEstadoBotones();
        }

        //[*] [*] [*] BOTONES [*] [*] [*] 
        //NUEVA COBRANZA
        private void btn_NuevaCobranza_Click(object sender, EventArgs e)
        {
            if (cmb_Categorias.SelectedValue is not int categoriaId) return;
            using var menuAgregarCuota = new CuotaForm(categoriaId);
            if (menuAgregarCuota.ShowDialog() == DialogResult.OK)
            {
                CargarListaCobranzas();
            }
        }
        //MODIFICAR IMPORTE
        private void btn_ModificarImporte_Click(object sender, EventArgs e)
        {
            if (v_Cobranzas.CurrentRow == null) { return; }
            var cuota = v_Cobranzas.CurrentRow.DataBoundItem as Cuota;
            if (cuota == null) { return; }

            if (!ConfirmarModImporte(cuota)) return;
            
            //Se confirma modificación:
            using var menuModificarImporte = new ModificarImporteForm(cuota);
            if (menuModificarImporte.ShowDialog() == DialogResult.OK)
            {
                CargarListaCobranzas();
            }
        }
        private bool ConfirmarModImporte(Cuota cuota)
        {
            var confirmacion = MessageBox.Show(
                $"¿Desea modificar el importe de la cuota {cuota.Mes} de {cuota.Anio}?",
                "Modificar importe", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (confirmacion != DialogResult.Yes) { return false; }//Si "No", cierra borrado.
            //"Si":
            if (CuotaServicio.HaySocioPago(cuota.Periodo, cuota.CategoriaId))
            {
                var confirmarModificacion = MessageBox.Show(
                    $"Hay pagos hechos relacionados a la cuota {cuota.Mes} de {cuota.Anio}. " +
                    $"¿Desea modificarlo de todas formas?", "Confirmación de modificación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
                if (confirmarModificacion != DialogResult.Yes) { return false; }//Si "No", cierra modificación
            }
            return true;
        }


        //Aux Botones
        private void v_Cobranzas_SelectionChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            ActualizarEstadoBotones();
        }
        private void ActualizarEstadoBotones()
        {
            Cuota? cuotaSeleccionada = v_Cobranzas.CurrentRow?.DataBoundItem as Cuota;
            if (cuotaSeleccionada == null)
            {
                btn_ModificarImporte.Enabled = false;
                btn_Eliminar.Enabled = false;
            }
            else
            {
                btn_ModificarImporte.Enabled = true;
                btn_Eliminar.Enabled = true;
            }

        }


    }
}
