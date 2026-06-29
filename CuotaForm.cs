namespace Socios_CamaraC
{
    public partial class CuotaForm : Form
    {
        private Socio _socio;
        private int? _categoriaId;
        public CuotaForm(Socio socio)
        {
            InitializeComponent();
            _socio = socio;
            _categoriaId = _socio.CategoriaId;
            CrearPeriodo();
            btn_Agregar.Enabled = false;
            var categoriaSocio = CategoriaRepository.ObtenerPorId(_socio.CategoriaId);
            lbl_CategoriaSocio.Text = categoriaSocio!.CategoriaCMB;
            txt_Importe.Text = categoriaSocio.ImporteBase.ToString("0.00");
        }
        public CuotaForm(int categoriaId)
        {
            InitializeComponent();
            _categoriaId = categoriaId;
            CrearPeriodo();
            btn_Agregar.Enabled = false;
            var categoria = CategoriaRepository.ObtenerPorId(categoriaId);
            lbl_CategoriaSocio.Text = categoria!.CategoriaCMB;
            txt_Importe.Text = categoria.ImporteBase.ToString("0.00");
        }

        private void CrearPeriodo()
        {
            //Periodo
            int anioInicio = 1980;
            int anioFinal = DateTime.Now.Year + 10;
            for (int anio = anioInicio; anio <= anioFinal; anio++)
            {
                cmb_Anio.Items.Add(anio);
            }
            cmb_Anio.SelectedItem = DateTime.Now.Year;
            cmb_Mes.DataSource = Cuota.ObtenerMesesLista();
            cmb_Mes.DisplayMember = "Nombre";
            cmb_Mes.ValueMember = "Numero";
            cmb_Mes.SelectedValue = DateTime.Now.Month;
        }
        private void txt_Importe_Click(object sender, EventArgs e)
        {
            txt_Importe.SelectAll();
        }

        //[*] [*] [*] BOTONES [*] [*] [*]
        // AGREGAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!ImporteAceptado()) //Seguro por fallo en .enable
            {
                return;
            }
            int anio = Convert.ToInt32(cmb_Anio.SelectedItem);
            int mes = cmb_Mes.SelectedIndex + 1;
            decimal.TryParse(txt_Importe.Text, out decimal importe);
            DateTime periodo = CuotaRepository.ObtenerPeriodoSeleccionado(anio, mes);

            //Si es por GESTIONAR COBRANZA
            if (_socio == null)
            {
                CuotaServicio.CrearYAsignarATodos(periodo, _categoriaId!.Value, importe);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            //Si es por Agregar cuota a socio
            int categoria = _socio.CategoriaId;
            CuotaServicio.CrearOAsignar(_socio.NumSocio, periodo, categoria, importe);
            ConfirmarPagoSocio(_socio.NumSocio, periodo, categoria);
        }
        private void ConfirmarPagoSocio(int numSocio, DateTime periodo, int categoria)
        {
            var resultado = MessageBox.Show(
            $"¿{_socio.NombreCompleto} ha pagado la cuota de {periodo:MMMM yyyy}?",
            "Confirmar pago",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                CuotaServicio.CambiarEstadoPago(numSocio, periodo, categoria, true);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void txt_Importe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Importe.Text))
            {
                btn_Agregar.Enabled = false;
                ep_AvisoError.SetError(txt_Importe, "");
            }
            btn_Agregar.Enabled = ImporteAceptado();
        }

        //Verificaciones
        private bool ImporteAceptado()
        {
            if (!decimal.TryParse(txt_Importe.Text, out decimal importe))
            {
                ep_AvisoError.SetError(txt_Importe, "El importe debe ser un número!");
                return false;
            }
            else
            {
                ep_AvisoError.SetError(txt_Importe, "");
            }
            if (!ValidarDatos.EsImporteValido(importe))
            {
                ep_AvisoError.SetError(txt_Importe, "Solo números positivos!");
                return false;
            }
            else
            {
                ep_AvisoError.SetError(txt_Importe, "");
            }
            return true;
        }

        //Aux: Cambiar "." por ","
        private void txt_Importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si presiona punto (.)
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // lo convertimos a coma
            }

            // Permitir solo números, coma y control (backspace)
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Evitar más de una coma
            if (e.KeyChar == ',' && txt_Importe.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

    }
}