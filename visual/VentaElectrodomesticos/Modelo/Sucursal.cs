using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Sucursal {

        public Sucursal(Int32 id) {
            this.id = id;
        }

        public Int32 id {
            get; private set;
        }

        public String direccion {
            get;
            set;
        }

        public String telefono {
            get;
            set;
        }

        public Byte tipoSucursalId {
            get;
            set;
        }

        public Byte provinciaId {
            get;
            set;
        }
    }
}
