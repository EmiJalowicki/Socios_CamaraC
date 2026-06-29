namespace Socios_CamaraC
{
    partial class CuotaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuotaForm));
            cmb_Anio = new ComboBox();
            cmb_Mes = new ComboBox();
            txt_Importe = new TextBox();
            lbl_Anio = new Label();
            lbl_Mes = new Label();
            lbl_Importe = new Label();
            btn_Agregar = new Button();
            btn_Cancelar = new Button();
            ep_AvisoError = new ErrorProvider(components);
            Layout_Cuota = new TableLayoutPanel();
            lbl_CategoriaSocio = new Label();
            lbl_Categoria = new Label();
            tb_Layout = new TableLayoutPanel();
            tb_Botonera = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).BeginInit();
            Layout_Cuota.SuspendLayout();
            tb_Layout.SuspendLayout();
            tb_Botonera.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_Anio
            // 
            cmb_Anio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Anio.FormattingEnabled = true;
            cmb_Anio.Location = new Point(70, 3);
            cmb_Anio.Name = "cmb_Anio";
            cmb_Anio.Size = new Size(121, 23);
            cmb_Anio.TabIndex = 0;
            // 
            // cmb_Mes
            // 
            cmb_Mes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Mes.FormattingEnabled = true;
            cmb_Mes.Location = new Point(70, 32);
            cmb_Mes.Name = "cmb_Mes";
            cmb_Mes.Size = new Size(121, 23);
            cmb_Mes.TabIndex = 1;
            // 
            // txt_Importe
            // 
            txt_Importe.Location = new Point(70, 76);
            txt_Importe.Name = "txt_Importe";
            txt_Importe.Size = new Size(107, 23);
            txt_Importe.TabIndex = 2;
            txt_Importe.Click += txt_Importe_Click;
            txt_Importe.TextChanged += txt_Importe_TextChanged;
            txt_Importe.KeyPress += txt_Importe_KeyPress;
            // 
            // lbl_Anio
            // 
            lbl_Anio.Anchor = AnchorStyles.Left;
            lbl_Anio.AutoSize = true;
            lbl_Anio.Location = new Point(3, 7);
            lbl_Anio.Name = "lbl_Anio";
            lbl_Anio.Size = new Size(32, 15);
            lbl_Anio.TabIndex = 3;
            lbl_Anio.Text = "Año:";
            // 
            // lbl_Mes
            // 
            lbl_Mes.Anchor = AnchorStyles.Left;
            lbl_Mes.AutoSize = true;
            lbl_Mes.Location = new Point(3, 36);
            lbl_Mes.Name = "lbl_Mes";
            lbl_Mes.Size = new Size(32, 15);
            lbl_Mes.TabIndex = 4;
            lbl_Mes.Text = "Mes:";
            // 
            // lbl_Importe
            // 
            lbl_Importe.Anchor = AnchorStyles.Left;
            lbl_Importe.AutoSize = true;
            lbl_Importe.Location = new Point(3, 80);
            lbl_Importe.Name = "lbl_Importe";
            lbl_Importe.Size = new Size(52, 15);
            lbl_Importe.TabIndex = 5;
            lbl_Importe.Text = "Importe:";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.None;
            btn_Agregar.AutoSize = true;
            btn_Agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Agregar.Location = new Point(27, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(59, 25);
            btn_Agregar.TabIndex = 6;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.None;
            btn_Cancelar.AutoSize = true;
            btn_Cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cancelar.Location = new Point(139, 3);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(63, 25);
            btn_Cancelar.TabIndex = 7;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // ep_AvisoError
            // 
            ep_AvisoError.ContainerControl = this;
            // 
            // Layout_Cuota
            // 
            Layout_Cuota.Anchor = AnchorStyles.None;
            Layout_Cuota.AutoSize = true;
            Layout_Cuota.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Layout_Cuota.ColumnCount = 2;
            Layout_Cuota.ColumnStyles.Add(new ColumnStyle());
            Layout_Cuota.ColumnStyles.Add(new ColumnStyle());
            Layout_Cuota.Controls.Add(lbl_CategoriaSocio, 1, 2);
            Layout_Cuota.Controls.Add(lbl_Anio, 0, 0);
            Layout_Cuota.Controls.Add(cmb_Anio, 1, 0);
            Layout_Cuota.Controls.Add(lbl_Mes, 0, 1);
            Layout_Cuota.Controls.Add(cmb_Mes, 1, 1);
            Layout_Cuota.Controls.Add(lbl_Importe, 0, 3);
            Layout_Cuota.Controls.Add(txt_Importe, 1, 3);
            Layout_Cuota.Controls.Add(lbl_Categoria, 0, 2);
            Layout_Cuota.Location = new Point(20, 3);
            Layout_Cuota.Name = "Layout_Cuota";
            Layout_Cuota.RowCount = 4;
            Layout_Cuota.RowStyles.Add(new RowStyle());
            Layout_Cuota.RowStyles.Add(new RowStyle());
            Layout_Cuota.RowStyles.Add(new RowStyle());
            Layout_Cuota.RowStyles.Add(new RowStyle());
            Layout_Cuota.Size = new Size(194, 102);
            Layout_Cuota.TabIndex = 8;
            // 
            // lbl_CategoriaSocio
            // 
            lbl_CategoriaSocio.Anchor = AnchorStyles.Right;
            lbl_CategoriaSocio.AutoSize = true;
            lbl_CategoriaSocio.Location = new Point(125, 58);
            lbl_CategoriaSocio.Name = "lbl_CategoriaSocio";
            lbl_CategoriaSocio.Size = new Size(66, 15);
            lbl_CategoriaSocio.TabIndex = 9;
            lbl_CategoriaSocio.Text = "[Categoria]";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.Anchor = AnchorStyles.Left;
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(3, 58);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(61, 15);
            lbl_Categoria.TabIndex = 6;
            lbl_Categoria.Text = "Categoria:";
            // 
            // tb_Layout
            // 
            tb_Layout.AutoSize = true;
            tb_Layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_Botonera, 0, 1);
            tb_Layout.Controls.Add(Layout_Cuota, 0, 0);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 2;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tb_Layout.Size = new Size(234, 146);
            tb_Layout.TabIndex = 9;
            // 
            // tb_Botonera
            // 
            tb_Botonera.AutoSize = true;
            tb_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Botonera.ColumnCount = 2;
            tb_Botonera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botonera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botonera.Controls.Add(btn_Agregar, 0, 0);
            tb_Botonera.Controls.Add(btn_Cancelar, 1, 0);
            tb_Botonera.Dock = DockStyle.Fill;
            tb_Botonera.Location = new Point(3, 111);
            tb_Botonera.Name = "tb_Botonera";
            tb_Botonera.RowCount = 1;
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tb_Botonera.Size = new Size(228, 32);
            tb_Botonera.TabIndex = 9;
            // 
            // CuotaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 146);
            Controls.Add(tb_Layout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CuotaForm";
            Text = "Cobranza";
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).EndInit();
            Layout_Cuota.ResumeLayout(false);
            Layout_Cuota.PerformLayout();
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Botonera.ResumeLayout(false);
            tb_Botonera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Anio;
        private ComboBox cmb_Mes;
        private TextBox txt_Importe;
        private Label lbl_Anio;
        private Label lbl_Mes;
        private Label lbl_Importe;
        private Button btn_Agregar;
        private Button btn_Cancelar;
        private ErrorProvider ep_AvisoError;
        private TableLayoutPanel Layout_Cuota;
        private Label lbl_Categoria;
        private Label lbl_CategoriaSocio;
        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Botonera;
    }
}