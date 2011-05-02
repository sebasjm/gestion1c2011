using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Usuario {

        public Usuario(int id) {
            this.id = id;
        }
        public int id {
            get; private set;
        }
        public string username {
            get; set;
        }
        public string password {
            get; set;
        }
    }
}
