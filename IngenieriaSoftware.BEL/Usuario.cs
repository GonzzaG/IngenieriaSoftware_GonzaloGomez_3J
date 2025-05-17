using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL
{
    [Verificable("user")]
    public class Usuario : Entity, IUsuario, IObserver, IVerificable
    {
        //public int Id { get; set; }
        public string Username { get; set; }

        public string _passwordHash;
        public DateTime FechaCreacion { get; set; }
        public List<Permiso> Permisos { get; set; } = new List<Permiso>();
        public int IdiomaId { get; set; }
        public int id_rol { get; set; }
        public string DVH { get; set; }
        public string Email { get; set; }

        public void Actualizar(Idioma i)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Username;
        }

        public bool VerificarIntegridad(string dvhBD)
        {
            return DVH == dvhBD;
        }

        public override string getNombreTabla()
        {
            return TablesName.Usuario;
        }
    }
}