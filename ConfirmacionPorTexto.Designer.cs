namespace Socios_CamaraC
{
    partial class ConfirmacionPorTexto
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
            lbl_Aviso = new Label();
            tb_Layout = new TableLayoutPanel();
            tb_Confirmacion = new TableLayoutPanel();
            lbl_Input = new Label();
            txt_Input = new TextBox();
            tb_Botones = new TableLayoutPanel();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            tb_Layout.SuspendLayout();
            tb_Confirmacion.SuspendLayout();
            tb_Botones.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Aviso
            // 
            lbl_Aviso.AutoSize = true;
            lbl_Aviso.Dock = DockStyle.Fill;
            lbl_Aviso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Aviso.Location = new Point(3, 0);
            lbl_Aviso.Name = "lbl_Aviso";
            lbl_Aviso.Size = new Size(300, 53);
            lbl_Aviso.TabIndex = 0;
            lbl_Aviso.Text = "[Aviso]";
            lbl_Aviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_Layout
            // 
            tb_Layout.ColumnCount = 1;
            tb_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tb_Layout.Controls.Add(lbl_Aviso, 0, 0);
            tb_Layout.Controls.Add(tb_Confirmacion, 0, 1);
            tb_Layout.Controls.Add(tb_Botones, 0, 2);
            tb_Layout.Dock = DockStyle.Fill;
            tb_Layout.Location = new Point(0, 0);
            tb_Layout.Name = "tb_Layout";
            tb_Layout.RowCount = 3;
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tb_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tb_Layout.RowStyles.Add(new RowStyle());
            tb_Layout.Size = new Size(306, 153);
            tb_Layout.TabIndex = 1;
            // 
            // tb_Confirmacion
            // 
            tb_Confirmacion.ColumnCount = 1;
            tb_Confirmacion.ColumnStyles.Add(new ColumnStyle());
            tb_Confirmacion.Controls.Add(lbl_Input, 0, 0);
            tb_Confirmacion.Controls.Add(txt_Input, 0, 1);
            tb_Confirmacion.Dock = DockStyle.Fill;
            tb_Confirmacion.Location = new Point(3, 56);
            tb_Confirmacion.Name = "tb_Confirmacion";
            tb_Confirmacion.RowCount = 2;
            tb_Confirmacion.RowStyles.Add(new RowStyle());
            tb_Confirmacion.RowStyles.Add(new RowStyle());
            tb_Confirmacion.Size = new Size(300, 48);
            tb_Confirmacion.TabIndex = 1;
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Dock = DockStyle.Fill;
            lbl_Input.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Input.Location = new Point(3, 0);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(326, 17);
            lbl_Input.TabIndex = 0;
            lbl_Input.Text = "Si desea continuar, ingrese [texto]";
            lbl_Input.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Input
            // 
            txt_Input.Dock = DockStyle.Fill;
            txt_Input.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Input.Location = new Point(3, 20);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(326, 27);
            txt_Input.TabIndex = 1;
            txt_Input.TextChanged += txt_Input_TextChanged;
            // 
            // tb_Botones
            // 
            tb_Botones.Anchor = AnchorStyles.None;
            tb_Botones.ColumnCount = 2;
            tb_Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tb_Botones.Controls.Add(btn_Aceptar, 0, 0);
            tb_Botones.Controls.Add(btn_Cancelar, 1, 0);
            tb_Botones.Location = new Point(9, 110);
            tb_Botones.Name = "tb_Botones";
            tb_Botones.RowCount = 1;
            tb_Botones.RowStyles.Add(new RowStyle());
            tb_Botones.Size = new Size(288, 39);
            tb_Botones.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.None;
            btn_Aceptar.AutoSize = true;
            btn_Aceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Aceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Aceptar.Location = new Point(36, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(71, 30);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.None;
            btn_Cancelar.AutoSize = true;
            btn_Cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(178, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(76, 30);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // ConfirmacionPorTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(306, 153);
            Controls.Add(tb_Layout);
            Name = "ConfirmacionPorTexto";
            Text = "Confirmar acción";
            tb_Layout.ResumeLayout(false);
            tb_Layout.PerformLayout();
            tb_Confirmacion.ResumeLayout(false);
            tb_Confirmacion.PerformLayout();
            tb_Botones.ResumeLayout(false);
            tb_Botones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Aviso;
        private TableLayoutPanel tb_Layout;
        private TableLayoutPanel tb_Confirmacion;
        private Label lbl_Input;
        private TextBox txt_Input;
        private TableLayoutPanel tb_Botones;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
    }
}