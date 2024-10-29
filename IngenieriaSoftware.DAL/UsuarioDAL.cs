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

            // Mapearemos los permisos LO OY A HACER EN PERMISODAL
            _permisoDAL.MapearPermisos(UsuariosPermisosDataSet);

            // Ahora establecemos la relacion usuarios_permisos
            RelacionarUsuariosPermisos(UsuariosPermisosDataSet);
            
            // Devolvemos solo los usuarios
            return _usuarioGlobales;

        }

        public void RelacionarUsuariosPermisos(DataSet pDs)
        {
             _permisoDAL.AsignarPermisosHijos(pDs);

            foreach (DataRow row in pDs.Tables[2].Rows)
            {
                int idUsuario = (int)row["id_usuario"];
                int idPermiso = (int)row["id_permiso"];


                Usuario usuario = _usuarioGlobales.FirstOrDefault(u => u.Id == idUsuario);
                Permiso permiso = _permisoDAL.ObtenerPermisoPorId(idPermiso);
                if (usuario != null && permiso != null)
                {
                    usuario.Permisos.Add(permiso);

                    permiso.Usuarios.Add(usuario);
                }
            }
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

            return _dao.ExecuteNonQuery("sp_GuardarUsuario", parametros);
        }
    }
}
