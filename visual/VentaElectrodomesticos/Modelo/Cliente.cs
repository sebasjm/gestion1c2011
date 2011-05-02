using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Cliente {

        public Cliente(Int32 dni) {
            this.dni = dni;
        }

        public Int32 dni {
            get; private set;
        }
        public String nombre {
            get; set;
        }
        public String apellido {
            get; set;
        }
        public String mail {
            get; set;
        }
    }
}
