using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class TipoSucursal {

        public TipoSucursal(Byte id) {
            this.id = id;
        }

        public Byte id {
            get;
            private set;
        }

        public String descripcion {
            get;
            private set;
        }
    }
}
