using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using IngenieriaSoftware.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormMDI : Form, IActualizable
    {
        internal UsuarioBLL usuarioBLL;
        internal PermisoBLL permisoBLL;
        internal IdiomaBLL idiomaBLL;
        internal ComandaBLL comandaBLL;
        internal TraduccionBLL traduccionBLL;
        private List<PermisoDTO> permisosUsuario;
        private SessionManager _sessionManager;
        private readonly AuthService _authService;
        private ITraduccionServicio ItraduccionServicio;

        private readonly ControlesHelper _controlesHelper;
        private readonly HelperExcepciones _helperExcepciones;
        private IdiomaSujeto _idiomaObserver;

        public NotificacionService _notificacionService => new NotificacionService();

        public event Action ActualizarFormsHijos;


        public FormMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioBLL = new UsuarioBLL();
            permisoBLL = new PermisoBLL();
            idiomaBLL = new IdiomaBLL();
            comandaBLL = new ComandaBLL();
            traduccionBLL = new TraduccionBLL();
            _authService = new AuthService();
            ItraduccionServicio = new TraduccionBLL();
            _idiomaObserver = new IdiomaSujeto(ItraduccionServicio);
            _controlesHelper = new ControlesHelper(_idiomaObserver);
            _helperExcepciones = new HelperExcepciones(_idiomaObserver);
            Inicializar();
            AbrirIniciarSesion();
        }

        private void Inicializar()
        {
            _controlesHelper.SuscribirControles(this);
            _helperExcepciones.SuscribirExcepciones();
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

            //comboBoxIdiomas.Text = IdiomaData.IdiomaActual.Nombre.ToString();
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
            //VerificarNotificaciones();
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
            comboBoxIdiomas.Text = IdiomaData.IdiomaActual.Nombre.ToString();

            //_controlesHelper.SuscribirControles(this);
            // Notificamos a los suscriptores del cambio de idioma
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

           // PermisosData.Permisos = AuthService.PermisosUsuario;
            var permisosUsuario = AuthService.PermisosUsuario;
            InicializarPermisosMenu();
            VerificarPermisosRoles(permisosUsuario);
            VerificarNotificaciones();

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
                
               // Actualizar();

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

            _controlesHelper.SuscribirControles(formInicio);

            // Notificamos a los suscriptores del cambio de idioma
            //_idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            formInicio.MdiParent = this;
            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.MaximizeBox = false;
            formInicio.Size = this.Size;
            formInicio.InicioSesionExitoso += AbrirFormMenu;
            formInicio.Show();
        }

        internal void AbrirFormHijo(Form formHijo)
        {
            //SuscribirControles(formHijo);
            _controlesHelper.SuscribirControles(formHijo);
            VerificarNotificaciones();
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
        private void MostrarNotificacion(string mensaje)
        {
            DialogResult result= MessageBox.Show(mensaje + " Quiere ir a la pantalla de comandas listas?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (result == DialogResult.Yes)
            {
                FormComandasAEntregar formComandasAEntregar = new FormComandasAEntregar();
                formComandasAEntregar.ShowDialog();
            }
            else
            {
                
            }
        }
        private Dictionary<string, ToolStripMenuItem[]> permisosRol;
        private Dictionary<string, ToolStripMenuItem> permisosIndividuales;
        public void InicializarPermisosMenu()
        {
            permisosRol = new Dictionary<string, ToolStripMenuItem[]>
            {
                { "PERM_ADMIN", new [] { gestionUsuariosToolStripMenuItem, gestionIdiomasToolStripMenuItem, cobrosToolStripMenuItem, gestionarMesasToolStripMenuItem, fToolStripMenuItem,
                    aBMMesasToolStripMenuItem , mesasToolStripMenuItem, comandasToolStripMenuItem, comandasAEntregarToolStripMenuItem, comandasCocinaToolStripMenuItem, registrarUsuarioToolStripMenuItem,
                    asignarPermisosToolStripMenuItem, eliminarUsuarioToolStripMenuItem, agregarTraduccionToolStripMenuItem, actualizarEtiquetasToolStripMenuItem, gestionarPermisosToolStripMenuItem} },
                { "PERM_CAJA", new [] { cobrosToolStripMenuItem, fToolStripMenuItem } },
                { "PERM_MESERO", new [] { mesasToolStripMenuItem, gestionarMesasToolStripMenuItem,  comandasToolStripMenuItem, comandasAEntregarToolStripMenuItem } },
                { "PERM_COCINA", new [] { comandasToolStripMenuItem, comandasCocinaToolStripMenuItem } }
            };

            permisosIndividuales = new Dictionary<string, ToolStripMenuItem>
            {
                { "PERM_GEST_MESAS", gestionarMesasToolStripMenuItem },
                { "PERM_ABM_MESAS", aBMMesasToolStripMenuItem },
                { "PERM_VER_FACTURAS", fToolStripMenuItem },
                { "PERM_COM_COCINA", comandasCocinaToolStripMenuItem },
                { "PERM_COM_ENTREGAR", comandasAEntregarToolStripMenuItem },
                { "PERM_REGIST_USUARIO", registrarUsuarioToolStripMenuItem },
                { "PERM_ELIM_USUARIO", eliminarUsuarioToolStripMenuItem },
                { "PERM_ACT_ETIQUETAS", actualizarEtiquetasToolStripMenuItem },
                { "PERM_AGR_TRADUCCION", agregarTraduccionToolStripMenuItem },
                { "PERM_GEST_PERMISOS", gestionarPermisosToolStripMenuItem },
                { "PERM_ASIGN_PERMISOS", asignarPermisosToolStripMenuItem }
                //{ "PERM_GEST_USUARIO", gestionUsuariosToolStripMenuItem },
            };
        }

        public void VerificarPermisosRoles(List<PermisoDTO> permisos)
        {
            List<string> permisosPermitidos = new List<string>();

            if (PermisoChecker.TienePermiso(permisos, "PERM_ADMIN"))
            {
                for (int i = menuStripMDI.Items.Count - 1; i >= 0; i--)
                {
                    var item = menuStripMDI.Items[i];
                    if (item is ToolStripMenuItem menuItem)
                    {
                        menuItem.Visible = false;
                        OcultarSubItems(menuItem);
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }

                foreach (var rol in permisosRol)
                {
                    foreach (var menuItem in rol.Value)
                    {
                        menuItem.Visible = true;
                    }
                }
            }
            else 
            {

                for (int i = menuStripMDI.Items.Count - 1; i >= 0; i--)
                {
                    var item = menuStripMDI.Items[i];
                    if (item is ToolStripMenuItem menuItem)
                    {
                        menuItem.Visible = false;
                        OcultarSubItems(menuItem);
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }
                foreach (var rol in permisosRol)
                {
                    if (PermisoChecker.TienePermiso(permisos, rol.Key))
                    {
                        foreach (var menuItem in rol.Value)
                        {
                            menuItem.Visible = true;
                        }
                    }
                }

            } 
                foreach (var permiso in permisosIndividuales)
                {
                    if (PermisoChecker.TienePermiso(permisos, permiso.Key))
                    {

                        //si tiene padre habilitarlo
                        var parentItem = ObtenerPadre(permiso.Value);

                        // Si el permiso tiene un padre y no está habilitado, habilitarlo
                        if (parentItem != null && !parentItem.Visible)
                        {
                            parentItem.Visible = true;
                        }
                        permiso.Value.Visible = true;
                    }
                    else
                    {
                        permiso.Value.Visible = false;
                    }
                }
              
                //mostrarPermisosDelUsuario();
                LogOutgestionUsuariosToolStripMenuItem.Visible = true;
        }

        private void OcultarSubItems(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                subItem.Visible = false;
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    OcultarSubItems(subMenuItem);
                }
            }
        }

        private ToolStripMenuItem ObtenerPadre(ToolStripMenuItem item)
        {
            foreach (var control in this.Controls)
            {
                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripMenuItem parentItem in menuStrip.Items)
                    {
                        if (parentItem.DropDownItems.Contains(item))
                        {
                            return parentItem;
                        }
                        foreach (ToolStripMenuItem childItem in parentItem.DropDownItems)
                        {
                            if (childItem.DropDownItems.Contains(item))
                            {
                                return parentItem;
                            }
                        }
                    }
                }
                else if (control is ToolStripMenuItem parentItem)
                {
                    if (parentItem.DropDownItems.Contains(item))
                    {
                        return parentItem;
                    }
                    foreach (ToolStripMenuItem childItem in parentItem.DropDownItems)
                    {
                        if (childItem.DropDownItems.Contains(item))
                        {
                            return parentItem;
                        }
                    }
                }
            }

            return null;
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
            if (this.HasChildren)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }

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
            var formularios = HelperForms.InstanciarTodosLosFormularios(this);
            formularios.Add(this); 
            Dictionary<string, IIdiomaObservador> etiquetasEnMemoria = ControlesHelper.ListarControles(this).ToDictionary(p => p.Key, p => (IIdiomaObservador)p.Value);

            var etiquetasExcepciones = HelperExcepciones.ListarExcepciones();
            foreach(var etiquetaExcepcion in etiquetasExcepciones)
            {
                etiquetasEnMemoria[etiquetaExcepcion.Key] = etiquetaExcepcion.Value;
            }
            idiomaBLL.AgregarEtiqueta(etiquetasEnMemoria); 
            
        }

        private void RegistrarEtiquetasDeControles(Control control, List<EtiquetaDTO> etiquetasEnBD, List<EtiquetaDTO> etiquetasNuevas)
        {
            foreach (Control c in control.Controls)
            {
                if (!etiquetasEnBD.Any(e => e.Name == c.Name))
                {
                    var nuevaEtiqueta = new EtiquetaDTO { Tag = (int)c.Tag, Name = c.Name };
                    etiquetasNuevas.Add(nuevaEtiqueta);
                }
                if (c is MenuStrip menuStrip)
                {
                    foreach (ToolStripItem menuItem in menuStrip.Items)
                    {
                        RegistrarEtiquetasDeMenu(menuItem, etiquetasEnBD, etiquetasNuevas);
                    }
                }
                if (c.HasChildren)
                {
                    RegistrarEtiquetasDeControles(c, etiquetasEnBD, etiquetasNuevas);
                }
            }
        }

        private void RegistrarEtiquetasDeMenu(ToolStripItem menuItem, List<EtiquetaDTO> etiquetasEnBD, List<EtiquetaDTO> etiquetasNuevas)
        {
            if (!etiquetasEnBD.Any(e => e.Name == menuItem.Name))
            {
                var nuevaEtiqueta = new EtiquetaDTO { Name = menuItem.Name };
                etiquetasNuevas.Add(nuevaEtiqueta);
            }

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

        private void gestionarMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarMesas formGestionarMesas = new FormGestionarMesas();
            AbrirFormHijo(formGestionarMesas);
        }

        private void aBMMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormABMMesas formGestionarMesas = new FormABMMesas();
            AbrirFormHijo(formGestionarMesas);
        }

        private void comandasCocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aca es donde la cocina podra visualizar las comandas que esten en espera de preparacion, en preparacion
            // tambien es donde podran confirmarlas
            FormGestionarComandas formGestionarComandas = new FormGestionarComandas();
            AbrirFormHijo(formGestionarComandas);
        }

        private void comandasAEntregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComandasAEntregar formComandasAEntregar = new FormComandasAEntregar();
            AbrirFormHijo(formComandasAEntregar);
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.Permisos.Contains("PERM_ADMIN") ||
               PermisosData.Permisos.Contains("PERM_MESERO") || 
               PermisosData.Permisos.Contains("PERM_GEST_MESAS") || 
               PermisosData.Permisos.Contains("PERM_COM_ENTREGAR") )
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }

        private void verFacturasPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarFacturas formGestionarFacturas = new FormGestionarFacturas();
            AbrirFormHijo(formGestionarFacturas);
        }

        private void asignarPermisosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGestionarPermisos formGestionPermisos = new FormGestionarPermisos();
            AbrirFormHijo(formGestionPermisos);
        }
    }
}