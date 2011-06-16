using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Marca {
        public Marca(short _id) {   
            this.id = _id; 
        }
        public short id      {
            get; private set;
        }
        public String nombre {
            get; set;
        }
    }
}
