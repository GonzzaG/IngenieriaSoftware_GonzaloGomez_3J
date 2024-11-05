using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace IngenieriaSoftware.Servicios
{
    public class EncryptionManager
    {
        private static readonly string Key = Environment.GetEnvironmentVariable("ENCRYPTION_KEY");

        public static string Encriptar(string data)
        {
            // Algoritmo de encriptación AES
            using (Aes aesAlgoritmo = Aes.Create())
            {
                // Convierte la clave Key en un arreglo de bytes.
                // El algoritmo AES requiere que la clave sea un arreglo de bytes.
                aesAlgoritmo.Key = Encoding.UTF8.GetBytes(Key);

                //Crea un Vector de inicializacion.
                // El IV es un conjunto de bytes que se utiliza junto con la clave para proporcionar un nivel adicional de seguridad
                // La misma entrada encriptada dos veces no producira el mismo resultado
                aesAlgoritmo.GenerateIV();

                // Realizamos encriptacion, usando la clave y el vectro de inicializacoin
                ICryptoTransform encryptor = aesAlgoritmo.CreateEncryptor(aesAlgoritmo.Key, aesAlgoritmo.IV);

                // Almacenamos datos en la memoria en lugar de en un archivo
                using (var msEncrypt = new MemoryStream())
                {
                    // CryptoStream permite realizar operaciones de encriptación en el flujo de memoria.
                    // Este flujo se conecta al MemoryStream y utiliza el encryptor creado
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        //StreamWriter para escribir en el CryptoStream
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // texto original que se desea encriptar
                            swEncrypt.Write(data);
                        }
                    }
                    byte[] iv = aesAlgoritmo.IV;
                    byte[] encrypted = msEncrypt.ToArray();
                    return Convert.ToBase64String(iv.Concat(encrypted).ToArray());
                }
            }
        }

        public static string Desencriptar(string encryptedData)
        {
            byte[] CifradoCompleto = Convert.FromBase64String(encryptedData);
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                byte[] iv = CifradoCompleto.Take(aesAlg.BlockSize / 8).ToArray();
                byte[] cipherText = CifradoCompleto.Skip(aesAlg.BlockSize / 8).ToArray();
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}