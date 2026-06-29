namespace Socios_CamaraC
{
    partial class TabSociosMorosos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tb_Layout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            gb_Socios = new GroupBox();
            v_SociosMorosos = new DataGridView();
            Col_NumSocio = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            Col_Apellido = new DataGridViewTextBoxColumn();
            Col_Nombre = new DataGridViewTextBoxColumn();
            Col_DNI = new DataGridViewTextBoxColumn();
            gb_Cobranzas = new GroupBox();
            v_Cuotas = new DataGridView();
            Col_Anio = new DataGridViewTextBoxColumn();
            Col_Mes = new DataGridViewTextBoxColumn();
            Col_Importe = new DataGridViewTextBoxColumn();
            p_Botonera = new Panel();
            btn_DarBaja = new Button();
            tb_Filtro = new TableLayoutPanel();
            lbl_FiltrarUltimas = new Label();
            lbl_Cuotas = new Label();
            n_Cuotas = new NumericUpDown();
            tb_Layout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gb_Socios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_SociosMorosos).BeginInit();
            gb_Cobranzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_Cuotas).BeginInit();
            p_Botonera.SuspendLayout();
            tb_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)n_Cuotas).BeginInit();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tableLayoutPanel1, 0, 1);
            tb_Layout.Controls.Add(p_Botonera, 0, 0);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 2;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.Size = new Size(808, 300);
            tb_Layout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel1.Controls.Add(gb_Socios, 0, 0);
            tableLayoutPanel1.Controls.Add(gb_Cobranzas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(802, 254);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // gb_Socios
            // 
            gb_Socios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb_Socios.Controls.Add(v_SociosMorosos);
            gb_Socios.Dock = DockStyle.Fill;
            gb_Socios.Location = new Point(3, 3);
            gb_Socios.Name = "gb_Socios";
            gb_Socios.Size = new Size(431, 248);
            gb_Socios.TabIndex = 0;
            gb_Socios.TabStop = false;
            gb_Socios.Text = "Socios:";
            // 
            // v_SociosMorosos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_SociosMorosos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_SociosMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_SociosMorosos.Columns.AddRange(new DataGridViewColumn[] { Col_NumSocio, Col_Categoria, Col_Apellido, Col_Nombre, Col_DNI });
            v_SociosMorosos.Dock = DockStyle.Fill;
            v_SociosMorosos.Location = new Point(3, 21);
            v_SociosMorosos.MultiSelect = false;
            v_SociosMorosos.Name = "v_SociosMorosos";
            v_SociosMorosos.ReadOnly = true;
            v_SociosMorosos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_SociosMorosos.Size = new Size(425, 224);
            v_SociosMorosos.TabIndex = 0;
            v_SociosMorosos.SelectionChanged += v_SociosMorosos_SelectionChanged;
            // 
            // Col_NumSocio
            // 
            Col_NumSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_NumSocio.DataPropertyName = "NumSocio";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Col_NumSocio.DefaultCellStyle = dataGridViewCellStyle2;
            Col_NumSocio.HeaderText = "N°";
            Col_NumSocio.Name = "Col_NumSocio";
            Col_NumSocio.ReadOnly = true;
            Col_NumSocio.Width = 48;
            // 
            // Col_Categoria
            // 
            Col_Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_Categoria.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            Col_Categoria.HeaderText = "CAT";
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.ReadOnly = true;
            Col_Categoria.Width = 32;
            // 
            // Col_Apellido
            // 
            Col_Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Apellido.DataPropertyName = "Apellido";
            Col_Apellido.HeaderText = "Apellido(s)";
            Col_Apellido.Name = "Col_Apellido";
            Col_Apellido.ReadOnly = true;
            Col_Apellido.Width = 96;
            // 
            // Col_Nombre
            // 
            Col_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Nombre.DataPropertyName = "Nombre";
            Col_Nombre.HeaderText = "Nombre";
            Col_Nombre.Name = "Col_Nombre";
            Col_Nombre.ReadOnly = true;
            Col_Nombre.Width = 83;
            // 
            // Col_DNI
            // 
            Col_DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_DNI.DataPropertyName = "DNI";
            Col_DNI.HeaderText = "DNI";
            Col_DNI.Name = "Col_DNI";
            Col_DNI.ReadOnly = true;
            // 
            // gb_Cobranzas
            // 
            gb_Cobranzas.Controls.Add(v_Cuotas);
            gb_Cobranzas.Dock = DockStyle.Fill;
            gb_Cobranzas.Location = new Point(440, 3);
            gb_Cobranzas.Name = "gb_Cobranzas";
            gb_Cobranzas.Size = new Size(359, 248);
            gb_Cobranzas.TabIndex = 1;
            gb_Cobranzas.TabStop = false;
            gb_Cobranzas.Text = "Cobranzas:";
            // 
            // v_Cuotas
            // 
            v_Cuotas.AllowUserToAddRows = false;
            v_Cuotas.AllowUserToDeleteRows = false;
            v_Cuotas.AllowUserToResizeColumns = false;
            v_Cuotas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            v_Cuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            v_Cuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_Cuotas.Columns.AddRange(new DataGridViewColumn[] { Col_Anio, Col_Mes, Col_Importe });
            v_Cuotas.Dock = DockStyle.Fill;
            v_Cuotas.Enabled = false;
            v_Cuotas.Location = new Point(3, 21);
            v_Cuotas.MultiSelect = false;
            v_Cuotas.Name = "v_Cuotas";
            v_Cuotas.ReadOnly = true;
            v_Cuotas.Size = new Size(353, 224);
            v_Cuotas.TabIndex = 0;
            // 
            // Col_Anio
            // 
            Col_Anio.DataPropertyName = "Anio";
            Col_Anio.HeaderText = "Año";
            Col_Anio.Name = "Col_Anio";
            Col_Anio.ReadOnly = true;
            // 
            // Col_Mes
            // 
            Col_Mes.DataPropertyName = "Mes";
            Col_Mes.HeaderText = "Mes";
            Col_Mes.Name = "Col_Mes";
            Col_Mes.ReadOnly = true;
            // 
            // Col_Importe
            // 
            Col_Importe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Col_Importe.DefaultCellStyle = dataGridViewCellStyle5;
            Col_Importe.HeaderText = "Importe";
            Col_Importe.Name = "Col_Importe";
            Col_Importe.ReadOnly = true;
            // 
            // p_Botonera
            // 
            p_Botonera.AutoSize = true;
            p_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            p_Botonera.Controls.Add(btn_DarBaja);
            p_Botonera.Controls.Add(tb_Filtro);
            p_Botonera.Dock = DockStyle.Fill;
            p_Botonera.Location = new Point(3, 3);
            p_Botonera.Name = "p_Botonera";
            p_Botonera.Size = new Size(802, 34);
            p_Botonera.TabIndex = 2;
            // 
            // btn_DarBaja
            // 
            btn_DarBaja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DarBaja.AutoSize = true;
            btn_DarBaja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_DarBaja.Location = new Point(715, 2);
            btn_DarBaja.Name = "btn_DarBaja";
            btn_DarBaja.Size = new Size(87, 27);
            btn_DarBaja.TabIndex = 1;
            btn_DarBaja.Text = "Dar de baja";
            btn_DarBaja.UseVisualStyleBackColor = true;
            btn_DarBaja.Click += btn_DarBaja_Click;
            // 
            // tb_Filtro
            // 
            tb_Filtro.AutoSize = true;
            tb_Filtro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Filtro.ColumnCount = 3;
            tb_Filtro.ColumnStyles.Add(new ColumnStyle());
            tb_Filtro.ColumnStyles.Add(new ColumnStyle());
            tb_Filtro.ColumnStyles.Add(new ColumnStyle());
            tb_Filtro.Controls.Add(lbl_FiltrarUltimas, 0, 0);
            tb_Filtro.Controls.Add(lbl_Cuotas, 2, 0);
            tb_Filtro.Controls.Add(n_Cuotas, 1, 0);
            tb_Filtro.Location = new Point(0, 0);
            tb_Filtro.Name = "tb_Filtro";
            tb_Filtro.RowCount = 1;
            tb_Filtro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Filtro.Size = new Size(220, 31);
            tb_Filtro.TabIndex = 0;
            // 
            // lbl_FiltrarUltimas
            // 
            lbl_FiltrarUltimas.Anchor = AnchorStyles.Left;
            lbl_FiltrarUltimas.AutoSize = true;
            lbl_FiltrarUltimas.Location = new Point(3, 7);
            lbl_FiltrarUltimas.Name = "lbl_FiltrarUltimas";
            lbl_FiltrarUltimas.Size = new Size(111, 17);
            lbl_FiltrarUltimas.TabIndex = 0;
            lbl_FiltrarUltimas.Text = "Filtrar por últimas";
            // 
            // lbl_Cuotas
            // 
            lbl_Cuotas.Anchor = AnchorStyles.Left;
            lbl_Cuotas.AutoSize = true;
            lbl_Cuotas.Location = new Point(171, 7);
            lbl_Cuotas.Name = "lbl_Cuotas";
            lbl_Cuotas.Size = new Size(46, 17);
            lbl_Cuotas.TabIndex = 2;
            lbl_Cuotas.Text = "cuotas";
            // 
            // n_Cuotas
            // 
            n_Cuotas.Anchor = AnchorStyles.Left;
            n_Cuotas.AutoSize = true;
            n_Cuotas.Location = new Point(120, 3);
            n_Cuotas.Name = "n_Cuotas";
            n_Cuotas.Size = new Size(45, 25);
            n_Cuotas.TabIndex = 3;
            n_Cuotas.ValueChanged += n_Cuotas_ValueChanged;
            // 
            // TabSociosMorosos
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tb_Layout);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TabSociosMorosos";
            Size = new Size(808, 300);
            Load += TabSociosInactivos_Load;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            gb_Socios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v_SociosMorosos).EndInit();
            gb_Cobranzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v_Cuotas).EndInit();
            p_Botonera.ResumeLayout(false);
            p_Botonera.PerformLayout();
            tb_Filtro.ResumeLayout(false);
            tb_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)n_Cuotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Filtro;
        private Label lbl_FiltrarUltimas;
        private Label lbl_Cuotas;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gb_Socios;
        private DataGridView v_SociosMorosos;
        private GroupBox gb_Cobranzas;
        private DataGridView v_Cuotas;
        private NumericUpDown n_Cuotas;
        private DataGridViewTextBoxColumn Col_NumSocio;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Apellido;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_DNI;
        private Panel p_Botonera;
        private Button btn_DarBaja;
        private DataGridViewTextBoxColumn Col_Anio;
        private DataGridViewTextBoxColumn Col_Mes;
        private DataGridViewTextBoxColumn Col_Importe;
    }
}
