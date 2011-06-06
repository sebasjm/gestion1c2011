using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class FaltanteStock {

        public FaltanteStock(int codigo, int dias) {
            this.codigo = codigo;
            this.dias = dias;
        }

        public int codigo {
            get;
            private set;
        }
        public int dias {
            get;
            private set;
        }

        public override string ToString() {
            return "" + dias + " dias (" + codigo + ")";
        }
    }

    class NullFaltanteStock : FaltanteStock {

        public NullFaltanteStock() : base(0,0) {
        }

        public override string ToString() {
            return "ninguno";
        }
    }
}
