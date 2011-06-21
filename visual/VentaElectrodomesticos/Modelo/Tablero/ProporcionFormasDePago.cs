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

        public override string ToString() {
            return contado == 0 ? "-" : String.Format("{0:#0.00}% - {1:#0.00}%", 100 * contado, 100 * cuotas);
        }
    }
    class ProporcionFormasDePagoSinValores: ProporcionFormasDePago{
        public ProporcionFormasDePagoSinValores(): base(0) {

        }
        public override string ToString() {
            return "sin valores";
        }
    }
}
