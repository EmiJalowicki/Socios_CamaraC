namespace Socios_CamaraC
{
    partial class ModificarImporteForm
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
            lbl_Anio = new Label();
            lbl_Mes = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Importe = new Label();
            lbl_AnioCuota = new Label();
            lbl_MesCuota = new Label();
            txt_Importe = new TextBox();
            btn_Modificar = new Button();
            btn_Cancelar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Anio
            // 
            lbl_Anio.AutoSize = true;
            lbl_Anio.Location = new Point(3, 0);
            lbl_Anio.Name = "lbl_Anio";
            lbl_Anio.Size = new Size(32, 15);
            lbl_Anio.TabIndex = 0;
            lbl_Anio.Text = "Año:";
            // 
            // lbl_Mes
            // 
            lbl_Mes.AutoSize = true;
            lbl_Mes.Location = new Point(3, 15);
            lbl_Mes.Name = "lbl_Mes";
            lbl_Mes.Size = new Size(32, 15);
            lbl_Mes.TabIndex = 1;
            lbl_Mes.Text = "Mes:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lbl_Anio, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_Mes, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Importe, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_AnioCuota, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_MesCuota, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_Importe, 1, 2);
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(164, 59);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_Importe
            // 
            lbl_Importe.Anchor = AnchorStyles.Left;
            lbl_Importe.AutoSize = true;
            lbl_Importe.Location = new Point(3, 37);
            lbl_Importe.Name = "lbl_Importe";
            lbl_Importe.Size = new Size(52, 15);
            lbl_Importe.TabIndex = 2;
            lbl_Importe.Text = "Importe:";
            // 
            // lbl_AnioCuota
            // 
            lbl_AnioCuota.AutoSize = true;
            lbl_AnioCuota.Location = new Point(61, 0);
            lbl_AnioCuota.Name = "lbl_AnioCuota";
            lbl_AnioCuota.Size = new Size(37, 15);
            lbl_AnioCuota.TabIndex = 3;
            lbl_AnioCuota.Text = "[Año]";
            // 
            // lbl_MesCuota
            // 
            lbl_MesCuota.AutoSize = true;
            lbl_MesCuota.Location = new Point(61, 15);
            lbl_MesCuota.Name = "lbl_MesCuota";
            lbl_MesCuota.Size = new Size(37, 15);
            lbl_MesCuota.TabIndex = 4;
            lbl_MesCuota.Text = "[Mes]";
            // 
            // txt_Importe
            // 
            txt_Importe.Location = new Point(61, 33);
            txt_Importe.Name = "txt_Importe";
            txt_Importe.Size = new Size(100, 23);
            txt_Importe.TabIndex = 5;
            txt_Importe.KeyPress += txt_Importe_KeyPress_1;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(10, 72);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(75, 23);
            btn_Modificar.TabIndex = 3;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(99, 72);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 4;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // ModificarImporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 99);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Modificar);
            Controls.Add(tableLayoutPanel1);
            Name = "ModificarImporteForm";
            Text = "Importe";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Anio;
        private Label lbl_Mes;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_Importe;
        private Label lbl_AnioCuota;
        private Label lbl_MesCuota;
        private TextBox txt_Importe;
        private Button btn_Modificar;
        private Button btn_Cancelar;
    }
}