namespace Socios_CamaraC
{
    public partial class SocioForm : Form
    {
        private enum ModoFormulario
        {
            Agregar,
            Modificar
        }

        private readonly ModoFormulario _modo;
        private readonly Socio? _socioOriginal;

        public SocioForm() //Agregar Socio
        {
            InitializeComponent();
            _modo = ModoFormulario.Agregar;
            Text = "Agregar socio";
            btn_Aceptar.Text = "Agregar"; //btn AGREGAR
            btn_Aceptar.Enabled = false; //Al principio -> AGREGAR (X)

            dtp_FechaAlta.Enabled = true;
            dtp_FechaAlta.Value = DateTime.Today;

            dtp_FechaNacimiento.Value = DateTime.Today.AddYears(-1);
            dtp_FechaNacimiento.Checked = false;

            CargarCMB();
            cmb_Sexo.SelectedItem = "M";
            cmb_Categoria.SelectedValue = 1;
            this.ActiveControl = txt_Apellido;

            ActualizarEstadobtn_Agregar();
        }
        public SocioForm(Socio socio) //Modificar Socio
        {
            InitializeComponent();

            _modo = ModoFormulario.Modificar;
            _socioOriginal = socio;

            Text = "Modificar socio";
            btn_Aceptar.Text = "Modificar"; //btn MODIFICAR
            this.ActiveControl = txt_NumSocio;

            CargarCMB();
            CargarSocioEnCampos(socio);
            ActualizarEstadobtn_Agregar();
        }
        private void CargarCMB()
        {
            cmb_Sexo.Items.Clear();
            cmb_Sexo.Items.Add("M");
            cmb_Sexo.Items.Add("F");

            var categorias = CategoriaRepository.Listar();

            cmb_Categoria.DataSource = categorias;
            cmb_Categoria.DisplayMember = "CategoriaCMB";
            cmb_Categoria.ValueMember = "IdCategoria";

        }

        // btn CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarSocioEnCampos(Socio socio)
        {
            txt_NumSocio.Text = socio.NumSocio.ToString();
            txt_NumSocio.Enabled = false;

            if (socio.FechaAlta.HasValue)
            {
                dtp_FechaAlta.Value = socio.FechaAlta.Value;
            }
            

            cmb_Categoria.SelectedValue = socio.CategoriaId;
            cmb_Categoria.Enabled = false;

            txt_Apellido.Text = socio.Apellido;
            txt_Nombre.Text = socio.Nombre;
            txt_DNI.Text = socio.DNI;
            cmb_Sexo.SelectedItem = socio.Sexo;
            if (socio.FechaNacimiento.HasValue)
            {
                dtp_FechaNacimiento.Value = socio.FechaNacimiento.Value;
                dtp_FechaNacimiento.Checked = true;
            }
            else
            {
                dtp_FechaNacimiento.Checked = false;
            }

            txt_NumTelefono.Text = socio.NumTelefono;
            txt_CalleNombre.Text = socio.CalleNombre;
            txt_CalleNum.Text = socio.CalleNum?.ToString();
            txt_Localidad.Text = socio.Localidad;
        }

        //btn AGREGAR
        //CREAR Socio: Todos los datos son válidos -> AGREGAR (V)
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Seguro por si falla el .enable
            if (!CamposValidados())
            {
                return;
            }

