namespace Socios_CamaraC
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            tb_Layout = new TableLayoutPanel();
            tb_Tablas = new TableLayoutPanel();
            chk_Socio = new CheckBox();
            chk_Cuota = new CheckBox();
            chk_Anual = new CheckBox();
            chk_CuotaSocio = new CheckBox();
            chk_AnualSocio = new CheckBox();
            lbl_Estado = new Label();
            Estado_Socios = new Label();
            Estado_Cuota = new Label();
            Estado_Anual = new Label();
            Estado_CuotaSocio = new Label();
            Estado_AnualSocio = new Label();
            p_Botonera = new Panel();
            tb_Botonera = new TableLayoutPanel();
            btn_CrearRespaldo = new Button();
            btn_EjecutarSQL = new Button();
            btn_AbrirCarpeta = new Button();
            btn_Restaurar = new Button();
            tb_Layout.SuspendLayout();
            tb_Tablas.SuspendLayout();
            p_Botonera.SuspendLayout();
            tb_Botonera.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 2;
            tb_Layout.ColumnStyles.Add(new ColumnStyle());
            tb_Layout.ColumnStyles.Add(new ColumnStyle());
            tb_Layout.Controls.Add(tb_Tablas, 0, 0);
            tb_Layout.Controls.Add(p_Botonera, 1, 0);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 1;
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.Size = new Size(417, 191);
            tb_Layout.TabIndex = 0;
            // 
            // tb_Tablas
            // 
            tb_Tablas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Tablas.ColumnCount = 2;
            tb_Tablas.ColumnStyles.Add(new ColumnStyle());
            tb_Tablas.ColumnStyles.Add(new ColumnStyle());
            tb_Tablas.Controls.Add(chk_Socio, 0, 1);
            tb_Tablas.Controls.Add(chk_Cuota, 0, 2);
            tb_Tablas.Controls.Add(chk_Anual, 0, 3);
            tb_Tablas.Controls.Add(chk_CuotaSocio, 0, 4);
            tb_Tablas.Controls.Add(chk_AnualSocio, 0, 5);
            tb_Tablas.Controls.Add(lbl_Estado, 1, 0);
            tb_Tablas.Controls.Add(Estado_Socios, 1, 1);
            tb_Tablas.Controls.Add(Estado_Cuota, 1, 2);
            tb_Tablas.Controls.Add(Estado_Anual, 1, 3);
            tb_Tablas.Controls.Add(Estado_CuotaSocio, 1, 4);
            tb_Tablas.Controls.Add(Estado_AnualSocio, 1, 5);
            tb_Tablas.Dock = DockStyle.Fill;
            tb_Tablas.Location = new Point(3, 3);
            tb_Tablas.Name = "tb_Tablas";
            tb_Tablas.RowCount = 6;
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tb_Tablas.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tb_Tablas.Size = new Size(280, 185);
            tb_Tablas.TabIndex = 3;
            // 
            // chk_Socio
            // 
            chk_Socio.Anchor = AnchorStyles.Left;
            chk_Socio.AutoSize = true;
            chk_Socio.Checked = true;
            chk_Socio.CheckState = CheckState.Checked;
            chk_Socio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_Socio.Location = new Point(3, 33);
            chk_Socio.Name = "chk_Socio";
            chk_Socio.Size = new Size(79, 24);
            chk_Socio.TabIndex = 0;
            chk_Socio.Text = "SOCIOS";
            chk_Socio.UseVisualStyleBackColor = true;
            // 
            // chk_Cuota
            // 
            chk_Cuota.Anchor = AnchorStyles.Left;
            chk_Cuota.AutoSize = true;
            chk_Cuota.Checked = true;
            chk_Cuota.CheckState = CheckState.Checked;
            chk_Cuota.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_Cuota.Location = new Point(3, 63);
            chk_Cuota.Name = "chk_Cuota";
            chk_Cuota.Size = new Size(83, 24);
            chk_Cuota.TabIndex = 1;
            chk_Cuota.Text = "CUOTAS";
            chk_Cuota.UseVisualStyleBackColor = true;
            // 
            // chk_Anual
            // 
            chk_Anual.Anchor = AnchorStyles.Left;
            chk_Anual.AutoSize = true;
            chk_Anual.Checked = true;
            chk_Anual.CheckState = CheckState.Checked;
            chk_Anual.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_Anual.Location = new Point(3, 93);
            chk_Anual.Name = "chk_Anual";
            chk_Anual.Size = new Size(94, 24);
            chk_Anual.TabIndex = 2;
            chk_Anual.Text = "ANUALES";
            chk_Anual.UseVisualStyleBackColor = true;
            // 
            // chk_CuotaSocio
            // 
            chk_CuotaSocio.Anchor = AnchorStyles.Left;
            chk_CuotaSocio.AutoSize = true;
            chk_CuotaSocio.Checked = true;
            chk_CuotaSocio.CheckState = CheckState.Checked;
            chk_CuotaSocio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_CuotaSocio.Location = new Point(3, 123);
            chk_CuotaSocio.Name = "chk_CuotaSocio";
            chk_CuotaSocio.Size = new Size(161, 24);
            chk_CuotaSocio.TabIndex = 3;
            chk_CuotaSocio.Text = "CUOTAS DE SOCIOS";
            chk_CuotaSocio.UseVisualStyleBackColor = true;
            // 
            // chk_AnualSocio
            // 
            chk_AnualSocio.Anchor = AnchorStyles.Left;
            chk_AnualSocio.AutoSize = true;
            chk_AnualSocio.Checked = true;
            chk_AnualSocio.CheckState = CheckState.Checked;
            chk_AnualSocio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk_AnualSocio.Location = new Point(3, 155);
            chk_AnualSocio.Name = "chk_AnualSocio";
            chk_AnualSocio.Size = new Size(172, 24);
            chk_AnualSocio.TabIndex = 4;
            chk_AnualSocio.Text = "ANUALES DE SOCIOS";
            chk_AnualSocio.UseVisualStyleBackColor = true;
            // 
            // lbl_Estado
            // 
            lbl_Estado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Estado.Location = new Point(181, 10);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(57, 20);
            lbl_Estado.TabIndex = 5;
            lbl_Estado.Text = "Estado:";
            // 
            // Estado_Socios
            // 
            Estado_Socios.Anchor = AnchorStyles.Left;
            Estado_Socios.AutoSize = true;
            Estado_Socios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estado_Socios.Location = new Point(181, 35);
            Estado_Socios.Name = "Estado_Socios";
            Estado_Socios.Size = new Size(96, 20);
            Estado_Socios.TabIndex = 6;
            Estado_Socios.Text = "Por respaldar";
            // 
            // Estado_Cuota
            // 
            Estado_Cuota.Anchor = AnchorStyles.Left;
            Estado_Cuota.AutoSize = true;
            Estado_Cuota.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estado_Cuota.Location = new Point(181, 65);
            Estado_Cuota.Name = "Estado_Cuota";
            Estado_Cuota.Size = new Size(96, 20);
            Estado_Cuota.TabIndex = 7;
            Estado_Cuota.Text = "Por respaldar";
            // 
            // Estado_Anual
            // 
            Estado_Anual.Anchor = AnchorStyles.Left;
            Estado_Anual.AutoSize = true;
            Estado_Anual.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estado_Anual.Location = new Point(181, 95);
            Estado_Anual.Name = "Estado_Anual";
            Estado_Anual.Size = new Size(96, 20);
            Estado_Anual.TabIndex = 8;
            Estado_Anual.Text = "Por respaldar";
            // 
            // Estado_CuotaSocio
            // 
            Estado_CuotaSocio.Anchor = AnchorStyles.Left;
            Estado_CuotaSocio.AutoSize = true;
            Estado_CuotaSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estado_CuotaSocio.Location = new Point(181, 125);
            Estado_CuotaSocio.Name = "Estado_CuotaSocio";
            Estado_CuotaSocio.Size = new Size(96, 20);
            Estado_CuotaSocio.TabIndex = 9;
            Estado_CuotaSocio.Text = "Por respaldar";
            // 
            // Estado_AnualSocio
            // 
            Estado_AnualSocio.Anchor = AnchorStyles.Left;
            Estado_AnualSocio.AutoSize = true;
            Estado_AnualSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Estado_AnualSocio.Location = new Point(181, 157);
            Estado_AnualSocio.Name = "Estado_AnualSocio";
            Estado_AnualSocio.Size = new Size(96, 20);
            Estado_AnualSocio.TabIndex = 10;
            Estado_AnualSocio.Text = "Por respaldar";
            // 
            // p_Botonera
            // 
            p_Botonera.AutoSize = true;
            p_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            p_Botonera.Controls.Add(tb_Botonera);
            p_Botonera.Dock = DockStyle.Fill;
            p_Botonera.Location = new Point(289, 3);
            p_Botonera.Name = "p_Botonera";
            p_Botonera.Size = new Size(125, 185);
            p_Botonera.TabIndex = 4;
            // 
            // tb_Botonera
            // 
            tb_Botonera.AutoSize = true;
            tb_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Botonera.ColumnCount = 1;
            tb_Botonera.ColumnStyles.Add(new ColumnStyle());
            tb_Botonera.Controls.Add(btn_CrearRespaldo, 0, 0);
            tb_Botonera.Controls.Add(btn_EjecutarSQL, 0, 1);
            tb_Botonera.Controls.Add(btn_AbrirCarpeta, 0, 2);
            tb_Botonera.Controls.Add(btn_Restaurar, 0, 3);
            tb_Botonera.Dock = DockStyle.Fill;
            tb_Botonera.Location = new Point(0, 0);
            tb_Botonera.Name = "tb_Botonera";
            tb_Botonera.RowCount = 4;
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tb_Botonera.Size = new Size(125, 185);
            tb_Botonera.TabIndex = 1;
            // 
            // btn_CrearRespaldo
            // 
            btn_CrearRespaldo.AutoSize = true;
            btn_CrearRespaldo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_CrearRespaldo.Dock = DockStyle.Fill;
            btn_CrearRespaldo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CrearRespaldo.Location = new Point(3, 3);
            btn_CrearRespaldo.Name = "btn_CrearRespaldo";
            btn_CrearRespaldo.Size = new Size(119, 40);
            btn_CrearRespaldo.TabIndex = 0;
            btn_CrearRespaldo.Text = "Crear respaldo";
            btn_CrearRespaldo.UseVisualStyleBackColor = true;
            btn_CrearRespaldo.Click += btn_CrearRespaldo_Click;
            // 
            // btn_EjecutarSQL
            // 
            btn_EjecutarSQL.AutoSize = true;
            btn_EjecutarSQL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_EjecutarSQL.Dock = DockStyle.Fill;
            btn_EjecutarSQL.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_EjecutarSQL.Location = new Point(3, 49);
            btn_EjecutarSQL.Name = "btn_EjecutarSQL";
            btn_EjecutarSQL.Size = new Size(119, 40);
            btn_EjecutarSQL.TabIndex = 1;
            btn_EjecutarSQL.Text = "Ejecutar SQL";
            btn_EjecutarSQL.UseVisualStyleBackColor = true;
            btn_EjecutarSQL.Click += btn_EjecutarSQL_Click;
            // 
            // btn_AbrirCarpeta
            // 
            btn_AbrirCarpeta.AutoSize = true;
            btn_AbrirCarpeta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_AbrirCarpeta.Dock = DockStyle.Fill;
            btn_AbrirCarpeta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AbrirCarpeta.Location = new Point(3, 95);
            btn_AbrirCarpeta.Name = "btn_AbrirCarpeta";
            btn_AbrirCarpeta.Size = new Size(119, 40);
            btn_AbrirCarpeta.TabIndex = 2;
            btn_AbrirCarpeta.Text = "Abrir carpeta";
            btn_AbrirCarpeta.UseVisualStyleBackColor = true;
            btn_AbrirCarpeta.Click += btn_AbrirCarpeta_Click;
            // 
            // btn_Restaurar
            // 
            btn_Restaurar.AutoSize = true;
            btn_Restaurar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Restaurar.Dock = DockStyle.Fill;
            btn_Restaurar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Restaurar.Location = new Point(3, 141);
            btn_Restaurar.Name = "btn_Restaurar";
            btn_Restaurar.Size = new Size(119, 41);
            btn_Restaurar.TabIndex = 3;
            btn_Restaurar.Text = "Restaurar BD";
            btn_Restaurar.UseVisualStyleBackColor = true;
            btn_Restaurar.Click += btn_Restaurar_Click;
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 191);
            Controls.Add(tb_Layout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BackupForm";
            Text = "Respaldar Base de Datos";
            Load += BackupForm_Load;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Tablas.ResumeLayout(false);
            tb_Tablas.PerformLayout();
            p_Botonera.ResumeLayout(false);
            p_Botonera.PerformLayout();
            tb_Botonera.ResumeLayout(false);
            tb_Botonera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Tablas;
        private CheckBox chk_Socio;
        private CheckBox chk_Cuota;
        private CheckBox chk_Anual;
        private CheckBox chk_CuotaSocio;
        private CheckBox chk_AnualSocio;
        private Label lbl_Estado;
        private Label Estado_Socios;
        private Label Estado_Cuota;
        private Label Estado_Anual;
        private Label Estado_CuotaSocio;
        private Label Estado_AnualSocio;
        private Panel p_Botonera;
        private TableLayoutPanel tb_Botonera;
        private Button btn_CrearRespaldo;
        private Button btn_EjecutarSQL;
        private Button btn_AbrirCarpeta;
        private Button btn_Restaurar;
    }
}