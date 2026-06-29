namespace Socios_CamaraC
{
    public partial class ModificarImporteForm : Form
    {
        private Cuota _cuota;
        public ModificarImporteForm(Cuota cuota)
        {
            InitializeComponent();
            _cuota = cuota;
            CargarDatosCuota();
        }
        private void CargarDatosCuota()
        {
            if (_cuota == null) { return; }
            lbl_AnioCuota.Text = _cuota.Anio.ToString();
            lbl_MesCuota.Text = _cuota.Mes.ToString();
            txt_Importe.Text = _cuota.Importe.ToString("N2");
        }
        //[*] [*] [*] BOTONES [*] [*] [*]
        //MODIFICAR
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string input = txt_Importe.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input, out decimal nuevoImporte))
            {
                MessageBox.Show("Importe inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CuotaServicio.ModificarImporte(_cuota.Periodo, _cuota.CategoriaId, nuevoImporte);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Aux: . como , en imput
        private void txt_Importe_KeyPress_1(object sender, KeyPressEventArgs e)
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
