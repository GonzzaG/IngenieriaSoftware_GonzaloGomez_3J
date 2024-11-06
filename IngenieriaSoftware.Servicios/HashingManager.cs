using System;
using System.Security.Cryptography;
using System.Text;

namespace IngenieriaSoftware.Servicios
{
    public class HashingManager
    {
        public static string GenerarHash(string pPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string GenerarPasswordHash(string password)
        {
            return HashingManager.GenerarHash(password);
        }

        public static bool VerificarHash(string pPassword, string pHashedPassword)
        {
            // string mHashDeEntrada = GenerarHash(pPassword);
            return StringComparer.OrdinalIgnoreCase.Compare(pPassword, pHashedPassword) == 0;
        }
    }
}