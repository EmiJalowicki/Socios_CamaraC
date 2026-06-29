using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Socios_CamaraC
{
    public partial class TabSocios : UserControl
    {
        private bool cargando = false;
        private Timer _timerBusqueda;
        public TabSocios()
        {
            InitializeComponent();
            v_socios.EnableHeadersVisualStyles = false;
            v_socios.AutoGenerateColumns = false;
            _timerBusqueda = new Timer();
            _timerBusqueda.Interval = 300; // milisegundos
            _timerBusqueda.Tick += (s, e) =>
            {
                _timerBusqueda.Stop();
                ActualizarDatos(true);
            };
            typeof(DataGridView)
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .SetValue(v_socios, true, null);

        }

        private void TabSocios_Load(object sender, EventArgs e)
        {
            cargando = true;
            chk_MostrarInactivos.Checked = false;
            txt_Buscador.PlaceholderText =
                "Buscar: Nº Socio, Apellido(s), Nombre(s), DNI...";
            
            this.BeginInvoke(new Action(() =>
            {
                ActualizarDatos(false);
                v_socios.ClearSelection();
                v_socios.CurrentCell = null;
                btn_Agregar_Socio.Focus();
                ActualizarBotones();
            }));

        }
        public void ActualizarDatos(bool limpiar)
        {
            CargarSocios();
            if (limpiar)
            {
                v_socios.ClearSelection();
                v_socios.CurrentCell = null;
                //btn_Agregar_Socio.Focus();
                ActualizarBotones();
            }
        }
        private void CargarSocios()
        {
            cargando = true;
            int? socioSeleccionado = ObtenerSocioSeleccionado();
            bool mostrarInactivos = chk_MostrarInactivos.Checked;
            string filtro = txt_Buscador.Text.Trim();
            v_socios.DataSource = null;

            var listaSocios = SocioRepository.Listar(mostrarInactivos, filtro);
            v_socios.DataSource = listaSocios;

            bool socioSeleccionadoRestaurado = false;
            if (socioSeleccionado.HasValue)
            {
                socioSeleccionadoRestaurado = ExisteSocioSeleccionado(
                                                socioSeleccionado.Value);
            }
            if (!socioSeleccionadoRestaurado)
            {
                v_socios.ClearSelection();
                v_socios.CurrentCell = null;
            }
            cargando = false;
            PintarInactivos();
            ActualizarBotones();
        }
        private void ActualizarBotones()
        {
            Socio? socioSeleccionado = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socioSeleccionado == null)
            {
                btn_Quitar_Socio.Text = "Dar de baja";
                btn_Quitar_Socio.Enabled = false;
                btn_Modificar_Socio.Enabled = false;
                btn_CobranzaSocio.Enabled = false;
                btn_EliminarSocio.Enabled = false;
            }
            else if (!socioSeleccionado.EstaActivo)
            {
                btn_Quitar_Socio.Text = "Reingresar";
                btn_Quitar_Socio.Enabled = true;
                btn_EliminarSocio.Enabled = true;
                btn_Modificar_Socio.Enabled = false;
                btn_CobranzaSocio.Enabled = false;
            }
            else
            {
                btn_Quitar_Socio.Text = "Dar de baja";
                btn_Quitar_Socio.Enabled = true;
                btn_Modificar_Socio.Enabled = true;
                btn_CobranzaSocio.Enabled = true;
                btn_EliminarSocio.Enabled = false;
            }
        }

        //Mantener Socio seleccionado
        int? ObtenerSocioSeleccionado()
        {
            int? numSocioSeleccionado = null;
            if (v_socios.CurrentRow?.DataBoundItem is Socio socio)
            {
                numSocioSeleccionado = socio.NumSocio;
            }
            return numSocioSeleccionado;
        }
        bool ExisteSocioSeleccionado(int numSocio)
        {
            foreach (DataGridViewRow fila in v_socios.Rows)
            {
                if (fila.DataBoundItem is Socio s && s.NumSocio == numSocio)
                {
                    fila.Selected = true;
                    v_socios.CurrentCell = fila.Cells[0];
                    return true;
                }
            }
            return false;
        }

        //Interacciones
        private void v_socios_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            _timerBusqueda.Stop();   // cancela si había uno en curso
            _timerBusqueda.Start();  // reinicia el conteo
        }

        private void chk_MostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDatos(false);
        }

        private void pb_Lupa_Click(object sender, EventArgs e)
        {
            txt_Buscador.Focus();
            txt_Buscador.SelectAll();
        }

        //[·] [·] [·] BOTONES [·] [·] [·]
        //AGREGAR SOCIO
        private void btn_Agregar_Socio_Click(object sender, EventArgs e)
        {
            using var menuAgregarSocio = new SocioForm();
            if (menuAgregarSocio.ShowDialog() == DialogResult.OK)
            {
                ActualizarDatos(true);
            }
        }
        //MODIFICAR SOCIO
        private void btn_Modificar_Socio_Click(object sender, EventArgs e)
        {
            Socio? socio = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socio == null) return;

            using var menuModificarSocio = new SocioForm(socio);
            if (menuModificarSocio.ShowDialog() == DialogResult.OK)
            {
                ActualizarDatos(false);
            }
        }
        //DAR DE BAJA / REINGRESAR
        private void btn_Quitar_Socio_Click(object sender, EventArgs e)
        {
            Socio? socio = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socio == null) return;
            bool confirmacion = false;

            if (socio.EstaActivo) //DAR DE BAJA
            {
                confirmacion = ConfirmarBtn_Quitar(socio, "dar de baja");
                if (confirmacion)
                {
                    SocioRepository.DarDeBaja(socio.NumSocio);
                    bool accion = true;
                    if (chk_MostrarInactivos.Checked)
                    {
                        accion = false;
                    }
                    ActualizarDatos(accion);
                }
            }
            else //REINGRESAR
            {
                confirmacion = ConfirmarBtn_Quitar(socio, "reingresar");
                if (confirmacion)
                {
                    SocioRepository.Reingresar(socio.NumSocio);
                    ActualizarDatos(false);
                }
            }
        }
        private bool ConfirmarBtn_Quitar(Socio socio, string accion)
        {
            var respuesta = MessageBox.Show(
                                $"Está por {accion} a " +
                                $"\n{socio.NumSocio}: {socio.NombreCompleto}" +
                                $"\n ¿Desea continuar?", $"Confirmar {accion}",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                );
            return (respuesta == DialogResult.Yes);
        }
        //COBRANZAS SOCIO
        private void btn_CobranzaSocio_Click(object sender, EventArgs e)
        {
            Socio? socio = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socio == null) return;

            using var menuCobranzasSocio = new CuotaSocioForm(socio);
            if (menuCobranzasSocio.ShowDialog() == DialogResult.Cancel)
            {
                ActualizarDatos(true);
            }
        }
        //ELIMINAR SOCIO
        private void btn_EliminarSocio_Click(object sender, EventArgs e)
        {
            Socio? socio = v_socios.CurrentRow?.DataBoundItem as Socio;
            if (socio == null) return;
            bool confirmacion = ConfirmarBtn_EliminarSocio(socio);
            if (confirmacion)
            {
                SocioServicio.EliminarInactivo(socio);
                ActualizarDatos(true);
                MessageBox.Show(
                    "Socio eliminado exitosamente", "", MessageBoxButtons.OK);
            }
        }
        private bool ConfirmarBtn_EliminarSocio(Socio socio)
        {
            if (SocioServicio.TieneCuotasPagas(socio))
            {
                MessageBox.Show(
                    $"Hay pagos registrados a nombre de {socio.NombreCompleto}",
                    "Imposible eliminar socio",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var respuesta = MessageBox.Show(
                $"Está por eliminar DEFINITIVAMENTE a" +
                $"\n{socio.NumSocio}: {socio.NombreCompleto}" +
                $"\n¿Desea continuar?", "Confirmar borrado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return (respuesta == DialogResult.Yes);
        }
        //PAGOS ANUALES
        private void btn_PagosAnuales_Click(object sender, EventArgs e)
        {
            using var menuPagosAnuales = new PagosAnualesForm();
            if (menuPagosAnuales.ShowDialog() == DialogResult.OK)
            {
                ActualizarDatos(true);
            }
        }
        private void btn_Respaldo_Click(object sender, EventArgs e)
        {
            using var menuRespaldo = new BackupForm();
            menuRespaldo.ShowDialog();
        }

        //Visuales
        private void PintarInactivos()
        {
            foreach (DataGridViewRow row in v_socios.Rows)
            {
                if (row.DataBoundItem is Socio socio && !socio.EstaActivo)
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

    }
}
