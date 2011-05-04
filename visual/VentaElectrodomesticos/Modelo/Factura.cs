using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo {
    class Factura {
        public int numero {
            get; set;
        }
        public double descuento {
            get; set;
        }
        public double total {
            get; set;
        }
        public DateTime fecha {
            get; set;
        }
        public int cuotas {
            get; set;
        }
        public int cliente_dni {
            get; set;
        }
    }
}
