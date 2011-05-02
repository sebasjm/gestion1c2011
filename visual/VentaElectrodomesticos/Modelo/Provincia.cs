using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Provincia {

        public Provincia(Byte id) {
            this.id = id;
        }

        public Byte id {
            get;
            private set;
        }

        public String nombre {
            get;
            set;
        }
    }
}
