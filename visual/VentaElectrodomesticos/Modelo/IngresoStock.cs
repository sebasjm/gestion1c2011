using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo {
    class IngresoStock {
        public IngresoStock(Byte _sucursal , Int32 _producto , DateTime _fecha){
            this.sucursal_id = _sucursal;
            this.producto_codigo = _producto;
            this.fecha = _fecha;
        }
        public Byte sucursal_id {
            get; private set;
        }
        public Int32 producto_codigo {
            get; private set;
        }
        public DateTime fecha {
            get; private set;
        }
        public int stock {
            get; set;
        }
    }
}
