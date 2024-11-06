using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormMDI : Form, IActualizable
    {
        internal UsuarioBLL usuarioBLL;
        internal PermisoBLL permisoBLL;
        internal IdiomaBLL idiomaBLL;
        internal TraduccionBLL traduccionBLL;
        private List<PermisoDTO> permisosUsuario;
        private SessionManager _sessionManager;
        private readonly AuthService _authService;
        private ITraduccionServicio ItraduccionServicio;

        private readonly ControlesHelper _controlesHelper;
        private IdiomaSujeto _idiomaObserver;

        public event Action ActualizarFormsHijos;


        public FormMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioBLL = new UsuarioBLL();
            permisoBLL = new PermisoBLL();
            idiomaBLL = new IdiomaBLL();
            traduccionBLL = new TraduccionBLL();
            _authService = new AuthService();
            ItraduccionServicio = new TraduccionBLL();
            _idiomaObserver = new IdiomaSujeto(ItraduccionServicio);
            _controlesHelper = new ControlesHelper(_idiomaObserver);

            Inicializar();
            AbrirIniciarSesion();
        }

        private void Inicializar()
        {
            _controlesHelper.SuscribirControles(this);
            //aca voy a tener que pasar como parametro el idimoaId
            IdiomaData.Idiomas = CargarIdiomas();
            ListarIdiomas(IdiomaData.Idiomas);

            // Obtenemos el idioma actual del sistema para el inicio, ya que aun no se inicio sesion
            var idiomaActual = CultureInfo.CurrentCulture.DisplayName.Split((' '))[0];
            IdiomaData.CambiarIdioma(idiomaActual);

            comboBoxIdiomas.Text = IdiomaData.IdiomaActual.Nombre.ToString();
        }

        #region Metodos de Interfaz

        public void Actualizar()
        {
            IdiomaData.Idiomas = CargarIdiomas();
            ListarIdiomas(IdiomaData.Idiomas);

            // Obtenemos el idioma actual del sistema para el inicio, ya que aun no se inicio sesion
            var idiomaActual = _sessionManager.Usuario.IdiomaId;
            IdiomaData.CambiarIdioma(idiomaActual);

        }
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMDI formPrincipal && this is IActualizable actualizableForm)
            {
                formPrincipal.ActualizarFormsHijos -= actualizableForm.Actualizar;
            }
            base.OnFormClosed(e);
        }

        private void MDI_Load(object sender, EventArgs e)
        {        

        }

        public List<IdiomaDTO> CargarIdiomas()
        {
            return new IdiomaBLL().ObtenerIdiomas();
        }

        public void ListarIdiomas(List<IdiomaDTO> idiomas)
        {
            comboBoxIdiomas.Items.Clear();
            foreach (IdiomaDTO idioma in idiomas)
            {
                comboBoxIdiomas.Items.Add(idioma.Nombre);
            }
        }

        internal void AbrirFormMenu()
        {
            this.menuStripMDI.Visible = true;
            //_controlesHelper.SuscribirControles(this);
            // Notificamos a los suscriptores del cambio de idioma
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            var nombreUsuario = SessionManager.UsuarioActual.Username;
            permisosUsuario = usuarioBLL.ObtenerPermisosDelUsuario(nombreUsuario);
            VerificarPermisosRoles(permisosUsuario);
            VerificarPermisosIndividuales(permisosUsuario);
        }

       

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            AbrirFormHijo(formRegistrarUsuario);
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarPermisos formGestionPermisos = new FormGestionarPermisos();
            AbrirFormHijo(formGestionPermisos);
        }

        private void gestionIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();

            FormEliminarUsuario formEliminarUsuario = new FormEliminarUsuario();
            AbrirFormHijo(formEliminarUsuario);
        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CerrarFormulariosHijos();

                _authService.LogOut();

                AbrirIniciarSesion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Metodos privados

        private void AbrirIniciarSesion()
        {
            this.menuStripMDI.Visible = false;

            FormInicioSesion formInicio = new FormInicioSesion(_idiomaObserver);
            //SuscribirControles(formInicio);
            _controlesHelper.SuscribirControles(formInicio);

            // Notificamos a los suscriptores del cambio de idioma
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            formInicio.MdiParent = this;
            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.MaximizeBox = false;
            formInicio.Size = this.Size;
            formInicio.InicioSesionExitoso += AbrirFormMenu;
            formInicio.Show();
        }

        private void AbrirFormHijo(Form formHijo)
        {
            //SuscribirControles(formHijo);
            _controlesHelper.SuscribirControles(formHijo);

            CerrarFormulariosHijos();
            // Notificamos a los suscriptores del cambio de idioma
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            // Lo suscribo al evento para que el formHijo se actualice si cambia el idioma
            if(formHijo is IActualizable formActualizable)
            {
                this.ActualizarFormsHijos += formActualizable.Actualizar;
            }
            
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.MaximizeBox = false;
            formHijo.StartPosition = FormStartPosition.CenterScreen;
            formHijo.Size = this.Size;
            formHijo.Show();
        }

        private void VerificarPermisosRoles(List<PermisoDTO> permisos)
        {
            List<string> permisosPermitidos = new List<string>();

            if (PermisoChecker.TienePermiso(permisos, "PERM_ADMIN"))
            {
                //permisosPermitidos.Add( "PERM_ADMIN");
                permisosPermitidos.Add("PERM_GEST_USUARIO");
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                //permisosPermitidos.Add( "PERM_MESERO");
                permisosPermitidos.Add("PERM_GEST_CAJA");
                permisosPermitidos.Add("PERM_GEST_MESAS");
                permisosPermitidos.Add("PERM_GEST_COBROS");

                gestionUsuariosToolStripMenuItem.Visible = true;
                gestionIdiomasToolStripMenuItem.Visible = true;
            }
            else //no es admin
            {
                gestionUsuariosToolStripMenuItem.Visible = false;
                gestionIdiomasToolStripMenuItem.Visible = false;

                if (PermisoChecker.TienePermiso(permisos, "PERM_CAJA"))
                {
                    permisosPermitidos.Add("PERM_GEST_COBROS");
                    cobrosToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Caja
                    cobrosToolStripMenuItem.Visible = false;
                }

                if (PermisoChecker.TienePermiso(permisos, "PERM_MESERO"))
                {
                    permisosPermitidos.Add("PERM_GEST_MESAS");
                    mesasToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Mesas
                    mesasToolStripMenuItem.Visible = false;
                }

                if (PermisoChecker.TienePermiso(permisos, "PERM_COCINA"))
                {
                    permisosPermitidos.Add("PERM_GEST_COMANDAS");
                    comandasToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Mesas
                    comandasToolStripMenuItem.Visible = false;
                }
            }

            if (permisos.Count == 0)
            {
                //Usuario no tiene permisos
            }

            mostrarPermisosDelUsuario(permisosPermitidos);
        }

        private void VerificarPermisosIndividuales(List<PermisoDTO> permisos)
        {
            List<string> permisosPermitidos = new List<string>();

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_USUARIO"))
            {
                permisosPermitidos.Add("PERM_GEST_USUARIO");

                gestionUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                gestionUsuariosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_PERMISOS"))
            {
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                gestionUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar permisos
                cobrosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_MESAS"))
            {
                permisosPermitidos.Add("PERM_GEST_MESAS");
                mesasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                mesasToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_COBROS"))
            {
                permisosPermitidos.Add("PERM_GEST_COBROS");
                cobrosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                cobrosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_COMANDAS"))
            {
                permisosPermitidos.Add("PERM_GEST_COMANDAS");

                comandasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                comandasToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_REGIST_USUARIO"))
            {
                permisosPermitidos.Add("PERM_REGIST_USUARIO");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                registrarUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                registrarUsuarioToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_ELIM_USUARIO"))
            {
                permisosPermitidos.Add("PERM_REGIST_USUARIO");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                eliminarUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                eliminarUsuarioToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_ASIGN_PERMISOS"))
            {
                permisosPermitidos.Add("PERM_ASIGN_PERMISOS");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                asignarPermisosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                asignarPermisosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_IDIOMAS"))
            {
                permisosPermitidos.Add("PERM_GEST_IDIOMAS");
                gestionIdiomasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                gestionIdiomasToolStripMenuItem.Visible = false;
            }

            mostrarPermisosDelUsuario(permisosPermitidos);
        }

        private void mostrarPermisosDelUsuario(List<string> permisos)
        {
            if (permisos.Count == 0)
            {
                MessageBox.Show("Usuario no tiene permisos");
                return;
            }

            string mensajeFinal = string.Join("\n", permisos);
            MessageBox.Show(mensajeFinal, "Lista de Permisos");
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion Metodos privados

        private void actualizarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que desea agregar todos los controles a la base de datos?", "Alerta de Agregacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No) return;
            else if (respuesta == DialogResult.Yes)
            {
                ActualizarEtiquetas();
            }
            // Este boton preguntara si esta seguro que desea continuar
            //este evento instanciara todos los formularios agregandolos a una List<Form>
            //se ejecutara el metodo d eControlesHelper que establece los tags a cada form
            //para luego traer de la bd todas las etiquetas
            // todas las etiquetas de bd se guardaran en otra lista
            //la lista de etiquetas en memoria recorrera la lista de etiquetas en bd, y si existe en la bd, se borrara de la lista de etiquetas en memoria
            // en el mismo foreach o en otro foreach, lo que se hara es ejecutar el stored procedure que agregue las etiquetas que hay en la lista en memoria y no en bd
            //esto agregara todas las etiquetas en memoria que no existen en bd
        }

        public void ActualizarEtiquetas()
        {
            // Instanciar todos los formularios
            var formularios = HelperForms.InstanciarTodosLosFormularios(this);

            //agregamos el formulario mdi
            formularios.Add(this); 
            
            // ListarControles devuelve un Dictionary<string, IdiomaSuscriptorDTO
            //Asi que, lo paso a un Dictionary<string, IIdiomaSusctriptor, para poder pasarlo como argumento en AgregarEtiqueta
            Dictionary<string, IIdiomaObservador> etiquetasEnMemoria = ControlesHelper.ListarControles(this).ToDictionary(p => p.Key, p => (IIdiomaObservador)p.Value); 

            // Guardar etiquetas nuevas en la base de datos si hay alguna
            idiomaBLL.AgregarEtiqueta(etiquetasEnMemoria); 
            
        }

        private void RegistrarEtiquetasDeControles(Control control, List<EtiquetaDTO> etiquetasEnBD, List<EtiquetaDTO> etiquetasNuevas)
        {
            foreach (Control c in control.Controls)
            {
                // Verificar si ya existe una etiqueta con el nombre del control en la base de datos
                if (!etiquetasEnBD.Any(e => e.Name == c.Name))
                {
                    // Si no existe, crear una nueva etiqueta y agregarla a la lista de etiquetas nuevas
                    var nuevaEtiqueta = new EtiquetaDTO { Tag = (int)c.Tag, Name = c.Name };
                    etiquetasNuevas.Add(nuevaEtiqueta);
                }

                // Si el control es un MenuStrip, registrar los elementos de menú
                if (c is MenuStrip menuStrip)
                {
                    foreach (ToolStripItem menuItem in menuStrip.Items)
                    {
                        RegistrarEtiquetasDeMenu(menuItem, etiquetasEnBD, etiquetasNuevas);
                    }
                }

                // Llamada recursiva para controles hijos
                if (c.HasChildren)
                {
                    RegistrarEtiquetasDeControles(c, etiquetasEnBD, etiquetasNuevas);
                }
            }
        }

        // Método auxiliar para registrar etiquetas de los elementos de menú
        private void RegistrarEtiquetasDeMenu(ToolStripItem menuItem, List<EtiquetaDTO> etiquetasEnBD, List<EtiquetaDTO> etiquetasNuevas)
        {
            // Verificar si ya existe una etiqueta con el nombre del elemento de menú en la base de datos
            if (!etiquetasEnBD.Any(e => e.Name == menuItem.Name))
            {
                // Si no existe, crear una nueva etiqueta y agregarla a la lista de etiquetas nuevas
                var nuevaEtiqueta = new EtiquetaDTO { Name = menuItem.Name };
                etiquetasNuevas.Add(nuevaEtiqueta);
            }

            // Si el elemento de menú es un ToolStripMenuItem, verificar si tiene subelementos
            if (menuItem is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.DropDownItems.Count > 0)
            {
                foreach (ToolStripItem subItem in toolStripMenuItem.DropDownItems)
                {
                    RegistrarEtiquetasDeMenu(subItem, etiquetasEnBD, etiquetasNuevas);
                }
            }
        }

        private void agregarTraduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIdioma formAgregarIdioma = new AgregarIdioma();
            AbrirFormHijo(formAgregarIdioma);
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxIdiomas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxIdiomas.SelectedItem == null) return;
            //Obtengo el idiomaId de la lista de idiomas, comparando el nombre del idioma con el del combo box, item seleccionado, y retorno el id
            var idiomaId = (IdiomaData.Idiomas.Find(I => I.Nombre == comboBoxIdiomas.SelectedItem.ToString())).Id;
           
            _idiomaObserver.CambiarEstado(idiomaId);

            
            ActualizarFormsHijos?.Invoke();
   
            
        }

    
    }
}