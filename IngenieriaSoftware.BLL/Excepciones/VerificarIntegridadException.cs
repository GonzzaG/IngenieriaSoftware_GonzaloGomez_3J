using System;

namespace IngenieriaSoftware.BLL.Excepciones
{
    public class VerificarIntegridadException : Exception
    {
        public VerificarIntegridadException(string message, string nombreTabla) : base(message)
        {
            NombreTabla = nombreTabla;
        }

        public string NombreTabla
        {
            get; set;
        }
    }
}