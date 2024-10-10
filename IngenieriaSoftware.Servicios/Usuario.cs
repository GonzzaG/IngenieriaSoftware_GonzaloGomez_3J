using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class Usuario
    {

        public string Username { get; set; }
        private string _passwordHash;

        public string Password 
        {
            get => null; 
            set => _passwordHash =  HashingManager.GenerarHash(value);
        }

        public bool VerifyPassword(string password)
        {
            return HashingManager.VerificarHash(password, _passwordHash); // Verificar usando HashingManager
        }

    }
}
