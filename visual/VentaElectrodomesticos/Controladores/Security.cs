using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Exception;

namespace VentaElectrodomesticos.Controladores {
    class Security {

        public Usuario usuario {
            get; private set;
        }

        public Security(string user, string passwd) {
             usuario = Context.instance.dao.user.findUserWithPassword(
                user,
                sha256encrypt(passwd)
             );
             if (usuario == null) {
                 throw new WrongUserOrPasswordException();
             }
        }

        private static string sha256encrypt(string phrase) {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }

        private static string byteArrayToString(byte[] inputArray) {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++) {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    
    }
}
