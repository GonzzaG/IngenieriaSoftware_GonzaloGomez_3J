using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL
{
    public class Usuario : IUsuario, IObserver
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string _passwordHash;
        public DateTime FechaCreacion { get; set; }
        public List<Permiso> Permisos { get; set; } = new List<Permiso>();
        public int IdiomaId { get; set; }

        public void Actualizar(Idioma i)
        {
            throw new NotImplementedException();
        }
    }
}