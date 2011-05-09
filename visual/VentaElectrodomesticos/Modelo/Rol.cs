using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Rol {
        public Rol(Int16 id){
            this.id = id;
        }
        public Int16 id {
            get; private set;
        }
        public String nombre {
            get; set;
        }
        public String descripcion {
            get; set;
        }
    }
}
