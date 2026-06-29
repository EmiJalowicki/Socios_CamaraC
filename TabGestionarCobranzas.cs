using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Socios_CamaraC
{
    public partial class TabGestionarCobranzas : UserControl
    {
        private bool cargando = false;
        public TabGestionarCobranzas()
        {
            InitializeComponent();
            v_Cobranzas.AutoGenerateColumns = false;
        }
        private void TabGestionarCobranzas_Load(object sender, EventArgs e)
        {
            btn_ModificarImporte.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_AplicarCobranzas.Enabled = false;

            this.BeginInvoke(new Action(() =>
            {
                CargarCategorias();
                CargarListaCobranzas();
                ActualizarEstadoBotones();
            }));

        }
        public void ActualizarDatos()
        {
            CargarListaCobranzas();
            v_Cobranzas.ClearSelection();
            ActualizarEstadoBotones();
        }
        private void cmb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
            chk_MarcarTodo.Checked = false;
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
                ActualizarDatos();
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
                ActualizarDatos();
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

        //ELIMINAR
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (v_Cobranzas.CurrentRow == null) { return; }
            var cuota = v_Cobranzas.CurrentRow.DataBoundItem as Cuota;
            if (cuota == null) { return; }
            if (!ConfirmarEliminacion(cuota)) return;
            //Si se confirma, borrar cobranza
            CuotaServicio.BorrarCuotaInutil(cuota.Periodo, cuota.CategoriaId);
            ActualizarDatos();

        }
        private bool ConfirmarEliminacion(Cuota cuota)
        {
            if (CuotaServicio.HaySocioPago(cuota.Periodo, cuota.CategoriaId))
            {
                MessageBox.Show(
                    $"Hay pagos realizados para {cuota.Mes} de {cuota.Anio}. " +
                    "\nNo es posible eliminar esta cobranza.",
                    "Imposible borrar", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return false;
            } //Si hay pagos -> No se puede

            var confirmarEliminacion = MessageBox.Show(
                $"¿Borrar la cobranza de {cuota.Mes} de {cuota.Anio}?", "Eliminar cobranza",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            return confirmarEliminacion == DialogResult.Yes;
        }
        //APLICAR COBRANZA(S)
        private void btn_AplicarCobranzas_Click(object sender, EventArgs e)
        {
            var listaCuotas = v_Cobranzas.DataSource as List<Cuota>;
            if (listaCuotas == null) return;
            var cuotasSeleccionadas = listaCuotas.Where(c => c.Aplicar).ToList();
            string plural = "";
            var cuenta = cuotasSeleccionadas.Count();
            if (cuenta > 1) { plural = "s"; }
            if (ConfirmarAplicarCobranzas(cuotasSeleccionadas, plural))
            {
                CuotaServicio.AplicarCuotasASociosPorCategoria(cuotasSeleccionadas);
                MessageBox.Show($"Cobranza{plural} añadida{plural} exitosamente",
                    "", MessageBoxButtons.OK);
            }

        }
        private bool ConfirmarAplicarCobranzas(List<Cuota> listaCuotas, string plural)
        {
            Categoria categoriaSeleccionada = (Categoria)cmb_Categorias.SelectedItem;
            string descripcion = categoriaSeleccionada.Descripcion;
            var respuesta = MessageBox.Show(
                $"¿Desea aplicar esta{plural} cobranza{plural} a todos " +
                $"los socios de la categoria {descripcion}?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return respuesta == DialogResult.Yes;
        }

        private void CambiarTextoAplicarCobranza()
        {
            var listaCuotas = v_Cobranzas.DataSource as List<Cuota>;
            if (listaCuotas == null) return;
            var cuenta = listaCuotas.Count(c => c.Aplicar);
            if (cuenta <= 1)
            {
                btn_AplicarCobranzas.Text = "Aplicar cobranza";
            }
            else
            {
                btn_AplicarCobranzas.Text = "Aplicar cobranzas";
            }
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
            var listaCuotas = (List<Cuota>)v_Cobranzas.DataSource;
            btn_AplicarCobranzas.Enabled =
                listaCuotas != null && listaCuotas.Any(c => c.Aplicar);
            CambiarTextoAplicarCobranza();
        }

        //APLICAR (Actualizar tabla cuando se marca)
        private void v_Cobranzas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (v_Cobranzas.IsCurrentCellDirty)
            {
                v_Cobranzas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void v_Cobranzas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
                v_Cobranzas.Columns[e.ColumnIndex].Name == "Col_AplicarChk")
            {
                ActualizarEstadoBotones();
            }
        }

        private void chk_MarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            var listaCuotas = v_Cobranzas.DataSource as List<Cuota>;
            if (listaCuotas == null) return;

            bool marcar = chk_MarcarTodo.Checked;

            foreach (var cuota in listaCuotas)
            {
                cuota.Aplicar = marcar;
            }

            v_Cobranzas.Refresh();
            ActualizarEstadoBotones();
        }
    }
}
