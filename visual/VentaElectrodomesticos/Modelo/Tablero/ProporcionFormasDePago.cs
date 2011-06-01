using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class ProporcionFormasDePago {
        public ProporcionFormasDePago(Double contado) {
            this.contado = contado;
        }

        public Double contado {
            get;
            private set;
        }

        public Double cuotas {
            get { return 1 - contado; }
        }
    }
}