            try
            {
                if (_modo == ModoFormulario.Agregar)
                {
                    Socio socioNuevo = CrearSocioNuevo();
                    bool exito = SocioServicio.CrearSocio(socioNuevo);
                    if (exito)
                    {
                        MessageBox.Show(
                            $"Socio Nº{socioNuevo.NumSocio} agregado correctamente!",
                            "Nuevo Socio registrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                            );
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            $"El N°Socio ya está siendo usado. Ingrese uno diferente",
                            "Socio Duplicado", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_NumSocio.Focus();
                        txt_NumSocio.SelectAll();
                    }
                }
                else
                {
                    Socio socioModificado = CrearSocioModificado();
                    SocioRepository.Modificar(socioModificado);
                    MessageBox.Show("Socio Nº" + socioModificado.NumSocio + " editado correctamente!",
                    "Socio editado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo agregar socio: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Socio CrearSocioNuevo()
        {
            int numSocio = AsignarNumSocio(txt_NumSocio);
            int? calleNum = AsignarCalleNum(txt_CalleNum);

            var nuevoSocio = new Socio
            {
                NumSocio = numSocio,
                Apellido = txt_Apellido.Text.Trim(),
                Nombre = txt_Nombre.Text.Trim(),
                DNI = txt_DNI.Text.Trim(),
                Sexo = cmb_Sexo.SelectedItem as string ?? "M",
                FechaNacimiento = dtp_FechaNacimiento.Checked
                ? dtp_FechaNacimiento.Value :
                    (DateTime?)null,
                NumTelefono = txt_NumTelefono.Text.Trim(),
                CalleNombre = txt_CalleNombre.Text.Trim(),
                CalleNum = calleNum,
                Localidad = txt_Localidad.Text.Trim(),
                FechaAlta = dtp_FechaAlta.Value,
                CategoriaId = cmb_Categoria.SelectedValue is int cat
                    ? cat
                    : 1 // fallback seguro

            };
            return nuevoSocio;
        }
        private Socio CrearSocioModificado()
        {
            var socioModificado = new Socio
            {
                NumSocio = _socioOriginal!.NumSocio,
                Apellido = txt_Apellido.Text.Trim(),
                Nombre = txt_Nombre.Text.Trim(),
                DNI = txt_DNI.Text.Trim(),
                Sexo = cmb_Sexo.SelectedItem as string ?? "M",
                FechaNacimiento = dtp_FechaNacimiento.Checked
                    ? dtp_FechaNacimiento.Value
                    : (DateTime?)null,
                NumTelefono = txt_NumTelefono.Text.Trim(),
                CalleNombre = txt_CalleNombre.Text.Trim(),
                CalleNum = AsignarCalleNum(txt_CalleNum),
                Localidad = txt_Localidad.Text.Trim(),
                FechaAlta = dtp_FechaAlta.Value,
                CategoriaId = _socioOriginal!.CategoriaId,
                EstaActivo = _socioOriginal.EstaActivo
            };
            return socioModificado;
        }

        private void ActualizarEstadobtn_Agregar()
        {
            btn_Aceptar.Enabled = CamposValidados();
        }

        public bool CamposValidados()
        {//Cada campo de controles maneja el estado del error (errorProvider)
            bool ObligatoriosOK =
                CampoObligatorio(txt_Apellido) &&
                CampoObligatorio(txt_Nombre);
            if (!ObligatoriosOK)
            {
                return false;
            }

            ValidarNumSocio();
            ValidarDNI();
            ValidarFechaNacimiento();
            ValidarCalleNum();

            Control[] controles =
            {
                txt_NumSocio,
                txt_DNI,
                dtp_FechaNacimiento,
                txt_NumTelefono,//No hay errores posibles -> siempre true.
                txt_CalleNombre,//No hay errores posibles -> siempre true.
                txt_CalleNum
            };
            foreach (Control campo in controles)
            {
                if (!string.IsNullOrEmpty(ep_AvisoError.GetError(campo)))//si hay error, flag
                {
                    return false;
                }
            }
            return true;
        }

        //[*] [*] [*] VALIDACIÓN DE CAMPOS [*] [*] [*]
        // Check TextChanged -> Llamar a Validar...() -> Actualizar estado de AGREGAR

        //NumSocio
        private void txt_NumSocio_TextChanged(object sender, EventArgs e)
        {
            ValidarNumSocio();
            ActualizarEstadobtn_Agregar();
        }
        private void ValidarNumSocio()
        {
            if (ValidarDatos.EsVacio(txt_NumSocio.Text))//Vacio -> Pasa (No hay error)
            {
                ep_AvisoError.SetError(txt_NumSocio, "");
            }
            else if (!ValidarDatos.EsNumeroYValido(txt_NumSocio.Text))//NaN o Negativo -> Error
            {
                ep_AvisoError.SetError(
                    txt_NumSocio,
                 "Solo numeros enteros positivos! (o dejar en blanco para asignar automáticamente)"
                    );
            }
            else //Si se corrige, borra error
            {
                ep_AvisoError.SetError(txt_NumSocio, "");
            }
        }
        //Apellido
        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadobtn_Agregar();
        }

        //Nombre
        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadobtn_Agregar();
        }

        //DNI
        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            ValidarDNI();
            ActualizarEstadobtn_Agregar();
        }
        private void ValidarDNI() //Dni Opcional
        {
            if (ValidarDatos.EsVacio(txt_DNI.Text))
            {
                ep_AvisoError.SetError(txt_DNI, "");
            }
            else if (!ValidarDatos.EsNumeroYValido(txt_DNI.Text))
            {
                ep_AvisoError.SetError(txt_DNI, "Solo números!");
            }
            else
            {
                ep_AvisoError.SetError(txt_DNI, "");
            }

            if (!ValidarDatos.EsVacio(txt_DNI.Text) && !ValidarDatos.EsDNIValido(txt_DNI.Text))
            {
                ep_AvisoError.SetError(txt_DNI, "Nº Documento inválido! (8 caracteres necesarios)");
            }
            else
            {
                ep_AvisoError.SetError(txt_DNI, "");
            }
        }
        //FechaNacimiento
        private void dtp_FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechaNacimiento();
            ActualizarEstadobtn_Agregar();
        }
        private void ValidarFechaNacimiento()
        {
            // Si no está marcada → no hay error
            if (!dtp_FechaNacimiento.Checked)
            {
                ep_AvisoError.SetError(dtp_FechaNacimiento, "");
                return;
            }
            if (dtp_FechaNacimiento.Value == DateTime.MinValue)
            {
                ep_AvisoError.SetError(dtp_FechaNacimiento, "Fecha inválida");
                return;
            }

            DateTime fechaNac = dtp_FechaNacimiento.Value.Date;
            DateTime hoy = DateTime.Today;
            DateTime fechaAlta = dtp_FechaAlta.Value.Date;

            if (fechaNac >= hoy)
            {
                ep_AvisoError.SetError(dtp_FechaNacimiento, "Fecha inválida!");
            }
            else if (fechaNac >= fechaAlta)
            {
                ep_AvisoError.SetError(dtp_FechaNacimiento, "Debe ser anterior a la fecha de alta");
            }
            else
            {
                ep_AvisoError.SetError(dtp_FechaNacimiento, "");
            }
        }

