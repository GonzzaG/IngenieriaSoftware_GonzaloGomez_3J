﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IngenieriaSoftware.UI
{
    public partial class MDI : Form
    {
        UsuarioBLL usuarioBLL;
        PermisoBLL permisoBLL;
        IdiomaBLL idiomaBLL;
        TraduccionBLL traduccionBLL;

        List<PermisoDTO> permisosUsuario;
        SessionManager _sessionManager;
        private readonly AuthService _authService = new AuthService();

        List<EtiquetaDTO> _etiquetas;

        private string idiomaActual;

        public MDI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioBLL = new UsuarioBLL();  
            permisoBLL = new PermisoBLL();
            idiomaBLL = new IdiomaBLL();
            _etiquetas = new List<EtiquetaDTO>();
            traduccionBLL = new TraduccionBLL();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            inicializarEtiquetas(this);
           // PruebaAsignarIdsAControles();
            Actualizar();
            
        }



        public void InicializarEtiquetas()
        {
            var etiquetas = ActualizarEtiquetas();
            //una vez obtenido las etiquetas, vamos a ir a bd a traer las etiquetas en base de datos
            new IdiomaBLL().AgregarEtiqueta(etiquetas);
        }



        public void PruebaAsignarIdsAControles(Control control)
        {

            



            _etiquetas = idiomaBLL.ObtenerTodasLasEtiquetasEnBD();
            ControlesHelper.AsignarEtiquetaIdsAControles(control, _etiquetas);
            //una vez que los controles en el formulario tienen id, ahora podemos traducirlas con las traducciones que tiene el dictionary en la dal
            idiomaActual = "Ingles";
            var traducciones = traduccionBLL.ObtenerTraducciones(idiomaActual);
            //ahora que tengo la lista de etiquetas y el dictinary con etiqueta_id, nombre, y la traducicon
            ControlesHelper.ActualizarControlesConTraducciones(control, traducciones, _etiquetas);

        }













        private void inicializarEtiquetas(Form formPadre)
        {
            // ControlesHelper.EstablecerTags(formPadre);

            var etiquetas = ActualizarEtiquetas();
            //una vez obtenido las etiquetas, vamos a ir a bd a traer las etiquetas en base de datos
            new IdiomaBLL().AgregarEtiqueta(etiquetas);
            var idiomaActual = CultureInfo.CurrentCulture.DisplayName.Split((' '))[0];
            idiomaActual = "Ingles";
            ObtenerTraduccionesPorIdioma(idiomaActual);    

        }
        private Dictionary<string, string> ObtenerTraduccionesPorIdioma(string idiomaNombre)
        {
           
            var traducciones = traduccionBLL.ObtenerTraducciones(idiomaNombre); // Llama a la DAL, que ejecuta el SP

           // ControlesHelper.CargarTraducciones(this, traducciones);

            return traducciones;
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            RegistrarUsuario formRegistrarUsuario = new RegistrarUsuario();
            AbrirFormHijo(formRegistrarUsuario);

           // formRegistrarUsuario.ShowDialog();
           //AbrirFormMenu();

        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPermisos formGestionPermisos = new GestionarPermisos();
            AbrirFormHijo(formGestionPermisos);

        }

        private void gestionIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();

            EliminarUsuario formEliminarUsuario = new EliminarUsuario();
            AbrirFormHijo(formEliminarUsuario);

        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CerrarFormulariosHijos();

                _authService.LogOut();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Metodos privados
        private void Actualizar()
        {
            InicioSesion FormInicio = new InicioSesion();
            PruebaAsignarIdsAControles(this);
            AbrirFormInicioSesion(FormInicio);
            PruebaAsignarIdsAControles(FormInicio);
            //ControlesHelper.EstablecerTags(FormInicio);
            FormInicio.MdiParent = null;
            if (FormInicio.ShowDialog(this) == DialogResult.OK)
            {
                // Si el inicio de sesion es correcto, se abre el formulario menu
                AbrirFormMenu();

            }
            else
            {
                this.Close();
            }
        }

        internal void AbrirFormMenu()
        {
         
            
           // var nombreUsuario = _sessionManager.Usuario.Username;
            var nombreUsuario =  SessionManager.UsuarioActual.Username;

            permisosUsuario = usuarioBLL.ObtenerPermisosDelUsuario(nombreUsuario);
            VerificarPermisosRoles(permisosUsuario);
            VerificarPermisosIndividuales(permisosUsuario);
        }

        private void AbrirFormInicioSesion(Form formHijo)
        {
            CerrarFormulariosHijos();

            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.StartPosition = FormStartPosition.CenterScreen;
            formHijo.Size = this.Size;
          //  formHijo.Show();

         //   ControlesHelper.AsignarEtiquetaIdsAControles(formHijo, _etiquetas);

            // CargarIdiomas(); // Llamar para traducir controles después de abrir
        }

        private void AbrirFormHijo(Form formHijo)
        {
            CerrarFormulariosHijos();

            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.StartPosition = FormStartPosition.CenterScreen;
            formHijo.Size = this.Size;
            formHijo.Show();

            ControlesHelper.AsignarEtiquetaIdsAControles(formHijo, _etiquetas);

           // CargarIdiomas(); // Llamar para traducir controles después de abrir
        }

        #region Traducciones
        private Dictionary<string, string> ObtenerTraduccionesDesdeBD(string idioma)
        {
            // Lógica para consultar la base de datos y obtener las traducciones
            // Esto debería retornar un Dictionary donde la clave es el Tag
            // y el valor es el texto traducido
            var traducciones = new Dictionary<string, string>
            {
                { "lblNombre", "Nombre" }, // Ejemplo de traducción
                { "btnAgregar", "Agregar" } // Ejemplo de traducción
                // Agrega más traducciones según sea necesario
            };
            return traducciones;
        }

        #endregion
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
            
            if(permisos.Count == 0)
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

        #endregion

        private void actualizarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que desea agregar todos los controles a la base de datos?", "Alerta de Agregacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No) return;
            else if (respuesta == DialogResult.Yes)
            {
                var etiquetas = ActualizarEtiquetas();
                //una vez obtenido las etiquetas, vamos a ir a bd a traer las etiquetas en base de datos
                new IdiomaBLL().AgregarEtiqueta(etiquetas);
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

        private List<EtiquetaDTO> ActualizarEtiquetas()
        {
            var formulariosHijos = FormHelper.InstanciarTodosLosFormularios(this);
            var etiquetas = idiomaBLL.ObtenerTodasLasEtiquetasEnBD();
          //  foreach (Form f in formulariosHijos)
           // {
           //     ControlesHelper.AsignarEtiquetaIdsAControles(this, todasLasEtiquetas);
           // }


            return etiquetas;
          
        }

        private void agregarTraduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIdioma formAgregarIdioma = new AgregarIdioma();
            AbrirFormHijo(formAgregarIdioma);
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
