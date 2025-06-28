using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Proveedor
{
    public class Proveedor
    {
        public Proveedor() { }

        private Proveedor(string documento, string razonSocial, string correo, string telefono, bool estado)
        {
            Documento = documento;
            RazonSocial = razonSocial;
            Correo = correo;
            Telefono = telefono;
            Estado = estado;
        }
        private Proveedor(int proveedorId, string documento, string razonSocial, string correo, string telefono, bool estado)
        {
            IdProveedor = proveedorId;
            Documento = documento;
            RazonSocial = razonSocial;
            Correo = correo;
            Telefono = telefono;    
            Estado = estado;
        }

        public static Proveedor CrearNuevoProveedor(string documento, string razonSocial, string correo, string telefono, bool estado)
        {
            return new Proveedor(documento, razonSocial, correo, telefono, estado); 
        }

        public static Proveedor ActualizarProveedor(int proveedorId, string documento, string razonSocial, string correo, string telefono, bool estado)
        {
            return new Proveedor(proveedorId,documento, razonSocial, correo, telefono, estado);
        }

        public int IdProveedor { get; set; }
        public string Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }



    }
}
