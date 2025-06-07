using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public class AuditoriaService
    {
        private readonly Dictionary<Type, object> _repositorios;

        public AuditoriaService(
            IAuditoriaRepository<UsuarioAuditoriaModel> usuarioRepo
        )
        {
            _repositorios = new Dictionary<Type, object>
                {
                    { typeof(UsuarioAuditoriaModel), usuarioRepo },
                };
        }

        public void RegistrarCambio<T>(T entidad) where T : IAuditableModel
        {
             var tipo = typeof(T);

            if (_repositorios.TryGetValue(tipo, out var repoObj))
            {
                var repo = repoObj as IAuditoriaRepository<T>;

                if (repo != null)
                {
                    repo.RegistrarCambio(entidad);
                }
                else
                {
                    throw new InvalidOperationException($"El repositorio encontrado no es válido para el tipo {tipo.Name}.");
                }
            }
            else
            {
                throw new InvalidOperationException($"No hay repositorio registrado para el tipo {tipo.Name}.");
            }
        }
    }
}
