using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Provincia {

        public Provincia(int id) {
            this.id = id;
        }

        public int id {
            get;
            private set;
        }

        public string nombre {
            get;
            set;
        }
    }
}
