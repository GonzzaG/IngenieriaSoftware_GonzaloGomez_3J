using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace IngenieriaSoftware.DAL
{
    public class UsuarioDAL
    {
        private DAO _dao = new DAO();

        private List<Usuario> _usuarioGlobales = new List<Usuario>(); // Para almacenar todos los usuarios.
        private PermisoDAL _permisoDAL = new PermisoDAL();


        //dataset donde voy a almacenar usuarios, permisos, usuarios_permisos
        internal static DataSet UsuariosPermisosDataSet { get; set; } = new DataSet();

        static int mId;
        
        public UsuarioDAL()
        {

        }

        public List<Usuario> ObtenerUsuarios()
        {
            // Mapearemos los usuarios y retornamos la lista
            return new UsuarioMapper().MapearUsuariosDesdeDataSet(UsuariosPermisosDataSet);

        }

        public List<Usuario> UsuariosGlobales()
        {
            return _usuarioGlobales;
        }

        public List<Permiso> PermisosTree()
        {
            return _permisoDAL.PermisosTree();
        }
        public List<Permiso> PermisosGlobales()
        {
            return _permisoDAL.PermisosGlobales();
        }
        public List<Permiso> ObtenerPermisosDelUsuario(string pUsername)
        {
            Usuario usuario = _usuarioGlobales.Find(u => u.Username == pUsername);

            return usuario.Permisos;
        }

        private static int ProximoId()
        {
            if (mId == 0)
                mId = (new DAO()).ObtenerUltimoId("usuarios", "id_usuario");
            mId += 1;
            return mId;
        }

        // Método para obtener un usuario por su nombre
        public Usuario ObtenerUsuarioPorNombre(string pUsuarioNombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@UserName", pUsuarioNombre)
            };

            DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorNombre", parametros);
            Usuario usuario = (new UsuarioMapper().MapearUsuariosDesdeDataSet(mDs))[0];

            return usuario;

        }
        public List<Usuario> CargarUsuariosPermisos()
        {     
            // Obtendremos en la bd todos los usuarios, permisos, y relaciones entre ellos
             UsuariosPermisosDataSet= _dao.ExecuteStoredProcedure("sp_ObtenerPermisosTreeView", null);

            // Mapearemos los usuarios
            _usuarioGlobales = new UsuarioMapper().MapearUsuariosDesdeDataSet(UsuariosPermisosDataSet);

            // Mapearemos los permisos
            var permisosMapeados = _permisoDAL.MapearPermisos(UsuariosPermisosDataSet);

            _permisoDAL.AsignarPermisosHijos(UsuariosPermisosDataSet);

            // Ahora establecemos la relacion usuarios_permisos
            RelacionarUsuariosPermisos(UsuariosPermisosDataSet);
            
            // Devolvemos solo los usuarios
            return _usuarioGlobales;

        }

        public void RelacionarUsuariosPermisos(DataSet pDs)
        {
            foreach (DataRow row in pDs.Tables[2].Rows)
            {
                int idUsuario = (int)row["id_usuario"];
                int idPermiso = (int)row["id_permiso"];

                // Obtener el usuario correspondiente
                Usuario usuario = _usuarioGlobales.FirstOrDefault(u => u.Id == idUsuario);

                // Obtener el permiso correspondiente
                Permiso permiso = _permisoDAL.ObtenerPermisoPorId(idPermiso);

                if (usuario != null && permiso != null)
                {
                    // Verificar si el permiso y sus hijos ya están asignados al usuario
                    if (!TienePermiso(usuario, permiso))
                    {
                        // Agregar el permiso al usuario
                        usuario.Permisos.Add(permiso);
                        permiso.Usuarios.Add(usuario);
                    }
                }
            }
        }

        private bool TienePermiso(Usuario usuario, Permiso permiso)
        {
            // Verificar si el permiso está directamente en la lista de permisos del usuario
            if (usuario.Permisos.Contains(permiso))
            {
                return true;
            }

            // Buscar recursivamente en los permisos hijos de cada permiso del usuario
            foreach (var permisoAsignado in usuario.Permisos)
            {
                if (VerificarPermisoRecursivo(permisoAsignado, permiso))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso en la lista del usuario ni en sus hijos
        }

        // Método auxiliar recursivo para verificar permisos
        private bool VerificarPermisoRecursivo(Permiso permisoActual, Permiso permisoBuscado)
        {
            // Verificar si el permiso actual es el que estamos buscando
            if (permisoActual == permisoBuscado)
            {
                return true;
            }

            // Buscar en los permisos hijos del permiso actual
            foreach (var hijo in permisoActual.permisosHijos)
            {
                if (VerificarPermisoRecursivo(hijo, permisoBuscado))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso buscado en el permiso actual ni en sus hijos
        }

        public Permiso BuscarPermiso(int permisoBuscadoId, List<Permiso> permisos)
        {
            foreach(Permiso permiso in permisos)
            {
                var permisoEncontrado = permiso.permisosHijos.Find(p => p.Id == permisoBuscadoId);
                // Verificar si el permiso está directamente en la lista de permisos del usuario
                if (permisoEncontrado != null)
                {
                    return permisoEncontrado;
                }

                // Buscar recursivamente en los permisos hijos de cada permiso del usuario
                foreach (var permisoAsignado in permiso.permisosHijos)
                {
                    permisoEncontrado = VerificarPermisoRecursivo(permisoAsignado, permisoBuscadoId);
                    if (permisoEncontrado != null)
                    {
                        return permisoEncontrado;
                    }
                }
            
            }

            throw new Exception("Permiso no encontrado"); // Si no se encontró el permiso en la lista del usuario ni en sus hijos
        }
        // Método auxiliar recursivo para verificar permisos
        private Permiso VerificarPermisoRecursivo(Permiso permisoActual, int permisoBuscadoId)
        {
            var permisoEncontrado = permisoActual.permisosHijos.Find(p => p.Id == permisoBuscadoId);
            // Verificar si el permiso actual es el que estamos buscando
            if (permisoEncontrado != null)
            {
                return permisoEncontrado;
            }

            // Buscar en los permisos hijos del permiso actual
            foreach (var hijo in permisoActual.permisosHijos)
            {
                permisoEncontrado = VerificarPermisoRecursivo(hijo, permisoBuscadoId);
                if (permisoEncontrado != null)
                {
                    return permisoEncontrado;
                }
            }
            return null;
        }

        public int GuardarUsuario(Usuario pUsuario, DateTime FechaInicio)
        {
            pUsuario.Id = ProximoId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", pUsuario.Id),
                new SqlParameter("@Username", pUsuario.Username),
                new SqlParameter("@PasswordHash", pUsuario._passwordHash),
                new SqlParameter("@FechaCreacion", FechaInicio)
            };

            return _dao.ExecuteNonQuery("sp_GuardarUsuario",  parametros);
        }
    }
}
