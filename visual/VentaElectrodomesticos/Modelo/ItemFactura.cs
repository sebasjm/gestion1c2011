using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class ItemFactura {

        public ItemFactura(Int32 producto_codigo, Int32 factura_numero) {
            this.producto_codigo = producto_codigo;
            this.factura_numero = factura_numero;
        }

        public Int32 producto_codigo {
            get;
            protected set;
        }

        public Int32 factura_numero {
            get;
            private set;
        }

        public double precio {
            get;
            set;
        }

        public Byte cantidad {
            get;
            set;
        }
    }

    class ItemFacturaMock : ItemFactura {

        public ItemFacturaMock(Producto prod) : base (prod.codigo,0) {
            this.producto = prod;
        }


        private Producto prod;
        public Producto producto {
            get { return prod; }
            set { prod = value; precio = prod.precio; producto_codigo = prod.codigo; }
        }
    }
}
