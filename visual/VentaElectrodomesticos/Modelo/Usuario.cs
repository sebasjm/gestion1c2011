using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo {
    class Usuario {
        public Usuario(Int32 id) {
            this.id = id;
        }
        public Int32 id {
            get; private set;
        }
        public String username {
            get; set;
        }
        public String password {
            get; set;
        }
    }
}
