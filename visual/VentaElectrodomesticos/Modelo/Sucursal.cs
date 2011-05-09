using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Sucursal {
        public Sucursal(Byte id) {
            this.id = id;
        }
        public Byte id {
            get; private set;
        }
        public String direccion {
            get; set;
        }
        public String telefono {
            get; set;
        }
        public Byte tipoSucursalId {
            get; set;
        }
        public Byte provinciaId {
            get; set;
        }
        public Provincia provincia {
            get { return Context.instance.dao.provincia.findById(provinciaId);  }
        }
    }
}
