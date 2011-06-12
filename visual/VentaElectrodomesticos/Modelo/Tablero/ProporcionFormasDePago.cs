using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class ProporcionFormasDePago    {
        public ProporcionFormasDePago(Int32 _contado, Int32 _cuotas)        {
            this.contado = _contado;
            this.cuotas = _cuotas;
        }
        public Int32 contado        {
            get;
            private set;
        }
        public Int32 cuotas        {
            get;
            private set;
        }
        public override string ToString()        {
            Int32 total = contado + cuotas;
            if (total == 0) total = 1;
            return "" + (contado / total) * 100 + "% - " + (cuotas / total) * 100 + "%";
        }
    }
}
