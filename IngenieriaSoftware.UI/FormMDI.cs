using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Auditoria;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Transactions;
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
        private readonly DigitoVerificadorManager _digitoVerificadorManager;

        public NotificacionService _notificacionService => new NotificacionService();

        public event Action ActualizarFormsHijos;

        public FormMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            _digitoVerificadorManager = new DigitoVerificadorManager();
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
            VerificarIntegridad();
        }


        /// <summary>
        /// Realizar la verificacion de digitos verificadores horizontales y verticales
        /// </summary>
        private void VerificarIntegridad()
        {
            try
            {
               //bool result = new DigitoVerificadorManager().ActualizarVerificadores(TablesName.Usuario);
                bool result = new DigitoVerificadorManager().VerificarDigitoVerticalYHorizontal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Integridad", SessionManager.GetInstance.Usuario.Username);
                this.Close();
            }
        }

        private void Inicializar()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        #endregion Metodos de Interfaz

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMDI formPrincipal && this is IActualizable actualizableForm)
            {
                formPrincipal.ActualizarFormsHijos -= actualizableForm.Actualizar;
            }
            base.OnFormClosed(e);
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

        public void ActualizarIdiomasCombo()
        {
            try
            {
                comboBoxIdiomas.Items.Clear();

                var idiomas = idiomaBLL.ObtenerIdiomas();

                if (idiomas != null)
                {
                    foreach (var idioma in idiomas)
                    {
                        comboBoxIdiomas.Items.Add(idioma.Nombre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los idiomas: " + ex.Message);
            }
        }

        internal void AbrirFormMenu()
        {
            this.menuStripMDI.Visible = true;
            comboBoxIdiomas.Text = IdiomaData.IdiomaActual.Nombre.ToString();
            this.WindowState = FormWindowState.Maximized;
            //_controlesHelper.SuscribirControles(this);
            // Notificamos a los suscriptores del cambio de idioma
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            // PermisosData.PermisosString = AuthService.PermisosUsuario;
            var permisosUsuario = AuthService.PermisosUsuario;

            //InicializarPermisosMenu();
            //VerificarPermisosRoles(permisosUsuario);

            ActualizarVisibilidadBotones();

            VerificarNotificaciones();
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario(_digitoVerificadorManager);
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
            FormEliminarUsuario formEliminarUsuario = new FormEliminarUsuario();
            AbrirFormHijo(formEliminarUsuario);
        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #region Metodos privados

        internal void AbrirIniciarSesion()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
            this.WindowState = FormWindowState.Normal;
            FormInicioSesion formInicio = new FormInicioSesion(_idiomaObserver);
            formInicio.MdiParent = this;
            this.menuStripMDI.Visible = false;

            _controlesHelper.SuscribirControles(formInicio);

            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.Dock = DockStyle.Fill;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.MaximizeBox = true;
            formInicio.Size = this.Size;
            formInicio.InicioSesionExitoso += AbrirFormMenu;
            //panel1.Visible = false;
            formInicio.Show();
        }

        internal void AbrirFormHijo(Form formHijo)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
            _controlesHelper.SuscribirControles(formHijo);
            VerificarNotificaciones();
            _idiomaObserver.CambiarEstado(IdiomaData.IdiomaActual.Id);

            if (formHijo is IActualizable formActualizable)
            {
                this.ActualizarFormsHijos += formActualizable.Actualizar;
            }

            formHijo.MdiParent = this;

            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.MaximizeBox = false;
            formHijo.StartPosition = FormStartPosition.CenterScreen;
            formHijo.Size = this.Size;
            formHijo.ControlBox = false;
            formHijo.AutoScroll = true;
            formHijo.Show();

            //panel1.Visible = false;
        }

        #endregion Metodos privados

        private void ActualizarVisibilidadBotones()
        {
            PermisosData.Permisos = permisoBLL.ObtenerPermisosUsuario(SessionManager.GetInstance.Usuario.Id);
            PermisosData.PermisosString = PermisosData.Permisos.Select(p => p.Nombre).ToList();
            List<int> permisosId = PermisosData.Permisos.Select(x => x.Id).ToList();

            var items = menuStripMDI.Items.Cast<ToolStripItem>().OfType<ToolStripMenuItem>().ToList();

            foreach (ToolStripMenuItem item in items)
            {
                EstablecerInvisibilidadRecursiva(item);
            }

            foreach (ToolStripMenuItem item in items)
            {
                ActualizarVisibilidadItem(item, permisosId);
            }
        }

        private void EstablecerInvisibilidadRecursiva(ToolStripMenuItem item)
        {
            item.Visible = false;

            var subItems = item.DropDownItems.OfType<ToolStripMenuItem>().ToList();
            foreach (ToolStripMenuItem subItem in subItems)
            {
                EstablecerInvisibilidadRecursiva(subItem);
            }
        }

        private void ActualizarVisibilidadItem(ToolStripMenuItem item, List<int> permisosId)
        {
            bool esVisible = false;

            if (item.Tag != null && int.TryParse(item.Tag.ToString(), out int etiquetaId))
            {
                esVisible = permisosId.Contains(etiquetaId);
            }

            var subItems = item.DropDownItems.OfType<ToolStripMenuItem>().ToList();
            foreach (ToolStripMenuItem subItem in subItems)
            {
                ActualizarVisibilidadItem(subItem, permisosId);
                if (subItem.Visible)
                {
                    esVisible = true;
                }
            }

            item.Visible = esVisible;
        }

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
            foreach (var etiquetaExcepcion in etiquetasExcepciones)
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
            if (PermisosData.PermisosString.Contains("Mesero"))
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

        private void generarFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerarFacturas formGenerarFacturas = new FormGenerarFacturas();
            AbrirFormHijo(formGenerarFacturas);
        }

        private void gestionPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionRoles formGestionRoles = new FormGestionRoles();
            AbrirFormHijo(formGestionRoles);
        }

        private void asignarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarRolAUsuario formAsignarRolAUsuario = new FormAsignarRolAUsuario();
            AbrirFormHijo(formAsignarRolAUsuario);
        }

        private void agregarIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarIdioma formGestionarIdioma = new FormGestionarIdioma();
            AbrirFormHijo(formGestionarIdioma);
        }

        private void FormMDI_Resize(object sender, EventArgs e)
        {
            //foreach (Form child in this.MdiChildren)
            //{
            //    child.WindowState = FormWindowState.Maximized;
            //}
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            BitacoraToolStripMenuItem.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormMDI_Activated(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                // HidePanel(); // Si hay formularios hijos, ocultar el panel
            }
            else
            {
                //ShowPanel(); // Si no hay formularios hijos, mostrar el panel
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBitacoraBusqueda form = new FormBitacoraBusqueda();
            this.AbrirFormHijo(form);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitacoraToolStripMenuItem.Visible = true;
        }

        private void BackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Actualizar();
                using (TransactionScope transac = new TransactionScope())
                {
                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Cerrar Sesion", DateTime.Now, "Cierre de sesion exitoso", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Sesion");
                    _authService.LogOut();
                    foreach (var hijo in this.MdiChildren)
                    {
                        hijo.Close();
                    }

                    AbrirIniciarSesion();
                    //this.WindowState = FormWindowState.Maximized;

                    transac.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Sesion", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormBitacoraBusqueda formBitacoraBusqueda = new FormBitacoraBusqueda();
                AbrirFormHijo(formBitacoraBusqueda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Bitacora", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void BackUpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormGestionarBackup formGestionarBackup = new FormGestionarBackup();
                AbrirFormHijo(formGestionarBackup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Backup", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void proponerCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormBusquedaAuditoria formAuditoria = new FormBusquedaAuditoria();
                AbrirFormHijo(formAuditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Auditoria", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void gestionarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestionarCambiosAuditoria formGestionarCambiosAuditoria = new FormGestionarCambiosAuditoria();
                AbrirFormHijo(formGestionarCambiosAuditoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Auditoria", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void AuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemGestionarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestionProveedores formGestionProveedores = new FormGestionProveedores();
                AbrirFormHijo(formGestionProveedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Gestionar Proveedores", SessionManager.GetInstance.Usuario.Username);
            }
        }

        //public void ShowPanel()
        //{
        //    panel1.Visible = true;
        //}
        //public void HidePanel()
        //{
        //    panel1.Visible = false;
        //}
    }
}