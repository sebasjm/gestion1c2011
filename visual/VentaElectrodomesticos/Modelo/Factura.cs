using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo {
    class Factura {
        public Factura(Int32 _numero){
            this.numero = _numero;
        }
        public Int32 numero {
            get; private set;
        }
        public double descuento {
            get; set;
        }
        public double total {
            get; set;
        }
        public Byte cuotasPagas {
            get; set;
        }
        public Int32 empleado_dni {
            get; set;
        }
        public Byte cuotasPorPagar {
            get { return (Byte) (cuotas - cuotasPagas); }
        }
        public double totalConDescuento {
            get { return total * (1-descuento); }
        }
        public double valorCuota {
            get { return totalConDescuento / cuotas; }
        }
        public DateTime fecha {
            get; set;
        }
        public Byte cuotas {
            get; set;
        }
        public int cliente_dni {
            get; set;
        }
    }
}
