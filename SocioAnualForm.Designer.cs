namespace Socios_CamaraC
{
    partial class SocioAnualForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocioAnualForm));
            tb_Layout = new TableLayoutPanel();
            tb_Filtrado = new TableLayoutPanel();
            tb_Buscador = new TableLayoutPanel();
            pb_Lupa = new PictureBox();
            txt_Buscador = new TextBox();
            tb_Periodo = new TableLayoutPanel();
            lbl_Mes = new Label();
            cmb_Meses = new ComboBox();
            tb_Anio = new TableLayoutPanel();
            num_Anio = new NumericUpDown();
            lbl_Anio = new Label();
            v_socios = new DataGridView();
            Col_NumSocio = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            Col_NombreCompleto = new DataGridViewTextBoxColumn();
            Col_DNI = new DataGridViewTextBoxColumn();
            tb_Botonera = new TableLayoutPanel();
            btn_Cerrar = new Button();
            btn_Agregar = new Button();
            gb_Importes = new GroupBox();
            tb_Importes = new TableLayoutPanel();
            lbl_ImporteTotal = new Label();
            txt_ImporteTotal = new TextBox();
            lbl_ImporteCuota = new Label();
            txt_ImporteCuota = new TextBox();
            tb_Layout.SuspendLayout();
            tb_Filtrado.SuspendLayout();
            tb_Buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Lupa).BeginInit();
            tb_Periodo.SuspendLayout();
            tb_Anio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Anio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)v_socios).BeginInit();
            tb_Botonera.SuspendLayout();
            gb_Importes.SuspendLayout();
            tb_Importes.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_Filtrado, 0, 0);
            tb_Layout.Controls.Add(v_socios, 0, 1);
            tb_Layout.Controls.Add(tb_Botonera, 0, 3);
            tb_Layout.Controls.Add(gb_Importes, 0, 2);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 4;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.Size = new Size(414, 361);
            tb_Layout.TabIndex = 0;
            // 
            // tb_Filtrado
            // 
            tb_Filtrado.AutoSize = true;
            tb_Filtrado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Filtrado.ColumnCount = 1;
            tb_Filtrado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Filtrado.Controls.Add(tb_Buscador, 0, 0);
            tb_Filtrado.Controls.Add(tb_Periodo, 0, 1);
            tb_Filtrado.Dock = DockStyle.Fill;
            tb_Filtrado.Location = new Point(3, 3);
            tb_Filtrado.Name = "tb_Filtrado";
            tb_Filtrado.RowCount = 2;
            tb_Filtrado.RowStyles.Add(new RowStyle());
            tb_Filtrado.RowStyles.Add(new RowStyle());
            tb_Filtrado.Size = new Size(408, 82);
            tb_Filtrado.TabIndex = 5;
            // 
            // tb_Buscador
            // 
            tb_Buscador.Anchor = AnchorStyles.None;
            tb_Buscador.AutoSize = true;
            tb_Buscador.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Buscador.ColumnCount = 2;
            tb_Buscador.ColumnStyles.Add(new ColumnStyle());
            tb_Buscador.ColumnStyles.Add(new ColumnStyle());
            tb_Buscador.Controls.Add(pb_Lupa, 0, 0);
            tb_Buscador.Controls.Add(txt_Buscador, 1, 0);
            tb_Buscador.Location = new Point(8, 2);
            tb_Buscador.Margin = new Padding(2);
            tb_Buscador.Name = "tb_Buscador";
            tb_Buscador.RowCount = 1;
            tb_Buscador.RowStyles.Add(new RowStyle());
            tb_Buscador.Size = new Size(391, 41);
            tb_Buscador.TabIndex = 0;
            // 
            // pb_Lupa
            // 
            pb_Lupa.BackColor = SystemColors.Control;
            pb_Lupa.Image = Properties.Resources.png_transparent_magnifying_glass_computer_icons_magnifying_glass_glass_desktop_wallpaper_circle;
            pb_Lupa.Location = new Point(3, 3);
            pb_Lupa.Name = "pb_Lupa";
            pb_Lupa.Size = new Size(34, 35);
            pb_Lupa.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Lupa.TabIndex = 11;
            pb_Lupa.TabStop = false;
            pb_Lupa.Click += pb_Lupa_Click;
            // 
            // txt_Buscador
            // 
            txt_Buscador.Anchor = AnchorStyles.Left;
            txt_Buscador.Location = new Point(43, 8);
            txt_Buscador.Name = "txt_Buscador";
            txt_Buscador.PlaceholderText = "Buscar: N°Socio, DNI, Apellido, Nombre...";
            txt_Buscador.Size = new Size(345, 25);
            txt_Buscador.TabIndex = 12;
            txt_Buscador.TextChanged += txt_Buscador_TextChanged;
            // 
            // tb_Periodo
            // 
            tb_Periodo.Anchor = AnchorStyles.None;
            tb_Periodo.AutoSize = true;
            tb_Periodo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Periodo.ColumnCount = 3;
            tb_Periodo.ColumnStyles.Add(new ColumnStyle());
            tb_Periodo.ColumnStyles.Add(new ColumnStyle());
            tb_Periodo.ColumnStyles.Add(new ColumnStyle());
            tb_Periodo.Controls.Add(lbl_Mes, 0, 0);
            tb_Periodo.Controls.Add(cmb_Meses, 1, 0);
            tb_Periodo.Controls.Add(tb_Anio, 2, 0);
            tb_Periodo.Location = new Point(58, 48);
            tb_Periodo.Name = "tb_Periodo";
            tb_Periodo.RowCount = 1;
            tb_Periodo.RowStyles.Add(new RowStyle());
            tb_Periodo.Size = new Size(291, 31);
            tb_Periodo.TabIndex = 3;
            // 
            // lbl_Mes
            // 
            lbl_Mes.Anchor = AnchorStyles.Left;
            lbl_Mes.AutoSize = true;
            lbl_Mes.Location = new Point(3, 7);
            lbl_Mes.Name = "lbl_Mes";
            lbl_Mes.Size = new Size(70, 17);
            lbl_Mes.TabIndex = 0;
            lbl_Mes.Text = "Mes inicio:";
            // 
            // cmb_Meses
            // 
            cmb_Meses.Anchor = AnchorStyles.Left;
            cmb_Meses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Meses.FormattingEnabled = true;
            cmb_Meses.Location = new Point(79, 3);
            cmb_Meses.Name = "cmb_Meses";
            cmb_Meses.Size = new Size(114, 25);
            cmb_Meses.TabIndex = 3;
            cmb_Meses.SelectedIndexChanged += cmb_Meses_SelectedIndexChanged;
            // 
            // tb_Anio
            // 
            tb_Anio.Anchor = AnchorStyles.Right;
            tb_Anio.AutoSize = true;
            tb_Anio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Anio.ColumnCount = 2;
            tb_Anio.ColumnStyles.Add(new ColumnStyle());
            tb_Anio.ColumnStyles.Add(new ColumnStyle());
            tb_Anio.Controls.Add(num_Anio, 1, 0);
            tb_Anio.Controls.Add(lbl_Anio, 0, 0);
            tb_Anio.Location = new Point(196, 0);
            tb_Anio.Margin = new Padding(0, 0, 0, 2);
            tb_Anio.Name = "tb_Anio";
            tb_Anio.RowCount = 1;
            tb_Anio.RowStyles.Add(new RowStyle());
            tb_Anio.Size = new Size(95, 28);
            tb_Anio.TabIndex = 2;
            // 
            // num_Anio
            // 
            num_Anio.Anchor = AnchorStyles.Left;
            num_Anio.Location = new Point(40, 3);
            num_Anio.Margin = new Padding(0, 3, 0, 0);
            num_Anio.Name = "num_Anio";
            num_Anio.Size = new Size(55, 25);
            num_Anio.TabIndex = 3;
            num_Anio.ValueChanged += num_Anio_ValueChanged;
            // 
            // lbl_Anio
            // 
            lbl_Anio.Anchor = AnchorStyles.Left;
            lbl_Anio.AutoSize = true;
            lbl_Anio.Location = new Point(3, 6);
            lbl_Anio.Margin = new Padding(3, 1, 3, 0);
            lbl_Anio.Name = "lbl_Anio";
            lbl_Anio.Size = new Size(34, 17);
            lbl_Anio.TabIndex = 2;
            lbl_Anio.Text = "Año:";
            // 
            // v_socios
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_socios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_socios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_socios.Columns.AddRange(new DataGridViewColumn[] { Col_NumSocio, Col_Categoria, Col_NombreCompleto, Col_DNI });
            v_socios.Dock = DockStyle.Fill;
            v_socios.Location = new Point(3, 91);
            v_socios.MultiSelect = false;
            v_socios.Name = "v_socios";
            v_socios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_socios.Size = new Size(408, 172);
            v_socios.TabIndex = 2;
            v_socios.CurrentCellChanged += v_socios_CurrentCellChanged;
            v_socios.DataBindingComplete += v_socios_DataBindingComplete;
            // 
            // Col_NumSocio
            // 
            Col_NumSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_NumSocio.DataPropertyName = "NumSocio";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_NumSocio.DefaultCellStyle = dataGridViewCellStyle2;
            Col_NumSocio.HeaderText = "N°Socio";
            Col_NumSocio.Name = "Col_NumSocio";
            Col_NumSocio.Width = 80;
            // 
            // Col_Categoria
            // 
            Col_Categoria.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            Col_Categoria.HeaderText = "CAT";
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.Width = 35;
            // 
            // Col_NombreCompleto
            // 
            Col_NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_NombreCompleto.DataPropertyName = "NombreCompleto";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_NombreCompleto.DefaultCellStyle = dataGridViewCellStyle4;
            Col_NombreCompleto.HeaderText = "Socio";
            Col_NombreCompleto.Name = "Col_NombreCompleto";
            Col_NombreCompleto.Width = 65;
            // 
            // Col_DNI
            // 
            Col_DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_DNI.DataPropertyName = "DNI";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_DNI.DefaultCellStyle = dataGridViewCellStyle5;
            Col_DNI.HeaderText = "DNI";
            Col_DNI.Name = "Col_DNI";
            // 
            // tb_Botonera
            // 
            tb_Botonera.Anchor = AnchorStyles.None;
            tb_Botonera.AutoSize = true;
            tb_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Botonera.ColumnCount = 2;
            tb_Botonera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botonera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botonera.Controls.Add(btn_Cerrar, 1, 0);
            tb_Botonera.Controls.Add(btn_Agregar, 0, 0);
            tb_Botonera.Location = new Point(135, 325);
            tb_Botonera.Name = "tb_Botonera";
            tb_Botonera.RowCount = 1;
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tb_Botonera.Size = new Size(144, 33);
            tb_Botonera.TabIndex = 2;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.None;
            btn_Cerrar.AutoSize = true;
            btn_Cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cerrar.Location = new Point(80, 3);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(55, 27);
            btn_Cerrar.TabIndex = 1;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Right;
            btn_Agregar.AutoSize = true;
            btn_Agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Agregar.Location = new Point(3, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(66, 27);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // gb_Importes
            // 
            gb_Importes.Anchor = AnchorStyles.None;
            gb_Importes.AutoSize = true;
            gb_Importes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb_Importes.Controls.Add(tb_Importes);
            gb_Importes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_Importes.Location = new Point(7, 269);
            gb_Importes.Name = "gb_Importes";
            gb_Importes.Size = new Size(400, 50);
            gb_Importes.TabIndex = 6;
            gb_Importes.TabStop = false;
            gb_Importes.Text = "Importes";
            // 
            // tb_Importes
            // 
            tb_Importes.AutoSize = true;
            tb_Importes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Importes.ColumnCount = 4;
            tb_Importes.ColumnStyles.Add(new ColumnStyle());
            tb_Importes.ColumnStyles.Add(new ColumnStyle());
            tb_Importes.ColumnStyles.Add(new ColumnStyle());
            tb_Importes.ColumnStyles.Add(new ColumnStyle());
            tb_Importes.Controls.Add(lbl_ImporteTotal, 2, 0);
            tb_Importes.Controls.Add(txt_ImporteTotal, 3, 0);
            tb_Importes.Controls.Add(lbl_ImporteCuota, 0, 0);
            tb_Importes.Controls.Add(txt_ImporteCuota, 1, 0);
            tb_Importes.Dock = DockStyle.Fill;
            tb_Importes.Location = new Point(3, 21);
            tb_Importes.Name = "tb_Importes";
            tb_Importes.RowCount = 1;
            tb_Importes.RowStyles.Add(new RowStyle());
            tb_Importes.Size = new Size(394, 26);
            tb_Importes.TabIndex = 0;
            // 
            // lbl_ImporteTotal
            // 
            lbl_ImporteTotal.Anchor = AnchorStyles.Right;
            lbl_ImporteTotal.AutoSize = true;
            lbl_ImporteTotal.Location = new Point(201, 4);
            lbl_ImporteTotal.Margin = new Padding(5, 0, 0, 0);
            lbl_ImporteTotal.Name = "lbl_ImporteTotal";
            lbl_ImporteTotal.Size = new Size(40, 17);
            lbl_ImporteTotal.TabIndex = 4;
            lbl_ImporteTotal.Text = "Total:";
            // 
            // txt_ImporteTotal
            // 
            txt_ImporteTotal.Dock = DockStyle.Fill;
            txt_ImporteTotal.Location = new Point(241, 0);
            txt_ImporteTotal.Margin = new Padding(0, 0, 0, 1);
            txt_ImporteTotal.Name = "txt_ImporteTotal";
            txt_ImporteTotal.ReadOnly = true;
            txt_ImporteTotal.Size = new Size(153, 25);
            txt_ImporteTotal.TabIndex = 5;
            txt_ImporteTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_ImporteCuota
            // 
            lbl_ImporteCuota.Anchor = AnchorStyles.Left;
            lbl_ImporteCuota.AutoSize = true;
            lbl_ImporteCuota.Location = new Point(0, 5);
            lbl_ImporteCuota.Margin = new Padding(0, 1, 0, 0);
            lbl_ImporteCuota.Name = "lbl_ImporteCuota";
            lbl_ImporteCuota.Size = new Size(68, 17);
            lbl_ImporteCuota.TabIndex = 6;
            lbl_ImporteCuota.Text = "Cobranza:";
            // 
            // txt_ImporteCuota
            // 
            txt_ImporteCuota.Dock = DockStyle.Fill;
            txt_ImporteCuota.Location = new Point(68, 0);
            txt_ImporteCuota.Margin = new Padding(0);
            txt_ImporteCuota.Name = "txt_ImporteCuota";
            txt_ImporteCuota.ReadOnly = true;
            txt_ImporteCuota.Size = new Size(128, 25);
            txt_ImporteCuota.TabIndex = 7;
            txt_ImporteCuota.TextAlign = HorizontalAlignment.Right;
            // 
            // SocioAnualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 361);
            Controls.Add(tb_Layout);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SocioAnualForm";
            Text = "Agregar pago anual";
            Load += SocioAnualForm_Load;
            Shown += SocioAnualForm_Shown;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Filtrado.ResumeLayout(false);
            tb_Filtrado.PerformLayout();
            tb_Buscador.ResumeLayout(false);
            tb_Buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Lupa).EndInit();
            tb_Periodo.ResumeLayout(false);
            tb_Periodo.PerformLayout();
            tb_Anio.ResumeLayout(false);
            tb_Anio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Anio).EndInit();
            ((System.ComponentModel.ISupportInitialize)v_socios).EndInit();
            tb_Botonera.ResumeLayout(false);
            tb_Botonera.PerformLayout();
            gb_Importes.ResumeLayout(false);
            gb_Importes.PerformLayout();
            tb_Importes.ResumeLayout(false);
            tb_Importes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private Button btn_Cerrar;
        private Button btn_Agregar;
        private DataGridView v_socios;
        private TableLayoutPanel tb_Botonera;
        private TableLayoutPanel tb_Filtrado;
        private TableLayoutPanel tb_Buscador;
        private PictureBox pb_Lupa;
        private TextBox txt_Buscador;
        private TableLayoutPanel tb_Periodo;
        private Label lbl_Mes;
        private TableLayoutPanel tb_Anio;
        private Label lbl_Anio;
        private NumericUpDown num_Anio;
        private ComboBox cmb_Meses;
        private GroupBox gb_Importes;
        private TableLayoutPanel tb_Importes;
        private Label lbl_ImporteTotal;
        private TextBox txt_ImporteTotal;
        private Label lbl_ImporteCuota;
        private TextBox txt_ImporteCuota;
        private DataGridViewTextBoxColumn Col_NumSocio;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_NombreCompleto;
        private DataGridViewTextBoxColumn Col_DNI;
    }
}