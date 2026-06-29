namespace Socios_CamaraC
{
    partial class PagosAnualesForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosAnualesForm));
            tb_Layout = new TableLayoutPanel();
            tb_Views = new TableLayoutPanel();
            gb_Socios = new GroupBox();
            v_SociosAnuales = new DataGridView();
            Col_NumSocio = new DataGridViewTextBoxColumn();
            Col_CAT = new DataGridViewTextBoxColumn();
            Col_Nombre = new DataGridViewTextBoxColumn();
            Col_DNI = new DataGridViewTextBoxColumn();
            gb_Anuales = new GroupBox();
            v_AniosPagos = new DataGridView();
            Col_Anio = new DataGridViewTextBoxColumn();
            Col_ImporteCuota = new DataGridViewTextBoxColumn();
            Col_ImporteTotal = new DataGridViewTextBoxColumn();
            Col_FechaRegistro = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btn_Cerrar = new Button();
            btn_Agregar = new Button();
            tb_SocioSeleccionado = new TableLayoutPanel();
            lbl_NumSocio = new Label();
            lbl_DNI = new Label();
            lbl_Nombre = new Label();
            lbl_Categoria = new Label();
            lbl_NumTelefono = new Label();
            lbl_NumSocio_S = new Label();
            lbl_Nombre_S = new Label();
            lbl_DNI_S = new Label();
            lbl_Categoria_S = new Label();
            lbl_NumTelefono_S = new Label();
            tb_Layout.SuspendLayout();
            tb_Views.SuspendLayout();
            gb_Socios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_SociosAnuales).BeginInit();
            gb_Anuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_AniosPagos).BeginInit();
            panel1.SuspendLayout();
            tb_SocioSeleccionado.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_Views, 0, 1);
            tb_Layout.Controls.Add(panel1, 0, 0);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 2;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tb_Layout.Size = new Size(800, 271);
            tb_Layout.TabIndex = 0;
            // 
            // tb_Views
            // 
            tb_Views.AutoSize = true;
            tb_Views.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Views.ColumnCount = 2;
            tb_Views.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Views.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Views.Controls.Add(gb_Socios, 0, 0);
            tb_Views.Controls.Add(gb_Anuales, 1, 0);
            tb_Views.Dock = DockStyle.Fill;
            tb_Views.Location = new Point(3, 49);
            tb_Views.Name = "tb_Views";
            tb_Views.RowCount = 1;
            tb_Views.RowStyles.Add(new RowStyle());
            tb_Views.Size = new Size(794, 219);
            tb_Views.TabIndex = 0;
            // 
            // gb_Socios
            // 
            gb_Socios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb_Socios.Controls.Add(v_SociosAnuales);
            gb_Socios.Dock = DockStyle.Fill;
            gb_Socios.Location = new Point(3, 3);
            gb_Socios.Name = "gb_Socios";
            gb_Socios.Size = new Size(391, 213);
            gb_Socios.TabIndex = 0;
            gb_Socios.TabStop = false;
            gb_Socios.Text = "Socios:";
            // 
            // v_SociosAnuales
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_SociosAnuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_SociosAnuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_SociosAnuales.Columns.AddRange(new DataGridViewColumn[] { Col_NumSocio, Col_CAT, Col_Nombre, Col_DNI });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            v_SociosAnuales.DefaultCellStyle = dataGridViewCellStyle6;
            v_SociosAnuales.Dock = DockStyle.Fill;
            v_SociosAnuales.Location = new Point(3, 19);
            v_SociosAnuales.Name = "v_SociosAnuales";
            v_SociosAnuales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_SociosAnuales.Size = new Size(385, 191);
            v_SociosAnuales.TabIndex = 0;
            v_SociosAnuales.SelectionChanged += v_SociosAnuales_SelectionChanged;
            // 
            // Col_NumSocio
            // 
            Col_NumSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Col_NumSocio.DataPropertyName = "NumSocio";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_NumSocio.DefaultCellStyle = dataGridViewCellStyle2;
            Col_NumSocio.HeaderText = "N°Socio";
            Col_NumSocio.Name = "Col_NumSocio";
            Col_NumSocio.ReadOnly = true;
            Col_NumSocio.Width = 80;
            // 
            // Col_CAT
            // 
            Col_CAT.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_CAT.DefaultCellStyle = dataGridViewCellStyle3;
            Col_CAT.HeaderText = "CAT";
            Col_CAT.Name = "Col_CAT";
            Col_CAT.ReadOnly = true;
            Col_CAT.Width = 36;
            // 
            // Col_Nombre
            // 
            Col_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Nombre.DataPropertyName = "NombreCompleto";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            Col_Nombre.HeaderText = "Socio";
            Col_Nombre.Name = "Col_Nombre";
            Col_Nombre.ReadOnly = true;
            Col_Nombre.Width = 65;
            // 
            // Col_DNI
            // 
            Col_DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_DNI.DataPropertyName = "DNI";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_DNI.DefaultCellStyle = dataGridViewCellStyle5;
            Col_DNI.HeaderText = "DNI";
            Col_DNI.Name = "Col_DNI";
            Col_DNI.ReadOnly = true;
            // 
            // gb_Anuales
            // 
            gb_Anuales.AutoSize = true;
            gb_Anuales.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb_Anuales.Controls.Add(v_AniosPagos);
            gb_Anuales.Dock = DockStyle.Fill;
            gb_Anuales.Location = new Point(400, 3);
            gb_Anuales.Name = "gb_Anuales";
            gb_Anuales.Size = new Size(391, 213);
            gb_Anuales.TabIndex = 1;
            gb_Anuales.TabStop = false;
            gb_Anuales.Text = "Pagos anuales:";
            // 
            // v_AniosPagos
            // 
            v_AniosPagos.AllowUserToAddRows = false;
            v_AniosPagos.AllowUserToDeleteRows = false;
            v_AniosPagos.AllowUserToResizeColumns = false;
            v_AniosPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            v_AniosPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            v_AniosPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_AniosPagos.Columns.AddRange(new DataGridViewColumn[] { Col_Anio, Col_ImporteCuota, Col_ImporteTotal, Col_FechaRegistro });
            v_AniosPagos.Dock = DockStyle.Fill;
            v_AniosPagos.Enabled = false;
            v_AniosPagos.Location = new Point(3, 19);
            v_AniosPagos.MultiSelect = false;
            v_AniosPagos.Name = "v_AniosPagos";
            v_AniosPagos.ReadOnly = true;
            v_AniosPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_AniosPagos.Size = new Size(385, 191);
            v_AniosPagos.TabIndex = 0;
            // 
            // Col_Anio
            // 
            Col_Anio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Anio.DataPropertyName = "Anio";
            Col_Anio.HeaderText = "Año Pago";
            Col_Anio.Name = "Col_Anio";
            Col_Anio.ReadOnly = true;
            Col_Anio.Width = 84;
            // 
            // Col_ImporteCuota
            // 
            Col_ImporteCuota.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_ImporteCuota.DataPropertyName = "ImportePorCuota";
            Col_ImporteCuota.HeaderText = "Mensual";
            Col_ImporteCuota.Name = "Col_ImporteCuota";
            Col_ImporteCuota.ReadOnly = true;
            Col_ImporteCuota.Width = 77;
            // 
            // Col_ImporteTotal
            // 
            Col_ImporteTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_ImporteTotal.DataPropertyName = "ImporteTotal";
            Col_ImporteTotal.HeaderText = "Total";
            Col_ImporteTotal.Name = "Col_ImporteTotal";
            Col_ImporteTotal.ReadOnly = true;
            Col_ImporteTotal.Width = 58;
            // 
            // Col_FechaRegistro
            // 
            Col_FechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_FechaRegistro.DataPropertyName = "FechaRegistro";
            Col_FechaRegistro.HeaderText = "Fecha pago";
            Col_FechaRegistro.Name = "Col_FechaRegistro";
            Col_FechaRegistro.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(tb_SocioSeleccionado);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 40);
            panel1.TabIndex = 2;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.AutoSize = true;
            btn_Cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cerrar.Location = new Point(733, 3);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(55, 27);
            btn_Cerrar.TabIndex = 3;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.AutoSize = true;
            btn_Agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Agregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar.Location = new Point(625, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(102, 27);
            btn_Agregar.TabIndex = 2;
            btn_Agregar.Text = "Agregar Socio";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // tb_SocioSeleccionado
            // 
            tb_SocioSeleccionado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_SocioSeleccionado.ColumnCount = 6;
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle());
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3340149F));
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle());
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8329964F));
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle());
            tb_SocioSeleccionado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.8329964F));
            tb_SocioSeleccionado.Controls.Add(lbl_NumSocio, 0, 0);
            tb_SocioSeleccionado.Controls.Add(lbl_DNI, 0, 1);
            tb_SocioSeleccionado.Controls.Add(lbl_Nombre, 2, 0);
            tb_SocioSeleccionado.Controls.Add(lbl_Categoria, 2, 1);
            tb_SocioSeleccionado.Controls.Add(lbl_NumTelefono, 4, 0);
            tb_SocioSeleccionado.Controls.Add(lbl_NumSocio_S, 1, 0);
            tb_SocioSeleccionado.Controls.Add(lbl_Nombre_S, 3, 0);
            tb_SocioSeleccionado.Controls.Add(lbl_DNI_S, 1, 1);
            tb_SocioSeleccionado.Controls.Add(lbl_Categoria_S, 3, 1);
            tb_SocioSeleccionado.Controls.Add(lbl_NumTelefono_S, 5, 0);
            tb_SocioSeleccionado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_SocioSeleccionado.Location = new Point(3, 3);
            tb_SocioSeleccionado.Name = "tb_SocioSeleccionado";
            tb_SocioSeleccionado.RowCount = 2;
            tb_SocioSeleccionado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tb_SocioSeleccionado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tb_SocioSeleccionado.Size = new Size(616, 34);
            tb_SocioSeleccionado.TabIndex = 1;
            // 
            // lbl_NumSocio
            // 
            lbl_NumSocio.AutoSize = true;
            lbl_NumSocio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NumSocio.Location = new Point(3, 0);
            lbl_NumSocio.Name = "lbl_NumSocio";
            lbl_NumSocio.Size = new Size(57, 17);
            lbl_NumSocio.TabIndex = 0;
            lbl_NumSocio.Text = "N°socio:";
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DNI.Location = new Point(3, 17);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(34, 17);
            lbl_DNI.TabIndex = 1;
            lbl_DNI.Text = "DNI:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nombre.Location = new Point(135, 0);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(61, 17);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Categoria.Location = new Point(135, 17);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(36, 17);
            lbl_Categoria.TabIndex = 3;
            lbl_Categoria.Text = "CAT.:";
            // 
            // lbl_NumTelefono
            // 
            lbl_NumTelefono.AutoSize = true;
            lbl_NumTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NumTelefono.Location = new Point(357, 0);
            lbl_NumTelefono.Name = "lbl_NumTelefono";
            lbl_NumTelefono.Size = new Size(99, 17);
            lbl_NumTelefono.TabIndex = 5;
            lbl_NumTelefono.Text = "Num. Teléfono:";
            // 
            // lbl_NumSocio_S
            // 
            lbl_NumSocio_S.AutoEllipsis = true;
            lbl_NumSocio_S.AutoSize = true;
            lbl_NumSocio_S.Location = new Point(66, 0);
            lbl_NumSocio_S.Name = "lbl_NumSocio_S";
            lbl_NumSocio_S.Size = new Size(61, 17);
            lbl_NumSocio_S.TabIndex = 6;
            lbl_NumSocio_S.Text = "[NumSocio]";
            // 
            // lbl_Nombre_S
            // 
            lbl_Nombre_S.AutoEllipsis = true;
            lbl_Nombre_S.AutoSize = true;
            lbl_Nombre_S.Location = new Point(202, 0);
            lbl_Nombre_S.Name = "lbl_Nombre_S";
            lbl_Nombre_S.Size = new Size(65, 17);
            lbl_Nombre_S.TabIndex = 7;
            lbl_Nombre_S.Text = "[Nombre]";
            // 
            // lbl_DNI_S
            // 
            lbl_DNI_S.AutoSize = true;
            lbl_DNI_S.Location = new Point(66, 17);
            lbl_DNI_S.Name = "lbl_DNI_S";
            lbl_DNI_S.Size = new Size(38, 17);
            lbl_DNI_S.TabIndex = 8;
            lbl_DNI_S.Text = "[DNI]";
            // 
            // lbl_Categoria_S
            // 
            lbl_Categoria_S.AutoSize = true;
            lbl_Categoria_S.Location = new Point(202, 17);
            lbl_Categoria_S.Name = "lbl_Categoria_S";
            lbl_Categoria_S.Size = new Size(38, 17);
            lbl_Categoria_S.TabIndex = 9;
            lbl_Categoria_S.Text = "[CAT]";
            // 
            // lbl_NumTelefono_S
            // 
            lbl_NumTelefono_S.AutoEllipsis = true;
            lbl_NumTelefono_S.AutoSize = true;
            lbl_NumTelefono_S.Location = new Point(462, 0);
            lbl_NumTelefono_S.Name = "lbl_NumTelefono_S";
            lbl_NumTelefono_S.Size = new Size(94, 17);
            lbl_NumTelefono_S.TabIndex = 10;
            lbl_NumTelefono_S.Text = "[NumTelefono]";
            // 
            // PagosAnualesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 271);
            Controls.Add(tb_Layout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PagosAnualesForm";
            Text = "Pagos anuales";
            Load += PagosAnuales_Load;
            Shown += PagosAnualesForm_Shown;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Views.ResumeLayout(false);
            tb_Views.PerformLayout();
            gb_Socios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v_SociosAnuales).EndInit();
            gb_Anuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)v_AniosPagos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tb_SocioSeleccionado.ResumeLayout(false);
            tb_SocioSeleccionado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Views;
        private GroupBox gb_Socios;
        private GroupBox gb_Anuales;
        private DataGridView v_SociosAnuales;
        private DataGridView v_AniosPagos;
        private TableLayoutPanel tb_SocioSeleccionado;
        private Label lbl_NumSocio;
        private Label lbl_DNI;
        private Label lbl_Nombre;
        private Label lbl_Categoria;
        private Label lbl_NumTelefono;
        private Label lbl_NumSocio_S;
        private Label lbl_Nombre_S;
        private Label lbl_DNI_S;
        private Label lbl_Categoria_S;
        private Label lbl_NumTelefono_S;
        private Panel panel1;
        private Button btn_Agregar;
        private DataGridViewTextBoxColumn Col_NumSocio;
        private DataGridViewTextBoxColumn Col_CAT;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_DNI;
        private Button btn_Cerrar;
        private DataGridViewTextBoxColumn Col_Anio;
        private DataGridViewTextBoxColumn Col_ImporteCuota;
        private DataGridViewTextBoxColumn Col_ImporteTotal;
        private DataGridViewTextBoxColumn Col_FechaRegistro;
    }
}