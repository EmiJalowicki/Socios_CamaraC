namespace Socios_CamaraC
{
    partial class EjecutarScriptSQL
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
            txtRuta = new TextBox();
            btn_Buscar = new Button();
            btn_Ejecutar = new Button();
            CancelarSQL_btn = new Button();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(10, 18);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(380, 23);
            txtRuta.TabIndex = 0;
            // 
            // BuscarSQL_btn
            // 
            btn_Buscar.Location = new Point(406, 18);
            btn_Buscar.Name = "BuscarSQL_btn";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 1;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // EjecutarSQL_btn
            // 
            btn_Ejecutar.Location = new Point(487, 18);
            btn_Ejecutar.Name = "EjecutarSQL_btn";
            btn_Ejecutar.Size = new Size(75, 23);
            btn_Ejecutar.TabIndex = 2;
            btn_Ejecutar.Text = "Ejecutar";
            btn_Ejecutar.UseVisualStyleBackColor = true;
            btn_Ejecutar.Click += btn_Ejecutar_SQL_Click;
            // 
            // CancelarSQL_btn
            // 
            CancelarSQL_btn.Location = new Point(568, 18);
            CancelarSQL_btn.Name = "CancelarSQL_btn";
            CancelarSQL_btn.Size = new Size(75, 23);
            CancelarSQL_btn.TabIndex = 3;
            CancelarSQL_btn.Text = "Cancelar";
            CancelarSQL_btn.UseVisualStyleBackColor = true;
            CancelarSQL_btn.Click += CancelarSQL_btn_Click;
            // 
            // EjecutarScriptSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 59);
            Controls.Add(CancelarSQL_btn);
            Controls.Add(btn_Ejecutar);
            Controls.Add(btn_Buscar);
            Controls.Add(txtRuta);
            Name = "EjecutarScriptSQL";
            Text = "EjecutarScriptSQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRuta;
        private Button btn_Buscar;
        private Button btn_Ejecutar;
        private Button CancelarSQL_btn;
    }
}