using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class MejorVendedor {
        public MejorVendedor(Int32 dni, String nombre, String apellido) {
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

        public override string ToString() {
            if (dni == 0) return "ninguno";
            return apellido + ", " + nombre + " (" + dni + ")";
        }
    }

    class NullMejorVendedor : MejorVendedor {
        public NullMejorVendedor() : base(0,"","") {

        }
        public override string ToString() {
            return "ninguno";
        }
    }
}
