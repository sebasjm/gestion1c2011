using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Producto {
        public Producto(int codigo) {
            this.codigo = codigo;
        }
        public int codigo {
            get; private set;
        }
        public String nombre {
            get; set;
        }
        public String descripcion {
            get; set;
        }
        public float precio {
            get; set;
        }
        public Int32 marca_id {
            get; set;
        }
        public Int32 categoria_id {
            get; set;
        }
    }
}
