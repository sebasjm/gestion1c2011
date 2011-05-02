using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Categoria {
        public int id {
            get; set;
        }
        public int categoria_padre
        {
            get;
            set;
        }
        public string nombre {
            get; set;
        }
    }
}
