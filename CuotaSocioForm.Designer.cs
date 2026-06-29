namespace Socios_CamaraC
{
    partial class CuotaSocioForm
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
            lbl_NumSocio = new Label();
            lbl_NombreCompleto = new Label();
            v_cuotas = new DataGridView();
            Col_Anio = new DataGridViewTextBoxColumn();
            Col_Mes = new DataGridViewTextBoxColumn();
            Col_Importe = new DataGridViewTextBoxColumn();
            btn_Agregar = new Button();
            btn_Quitar = new Button();
            tb_DatosSocio = new TableLayoutPanel();
            lbl_Estado = new Label();
            lbl_EstadoCuota = new Label();
            lbl_CategoriaSocio = new Label();
            lbl_DNI = new Label();
            lbl_Categoria = new Label();
            lbl_NSocio = new Label();
            lbl_NombreSocio = new Label();
            lbl_DNISocio = new Label();
            lbl_FechaAltaSocio = new Label();
            lbl_FechaAlta = new Label();
            btn_Pagar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tb_Layout = new TableLayoutPanel();
            tb_Botonera = new TableLayoutPanel();
            tb_Glosario = new TableLayoutPanel();
            lbl_PagoFalta = new Label();
            lb_PagoMes = new Label();
            lbl_PagoAnual = new Label();
            ((System.ComponentModel.ISupportInitialize)v_cuotas).BeginInit();
            tb_DatosSocio.SuspendLayout();
            tb_Layout.SuspendLayout();
            tb_Botonera.SuspendLayout();
            tb_Glosario.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_NumSocio
            // 
            lbl_NumSocio.AutoSize = true;
            lbl_NumSocio.Location = new Point(69, 0);
            lbl_NumSocio.Name = "lbl_NumSocio";
            lbl_NumSocio.Size = new Size(26, 13);
            lbl_NumSocio.TabIndex = 2;
            lbl_NumSocio.Text = "[Nº]";
            // 
            // lbl_NombreCompleto
            // 
            lbl_NombreCompleto.AutoEllipsis = true;
            lbl_NombreCompleto.Dock = DockStyle.Fill;
            lbl_NombreCompleto.Location = new Point(69, 15);
            lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            lbl_NombreCompleto.Size = new Size(114, 15);
            lbl_NombreCompleto.TabIndex = 3;
            lbl_NombreCompleto.Text = "[Nombre]";
            // 
            // v_cuotas
            // 
            v_cuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            v_cuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            v_cuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            v_cuotas.Columns.AddRange(new DataGridViewColumn[] { Col_Anio, Col_Mes, Col_Importe });
            v_cuotas.Dock = DockStyle.Fill;
            v_cuotas.Location = new Point(3, 68);
            v_cuotas.MultiSelect = false;
            v_cuotas.Name = "v_cuotas";
            v_cuotas.ReadOnly = true;
            v_cuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            v_cuotas.Size = new Size(428, 132);
            v_cuotas.TabIndex = 7;
            v_cuotas.CellClick += v_cuotas_CellClick;
            v_cuotas.RowPrePaint += v_cuotas_RowPrePaint;
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
            Col_Importe.DataPropertyName = "Importe";
            Col_Importe.HeaderText = "Importe";
            Col_Importe.Name = "Col_Importe";
            Col_Importe.ReadOnly = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Left;
            btn_Agregar.Location = new Point(3, 14);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 8;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Quitar
            // 
            btn_Quitar.Anchor = AnchorStyles.Right;
            btn_Quitar.Location = new Point(84, 14);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(75, 23);
            btn_Quitar.TabIndex = 10;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.UseVisualStyleBackColor = true;
            btn_Quitar.Click += btn_Quitar_Click;
            // 
            // tb_DatosSocio
            // 
            tb_DatosSocio.Anchor = AnchorStyles.None;
            tb_DatosSocio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_DatosSocio.ColumnCount = 5;
            tb_DatosSocio.ColumnStyles.Add(new ColumnStyle());
            tb_DatosSocio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tb_DatosSocio.ColumnStyles.Add(new ColumnStyle());
            tb_DatosSocio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tb_DatosSocio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tb_DatosSocio.Controls.Add(lbl_Estado, 2, 2);
            tb_DatosSocio.Controls.Add(lbl_EstadoCuota, 3, 2);
            tb_DatosSocio.Controls.Add(lbl_CategoriaSocio, 1, 2);
            tb_DatosSocio.Controls.Add(lbl_DNI, 3, 0);
            tb_DatosSocio.Controls.Add(lbl_Categoria, 0, 2);
            tb_DatosSocio.Controls.Add(lbl_NSocio, 0, 0);
            tb_DatosSocio.Controls.Add(lbl_NumSocio, 1, 0);
            tb_DatosSocio.Controls.Add(lbl_NombreSocio, 0, 1);
            tb_DatosSocio.Controls.Add(lbl_NombreCompleto, 1, 1);
            tb_DatosSocio.Controls.Add(lbl_DNISocio, 2, 0);
            tb_DatosSocio.Controls.Add(lbl_FechaAltaSocio, 2, 1);
            tb_DatosSocio.Controls.Add(lbl_FechaAlta, 3, 1);
            tb_DatosSocio.Controls.Add(btn_Pagar, 4, 2);
            tb_DatosSocio.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_DatosSocio.Location = new Point(0, 0);
            tb_DatosSocio.Margin = new Padding(0);
            tb_DatosSocio.Name = "tb_DatosSocio";
            tb_DatosSocio.RowCount = 3;
            tb_DatosSocio.RowStyles.Add(new RowStyle());
            tb_DatosSocio.RowStyles.Add(new RowStyle());
            tb_DatosSocio.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tb_DatosSocio.Size = new Size(434, 65);
            tb_DatosSocio.TabIndex = 13;
            // 
            // lbl_Estado
            // 
            lbl_Estado.Anchor = AnchorStyles.Left;
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Estado.Location = new Point(189, 40);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(94, 15);
            lbl_Estado.TabIndex = 20;
            lbl_Estado.Text = "Estado de cuota:";
            // 
            // lbl_EstadoCuota
            // 
            lbl_EstadoCuota.Anchor = AnchorStyles.Left;
            lbl_EstadoCuota.AutoSize = true;
            lbl_EstadoCuota.Location = new Point(289, 41);
            lbl_EstadoCuota.Name = "lbl_EstadoCuota";
            lbl_EstadoCuota.Size = new Size(48, 13);
            lbl_EstadoCuota.TabIndex = 21;
            lbl_EstadoCuota.Text = "[Estado]";
            // 
            // lbl_CategoriaSocio
            // 
            lbl_CategoriaSocio.Anchor = AnchorStyles.Left;
            lbl_CategoriaSocio.AutoSize = true;
            lbl_CategoriaSocio.Location = new Point(69, 41);
            lbl_CategoriaSocio.Name = "lbl_CategoriaSocio";
            lbl_CategoriaSocio.Size = new Size(63, 13);
            lbl_CategoriaSocio.TabIndex = 23;
            lbl_CategoriaSocio.Text = "[Categoria]";
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(289, 0);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(32, 13);
            lbl_DNI.TabIndex = 18;
            lbl_DNI.Text = "[DNI]";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.Anchor = AnchorStyles.Left;
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Categoria.Location = new Point(3, 40);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(60, 15);
            lbl_Categoria.TabIndex = 22;
            lbl_Categoria.Text = "Categoría:";
            // 
            // lbl_NSocio
            // 
            lbl_NSocio.AutoSize = true;
            lbl_NSocio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NSocio.Location = new Point(3, 0);
            lbl_NSocio.Name = "lbl_NSocio";
            lbl_NSocio.Size = new Size(54, 15);
            lbl_NSocio.TabIndex = 14;
            lbl_NSocio.Text = "NºSocio:";
            // 
            // lbl_NombreSocio
            // 
            lbl_NombreSocio.AutoSize = true;
            lbl_NombreSocio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NombreSocio.Location = new Point(3, 15);
            lbl_NombreSocio.Name = "lbl_NombreSocio";
            lbl_NombreSocio.Size = new Size(54, 15);
            lbl_NombreSocio.TabIndex = 15;
            lbl_NombreSocio.Text = "Nombre:";
            // 
            // lbl_DNISocio
            // 
            lbl_DNISocio.AutoSize = true;
            lbl_DNISocio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DNISocio.Location = new Point(189, 0);
            lbl_DNISocio.Name = "lbl_DNISocio";
            lbl_DNISocio.Size = new Size(32, 15);
            lbl_DNISocio.TabIndex = 16;
            lbl_DNISocio.Text = "DNI:";
            // 
            // lbl_FechaAltaSocio
            // 
            lbl_FechaAltaSocio.AutoSize = true;
            lbl_FechaAltaSocio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FechaAltaSocio.Location = new Point(189, 15);
            lbl_FechaAltaSocio.Name = "lbl_FechaAltaSocio";
            lbl_FechaAltaSocio.Size = new Size(81, 15);
            lbl_FechaAltaSocio.TabIndex = 17;
            lbl_FechaAltaSocio.Text = "Fecha de Alta:";
            // 
            // lbl_FechaAlta
            // 
            lbl_FechaAlta.AutoSize = true;
            lbl_FechaAlta.Location = new Point(289, 15);
            lbl_FechaAlta.Name = "lbl_FechaAlta";
            lbl_FechaAlta.Size = new Size(63, 13);
            lbl_FechaAlta.TabIndex = 19;
            lbl_FechaAlta.Text = "[FechaAlta]";
            // 
            // btn_Pagar
            // 
            btn_Pagar.Anchor = AnchorStyles.None;
            btn_Pagar.AutoSize = true;
            btn_Pagar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Pagar.Location = new Point(374, 36);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new Size(46, 23);
            btn_Pagar.TabIndex = 24;
            btn_Pagar.Text = "Pagar";
            btn_Pagar.UseVisualStyleBackColor = true;
            btn_Pagar.Click += btn_Pagar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Location = new Point(191, 42);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(0, 0);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Location = new Point(10, 42);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(40, 0);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(tb_DatosSocio, 0, 0);
            tb_Layout.Controls.Add(v_cuotas, 0, 1);
            tb_Layout.Controls.Add(tb_Botonera, 0, 2);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 3;
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.Size = new Size(434, 260);
            tb_Layout.TabIndex = 25;
            // 
            // tb_Botonera
            // 
            tb_Botonera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tb_Botonera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Botonera.ColumnCount = 3;
            tb_Botonera.ColumnStyles.Add(new ColumnStyle());
            tb_Botonera.ColumnStyles.Add(new ColumnStyle());
            tb_Botonera.ColumnStyles.Add(new ColumnStyle());
            tb_Botonera.Controls.Add(btn_Agregar, 0, 0);
            tb_Botonera.Controls.Add(btn_Quitar, 1, 0);
            tb_Botonera.Controls.Add(tb_Glosario, 2, 0);
            tb_Botonera.Location = new Point(68, 206);
            tb_Botonera.Name = "tb_Botonera";
            tb_Botonera.RowCount = 1;
            tb_Botonera.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tb_Botonera.Size = new Size(297, 51);
            tb_Botonera.TabIndex = 14;
            // 
            // tb_Glosario
            // 
            tb_Glosario.AutoSize = true;
            tb_Glosario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tb_Glosario.ColumnCount = 1;
            tb_Glosario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Glosario.Controls.Add(lbl_PagoFalta, 0, 0);
            tb_Glosario.Controls.Add(lb_PagoMes, 0, 1);
            tb_Glosario.Controls.Add(lbl_PagoAnual, 0, 2);
            tb_Glosario.Location = new Point(165, 3);
            tb_Glosario.Name = "tb_Glosario";
            tb_Glosario.RowCount = 3;
            tb_Glosario.RowStyles.Add(new RowStyle());
            tb_Glosario.RowStyles.Add(new RowStyle());
            tb_Glosario.RowStyles.Add(new RowStyle());
            tb_Glosario.Size = new Size(136, 45);
            tb_Glosario.TabIndex = 11;
            // 
            // lbl_PagoFalta
            // 
            lbl_PagoFalta.AutoSize = true;
            lbl_PagoFalta.ForeColor = Color.Red;
            lbl_PagoFalta.Location = new Point(3, 0);
            lbl_PagoFalta.Name = "lbl_PagoFalta";
            lbl_PagoFalta.Size = new Size(70, 15);
            lbl_PagoFalta.TabIndex = 1;
            lbl_PagoFalta.Text = "*Falta pagar";
            // 
            // lb_PagoMes
            // 
            lb_PagoMes.AutoSize = true;
            lb_PagoMes.Location = new Point(3, 15);
            lb_PagoMes.Name = "lb_PagoMes";
            lb_PagoMes.Size = new Size(130, 15);
            lb_PagoMes.TabIndex = 0;
            lb_PagoMes.Text = "*Pago mensual manual";
            // 
            // lbl_PagoAnual
            // 
            lbl_PagoAnual.AutoSize = true;
            lbl_PagoAnual.ForeColor = Color.Green;
            lbl_PagoAnual.Location = new Point(3, 30);
            lbl_PagoAnual.Name = "lbl_PagoAnual";
            lbl_PagoAnual.Size = new Size(71, 15);
            lbl_PagoAnual.TabIndex = 2;
            lbl_PagoAnual.Text = "*Pago anual";
            // 
            // CuotaSocioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 260);
            Controls.Add(tb_Layout);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Name = "CuotaSocioForm";
            Text = "Cobranzas";
            Load += CuotaForm_Load;
            ((System.ComponentModel.ISupportInitialize)v_cuotas).EndInit();
            tb_DatosSocio.ResumeLayout(false);
            tb_DatosSocio.PerformLayout();
            tb_Layout.ResumeLayout(false);
            tb_Botonera.ResumeLayout(false);
            tb_Botonera.PerformLayout();
            tb_Glosario.ResumeLayout(false);
            tb_Glosario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_NumSocio;
        private Label lbl_NombreCompleto;
        private DataGridView v_cuotas;
        private Button btn_Agregar;
        private Button btn_Quitar;
        private TableLayoutPanel tb_DatosSocio;
        private Label lbl_NSocio;
        private Label lbl_NombreSocio;
        private DataGridViewTextBoxColumn Col_Anio;
        private DataGridViewTextBoxColumn Col_Mes;
        private DataGridViewTextBoxColumn Col_Importe;
        private Label lbl_DNISocio;
        private Label lbl_FechaAltaSocio;
        private Label lbl_DNI;
        private Label lbl_FechaAlta;
        private Label lbl_Categoria;
        private Label lbl_CategoriaSocio;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbl_Estado;
        private Label lbl_EstadoCuota;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_Pagar;
        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Botonera;
        private TableLayoutPanel tb_Glosario;
        private Label lb_PagoMes;
        private Label lbl_PagoFalta;
        private Label lbl_PagoAnual;
    }
}