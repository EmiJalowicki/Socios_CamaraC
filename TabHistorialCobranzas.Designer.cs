namespace Socios_CamaraC
{
    partial class TabHistorialCobranzas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            ep_AvisoError = new ErrorProvider(components);
            tb_Layout = new TableLayoutPanel();
            v_HistorialCobranzas = new DataGridView();
            Col_FechaPagoH = new DataGridViewTextBoxColumn();
            Col_NumSocioH = new DataGridViewTextBoxColumn();
            Col_NombreH = new DataGridViewTextBoxColumn();
            Col_CategoriaH = new DataGridViewTextBoxColumn();
            Col_PeriodoH = new DataGridViewTextBoxColumn();
            Col_ImporteH = new DataGridViewTextBoxColumn();
            tb_Filtros = new TableLayoutPanel();
            tb_FiltroDiasQuincena = new TableLayoutPanel();
            tb_Quincena = new TableLayoutPanel();
            lbl_Quincena = new Label();
            cmb_Quincena = new ComboBox();
            tb_FiltroDias = new TableLayoutPanel();
            lbl_Desde = new Label();
            lbl_Hasta = new Label();
            txt_DDesde = new TextBox();
            txt_DHasta = new TextBox();
            chk_FiltrarDias = new CheckBox();
            tb_FiltroAnioMes = new TableLayoutPanel();
            chk_FiltrarAnio = new CheckBox();
            chk_FiltrarMes = new CheckBox();
            cmb_FMes = new ComboBox();
            num_FAnio = new NumericUpDown();
            tb_Total = new TableLayoutPanel();
            lbl_Total = new Label();
            txt_Total = new TextBox();
            chk_OcultarAnuales = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).BeginInit();
            tb_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_HistorialCobranzas).BeginInit();
            tb_Filtros.SuspendLayout();
            tb_FiltroDiasQuincena.SuspendLayout();
            tb_Quincena.SuspendLayout();
            tb_FiltroDias.SuspendLayout();
            tb_FiltroAnioMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_FAnio).BeginInit();
            tb_Total.SuspendLayout();
            SuspendLayout();
            // 
            // ep_AvisoError
            // 
            ep_AvisoError.ContainerControl = this;
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(v_HistorialCobranzas, 0, 1);
            tb_Layout.Controls.Add(tb_Filtros, 0, 0);
            tb_Layout.Controls.Add(tb_Total, 0, 2);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 3;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.Size = new Size(808, 300);
            tb_Layout.TabIndex = 0;
            // 
            // v_HistorialCobranzas
            // 
            v_HistorialCobranzas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_HistorialCobranzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_HistorialCobranzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_HistorialCobranzas.Columns.AddRange(new DataGridViewColumn[] { Col_FechaPagoH, Col_NumSocioH, Col_NombreH, Col_CategoriaH, Col_PeriodoH, Col_ImporteH });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            v_HistorialCobranzas.DefaultCellStyle = dataGridViewCellStyle6;
            v_HistorialCobranzas.Dock = DockStyle.Fill;
            v_HistorialCobranzas.Location = new Point(3, 85);
            v_HistorialCobranzas.MultiSelect = false;
            v_HistorialCobranzas.Name = "v_HistorialCobranzas";
            v_HistorialCobranzas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            v_HistorialCobranzas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            v_HistorialCobranzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_HistorialCobranzas.Size = new Size(802, 171);
            v_HistorialCobranzas.TabIndex = 4;
            v_HistorialCobranzas.RowPrePaint += v_HistorialCobranzas_RowPrePaint;
            // 
            // Col_FechaPagoH
            // 
            Col_FechaPagoH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_FechaPagoH.DataPropertyName = "FechaPago";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Col_FechaPagoH.DefaultCellStyle = dataGridViewCellStyle2;
            Col_FechaPagoH.Frozen = true;
            Col_FechaPagoH.HeaderText = "Fecha pago";
            Col_FechaPagoH.Name = "Col_FechaPagoH";
            Col_FechaPagoH.ReadOnly = true;
            Col_FechaPagoH.Width = 119;
            // 
            // Col_NumSocioH
            // 
            Col_NumSocioH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_NumSocioH.DataPropertyName = "NumSocio";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Col_NumSocioH.DefaultCellStyle = dataGridViewCellStyle3;
            Col_NumSocioH.Frozen = true;
            Col_NumSocioH.HeaderText = "Nº Socio";
            Col_NumSocioH.Name = "Col_NumSocioH";
            Col_NumSocioH.ReadOnly = true;
            Col_NumSocioH.Width = 99;
            // 
            // Col_NombreH
            // 
            Col_NombreH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_NombreH.DataPropertyName = "NombreCompleto";
            Col_NombreH.HeaderText = "Nombre";
            Col_NombreH.Name = "Col_NombreH";
            Col_NombreH.ReadOnly = true;
            // 
            // Col_CategoriaH
            // 
            Col_CategoriaH.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Col_CategoriaH.DataPropertyName = "Categoria";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_CategoriaH.DefaultCellStyle = dataGridViewCellStyle4;
            Col_CategoriaH.HeaderText = "CAT.";
            Col_CategoriaH.Name = "Col_CategoriaH";
            Col_CategoriaH.ReadOnly = true;
            Col_CategoriaH.Width = 67;
            // 
            // Col_PeriodoH
            // 
            Col_PeriodoH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_PeriodoH.DataPropertyName = "DescripcionPeriodo";
            Col_PeriodoH.HeaderText = "Periodo";
            Col_PeriodoH.Name = "Col_PeriodoH";
            Col_PeriodoH.ReadOnly = true;
            Col_PeriodoH.Width = 92;
            // 
            // Col_ImporteH
            // 
            Col_ImporteH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_ImporteH.DataPropertyName = "Importe";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Col_ImporteH.DefaultCellStyle = dataGridViewCellStyle5;
            Col_ImporteH.HeaderText = "Importe";
            Col_ImporteH.Name = "Col_ImporteH";
            Col_ImporteH.ReadOnly = true;
            // 
            // tb_Filtros
            // 
            tb_Filtros.AutoSize = true;
            tb_Filtros.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Filtros.ColumnCount = 2;
            tb_Filtros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Filtros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Filtros.Controls.Add(tb_FiltroDiasQuincena, 1, 0);
            tb_Filtros.Controls.Add(tb_FiltroAnioMes, 0, 0);
            tb_Filtros.Dock = DockStyle.Fill;
            tb_Filtros.Location = new Point(3, 3);
            tb_Filtros.Name = "tb_Filtros";
            tb_Filtros.RowCount = 1;
            tb_Filtros.RowStyles.Add(new RowStyle());
            tb_Filtros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tb_Filtros.Size = new Size(802, 76);
            tb_Filtros.TabIndex = 0;
            // 
            // tb_FiltroDiasQuincena
            // 
            tb_FiltroDiasQuincena.Anchor = AnchorStyles.Right;
            tb_FiltroDiasQuincena.AutoSize = true;
            tb_FiltroDiasQuincena.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_FiltroDiasQuincena.ColumnCount = 1;
            tb_FiltroDiasQuincena.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDiasQuincena.Controls.Add(tb_Quincena, 0, 0);
            tb_FiltroDiasQuincena.Controls.Add(tb_FiltroDias, 0, 1);
            tb_FiltroDiasQuincena.Location = new Point(496, 1);
            tb_FiltroDiasQuincena.Margin = new Padding(0);
            tb_FiltroDiasQuincena.Name = "tb_FiltroDiasQuincena";
            tb_FiltroDiasQuincena.RowCount = 2;
            tb_FiltroDiasQuincena.RowStyles.Add(new RowStyle());
            tb_FiltroDiasQuincena.RowStyles.Add(new RowStyle());
            tb_FiltroDiasQuincena.Size = new Size(306, 74);
            tb_FiltroDiasQuincena.TabIndex = 1;
            // 
            // tb_Quincena
            // 
            tb_Quincena.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_Quincena.AutoSize = true;
            tb_Quincena.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Quincena.ColumnCount = 2;
            tb_Quincena.ColumnStyles.Add(new ColumnStyle());
            tb_Quincena.ColumnStyles.Add(new ColumnStyle());
            tb_Quincena.Controls.Add(lbl_Quincena, 0, 0);
            tb_Quincena.Controls.Add(cmb_Quincena, 1, 0);
            tb_Quincena.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Quincena.Location = new Point(102, 3);
            tb_Quincena.Name = "tb_Quincena";
            tb_Quincena.RowCount = 1;
            tb_Quincena.RowStyles.Add(new RowStyle());
            tb_Quincena.Size = new Size(201, 31);
            tb_Quincena.TabIndex = 0;
            // 
            // lbl_Quincena
            // 
            lbl_Quincena.Anchor = AnchorStyles.Left;
            lbl_Quincena.AutoSize = true;
            lbl_Quincena.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Quincena.Location = new Point(3, 7);
            lbl_Quincena.Name = "lbl_Quincena";
            lbl_Quincena.Size = new Size(68, 17);
            lbl_Quincena.TabIndex = 0;
            lbl_Quincena.Text = "Quincena:";
            // 
            // cmb_Quincena
            // 
            cmb_Quincena.Anchor = AnchorStyles.Left;
            cmb_Quincena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Quincena.FormattingEnabled = true;
            cmb_Quincena.Location = new Point(77, 3);
            cmb_Quincena.Name = "cmb_Quincena";
            cmb_Quincena.Size = new Size(121, 25);
            cmb_Quincena.TabIndex = 1;
            cmb_Quincena.SelectedIndexChanged += cmb_Quincena_SelectedIndexChanged;
            // 
            // tb_FiltroDias
            // 
            tb_FiltroDias.Anchor = AnchorStyles.Left;
            tb_FiltroDias.AutoSize = true;
            tb_FiltroDias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_FiltroDias.ColumnCount = 5;
            tb_FiltroDias.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDias.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDias.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDias.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDias.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroDias.Controls.Add(lbl_Desde, 1, 0);
            tb_FiltroDias.Controls.Add(lbl_Hasta, 3, 0);
            tb_FiltroDias.Controls.Add(txt_DDesde, 2, 0);
            tb_FiltroDias.Controls.Add(txt_DHasta, 4, 0);
            tb_FiltroDias.Controls.Add(chk_FiltrarDias, 0, 0);
            tb_FiltroDias.Location = new Point(3, 40);
            tb_FiltroDias.Name = "tb_FiltroDias";
            tb_FiltroDias.RowCount = 1;
            tb_FiltroDias.RowStyles.Add(new RowStyle());
            tb_FiltroDias.Size = new Size(300, 31);
            tb_FiltroDias.TabIndex = 1;
            // 
            // lbl_Desde
            // 
            lbl_Desde.Anchor = AnchorStyles.Left;
            lbl_Desde.AutoSize = true;
            lbl_Desde.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Desde.Location = new Point(119, 7);
            lbl_Desde.Name = "lbl_Desde";
            lbl_Desde.Size = new Size(48, 17);
            lbl_Desde.TabIndex = 1;
            lbl_Desde.Text = "Desde:";
            // 
            // lbl_Hasta
            // 
            lbl_Hasta.Anchor = AnchorStyles.Left;
            lbl_Hasta.AutoSize = true;
            lbl_Hasta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Hasta.Location = new Point(213, 7);
            lbl_Hasta.Name = "lbl_Hasta";
            lbl_Hasta.Size = new Size(44, 17);
            lbl_Hasta.TabIndex = 2;
            lbl_Hasta.Text = "Hasta:";
            // 
            // txt_DDesde
            // 
            txt_DDesde.Anchor = AnchorStyles.Left;
            txt_DDesde.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DDesde.Location = new Point(173, 3);
            txt_DDesde.Name = "txt_DDesde";
            txt_DDesde.Size = new Size(34, 25);
            txt_DDesde.TabIndex = 3;
            txt_DDesde.TextChanged += txt_DDesde_TextChanged;
            // 
            // txt_DHasta
            // 
            txt_DHasta.Anchor = AnchorStyles.Left;
            txt_DHasta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DHasta.Location = new Point(263, 3);
            txt_DHasta.Name = "txt_DHasta";
            txt_DHasta.Size = new Size(34, 25);
            txt_DHasta.TabIndex = 4;
            txt_DHasta.TextChanged += txt_DHasta_TextChanged;
            // 
            // chk_FiltrarDias
            // 
            chk_FiltrarDias.Anchor = AnchorStyles.Left;
            chk_FiltrarDias.AutoSize = true;
            chk_FiltrarDias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_FiltrarDias.Location = new Point(3, 6);
            chk_FiltrarDias.Margin = new Padding(3, 4, 3, 2);
            chk_FiltrarDias.Name = "chk_FiltrarDias";
            chk_FiltrarDias.Size = new Size(110, 21);
            chk_FiltrarDias.TabIndex = 0;
            chk_FiltrarDias.Text = "Filtrar por día:";
            chk_FiltrarDias.UseVisualStyleBackColor = true;
            chk_FiltrarDias.CheckedChanged += chk_FiltrarDias_CheckedChanged;
            // 
            // tb_FiltroAnioMes
            // 
            tb_FiltroAnioMes.Anchor = AnchorStyles.Left;
            tb_FiltroAnioMes.AutoSize = true;
            tb_FiltroAnioMes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_FiltroAnioMes.ColumnCount = 2;
            tb_FiltroAnioMes.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroAnioMes.ColumnStyles.Add(new ColumnStyle());
            tb_FiltroAnioMes.Controls.Add(chk_FiltrarAnio, 0, 0);
            tb_FiltroAnioMes.Controls.Add(chk_FiltrarMes, 0, 1);
            tb_FiltroAnioMes.Controls.Add(cmb_FMes, 1, 1);
            tb_FiltroAnioMes.Controls.Add(num_FAnio, 1, 0);
            tb_FiltroAnioMes.Location = new Point(3, 3);
            tb_FiltroAnioMes.Name = "tb_FiltroAnioMes";
            tb_FiltroAnioMes.RowCount = 2;
            tb_FiltroAnioMes.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tb_FiltroAnioMes.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tb_FiltroAnioMes.Size = new Size(249, 70);
            tb_FiltroAnioMes.TabIndex = 0;
            // 
            // chk_FiltrarAnio
            // 
            chk_FiltrarAnio.AutoSize = true;
            chk_FiltrarAnio.Dock = DockStyle.Fill;
            chk_FiltrarAnio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_FiltrarAnio.Location = new Point(3, 3);
            chk_FiltrarAnio.Name = "chk_FiltrarAnio";
            chk_FiltrarAnio.Size = new Size(116, 29);
            chk_FiltrarAnio.TabIndex = 0;
            chk_FiltrarAnio.Text = "Filtrar por año:";
            chk_FiltrarAnio.UseVisualStyleBackColor = true;
            chk_FiltrarAnio.CheckedChanged += chk_FiltrarAnio_CheckedChanged;
            // 
            // chk_FiltrarMes
            // 
            chk_FiltrarMes.AutoSize = true;
            chk_FiltrarMes.Dock = DockStyle.Fill;
            chk_FiltrarMes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_FiltrarMes.Location = new Point(3, 38);
            chk_FiltrarMes.Name = "chk_FiltrarMes";
            chk_FiltrarMes.Size = new Size(116, 29);
            chk_FiltrarMes.TabIndex = 1;
            chk_FiltrarMes.Text = "Filtrar por mes:";
            chk_FiltrarMes.UseVisualStyleBackColor = true;
            chk_FiltrarMes.CheckedChanged += chk_FiltrarMes_CheckedChanged;
            // 
            // cmb_FMes
            // 
            cmb_FMes.Anchor = AnchorStyles.Left;
            cmb_FMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FMes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_FMes.FormattingEnabled = true;
            cmb_FMes.Location = new Point(125, 40);
            cmb_FMes.Name = "cmb_FMes";
            cmb_FMes.Size = new Size(121, 25);
            cmb_FMes.TabIndex = 3;
            cmb_FMes.SelectedIndexChanged += cmb_FMes_SelectedIndexChanged;
            // 
            // num_FAnio
            // 
            num_FAnio.Anchor = AnchorStyles.Left;
            num_FAnio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_FAnio.Location = new Point(125, 5);
            num_FAnio.Name = "num_FAnio";
            num_FAnio.Size = new Size(120, 25);
            num_FAnio.TabIndex = 4;
            num_FAnio.ValueChanged += num_FAnio_ValueChanged;
            // 
            // tb_Total
            // 
            tb_Total.AutoSize = true;
            tb_Total.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Total.ColumnCount = 3;
            tb_Total.ColumnStyles.Add(new ColumnStyle());
            tb_Total.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Total.ColumnStyles.Add(new ColumnStyle());
            tb_Total.Controls.Add(lbl_Total, 1, 0);
            tb_Total.Controls.Add(txt_Total, 2, 0);
            tb_Total.Controls.Add(chk_OcultarAnuales, 0, 0);
            tb_Total.Dock = DockStyle.Fill;
            tb_Total.Location = new Point(3, 262);
            tb_Total.Name = "tb_Total";
            tb_Total.RowCount = 1;
            tb_Total.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Total.Size = new Size(802, 35);
            tb_Total.TabIndex = 3;
            // 
            // lbl_Total
            // 
            lbl_Total.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(544, 0);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(49, 35);
            lbl_Total.TabIndex = 0;
            lbl_Total.Text = "Total:";
            lbl_Total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Total
            // 
            txt_Total.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Total.BackColor = SystemColors.Control;
            txt_Total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Total.ForeColor = SystemColors.HotTrack;
            txt_Total.Location = new Point(602, 3);
            txt_Total.Margin = new Padding(6, 3, 0, 3);
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new Size(200, 29);
            txt_Total.TabIndex = 1;
            txt_Total.TextAlign = HorizontalAlignment.Right;
            // 
            // chk_OcultarAnuales
            // 
            chk_OcultarAnuales.AutoSize = true;
            chk_OcultarAnuales.Dock = DockStyle.Fill;
            chk_OcultarAnuales.Location = new Point(3, 3);
            chk_OcultarAnuales.Name = "chk_OcultarAnuales";
            chk_OcultarAnuales.Size = new Size(108, 29);
            chk_OcultarAnuales.TabIndex = 2;
            chk_OcultarAnuales.Text = "Ocultar anuales";
            chk_OcultarAnuales.UseVisualStyleBackColor = true;
            chk_OcultarAnuales.CheckedChanged += chk_OcultarAnuales_CheckedChanged;
            // 
            // TabHistorialCobranzas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_Layout);
            Name = "TabHistorialCobranzas";
            Size = new Size(808, 300);
            Load += TabHistorialCobranzas_Load;
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).EndInit();
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)v_HistorialCobranzas).EndInit();
            tb_Filtros.ResumeLayout(false);
            tb_Filtros.PerformLayout();
            tb_FiltroDiasQuincena.ResumeLayout(false);
            tb_FiltroDiasQuincena.PerformLayout();
            tb_Quincena.ResumeLayout(false);
            tb_Quincena.PerformLayout();
            tb_FiltroDias.ResumeLayout(false);
            tb_FiltroDias.PerformLayout();
            tb_FiltroAnioMes.ResumeLayout(false);
            tb_FiltroAnioMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_FAnio).EndInit();
            tb_Total.ResumeLayout(false);
            tb_Total.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider ep_AvisoError;
        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Filtros;
        private TableLayoutPanel tb_FiltroAnioMes;
        private CheckBox chk_FiltrarAnio;
        private CheckBox chk_FiltrarMes;
        private ComboBox cmb_FMes;
        private TableLayoutPanel tb_Total;
        private Label lbl_Total;
        private TextBox txt_Total;
        private DataGridView v_HistorialCobranzas;
        private TableLayoutPanel tb_FiltroDiasQuincena;
        private TableLayoutPanel tb_Quincena;
        private Label lbl_Quincena;
        private ComboBox cmb_Quincena;
        private TableLayoutPanel tb_FiltroDias;
        private CheckBox chk_FiltrarDias;
        private Label lbl_Desde;
        private Label lbl_Hasta;
        private TextBox txt_DDesde;
        private TextBox txt_DHasta;
        private NumericUpDown num_FAnio;
        private DataGridViewTextBoxColumn Col_FechaPagoH;
        private DataGridViewTextBoxColumn Col_NumSocioH;
        private DataGridViewTextBoxColumn Col_NombreH;
        private DataGridViewTextBoxColumn Col_CategoriaH;
        private DataGridViewTextBoxColumn Col_PeriodoH;
        private DataGridViewTextBoxColumn Col_ImporteH;
        private CheckBox chk_OcultarAnuales;
    }
}
