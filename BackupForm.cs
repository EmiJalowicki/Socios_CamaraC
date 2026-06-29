using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Socios_CamaraC
{
    public partial class BackupForm : Form
    {
        public enum TablasBD
        {
            SOCIO,
            CUOTA,
            ANUAL,
            CUOTA_SOCIO,
            ANUAL_SOCIO,
        }
        private Dictionary<CheckBox, TablasBD> _mapaCheckBoxTabla;

        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            _mapaCheckBoxTabla = new Dictionary<CheckBox, TablasBD>
            {
                { chk_Socio, TablasBD.SOCIO },
                { chk_Cuota, TablasBD.CUOTA },
                { chk_Anual, TablasBD.ANUAL },
                { chk_CuotaSocio, TablasBD.CUOTA_SOCIO },
                { chk_AnualSocio, TablasBD.ANUAL_SOCIO },
            };

            chk_Socio.Tag = Estado_Socios;
            chk_Cuota.Tag = Estado_Cuota;
            chk_Anual.Tag = Estado_Anual;
            chk_CuotaSocio.Tag = Estado_CuotaSocio;
            chk_AnualSocio.Tag = Estado_AnualSocio;
        }
        private void LimpiarEstados()
        {
            foreach (var (chk, _) in _mapaCheckBoxTabla)
            {
                if (chk.Tag is Label lbl)
                {
                    lbl.Text = "";
                    lbl.ForeColor = SystemColors.ControlText;
                    lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                }
            }
        }

        //[*] [*] [*] BOTONES [*] [*] [*]
        private void btn_CrearRespaldo_Click(object sender, EventArgs e)
        {
            CopiarBaseDatos(false);

        }
        private void CopiarBaseDatos(bool completa)
        {
            if (completa)
            {
                chk_Socio.Checked = true;
                chk_Cuota.Checked = true;
                chk_Anual.Checked = true;
                chk_CuotaSocio.Checked = true;
                chk_AnualSocio.Checked = true;
            }
            bool huboFallos = false;
            bool algunaTablaSeleccionada = false;
            LimpiarEstados();
            btn_CrearRespaldo.Enabled = false;
            Cursor = Cursors.WaitCursor;
            bool crearRestablecer = CrearRestablecer();

            string carpetaBackup = Backup.CrearCarpetaBackup();
            try
            {

                foreach (var (chk, tabla) in _mapaCheckBoxTabla)
                {
                    if (chk.Checked)
                    {
                        algunaTablaSeleccionada = true;
                        bool completado;
                        try
                        {
                            Backup.ExportarTabla(tabla.ToString(), carpetaBackup);
                            completado = true;

                        }
                        catch (Exception ex)
                        {
                            completado = false;
                            huboFallos = true;
                            MessageBox.Show(
                                $"Error al respaldar {tabla}:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        CambiarEstado(chk, completado);
                    }
                }
                if (!algunaTablaSeleccionada)
                {
                    MessageBox.Show("Seleccione algún item!", "Ningún elemento seleccionado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!huboFallos)
                {
                    MessageBox.Show("Respaldo creado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"El respaldo finalizó con algunos errores." +
                        $"\nRevise los estados en pantalla.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                if (crearRestablecer)
                {
                    try
                    {
                        Backup.GenerarRestablecerSql(carpetaBackup);
                        MessageBox.Show("'Restablecer.sql' creado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                                $"Error al crear 'Restablecer.sql':\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }


                }
                Cursor = Cursors.Default;
                btn_CrearRespaldo.Enabled = true;
            }
        }
        private bool CrearRestablecer()
        {
            var respuesta = MessageBox.Show(
                $"¿Crear Restablecer.sql? " +
                $"(Archivo que recrea la base de datos automáticamente)",
                "Automatizar recuperación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return (respuesta == DialogResult.Yes);
        }

        private void btn_AbrirCarpeta_Click(object sender, EventArgs e)
        {
            Backup.AbrirCarpetaBackup();
        }

        private void btn_EjecutarSQL_Click(object sender, EventArgs e)
        {
            using var menuEjecutarSQL = new EjecutarScriptSQL();
            menuEjecutarSQL.ShowDialog();
        }
        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            //Confirmar
            var respuesta = ConfirmarRestauracion();
            if (respuesta == true)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    btn_Restaurar.Enabled = false;
                    Backup.BorrarDatosEnTablas();
                    Backup.EjecutarUltimoRestablecer();
                    MessageBox.Show(
                        "Base de datos restaurada exitosamente! " +
                        "\n El programa se reiniciará automáticamente", "Éxito al recuperar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al restaurar:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                    btn_Restaurar.Enabled = true;
                }
                
            }
            
        }
        private bool ConfirmarRestauracion()
        {
            var copiarBase = MessageBox.Show(
                $"ATENCIÓN: Para restaurar la base de datos es necesario BORRAR la actual." +
                $"\n¿Hacer copia de seguridad antes de continuar?",
                "Aviso: pérdida de datos",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (copiarBase == DialogResult.Cancel) return false;
            if (copiarBase == DialogResult.Yes)
            {
                try
                {
                    CopiarBaseDatos(true);
                }
                catch
                {
                    MessageBox.Show(
                        "No se pudo crear la copia. Restauración cancelada.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            return true;
        }

        //Visuales
        private void CambiarEstado(CheckBox chk, bool completado)
        {
            if (chk.Tag is Label lblEstado)
            {
                if (completado)
                {
                    lblEstado.Text = "Respaldado!";
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Font = new Font(lblEstado.Font, FontStyle.Bold);
                }
                else
                {
                    lblEstado.Text = "Error al respaldar";
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Font = new Font(lblEstado.Font, FontStyle.Regular);
                }

            }
        }

        
    }
}
