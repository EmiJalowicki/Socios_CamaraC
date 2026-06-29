namespace Socios_CamaraC
{
    public partial class EjecutarScriptSQL : Form
    {
        public EjecutarScriptSQL()
        {
            InitializeComponent();
            btn_Ejecutar.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            using var buscador = new OpenFileDialog();
            buscador.Filter = "Archivos SQL (*.sql)|*.sql";
            buscador.Title = "Seleccionar script SQL";
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = buscador.FileName;
                btn_Ejecutar.Enabled = true;
            }
        }

        private void CancelarSQL_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejecutar_SQL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRuta.Text))
            {
                MessageBox.Show("Seleccione un archivo SQL");
                return;
            }
            try
            {
                EjecutarSQL.DesdeArchivo(txtRuta.Text);
                MessageBox.Show("Script ejecutado correctamente ✅");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, "Error al ejecutar SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
        }
    }
}
