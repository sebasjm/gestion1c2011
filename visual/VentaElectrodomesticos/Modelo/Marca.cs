using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Marca {
        public Marca(Int32 _id) {   
            this.id = _id; 
        }
        public Int32 id      {
            get; private set;
        }
        public String nombre {
            get; set;
        }
    }
}
