namespace Socios_CamaraC
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            ep_AvisoError = new ErrorProvider(components);
            tbc_Menu = new TabControl();
            tab_Socios = new TabPage();
            tab_HistorialCobranzas = new TabPage();
            tab_GestionarCobranzas = new TabPage();
            tab_Morosos = new TabPage();
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).BeginInit();
            tbc_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // ep_AvisoError
            // 
            ep_AvisoError.ContainerControl = this;
            // 
            // tbc_Menu
            // 
            tbc_Menu.Controls.Add(tab_Socios);
            tbc_Menu.Controls.Add(tab_HistorialCobranzas);
            tbc_Menu.Controls.Add(tab_GestionarCobranzas);
            tbc_Menu.Controls.Add(tab_Morosos);
            tbc_Menu.Dock = DockStyle.Fill;
            tbc_Menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbc_Menu.Location = new Point(0, 0);
            tbc_Menu.Name = "tbc_Menu";
            tbc_Menu.SelectedIndex = 0;
            tbc_Menu.Size = new Size(807, 334);
            tbc_Menu.TabIndex = 13;
            tbc_Menu.SelectedIndexChanged += tbc_Menu_SelectedIndexChanged;
            // 
            // tab_Socios
            // 
            tab_Socios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Socios.Location = new Point(4, 30);
            tab_Socios.Margin = new Padding(0);
            tab_Socios.Name = "tab_Socios";
            tab_Socios.Padding = new Padding(3);
            tab_Socios.Size = new Size(799, 300);
            tab_Socios.TabIndex = 5;
            tab_Socios.Text = "Socios";
            tab_Socios.UseVisualStyleBackColor = true;
            // 
            // tab_HistorialCobranzas
            // 
            tab_HistorialCobranzas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_HistorialCobranzas.Location = new Point(4, 30);
            tab_HistorialCobranzas.Name = "tab_HistorialCobranzas";
            tab_HistorialCobranzas.Size = new Size(976, 300);
            tab_HistorialCobranzas.TabIndex = 3;
            tab_HistorialCobranzas.Text = "Historial Cobranzas";
            tab_HistorialCobranzas.UseVisualStyleBackColor = true;
            // 
            // tab_GestionarCobranzas
            // 
            tab_GestionarCobranzas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_GestionarCobranzas.Location = new Point(4, 30);
            tab_GestionarCobranzas.Name = "tab_GestionarCobranzas";
            tab_GestionarCobranzas.Padding = new Padding(3);
            tab_GestionarCobranzas.Size = new Size(976, 300);
            tab_GestionarCobranzas.TabIndex = 2;
            tab_GestionarCobranzas.Text = "Gestionar Cobranzas";
            tab_GestionarCobranzas.UseVisualStyleBackColor = true;
            // 
            // tab_Morosos
            // 
            tab_Morosos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab_Morosos.Location = new Point(4, 30);
            tab_Morosos.Name = "tab_Morosos";
            tab_Morosos.Padding = new Padding(3);
            tab_Morosos.Size = new Size(976, 300);
            tab_Morosos.TabIndex = 4;
            tab_Morosos.Text = "Pendiente de pago";
            tab_Morosos.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 334);
            Controls.Add(tbc_Menu);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Menu";
            Text = "Socios - Camara de Comercio";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)ep_AvisoError).EndInit();
            tbc_Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider ep_AvisoError;
        private TabControl tbc_Menu;
        private TabPage tab_GestionarCobranzas;
        private TabPage tab_HistorialCobranzas;
        private TabPage tab_Morosos;
        private TabPage tab_Socios;
    }
}