        //NumTelefono [Todos son válidos]

        //CalleNombre [Todos son válidos]


        //CalleNum
        private void txt_CalleNum_TextChanged(object sender, EventArgs e)
        {
            ValidarCalleNum();
            ActualizarEstadobtn_Agregar();
        }
        private void ValidarCalleNum()
        {
            if (ValidarDatos.EsVacio(txt_CalleNum.Text))
            {
                ep_AvisoError.SetError(txt_CalleNum, "");
            }
            else if (!ValidarDatos.EsNumeroYValido(txt_CalleNum.Text))
            {
                ep_AvisoError.SetError(txt_CalleNum, "Solo numeros!");
            }
            else
            {
                ep_AvisoError.SetError(txt_CalleNum, "");
            }

            if (!ValidarDatos.EsVacio(txt_CalleNombre.Text) && (ValidarDatos.EsVacio(txt_CalleNum.Text)))
            {
                ep_AvisoError.SetError(txt_CalleNum, "Nº Calle requerido");
            }
            else
            {
                ep_AvisoError.SetError(txt_CalleNum, "");
            }
        }

        private bool CampoObligatorio(Control campo)
        {
            return (!ValidarDatos.EsVacio(campo.Text));
        }

        //AUX new Socio
        private static int AsignarNumSocio(Control numeroSocio)
        {
            int numAsignado;
            if (ValidarDatos.EsVacio(numeroSocio.Text))
            {
                using var conn = ConexionBD.AbrirConexion();
                numAsignado = SocioRepository.ObtenerNumSocioSiguiente(conn);
            }
            else
            {
                numAsignado = int.Parse(numeroSocio.Text);
            }
            return numAsignado;
        }
        private static int? AsignarCalleNum(Control numeroCalle)
        {
            int? calleAsignada = null;
            if (!ValidarDatos.EsVacio(numeroCalle.Text))
            {
                calleAsignada = int.Parse(numeroCalle.Text);
            }
            return calleAsignada;
        }

        
    }
}