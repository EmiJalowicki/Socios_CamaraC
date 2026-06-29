namespace Socios_CamaraC
{
    public partial class CuotaSocioForm : Form
    {
        private Socio _socio;
        public CuotaSocioForm(Socio socio)
        {
            InitializeComponent();
            _socio = socio;
            CargarDatosSocio();
            btn_Quitar.Enabled = false;
            btn_Pagar.Enabled = false;
        }
        private void CuotaForm_Load(object sender, EventArgs e)
        {
            v_cuotas.AutoGenerateColumns = false;
            v_cuotas.AllowUserToDeleteRows = false;
            v_cuotas.EnableHeadersVisualStyles = false;
            v_cuotas.DataSource = null;
            v_cuotas.ClearSelection();
            CargarDatosSocio();
            CargarCuotas();
            v_cuotas.ClearSelection();
            btn_Quitar.Enabled = false;
        }
        private void CargarCuotas()
        {
            v_cuotas.DataSource = null;
            var listaCuotasSocio = CuotaSocioRepository.ListarCuotas(_socio.NumSocio, true);
            v_cuotas.DataSource = listaCuotasSocio;

            if (v_cuotas.Columns["Col_Importe"] != null)
            {
                var estilo = v_cuotas.Columns["Col_Importe"].DefaultCellStyle;
                estilo.Format = "C2";
                estilo.FormatProvider = new System.Globalization.CultureInfo("es-AR");
            }

        }

        //Configuración Visual
        private void CargarDatosSocio()
        {
            v_cuotas.ClearSelection();
            lbl_EstadoCuota.ForeColor = Color.Black;
            lbl_EstadoCuota.Text = "";
            lbl_NumSocio.Text = _socio.NumSocio.ToString();
            lbl_NombreCompleto.Text = _socio.NombreCompleto;
            lbl_DNI.Text = string.IsNullOrWhiteSpace(_socio.DNI) ? "-" : _socio.DNI;
            lbl_FechaAlta.Text = _socio.FechaAlta.HasValue 
                                                    ?_socio.FechaAlta.Value.ToString("dd/MM/yyyy")
                                                    : "";
            var categoriaSocio = CategoriaRepository.ObtenerPorId(_socio.CategoriaId);
            lbl_CategoriaSocio.Text = categoriaSocio!.CategoriaCMB;
        }
        private void v_cuotas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (v_cuotas.Rows[e.RowIndex].DataBoundItem is CuotaSocio cuota)
            {
                using var conn = ConexionBD.AbrirConexion();
                bool esCuotaAnual =
                    AnualServicio.EstaDentroDeAnual(_socio.NumSocio, cuota.Periodo);

                if (esCuotaAnual)
                    v_cuotas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                else
                    v_cuotas.Rows[e.RowIndex].DefaultCellStyle.ForeColor =
                        cuota.EstaPaga ? Color.Black : Color.Red;
            }
        }

        //Interactuar
        private void v_cuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarEstadoCuotaSeleccionada();
        }
        private void ActualizarEstadoCuotaSeleccionada()
        {
            if (v_cuotas.CurrentRow?.DataBoundItem is not CuotaSocio cuota)
            {
                btn_Quitar.Enabled = false;
                btn_Pagar.Enabled = false;
                lbl_EstadoCuota.Text = "";
                lbl_EstadoCuota.ForeColor = Color.Black;
                return;
            }

            btn_Quitar.Enabled = true;

            bool esCuotaAnual =
                AnualServicio.EstaDentroDeAnual(_socio.NumSocio, cuota.Periodo);
            if (esCuotaAnual)
            {
                lbl_EstadoCuota.Text = "Anual";
                lbl_EstadoCuota.ForeColor = Color.Green;
                btn_Pagar.Enabled = false;
            }
            else if (cuota.EstaPaga)
            {
                lbl_EstadoCuota.Text = "Pagada";
                lbl_EstadoCuota.ForeColor = Color.Black;
                btn_Pagar.Enabled = false;
            }
            else
            {
                lbl_EstadoCuota.Text = "Falta pagar";
                lbl_EstadoCuota.ForeColor = Color.Red;
                btn_Pagar.Enabled = true;
            }
        }

        // [*] [*] [*] BOTONES [*] [*] [*]
        //AGREGAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            using var menuAgregarCuota = new CuotaForm(_socio);
            if (menuAgregarCuota.ShowDialog() == DialogResult.OK)
            {
                CargarCuotas();
                ActualizarEstadoCuotaSeleccionada();
            }
        }

        //QUITAR
        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (v_cuotas.CurrentRow == null) { return; }
            var cuota = v_cuotas.CurrentRow.DataBoundItem as CuotaSocio;
            if (cuota == null) { return; }

            var confirmacion = MessageBox.Show(
                $"¿Desea quitarle a {_socio.NombreCompleto} la cuota {cuota.Mes} de {cuota.Anio}?",
                "Desvincular pago de cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
            if (confirmacion != DialogResult.Yes) { return; }//Si "No", cierra borrado.
            //"Si":
            if (CuotaServicio.HaPagadoSocio(_socio.NumSocio, cuota.Periodo, cuota.CategoriaId))
            {
                var confirmacionDoble = MessageBox.Show(
                    $"{_socio.NombreCompleto} ha pagado la cuota de {cuota.Mes} del {cuota.Anio}. " +
                    $"¿Seguro que desea eliminarla?",
                    "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
                if (confirmacionDoble != DialogResult.Yes) { return; }//Si "No", cierra borrado
            }
            //Se confirma borrado:
            CuotaServicio.QuitarCuotaSocio(_socio.NumSocio, cuota.Periodo, cuota.CategoriaId);
            CargarCuotas();
            ActualizarEstadoCuotaSeleccionada();
        }

        //MODIFICAR
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (v_cuotas.CurrentRow == null) { return; }
            var cuota = v_cuotas.CurrentRow.DataBoundItem as Cuota;
            if (cuota == null) { return; }

            var confirmacion = MessageBox.Show(
                $"¿Desea modificar el importe de la cuota {cuota.Mes} de {cuota.Anio}?",
                "Modificar importe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
            if (confirmacion != DialogResult.Yes) { return; }//Si "No", cierra borrado.
            //"Si":
            if (CuotaServicio.HaySocioPago(cuota.Periodo, cuota.CategoriaId))
            {
                var confirmarModificacion = MessageBox.Show(
                    $"Hay pagos hechos relacionados a la cuota {cuota.Mes} de {cuota.Anio}. " +
                    $"¿Desea modificarlo de todas formas?", "Confirmación de modificación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
                if (confirmarModificacion != DialogResult.Yes) { return; }//Si "No", cierra modificación
            }
            //Se confirma modificación:
            using var menuModificarImporte = new ModificarImporteForm(cuota);
            if (menuModificarImporte.ShowDialog() == DialogResult.OK)
            {
                CargarCuotas();
            }
        }

        //PAGAR
        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            if (v_cuotas.CurrentRow == null) { return; }
            var cuota = v_cuotas.CurrentRow.DataBoundItem as CuotaSocio;
            if (cuota == null) { return; }

            var confirmacion = MessageBox.Show(
                $"¿Pagar {cuota.Mes} de {cuota.Anio}?\n" +
                $"Importe: " + cuota.MuestraImporte,
                "Modificar importe", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (confirmacion == DialogResult.Yes)
            {
                CuotaServicio.CambiarEstadoPago(
                    _socio.NumSocio, cuota.Periodo, cuota.CategoriaId, true);
            }
            CargarCuotas();
            ActualizarEstadoCuotaSeleccionada();
        }

    }
}
