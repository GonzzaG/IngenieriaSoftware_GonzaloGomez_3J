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
        public int Id {  get; set; }    
        public string Username { get; set; }
        private string _passwordHash;

        public string Password 
        {
            get => _passwordHash; 
            set => _passwordHash =  HashingManager.GenerarHash(value);
        }

        public void AsignarPassword(string password)
        {
            _passwordHash = password;
        }

        public bool VerifyPassword(string password)
        {
            return HashingManager.VerificarHash(password, _passwordHash); // Verificar usando HashingManager
        }

    }
}
