using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class ConfirmacionPorTexto : Form
    {
        private readonly string _textoConfirmacion;
        public ConfirmacionPorTexto(string mensaje, string textoConfirmacion, int numSocio)
        {
            InitializeComponent();
            this.Text = $"Confirmar: {textoConfirmacion}";
            lbl_Aviso.Text = mensaje;
            _textoConfirmacion = $"{textoConfirmacion} {numSocio}";
            lbl_Input.Text = $"Si desea continuar, " +
                $"ingrese '{_textoConfirmacion.ToUpper()}'";
            btn_Aceptar.Enabled = false;

        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = txt_Input.Text.Trim().Equals(_textoConfirmacion,
                StringComparison.OrdinalIgnoreCase);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
