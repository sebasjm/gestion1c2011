using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Exception;

namespace VentaElectrodomesticos.Controladores {
    class SecurityMock : Security {
        public SecurityMock() : base() {
            //admin user
            loggedUser = Context.instance.dao.user.searchById(1);
        }
    }
    class Security {

        public Usuario loggedUser {
            get; protected set;
        }
        public Security() { }

        public Security(string user, string passwd) {
             loggedUser = Context.instance.dao.user.findUserWithPassword(
                user,
                sha256encrypt(passwd)
             );
             if (loggedUser == null) {
                 throw new WrongUserOrPasswordException();
             }
        }

        public string sha256encrypt(string phrase) {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }

        public string byteArrayToString(byte[] inputArray) {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++) {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    
    }
}
