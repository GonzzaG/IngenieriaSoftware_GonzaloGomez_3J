﻿using System.Security.Cryptography;
using System.Text;

namespace IngenieriaSoftware.Servicios
{
    public class Encriptador
    {
        public static string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (var md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }

            return sBuilder.ToString();
        }
    }
}