using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class TipoEmpleado {
        public TipoEmpleado(Byte id) {
            this.id = id;
        }
        public Byte id {
            get; private set;
        }
        public String nombre {
            get; set;
        }
    }
}
