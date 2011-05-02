using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class TipoSucursal {

        public TipoSucursal(int id) {
            this.id = id;
        }

        public int id {
            get;
            private set;
        }

        public string descripcion {
            get;
            private set;
        }
    }
}
