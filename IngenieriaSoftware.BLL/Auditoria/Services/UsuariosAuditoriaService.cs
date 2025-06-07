using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.DAL.Auditoria;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public class UsuarioAuditoriaService : IAuditoriaService<UsuarioAuditoriaModel>
    {
        private readonly IAuditoriaRepository<UsuarioAuditoriaModel> _repo;

        public UsuarioAuditoriaService()
        {
            _repo = new UsuarioAuditoriaRepository();
        }

        public void RegistrarCambio(UsuarioAuditoriaModel usuario)
        {
            if (usuario != null)
            {
                _repo.RegistrarCambio(usuario);
            }
        }

        public void RestaurarEstadoEntidad(int idEntidad, int version)
        {
            using(var transaction = new TransactionScope())
            {
                try
                {
                    _repo.RestaurarEstadoEntidad(idEntidad, version);

                    var usuario = new UsuarioBLL().ObtenerUsuarioPorId(idEntidad);

                    var usuarioAuditoria = UsuarioAuditoriaFactory.CrearParaRestore(usuario, SessionManager.GetInstance.Usuario.Username);

                    _repo.RegistrarCambio(usuarioAuditoria);

                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al restaurar el estado del usuario", ex);
                }
            }
           

        }

        public IEnumerable<UsuarioAuditoriaModel> GetAll() => _repo.GetAll();
        public UsuarioAuditoriaModel GetById(int id) => _repo.GetById(id);
    }
}
