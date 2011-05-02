using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Sucursal {

        public Sucursal(int id) {
            this.id = id;
        }

        public int id {
            get; private set;
        }

        public string direccion {
            get;
            set;
        }

        public string telefono {
            get;
            set;
        }

        public int tipoSucursalId {
            get;
            set;
        }

        public int provinciaId {
            get;
            set;
        }
    }
}
