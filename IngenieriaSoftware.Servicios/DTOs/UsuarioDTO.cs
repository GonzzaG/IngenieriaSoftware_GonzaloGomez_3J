using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public class UsuarioDTO : IUsuario, IVerificable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string _passwordHash;
        public DateTime FechaCreacion { get; set; }
        public List<PermisoDTO> Permisos { get; set; } = new List<PermisoDTO>();
        public int IdiomaId { get; set; }
        public int id_rol { get; set; }
        public string DVH { get; set; }
        public string NombreTabla { get; set; }

        public bool VerificarIntegridad(string dvhBD)
        {
            return DVH == dvhBD;
        }

        public string getNombreTabla()
        {
            return TablesName.Usuario;
        }
    }
}