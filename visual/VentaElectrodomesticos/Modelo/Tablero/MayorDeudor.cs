using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class MayorDeudor {
        public MayorDeudor(Int32 dni, String nombre, String apellido) {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        public Int32 dni {
            get;
            private set;
        }
        public String nombre {
            get;
            private set;
        }
        public String apellido {
            get;
            private set;
        }

    }
}
