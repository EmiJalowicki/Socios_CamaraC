using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class Menu : Form
    {
        private TabSocios ucSocios;
        private TabHistorialCobranzas ucHistorial;
        private TabGestionarCobranzas ucCobranzas;
        private TabSociosMorosos ucMorosos;
        public Menu()
        {
            InitializeComponent();
            //[+] [+] [+] [+] [+] TAB_SOCIOS [+] [+] [+] [+] [+]
            ucSocios = new TabSocios();
            ucSocios.Dock = DockStyle.Fill;
            tab_Socios.Controls.Add(ucSocios);
            tbc_Menu.SelectedTab = tab_Socios;
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            //[+] [+] [+] [+] [+] TAB_HISTORIAL COBRANZAS [+] [+] [+] [+] [+]
            ucHistorial = new TabHistorialCobranzas();
            ucHistorial.Dock = DockStyle.Fill;
            tab_HistorialCobranzas.Controls.Add(ucHistorial);
            //[+] [+] [+] [+] [+] TAB_GESTIONAR COBRANZAS [+] [+] [+] [+] [+] 
            ucCobranzas = new TabGestionarCobranzas();
            ucCobranzas.Dock = DockStyle.Fill;
            tab_GestionarCobranzas.Controls.Add(ucCobranzas);
            //[+] [+] [+] [+] [+] TAB_INACTIVOS [+] [+] [+] [+] [+] 
            ucMorosos = new TabSociosMorosos();
            ucMorosos.Dock = DockStyle.Fill;
            tab_Morosos.Controls.Add(ucMorosos);

        }

        //Cambiar TAB
        private void tbc_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc_Menu.SelectedTab == tab_Socios)
            {
                ucSocios.ActualizarDatos(true);
            }
            if (tbc_Menu.SelectedTab == tab_HistorialCobranzas)
            {
                ucHistorial.ActualizarDatos();
            }
            if (tbc_Menu.SelectedTab == tab_GestionarCobranzas)
            {
                ucCobranzas.ActualizarDatos();
            }
            if (tbc_Menu.SelectedTab == tab_Morosos)
            {
                ucMorosos.ActualizarDatos();
            }
        }

    }
}
