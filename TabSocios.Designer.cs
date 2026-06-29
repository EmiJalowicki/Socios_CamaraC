namespace Socios_CamaraC
{
    partial class TabSocios
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tb_Layout = new TableLayoutPanel();
            v_socios = new DataGridView();
            p_FiltroYBotonera = new Panel();
            tb_Botones = new TableLayoutPanel();
            btn_Agregar_Socio = new Button();
            btn_Modificar_Socio = new Button();
            btn_Quitar_Socio = new Button();
            tb_Buscador = new TableLayoutPanel();
            txt_Buscador = new TextBox();
            pb_Lupa = new PictureBox();
            p_BotoneraSocios = new Panel();
            btn_Respaldo = new Button();
            tb_BotoneraSocios = new TableLayoutPanel();
            btn_PagosAnuales = new Button();
            btn_CobranzaSocio = new Button();
            tb_ChkYEliminar = new TableLayoutPanel();
            btn_EliminarSocio = new Button();
            chk_MostrarInactivos = new CheckBox();
            vc_NumSocio = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            vc_Nombre = new DataGridViewTextBoxColumn();
            vc_Apellido = new DataGridViewTextBoxColumn();
            Col_Sexo = new DataGridViewTextBoxColumn();
            vc_Telefono = new DataGridViewTextBoxColumn();
            vc_DNI = new DataGridViewTextBoxColumn();
            Col_FechaNacimiento = new DataGridViewTextBoxColumn();
            vc_Direccion = new DataGridViewTextBoxColumn();
            Col_Localidad = new DataGridViewTextBoxColumn();
            Col_FechaAlta = new DataGridViewTextBoxColumn();
            tb_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)v_socios).BeginInit();
            p_FiltroYBotonera.SuspendLayout();
            tb_Botones.SuspendLayout();
            tb_Buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Lupa).BeginInit();
            p_BotoneraSocios.SuspendLayout();
            tb_BotoneraSocios.SuspendLayout();
            tb_ChkYEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(v_socios, 0, 1);
            tb_Layout.Controls.Add(p_FiltroYBotonera, 0, 0);
            tb_Layout.Controls.Add(p_BotoneraSocios, 0, 2);
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
            // v_socios
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_socios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_socios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_socios.Columns.AddRange(new DataGridViewColumn[] { vc_NumSocio, Col_Categoria, vc_Nombre, vc_Apellido, Col_Sexo, vc_Telefono, vc_DNI, Col_FechaNacimiento, vc_Direccion, Col_Localidad, Col_FechaAlta });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            v_socios.DefaultCellStyle = dataGridViewCellStyle10;
            v_socios.Dock = DockStyle.Fill;
            v_socios.Location = new Point(3, 53);
            v_socios.MultiSelect = false;
            v_socios.Name = "v_socios";
            v_socios.ReadOnly = true;
            v_socios.RowTemplate.Height = 32;
            v_socios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_socios.Size = new Size(802, 198);
            v_socios.TabIndex = 16;
            v_socios.SelectionChanged += v_socios_SelectionChanged;
            // 
            // p_FiltroYBotonera
            // 
            p_FiltroYBotonera.AutoSize = true;
            p_FiltroYBotonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            p_FiltroYBotonera.Controls.Add(tb_Botones);
            p_FiltroYBotonera.Controls.Add(tb_Buscador);
            p_FiltroYBotonera.Dock = DockStyle.Fill;
            p_FiltroYBotonera.Location = new Point(3, 3);
            p_FiltroYBotonera.Name = "p_FiltroYBotonera";
            p_FiltroYBotonera.Size = new Size(802, 44);
            p_FiltroYBotonera.TabIndex = 0;
            // 
            // tb_Botones
            // 
            tb_Botones.Anchor = AnchorStyles.Right;
            tb_Botones.AutoSize = true;
            tb_Botones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Botones.ColumnCount = 3;
            tb_Botones.ColumnStyles.Add(new ColumnStyle());
            tb_Botones.ColumnStyles.Add(new ColumnStyle());
            tb_Botones.ColumnStyles.Add(new ColumnStyle());
            tb_Botones.Controls.Add(btn_Agregar_Socio, 0, 0);
            tb_Botones.Controls.Add(btn_Modificar_Socio, 2, 0);
            tb_Botones.Controls.Add(btn_Quitar_Socio, 1, 0);
            tb_Botones.Location = new Point(476, 0);
            tb_Botones.Name = "tb_Botones";
            tb_Botones.RowCount = 1;
            tb_Botones.RowStyles.Add(new RowStyle());
            tb_Botones.Size = new Size(329, 41);
            tb_Botones.TabIndex = 22;
            // 
            // btn_Agregar_Socio
            // 
            btn_Agregar_Socio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Socio.Location = new Point(3, 3);
            btn_Agregar_Socio.Name = "btn_Agregar_Socio";
            btn_Agregar_Socio.Size = new Size(116, 35);
            btn_Agregar_Socio.TabIndex = 19;
            btn_Agregar_Socio.Text = "Agregar socio";
            btn_Agregar_Socio.UseVisualStyleBackColor = true;
            btn_Agregar_Socio.Click += btn_Agregar_Socio_Click;
            // 
            // btn_Modificar_Socio
            // 
            btn_Modificar_Socio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Modificar_Socio.Location = new Point(241, 3);
            btn_Modificar_Socio.Name = "btn_Modificar_Socio";
            btn_Modificar_Socio.Size = new Size(85, 35);
            btn_Modificar_Socio.TabIndex = 21;
            btn_Modificar_Socio.Text = "Modificar";
            btn_Modificar_Socio.UseVisualStyleBackColor = true;
            btn_Modificar_Socio.Click += btn_Modificar_Socio_Click;
            // 
            // btn_Quitar_Socio
            // 
            btn_Quitar_Socio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Quitar_Socio.Location = new Point(125, 3);
            btn_Quitar_Socio.Name = "btn_Quitar_Socio";
            btn_Quitar_Socio.Size = new Size(110, 35);
            btn_Quitar_Socio.TabIndex = 20;
            btn_Quitar_Socio.Text = "Dar de baja";
            btn_Quitar_Socio.UseVisualStyleBackColor = true;
            btn_Quitar_Socio.Click += btn_Quitar_Socio_Click;
            // 
            // tb_Buscador
            // 
            tb_Buscador.Anchor = AnchorStyles.Left;
            tb_Buscador.AutoSize = true;
            tb_Buscador.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Buscador.ColumnCount = 2;
            tb_Buscador.ColumnStyles.Add(new ColumnStyle());
            tb_Buscador.ColumnStyles.Add(new ColumnStyle());
            tb_Buscador.Controls.Add(txt_Buscador, 1, 0);
            tb_Buscador.Controls.Add(pb_Lupa, 0, 0);
            tb_Buscador.Location = new Point(0, 0);
            tb_Buscador.Name = "tb_Buscador";
            tb_Buscador.RowCount = 1;
            tb_Buscador.RowStyles.Add(new RowStyle());
            tb_Buscador.Size = new Size(391, 41);
            tb_Buscador.TabIndex = 0;
            // 
            // txt_Buscador
            // 
            txt_Buscador.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_Buscador.Location = new Point(45, 6);
            txt_Buscador.Margin = new Padding(5, 6, 5, 6);
            txt_Buscador.Name = "txt_Buscador";
            txt_Buscador.Size = new Size(341, 29);
            txt_Buscador.TabIndex = 11;
            txt_Buscador.TextChanged += txt_Buscador_TextChanged;
            // 
            // pb_Lupa
            // 
            pb_Lupa.BackColor = SystemColors.Control;
            pb_Lupa.Dock = DockStyle.Fill;
            pb_Lupa.Image = Properties.Resources.png_transparent_magnifying_glass_computer_icons_magnifying_glass_glass_desktop_wallpaper_circle;
            pb_Lupa.Location = new Point(3, 3);
            pb_Lupa.Name = "pb_Lupa";
            pb_Lupa.Size = new Size(34, 35);
            pb_Lupa.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Lupa.TabIndex = 10;
            pb_Lupa.TabStop = false;
            pb_Lupa.Click += pb_Lupa_Click;
            // 
            // p_BotoneraSocios
            // 
            p_BotoneraSocios.AutoSize = true;
            p_BotoneraSocios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            p_BotoneraSocios.Controls.Add(btn_Respaldo);
            p_BotoneraSocios.Controls.Add(tb_BotoneraSocios);
            p_BotoneraSocios.Controls.Add(tb_ChkYEliminar);
            p_BotoneraSocios.Dock = DockStyle.Fill;
            p_BotoneraSocios.Location = new Point(3, 257);
            p_BotoneraSocios.Name = "p_BotoneraSocios";
            p_BotoneraSocios.Size = new Size(802, 40);
            p_BotoneraSocios.TabIndex = 17;
            // 
            // btn_Respaldo
            // 
            btn_Respaldo.AutoSize = true;
            btn_Respaldo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Respaldo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Respaldo.ForeColor = Color.ForestGreen;
            btn_Respaldo.Location = new Point(273, 3);
            btn_Respaldo.Name = "btn_Respaldo";
            btn_Respaldo.Size = new Size(162, 31);
            btn_Respaldo.TabIndex = 29;
            btn_Respaldo.Text = "Copia de seguridad";
            btn_Respaldo.UseVisualStyleBackColor = true;
            btn_Respaldo.Click += btn_Respaldo_Click;
            // 
            // tb_BotoneraSocios
            // 
            tb_BotoneraSocios.Anchor = AnchorStyles.Right;
            tb_BotoneraSocios.AutoSize = true;
            tb_BotoneraSocios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_BotoneraSocios.ColumnCount = 2;
            tb_BotoneraSocios.ColumnStyles.Add(new ColumnStyle());
            tb_BotoneraSocios.ColumnStyles.Add(new ColumnStyle());
            tb_BotoneraSocios.Controls.Add(btn_PagosAnuales, 0, 0);
            tb_BotoneraSocios.Controls.Add(btn_CobranzaSocio, 1, 0);
            tb_BotoneraSocios.Location = new Point(536, 0);
            tb_BotoneraSocios.Name = "tb_BotoneraSocios";
            tb_BotoneraSocios.RowCount = 1;
            tb_BotoneraSocios.RowStyles.Add(new RowStyle());
            tb_BotoneraSocios.Size = new Size(270, 37);
            tb_BotoneraSocios.TabIndex = 28;
            // 
            // btn_PagosAnuales
            // 
            btn_PagosAnuales.AutoSize = true;
            btn_PagosAnuales.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PagosAnuales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PagosAnuales.Location = new Point(3, 3);
            btn_PagosAnuales.Name = "btn_PagosAnuales";
            btn_PagosAnuales.Size = new Size(118, 31);
            btn_PagosAnuales.TabIndex = 27;
            btn_PagosAnuales.Text = "Pagos anuales";
            btn_PagosAnuales.UseVisualStyleBackColor = true;
            btn_PagosAnuales.Click += btn_PagosAnuales_Click;
            // 
            // btn_CobranzaSocio
            // 
            btn_CobranzaSocio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_CobranzaSocio.AutoSize = true;
            btn_CobranzaSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_CobranzaSocio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CobranzaSocio.Location = new Point(127, 3);
            btn_CobranzaSocio.Name = "btn_CobranzaSocio";
            btn_CobranzaSocio.Size = new Size(140, 31);
            btn_CobranzaSocio.TabIndex = 24;
            btn_CobranzaSocio.Text = "Cobranzas Socio";
            btn_CobranzaSocio.UseVisualStyleBackColor = true;
            btn_CobranzaSocio.Click += btn_CobranzaSocio_Click;
            // 
            // tb_ChkYEliminar
            // 
            tb_ChkYEliminar.AutoSize = true;
            tb_ChkYEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_ChkYEliminar.ColumnCount = 2;
            tb_ChkYEliminar.ColumnStyles.Add(new ColumnStyle());
            tb_ChkYEliminar.ColumnStyles.Add(new ColumnStyle());
            tb_ChkYEliminar.Controls.Add(btn_EliminarSocio, 1, 0);
            tb_ChkYEliminar.Controls.Add(chk_MostrarInactivos, 0, 0);
            tb_ChkYEliminar.Location = new Point(0, 0);
            tb_ChkYEliminar.Name = "tb_ChkYEliminar";
            tb_ChkYEliminar.RowCount = 1;
            tb_ChkYEliminar.RowStyles.Add(new RowStyle());
            tb_ChkYEliminar.Size = new Size(270, 37);
            tb_ChkYEliminar.TabIndex = 26;
            // 
            // btn_EliminarSocio
            // 
            btn_EliminarSocio.Anchor = AnchorStyles.None;
            btn_EliminarSocio.AutoSize = true;
            btn_EliminarSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_EliminarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EliminarSocio.Location = new Point(150, 3);
            btn_EliminarSocio.Name = "btn_EliminarSocio";
            btn_EliminarSocio.Size = new Size(117, 31);
            btn_EliminarSocio.TabIndex = 23;
            btn_EliminarSocio.Text = "Eliminar socio";
            btn_EliminarSocio.UseVisualStyleBackColor = true;
            btn_EliminarSocio.Click += btn_EliminarSocio_Click;
            // 
            // chk_MostrarInactivos
            // 
            chk_MostrarInactivos.Anchor = AnchorStyles.Left;
            chk_MostrarInactivos.AutoSize = true;
            chk_MostrarInactivos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_MostrarInactivos.Location = new Point(3, 6);
            chk_MostrarInactivos.Name = "chk_MostrarInactivos";
            chk_MostrarInactivos.Size = new Size(141, 24);
            chk_MostrarInactivos.TabIndex = 17;
            chk_MostrarInactivos.Text = "Mostrar inactivos";
            chk_MostrarInactivos.UseVisualStyleBackColor = true;
            chk_MostrarInactivos.CheckedChanged += chk_MostrarInactivos_CheckedChanged;
            // 
            // vc_NumSocio
            // 
            vc_NumSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            vc_NumSocio.DataPropertyName = "NumSocio";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_NumSocio.DefaultCellStyle = dataGridViewCellStyle2;
            vc_NumSocio.Frozen = true;
            vc_NumSocio.HeaderText = "Nº Socio";
            vc_NumSocio.MinimumWidth = 50;
            vc_NumSocio.Name = "vc_NumSocio";
            vc_NumSocio.ReadOnly = true;
            vc_NumSocio.Resizable = DataGridViewTriState.True;
            vc_NumSocio.SortMode = DataGridViewColumnSortMode.Programmatic;
            vc_NumSocio.Width = 50;
            // 
            // Col_Categoria
            // 
            Col_Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Col_Categoria.DataPropertyName = "CategoriaId";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Col_Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            Col_Categoria.HeaderText = "CAT.";
            Col_Categoria.MinimumWidth = 50;
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.ReadOnly = true;
            Col_Categoria.Width = 50;
            // 
            // vc_Nombre
            // 
            vc_Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            vc_Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            vc_Nombre.HeaderText = "Nombre(s)";
            vc_Nombre.MinimumWidth = 100;
            vc_Nombre.Name = "vc_Nombre";
            vc_Nombre.ReadOnly = true;
            // 
            // vc_Apellido
            // 
            vc_Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            vc_Apellido.DataPropertyName = "Apellido";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            vc_Apellido.HeaderText = "Apellido(s)";
            vc_Apellido.MinimumWidth = 100;
            vc_Apellido.Name = "vc_Apellido";
            vc_Apellido.ReadOnly = true;
            // 
            // Col_Sexo
            // 
            Col_Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Sexo.DataPropertyName = "Sexo";
            Col_Sexo.HeaderText = "G";
            Col_Sexo.MinimumWidth = 40;
            Col_Sexo.Name = "Col_Sexo";
            Col_Sexo.ReadOnly = true;
            Col_Sexo.Width = 46;
            // 
            // vc_Telefono
            // 
            vc_Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            vc_Telefono.DataPropertyName = "NumTelefono";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_Telefono.DefaultCellStyle = dataGridViewCellStyle6;
            vc_Telefono.HeaderText = "Teléfono";
            vc_Telefono.MinimumWidth = 100;
            vc_Telefono.Name = "vc_Telefono";
            vc_Telefono.ReadOnly = true;
            // 
            // vc_DNI
            // 
            vc_DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            vc_DNI.DataPropertyName = "DNI";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_DNI.DefaultCellStyle = dataGridViewCellStyle7;
            vc_DNI.HeaderText = "DNI";
            vc_DNI.Name = "vc_DNI";
            vc_DNI.ReadOnly = true;
            vc_DNI.Width = 63;
            // 
            // Col_FechaNacimiento
            // 
            Col_FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Col_FechaNacimiento.DataPropertyName = "FechaNacimientoStr";
            Col_FechaNacimiento.HeaderText = "Fecha Nacimiento";
            Col_FechaNacimiento.MinimumWidth = 100;
            Col_FechaNacimiento.Name = "Col_FechaNacimiento";
            Col_FechaNacimiento.ReadOnly = true;
            // 
            // vc_Direccion
            // 
            vc_Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            vc_Direccion.DataPropertyName = "Direccion";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vc_Direccion.DefaultCellStyle = dataGridViewCellStyle8;
            vc_Direccion.HeaderText = "Direccion";
            vc_Direccion.Name = "vc_Direccion";
            vc_Direccion.ReadOnly = true;
            vc_Direccion.Width = 104;
            // 
            // Col_Localidad
            // 
            Col_Localidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Col_Localidad.DataPropertyName = "Localidad";
            Col_Localidad.HeaderText = "Localidad";
            Col_Localidad.Name = "Col_Localidad";
            Col_Localidad.ReadOnly = true;
            Col_Localidad.Width = 105;
            // 
            // Col_FechaAlta
            // 
            Col_FechaAlta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_FechaAlta.DataPropertyName = "FechaAltaStr";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            Col_FechaAlta.DefaultCellStyle = dataGridViewCellStyle9;
            Col_FechaAlta.HeaderText = "Fecha ingreso";
            Col_FechaAlta.MinimumWidth = 100;
            Col_FechaAlta.Name = "Col_FechaAlta";
            Col_FechaAlta.ReadOnly = true;
            Col_FechaAlta.Resizable = DataGridViewTriState.True;
            // 
            // TabSocios
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tb_Layout);
            Name = "TabSocios";
            Size = new Size(808, 300);
            Load += TabSocios_Load;
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)v_socios).EndInit();
            p_FiltroYBotonera.ResumeLayout(false);
            p_FiltroYBotonera.PerformLayout();
            tb_Botones.ResumeLayout(false);
            tb_Buscador.ResumeLayout(false);
            tb_Buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Lupa).EndInit();
            p_BotoneraSocios.ResumeLayout(false);
            p_BotoneraSocios.PerformLayout();
            tb_BotoneraSocios.ResumeLayout(false);
            tb_BotoneraSocios.PerformLayout();
            tb_ChkYEliminar.ResumeLayout(false);
            tb_ChkYEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tb_Layout;
        private Panel p_FiltroYBotonera;
        private TableLayoutPanel tb_Buscador;
        private PictureBox pb_Lupa;
        private TextBox txt_Buscador;
        private Button btn_Agregar_Socio;
        private Button btn_Quitar_Socio;
        private Button btn_Modificar_Socio;
        private DataGridView v_socios;
        private Panel p_BotoneraSocios;
        private CheckBox chk_MostrarInactivos;
        private Button btn_EliminarSocio;
        private Button btn_CobranzaSocio;
        private TableLayoutPanel tb_ChkYEliminar;
        private TableLayoutPanel tb_Botones;
        private Button btn_PagosAnuales;
        private TableLayoutPanel tb_BotoneraSocios;
        private Button btn_Respaldo;
        private DataGridViewTextBoxColumn vc_NumSocio;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn vc_Nombre;
        private DataGridViewTextBoxColumn vc_Apellido;
        private DataGridViewTextBoxColumn Col_Sexo;
        private DataGridViewTextBoxColumn vc_Telefono;
        private DataGridViewTextBoxColumn vc_DNI;
        private DataGridViewTextBoxColumn Col_FechaNacimiento;
        private DataGridViewTextBoxColumn vc_Direccion;
        private DataGridViewTextBoxColumn Col_Localidad;
        private DataGridViewTextBoxColumn Col_FechaAlta;
    }
}
