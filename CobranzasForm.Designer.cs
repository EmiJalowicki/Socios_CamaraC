namespace Socios_CamaraC
{
    partial class CobranzasForm
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
            tb_Layout = new TableLayoutPanel();
            tb_Opciones = new TableLayoutPanel();
            lbl_Categoria = new Label();
            cmb_Categorias = new ComboBox();
            panel_Botones = new Panel();
            btn_ModificarImporte = new Button();
            btn_Eliminar = new Button();
            btn_NuevaCobranza = new Button();
            v_Cobranzas = new DataGridView();
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
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_Opciones, 0, 0);
            tb_Layout.Controls.Add(v_Cobranzas, 0, 1);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 2;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.Size = new Size(499, 450);
            tb_Layout.TabIndex = 0;
            // 
            // tb_Opciones
            // 
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
            tb_Opciones.Size = new Size(493, 100);
            tb_Opciones.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.Anchor = AnchorStyles.Left;
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(3, 42);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(61, 15);
            lbl_Categoria.TabIndex = 2;
            lbl_Categoria.Text = "Categoría:";
            // 
            // cmb_Categorias
            // 
            cmb_Categorias.Anchor = AnchorStyles.Left;
            cmb_Categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categorias.FormattingEnabled = true;
            cmb_Categorias.Location = new Point(70, 38);
            cmb_Categorias.Name = "cmb_Categorias";
            cmb_Categorias.Size = new Size(121, 23);
            cmb_Categorias.TabIndex = 1;
            cmb_Categorias.SelectedIndexChanged += cmb_Categorias_SelectedIndexChanged;
            // 
            // panel_Botones
            // 
            panel_Botones.Controls.Add(btn_ModificarImporte);
            panel_Botones.Controls.Add(btn_Eliminar);
            panel_Botones.Controls.Add(btn_NuevaCobranza);
            panel_Botones.Dock = DockStyle.Fill;
            panel_Botones.Location = new Point(197, 3);
            panel_Botones.Name = "panel_Botones";
            panel_Botones.Size = new Size(594, 94);
            panel_Botones.TabIndex = 1;
            // 
            // btn_ModificarImporte
            // 
            btn_ModificarImporte.AutoSize = true;
            btn_ModificarImporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ModificarImporte.Location = new Point(177, 34);
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
            btn_Eliminar.Location = new Point(111, 34);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(60, 25);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_NuevaCobranza
            // 
            btn_NuevaCobranza.AutoSize = true;
            btn_NuevaCobranza.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_NuevaCobranza.Location = new Point(3, 34);
            btn_NuevaCobranza.Name = "btn_NuevaCobranza";
            btn_NuevaCobranza.Size = new Size(102, 25);
            btn_NuevaCobranza.TabIndex = 0;
            btn_NuevaCobranza.Text = "Nueva cobranza";
            btn_NuevaCobranza.UseVisualStyleBackColor = true;
            btn_NuevaCobranza.Click += btn_NuevaCobranza_Click;
            // 
            // v_Cobranzas
            // 
            v_Cobranzas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            v_Cobranzas.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            v_Cobranzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_Cobranzas.Columns.AddRange(new DataGridViewColumn[] { col_Anio, col_Mes, col_Importe });
            v_Cobranzas.Dock = DockStyle.Fill;
            v_Cobranzas.Location = new Point(3, 109);
            v_Cobranzas.MultiSelect = false;
            v_Cobranzas.Name = "v_Cobranzas";
            v_Cobranzas.ReadOnly = true;
            v_Cobranzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_Cobranzas.Size = new Size(493, 338);
            v_Cobranzas.TabIndex = 1;
            v_Cobranzas.SelectionChanged += v_Cobranzas_SelectionChanged;
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
            col_Importe.HeaderText = "Importe";
            col_Importe.Name = "col_Importe";
            col_Importe.ReadOnly = true;
            // 
            // CobranzasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(499, 450);
            Controls.Add(tb_Layout);
            Name = "CobranzasForm";
            Text = "Gestionar Cobranzas";
            Load += CobranzasForm_Load;
            tb_Layout.ResumeLayout(false);
            tb_Opciones.ResumeLayout(false);
            tb_Opciones.PerformLayout();
            panel_Botones.ResumeLayout(false);
            panel_Botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)v_Cobranzas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Opciones;
        private Panel panel_Botones;
        private Label lbl_Categoria;
        private ComboBox cmb_Categorias;
        private Button btn_ModificarImporte;
        private Button btn_Eliminar;
        private Button btn_NuevaCobranza;
        private DataGridView v_Cobranzas;
        private DataGridViewTextBoxColumn col_Anio;
        private DataGridViewTextBoxColumn col_Mes;
        private DataGridViewTextBoxColumn col_Importe;
    }
}