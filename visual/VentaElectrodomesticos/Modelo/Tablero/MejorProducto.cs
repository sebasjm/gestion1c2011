using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class MejorProducto {
        public MejorProducto(Int32 codigo, String nombre, String categoria) {
            this.codigo = codigo;
            this.nombre = nombre;
            this.categoria = categoria;
        }

        public Int32 codigo {
            get;
            private set;
        }
        public String nombre {
            get;
            private set;
        }
        public String categoria {
            get;
            private set;
        }
    }
}
