using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Idioma : ISujeto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Dictionary<string, string> Traducciones { get; set; }

        // Lista de observadores (usuarios suscritos)
        private List<IObserver> observadores;

        public void Notificar()
        {
            foreach (var usuario in observadores)
            {
                usuario.Actualizar(this);  // Notifica a cada usuario del cambio
            }
        }

        void ISujeto.Agregar(IObserver usuario)
        {
            observadores.Add(usuario);
        }

        void ISujeto.Quitar(IObserver usuario)
        {
            observadores.Remove(usuario);
        }
        public void ActualizarTraduccion(string clave, string valor)
        {
            Traducciones[clave] = valor;
            Notificar();  // Notifica a los observadores después de actualizar
        }
    }
}
