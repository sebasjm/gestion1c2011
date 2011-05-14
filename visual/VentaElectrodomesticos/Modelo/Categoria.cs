using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Categoria {
        public Categoria(Int16 _id){
            this.id = _id;
        }
        public Int16 id
        {
            get; private set;
        }
        public Int16? categoria_padre
        {
            get; set;
        }
        public String nombre {
            get; set;
        }
    }
}
