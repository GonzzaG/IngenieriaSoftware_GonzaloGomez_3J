using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormMDI : Form
    {
        private UsuarioBLL usuarioBLL;
        private PermisoBLL permisoBLL;
        private IdiomaBLL idiomaBLL;
        private TraduccionBLL traduccionBLL;
        private List<PermisoDTO> permisosUsuario;
        private SessionManager _sessionManager;
        private readonly AuthService _authService;
        private ITraduccionServicio ItraduccionServicio;

        private IdiomaObserver idiomaObserver;

        public FormMDI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioBLL = new UsuarioBLL();
            permisoBLL = new PermisoBLL();
            idiomaBLL = new IdiomaBLL();
            traduccionBLL = new TraduccionBLL();
            _authService = new AuthService();

            Inicializar();
        }

        private void Inicializar()
        {
            ItraduccionServicio = new TraduccionBLL();
            //aca voy a tener que pasar como parametro el idimoaId
            idiomaObserver = new IdiomaObserver(idiomaInicialId: 1, ItraduccionServicio);
        }

        private void SuscribirControles(Form form)
        {
            var controlesForm = HelperForms.ListarControles(form);

            //  new IdiomaBLL().GuardarEtiquetas(controlesForm);

            foreach (var etiqueta in controlesForm)
            {
                var tag = etiqueta.Key;
                var suscriptor = etiqueta.Value;

                var suscriptorDTO = new IdiomaSuscriptorDTO
                {
                    Tag = tag,
                    Control = suscriptor.Control, // Asignar el control encontrado
                    MenuItem = suscriptor.MenuItem,
                    Name = suscriptor.Name
                };

                idiomaObserver.Suscribir(suscriptorDTO);
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            VolverAIniciarSesion();
        }

        internal void AbrirFormMenu()
        {
            this.menuStripMDI.Visible = true;
            SuscribirControles(this);

            var nombreUsuario = SessionManager.UsuarioActual.Username;
            permisosUsuario = usuarioBLL.ObtenerPermisosDelUsuario(nombreUsuario);
            VerificarPermisosRoles(permisosUsuario);
            VerificarPermisosIndividuales(permisosUsuario);
        }

        private void inicializarEtiquetas(Form formPadre)
        {
            var idiomaActual = CultureInfo.CurrentCulture.DisplayName.Split((' '))[0];
            idiomaActual = "Ingles";
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            AbrirFormHijo(formRegistrarUsuario);

            // formRegistrarUsuario.ShowDialog();
            //AbrirFormMenu();
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

                VolverAIniciarSesion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Metodos privados

        private void VolverAIniciarSesion()
        {
            this.menuStripMDI.Visible = false;

            FormInicioSesion formInicio = new FormInicioSesion(idiomaObserver);
            SuscribirControles(formInicio);
            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.MaximizeBox = false;
            formInicio.MdiParent = this;
            formInicio.Size = this.Size;
            formInicio.InicioSesionExitoso += AbrirFormMenu;
            formInicio.Show();
        }

        private void AbrirFormHijo(Form formHijo)
        {
            SuscribirControles(formHijo);

            CerrarFormulariosHijos();

            //var etiquetas = ControlesHelper.ObtenerEtiquetas(formHijo.Controls);

            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.MaximizeBox = false;
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
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
            Dictionary<string, IIdiomaSuscriptor> etiquetasEnMemoria = HelperForms.ListarControles(this).ToDictionary(p => p.Key, p => (IIdiomaSuscriptor)p.Value); 

            // Guardar etiquetas nuevas en la base de datos si hay alguna
            idiomaBLL.AgregarEtiqueta(etiquetasEnMemoria); 
            
        }

        private void RegistrarEtiquetasDeControles(Control control, List<EtiquetaDTO> etiquetasEnBD, List<EtiquetaDTO> etiquetasNuevas)
        {
            foreach (Control c in control.Controls)
            {
                // Verificar si ya existe una etiqueta con el nombre del control en la base de datos
                if (!etiquetasEnBD.Any(e => e.Nombre == c.Name))
                {
                    // Si no existe, crear una nueva etiqueta y agregarla a la lista de etiquetas nuevas
                    var nuevaEtiqueta = new EtiquetaDTO { Tag = (int)c.Tag, Nombre = c.Name };
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
            if (!etiquetasEnBD.Any(e => e.Nombre == menuItem.Name))
            {
                // Si no existe, crear una nueva etiqueta y agregarla a la lista de etiquetas nuevas
                var nuevaEtiqueta = new EtiquetaDTO { Nombre = menuItem.Name };
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
    }
}