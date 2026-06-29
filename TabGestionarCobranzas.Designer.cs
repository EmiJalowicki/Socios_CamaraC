namespace Socios_CamaraC
{
    partial class TabGestionarCobranzas
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
            tb_Layout = new TableLayoutPanel();
            tb_Opciones = new TableLayoutPanel();
            lbl_Categoria = new Label();
            cmb_Categorias = new ComboBox();
            panel_Botones = new Panel();
            chk_MarcarTodo = new CheckBox();
            btn_AplicarCobranzas = new Button();
            btn_ModificarImporte = new Button();
            btn_Eliminar = new Button();
            btn_NuevaCobranza = new Button();
            v_Cobranzas = new DataGridView();
            Col_AplicarChk = new DataGridViewCheckBoxColumn();
            col_Anio = new DataGridViewTextBoxColumn();
            col_Mes = new DataGridViewTextBoxColumn();
            col_Importe = new DataGridViewTextBoxColumn();
            tb_Layout.SuspendLayout();
            tb_Opciones.SuspendLayout();
            panel_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_Cobranzas).BeginInit();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.AutoSize = true;
            tb_Layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_Opciones, 0, 0);
            tb_Layout.Controls.Add(v_Cobranzas, 0, 1);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 2;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.Size = new Size(808, 300);
            tb_Layout.TabIndex = 1;
            // 
            // tb_Opciones
            // 
            tb_Opciones.AutoSize = true;
            tb_Opciones.ColumnCount = 3;
            tb_Opciones.ColumnStyles.Add(new ColumnStyle());
            tb_Opciones.ColumnStyles.Add(new ColumnStyle());
            tb_Opciones.ColumnStyles.Add(new ColumnStyle());
            tb_Opciones.Controls.Add(lbl_Categoria, 0, 0);
            tb_Opciones.Controls.Add(cmb_Categorias, 1, 0);
            tb_Opciones.Controls.Add(panel_Botones, 2, 0);
            tb_Opciones.Dock = DockStyle.Fill;
            tb_Opciones.Location = new Point(3, 3);
            tb_Opciones.Name = "tb_Opciones";
            tb_Opciones.RowCount = 1;
            tb_Opciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Opciones.Size = new Size(802, 37);
            tb_Opciones.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.Anchor = AnchorStyles.Left;
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(3, 10);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(68, 17);
            lbl_Categoria.TabIndex = 2;
            lbl_Categoria.Text = "Categoría:";
            // 
            // cmb_Categorias
            // 
            cmb_Categorias.Anchor = AnchorStyles.Left;
            cmb_Categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categorias.FormattingEnabled = true;
            cmb_Categorias.Location = new Point(77, 7);
            cmb_Categorias.Name = "cmb_Categorias";
            cmb_Categorias.Size = new Size(142, 25);
            cmb_Categorias.TabIndex = 1;
            cmb_Categorias.SelectedIndexChanged += cmb_Categorias_SelectedIndexChanged;
            // 
            // panel_Botones
            // 
            panel_Botones.AutoSize = true;
            panel_Botones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_Botones.Controls.Add(chk_MarcarTodo);
            panel_Botones.Controls.Add(btn_AplicarCobranzas);
            panel_Botones.Controls.Add(btn_ModificarImporte);
            panel_Botones.Controls.Add(btn_Eliminar);
            panel_Botones.Controls.Add(btn_NuevaCobranza);
            panel_Botones.Dock = DockStyle.Fill;
            panel_Botones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel_Botones.Location = new Point(225, 3);
            panel_Botones.Name = "panel_Botones";
            panel_Botones.Size = new Size(574, 31);
            panel_Botones.TabIndex = 1;
            // 
            // chk_MarcarTodo
            // 
            chk_MarcarTodo.AutoSize = true;
            chk_MarcarTodo.Location = new Point(421, 7);
            chk_MarcarTodo.Name = "chk_MarcarTodo";
            chk_MarcarTodo.Size = new Size(95, 19);
            chk_MarcarTodo.TabIndex = 4;
            chk_MarcarTodo.Text = "Marcar todas";
            chk_MarcarTodo.UseVisualStyleBackColor = true;
            chk_MarcarTodo.CheckedChanged += chk_MarcarTodo_CheckedChanged;
            // 
            // btn_AplicarCobranzas
            // 
            btn_AplicarCobranzas.AutoSize = true;
            btn_AplicarCobranzas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_AplicarCobranzas.Location = new Point(305, 3);
            btn_AplicarCobranzas.Name = "btn_AplicarCobranzas";
            btn_AplicarCobranzas.Size = new Size(110, 25);
            btn_AplicarCobranzas.TabIndex = 3;
            btn_AplicarCobranzas.Text = "Aplicar cobranzas";
            btn_AplicarCobranzas.UseVisualStyleBackColor = true;
            btn_AplicarCobranzas.Click += btn_AplicarCobranzas_Click;
            // 
            // btn_ModificarImporte
            // 
            btn_ModificarImporte.AutoSize = true;
            btn_ModificarImporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ModificarImporte.Location = new Point(186, 3);
            btn_ModificarImporte.Name = "btn_ModificarImporte";
            btn_ModificarImporte.Size = new Size(113, 25);
            btn_ModificarImporte.TabIndex = 2;
            btn_ModificarImporte.Text = "Modificar importe";
            btn_ModificarImporte.UseVisualStyleBackColor = true;
            btn_ModificarImporte.Click += btn_ModificarImporte_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.AutoSize = true;
            btn_Eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Eliminar.Location = new Point(120, 3);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(60, 25);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_NuevaCobranza
            // 
            btn_NuevaCobranza.AutoSize = true;
            btn_NuevaCobranza.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_NuevaCobranza.Location = new Point(12, 3);
            btn_NuevaCobranza.Name = "btn_NuevaCobranza";
            btn_NuevaCobranza.Size = new Size(102, 25);
            btn_NuevaCobranza.TabIndex = 0;
            btn_NuevaCobranza.Text = "Nueva cobranza";
            btn_NuevaCobranza.UseVisualStyleBackColor = true;
            btn_NuevaCobranza.Click += btn_NuevaCobranza_Click;
            // 
            // v_Cobranzas
            // 
            v_Cobranzas.AllowUserToAddRows = false;
            v_Cobranzas.AllowUserToDeleteRows = false;
            v_Cobranzas.AllowUserToResizeColumns = false;
            v_Cobranzas.AllowUserToResizeRows = false;
            v_Cobranzas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            v_Cobranzas.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_Cobranzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_Cobranzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_Cobranzas.Columns.AddRange(new DataGridViewColumn[] { Col_AplicarChk, col_Anio, col_Mes, col_Importe });
            v_Cobranzas.Dock = DockStyle.Fill;
            v_Cobranzas.EnableHeadersVisualStyles = false;
            v_Cobranzas.Location = new Point(3, 46);
            v_Cobranzas.MultiSelect = false;
            v_Cobranzas.Name = "v_Cobranzas";
            v_Cobranzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_Cobranzas.Size = new Size(802, 251);
            v_Cobranzas.TabIndex = 1;
            v_Cobranzas.CellValueChanged += v_Cobranzas_CellValueChanged;
            v_Cobranzas.CurrentCellDirtyStateChanged += v_Cobranzas_CurrentCellDirtyStateChanged;
            v_Cobranzas.SelectionChanged += v_Cobranzas_SelectionChanged;
            // 
            // Col_AplicarChk
            // 
            Col_AplicarChk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_AplicarChk.DataPropertyName = "Aplicar";
            Col_AplicarChk.HeaderText = "Aplicar";
            Col_AplicarChk.Name = "Col_AplicarChk";
            Col_AplicarChk.Width = 55;
            // 
            // col_Anio
            // 
            col_Anio.DataPropertyName = "Anio";
            col_Anio.HeaderText = "Año";
            col_Anio.Name = "col_Anio";
            col_Anio.ReadOnly = true;
            // 
            // col_Mes
            // 
            col_Mes.DataPropertyName = "Mes";
            col_Mes.HeaderText = "Mes";
            col_Mes.Name = "col_Mes";
            col_Mes.ReadOnly = true;
            // 
            // col_Importe
            // 
            col_Importe.DataPropertyName = "MuestraImporte";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Importe.DefaultCellStyle = dataGridViewCellStyle2;
            col_Importe.HeaderText = "Importe";
            col_Importe.Name = "col_Importe";
            col_Importe.ReadOnly = true;
            // 
            // TabGestionarCobranzas
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tb_Layout);
            Name = "TabGestionarCobranzas";
            Size = new Size(808, 300);
            Load += TabGestionarCobranzas_Load;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Opciones.ResumeLayout(false);
            tb_Opciones.PerformLayout();
            panel_Botones.ResumeLayout(false);
            panel_Botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)v_Cobranzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Opciones;
        private Label lbl_Categoria;
        private ComboBox cmb_Categorias;
        private Panel panel_Botones;
        private Button btn_ModificarImporte;
        private Button btn_Eliminar;
        private Button btn_NuevaCobranza;
        private DataGridView v_Cobranzas;
        private DataGridViewCheckBoxColumn Col_AplicarChk;
        private DataGridViewTextBoxColumn col_Anio;
        private DataGridViewTextBoxColumn col_Mes;
        private DataGridViewTextBoxColumn col_Importe;
        private Button btn_AplicarCobranzas;
        private CheckBox chk_MarcarTodo;
    }
}
