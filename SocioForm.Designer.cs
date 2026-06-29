namespace Socios_CamaraC
{
    partial class SocioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocioForm));
            txt_NumSocio = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_CalleNombre = new TextBox();
            txt_NumTelefono = new TextBox();
            txt_CalleNum = new TextBox();
            txt_DNI = new TextBox();
            lbl_NumSocio = new Label();
            lbl_Apellido = new Label();
            lbl_DNI = new Label();
            lbl_NumTelefono = new Label();
            lbl_CalleNombre = new Label();
            lbl_CalleNum = new Label();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            ep_AvisoError = new ErrorProvider(components);
            obl_Apellido = new Label();
            obl_Nombre = new Label();
            ob_Msg = new Label();
            tb_Apellido = new TableLayoutPanel();
            lbl_Nombre = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_FechaNacimiento = new Label();
            dtp_FechaNacimiento = new DateTimePicker();
            dtp_FechaAlta = new DateTimePicker();
            lbl_FechaAlta = new Label();
            txt_Localidad = new TextBox();
            lbl_Localidad = new Label();
            cmb_Sexo = new ComboBox();
            lbl_Sexo = new Label();
            lbl_Categoria = new Label();
            cmb_Categoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).BeginInit();
            tb_Apellido.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_NumSocio
            // 
            txt_NumSocio.Location = new Point(12, 26);
            txt_NumSocio.Name = "txt_NumSocio";
            txt_NumSocio.Size = new Size(90, 23);
            txt_NumSocio.TabIndex = 0;
            txt_NumSocio.TextChanged += txt_NumSocio_TextChanged;
            // 
            // txt_Apellido
            // 
            txt_Apellido.ForeColor = Color.Black;
            txt_Apellido.Location = new Point(108, 26);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(181, 23);
            txt_Apellido.TabIndex = 1;
            txt_Apellido.TextChanged += txt_Apellido_TextChanged;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(295, 26);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(225, 23);
            txt_Nombre.TabIndex = 2;
            txt_Nombre.TextChanged += txt_Nombre_TextChanged;
            // 
            // txt_CalleNombre
            // 
            txt_CalleNombre.Location = new Point(12, 115);
            txt_CalleNombre.Name = "txt_CalleNombre";
            txt_CalleNombre.Size = new Size(211, 23);
            txt_CalleNombre.TabIndex = 7;
            // 
            // txt_NumTelefono
            // 
            txt_NumTelefono.Location = new Point(295, 70);
            txt_NumTelefono.Name = "txt_NumTelefono";
            txt_NumTelefono.Size = new Size(277, 23);
            txt_NumTelefono.TabIndex = 6;
            // 
            // txt_CalleNum
            // 
            txt_CalleNum.Location = new Point(229, 115);
            txt_CalleNum.Name = "txt_CalleNum";
            txt_CalleNum.Size = new Size(90, 23);
            txt_CalleNum.TabIndex = 8;
            txt_CalleNum.TextChanged += txt_CalleNum_TextChanged;
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(12, 70);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(90, 23);
            txt_DNI.TabIndex = 4;
            txt_DNI.TextChanged += txt_DNI_TextChanged;
            // 
            // lbl_NumSocio
            // 
            lbl_NumSocio.AutoSize = true;
            lbl_NumSocio.Location = new Point(12, 7);
            lbl_NumSocio.Name = "lbl_NumSocio";
            lbl_NumSocio.Size = new Size(53, 15);
            lbl_NumSocio.TabIndex = 8;
            lbl_NumSocio.Text = "Nº Socio";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(0, 0);
            lbl_Apellido.Margin = new Padding(0);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(64, 15);
            lbl_Apellido.TabIndex = 9;
            lbl_Apellido.Text = "Apellido(s)";
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(12, 52);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(27, 15);
            lbl_DNI.TabIndex = 11;
            lbl_DNI.Text = "DNI";
            // 
            // lbl_NumTelefono
            // 
            lbl_NumTelefono.AutoSize = true;
            lbl_NumTelefono.Location = new Point(295, 52);
            lbl_NumTelefono.Name = "lbl_NumTelefono";
            lbl_NumTelefono.Size = new Size(115, 15);
            lbl_NumTelefono.TabIndex = 12;
            lbl_NumTelefono.Text = "Numero de Telefono";
            // 
            // lbl_CalleNombre
            // 
            lbl_CalleNombre.AutoSize = true;
            lbl_CalleNombre.Location = new Point(12, 96);
            lbl_CalleNombre.Name = "lbl_CalleNombre";
            lbl_CalleNombre.Size = new Size(57, 15);
            lbl_CalleNombre.TabIndex = 13;
            lbl_CalleNombre.Text = "Dirección";
            // 
            // lbl_CalleNum
            // 
            lbl_CalleNum.AutoSize = true;
            lbl_CalleNum.Location = new Point(229, 97);
            lbl_CalleNum.Name = "lbl_CalleNum";
            lbl_CalleNum.Size = new Size(21, 15);
            lbl_CalleNum.TabIndex = 14;
            lbl_CalleNum.Text = "Nº";
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(407, 160);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(75, 23);
            btn_Aceptar.TabIndex = 12;
            btn_Aceptar.Text = "Agregar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(497, 160);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 13;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // ep_AvisoError
            // 
            ep_AvisoError.BlinkRate = 100;
            ep_AvisoError.ContainerControl = this;
            // 
            // obl_Apellido
            // 
            obl_Apellido.AutoSize = true;
            obl_Apellido.ForeColor = Color.Red;
            obl_Apellido.Location = new Point(64, 0);
            obl_Apellido.Margin = new Padding(0);
            obl_Apellido.Name = "obl_Apellido";
            obl_Apellido.Size = new Size(20, 15);
            obl_Apellido.TabIndex = 17;
            obl_Apellido.Text = "(*)";
            // 
            // obl_Nombre
            // 
            obl_Nombre.AutoSize = true;
            obl_Nombre.ForeColor = Color.Red;
            obl_Nombre.Location = new Point(64, 0);
            obl_Nombre.Margin = new Padding(0);
            obl_Nombre.Name = "obl_Nombre";
            obl_Nombre.Size = new Size(20, 15);
            obl_Nombre.TabIndex = 18;
            obl_Nombre.Text = "(*)";
            // 
            // ob_Msg
            // 
            ob_Msg.AutoSize = true;
            ob_Msg.ForeColor = Color.Red;
            ob_Msg.Location = new Point(437, 142);
            ob_Msg.Name = "ob_Msg";
            ob_Msg.Size = new Size(135, 15);
            ob_Msg.TabIndex = 19;
            ob_Msg.Text = "Campos Obligatorios (*)";
            // 
            // tb_Apellido
            // 
            tb_Apellido.AutoSize = true;
            tb_Apellido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Apellido.ColumnCount = 2;
            tb_Apellido.ColumnStyles.Add(new ColumnStyle());
            tb_Apellido.ColumnStyles.Add(new ColumnStyle());
            tb_Apellido.Controls.Add(obl_Apellido, 1, 0);
            tb_Apellido.Controls.Add(lbl_Apellido, 0, 0);
            tb_Apellido.Location = new Point(108, 7);
            tb_Apellido.Margin = new Padding(0);
            tb_Apellido.Name = "tb_Apellido";
            tb_Apellido.RowCount = 1;
            tb_Apellido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Apellido.Size = new Size(84, 15);
            tb_Apellido.TabIndex = 20;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(0, 0);
            lbl_Nombre.Margin = new Padding(0);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(64, 15);
            lbl_Nombre.TabIndex = 10;
            lbl_Nombre.Text = "Nombre(s)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(obl_Nombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_Nombre, 0, 0);
            tableLayoutPanel1.Location = new Point(295, 7);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(84, 15);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // lbl_FechaNacimiento
            // 
            lbl_FechaNacimiento.AutoSize = true;
            lbl_FechaNacimiento.Location = new Point(12, 142);
            lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            lbl_FechaNacimiento.Size = new Size(117, 15);
            lbl_FechaNacimiento.TabIndex = 22;
            lbl_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Checked = false;
            dtp_FechaNacimiento.CustomFormat = "  dd/MM/yyyy";
            dtp_FechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtp_FechaNacimiento.Location = new Point(12, 160);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.ShowCheckBox = true;
            dtp_FechaNacimiento.Size = new Size(211, 23);
            dtp_FechaNacimiento.TabIndex = 10;
            dtp_FechaNacimiento.Value = new DateTime(2025, 12, 21, 0, 0, 0, 0);
            dtp_FechaNacimiento.ValueChanged += dtp_FechaNacimiento_ValueChanged;
            // 
            // dtp_FechaAlta
            // 
            dtp_FechaAlta.CustomFormat = "  dd/MM/yyyy";
            dtp_FechaAlta.Format = DateTimePickerFormat.Custom;
            dtp_FechaAlta.Location = new Point(229, 160);
            dtp_FechaAlta.Name = "dtp_FechaAlta";
            dtp_FechaAlta.Size = new Size(156, 23);
            dtp_FechaAlta.TabIndex = 11;
            dtp_FechaAlta.Value = new DateTime(2026, 2, 22, 0, 0, 0, 0);
            // 
            // lbl_FechaAlta
            // 
            lbl_FechaAlta.AutoSize = true;
            lbl_FechaAlta.Location = new Point(229, 142);
            lbl_FechaAlta.Name = "lbl_FechaAlta";
            lbl_FechaAlta.Size = new Size(96, 15);
            lbl_FechaAlta.TabIndex = 25;
            lbl_FechaAlta.Text = "Fecha de ingreso";
            // 
            // txt_Localidad
            // 
            txt_Localidad.Location = new Point(325, 115);
            txt_Localidad.Name = "txt_Localidad";
            txt_Localidad.Size = new Size(247, 23);
            txt_Localidad.TabIndex = 9;
            // 
            // lbl_Localidad
            // 
            lbl_Localidad.AutoSize = true;
            lbl_Localidad.Location = new Point(325, 97);
            lbl_Localidad.Name = "lbl_Localidad";
            lbl_Localidad.Size = new Size(58, 15);
            lbl_Localidad.TabIndex = 27;
            lbl_Localidad.Text = "Localidad";
            // 
            // cmb_Sexo
            // 
            cmb_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Sexo.FormattingEnabled = true;
            cmb_Sexo.Location = new Point(526, 26);
            cmb_Sexo.Name = "cmb_Sexo";
            cmb_Sexo.Size = new Size(46, 23);
            cmb_Sexo.TabIndex = 3;
            // 
            // lbl_Sexo
            // 
            lbl_Sexo.AutoSize = true;
            lbl_Sexo.Location = new Point(526, 7);
            lbl_Sexo.Name = "lbl_Sexo";
            lbl_Sexo.Size = new Size(32, 15);
            lbl_Sexo.TabIndex = 29;
            lbl_Sexo.Text = "Sexo";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(108, 52);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(58, 15);
            lbl_Categoria.TabIndex = 30;
            lbl_Categoria.Text = "Categoria";
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(108, 70);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(181, 23);
            cmb_Categoria.TabIndex = 5;
            // 
            // SocioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 192);
            Controls.Add(cmb_Categoria);
            Controls.Add(lbl_Categoria);
            Controls.Add(lbl_Sexo);
            Controls.Add(cmb_Sexo);
            Controls.Add(lbl_Localidad);
            Controls.Add(txt_Localidad);
            Controls.Add(lbl_FechaAlta);
            Controls.Add(dtp_FechaAlta);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(lbl_FechaNacimiento);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tb_Apellido);
            Controls.Add(ob_Msg);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(lbl_CalleNum);
            Controls.Add(lbl_CalleNombre);
            Controls.Add(lbl_NumTelefono);
            Controls.Add(lbl_DNI);
            Controls.Add(lbl_NumSocio);
            Controls.Add(txt_DNI);
            Controls.Add(txt_CalleNum);
            Controls.Add(txt_NumTelefono);
            Controls.Add(txt_CalleNombre);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_NumSocio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SocioForm";
            Text = "Agregar Socio";
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).EndInit();
            tb_Apellido.ResumeLayout(false);
            tb_Apellido.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NumSocio;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_CalleNombre;
        private TextBox txt_NumTelefono;
        private TextBox txt_CalleNum;
        private TextBox txt_DNI;
        private Label lbl_NumSocio;
        private Label lbl_Apellido;
        private Label lbl_DNI;
        private Label lbl_NumTelefono;
        private Label lbl_CalleNombre;
        private Label lbl_CalleNum;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private ErrorProvider ep_AvisoError;
        private Label obl_Nombre;
        private Label obl_Apellido;
        private Label ob_Msg;
        private TableLayoutPanel tb_Apellido;
        private Label lbl_Nombre;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtp_FechaNacimiento;
        private Label lbl_FechaNacimiento;
        private DateTimePicker dtp_FechaAlta;
        private Label lbl_FechaAlta;
        private Label lbl_Sexo;
        private ComboBox cmb_Sexo;
        private Label lbl_Localidad;
        private TextBox txt_Localidad;
        private ComboBox cmb_Categoria;
        private Label lbl_Categoria;
    }
}