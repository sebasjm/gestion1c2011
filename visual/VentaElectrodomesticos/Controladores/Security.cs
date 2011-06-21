using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Exception;

namespace VentaElectrodomesticos.Controladores {
    class Security {

        public static readonly byte FUNCIONALIDAD_ABM_EMPLEADO = 1;
        public static readonly byte FUNCIONALIDAD_ABM_ROL = 2;
        public static readonly byte FUNCIONALIDAD_ABM_USUARIO = 3;
        public static readonly byte FUNCIONALIDAD_ABM_CLIENTE = 4;
        public static readonly byte FUNCIONALIDAD_ABM_PRODUCTO = 5;
        public static readonly byte FUNCIONALIDAD_OPERACION_STOCK = 6;
        public static readonly byte FUNCIONALIDAD_OPERACION_FACTURACION = 7;
        public static readonly byte FUNCIONALIDAD_OPERACION_PAGOS = 8;
        public static readonly byte FUNCIONALIDAD_TABLERO_CONTROL = 9;
        public static readonly byte FUNCIONALIDAD_TABLERO_CATEGORIAS = 10;
        public static readonly byte FUNCIONALIDAD_TABLERO_CLIENTES = 11;

        public Usuario loggedUser {
            get; protected set;
        }
        public Security() { }

        List<byte> permissionList = null;

        public Security(string user, string passwd) {
            loggedUser = Context.instance.dao.user.findUserWithPassword(
               user,
               sha256encrypt(passwd)
            );
            if (loggedUser == null) {
                Context.instance.dao.user.failLogin(user);
                throw new WrongUserOrPasswordException();
            }
            Context.instance.dao.user.resetFailLogin(user);
            permissionList = Context.instance.dao.user.findPermissionList(loggedUser.id);
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

        public bool hasPermissionTo(byte p) {
            foreach(byte per in permissionList) {
                if (per == p) return true;
            }
            return false;
        }

        public bool esAnalista() {
            return loggedUser.empleado.tipoEmpleadoId == 1;
        }
    }
}
