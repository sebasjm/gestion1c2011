using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {
    class MejorCategoria {

        public MejorCategoria(String nombre, int subs, double fact, String masVend, String masFact, String masCaro, String mejorVend) {
            this.nombre = nombre;
            this.cantidadSubcategorias = subs;
            this.facturacion = fact;
            this.productoMasVendido = masVend;
            this.productoMasFacturado = masFact;
            this.productoMasCaro = masCaro;
            this.mejorVendedor = mejorVend;
        }
        public String nombre {
            get;
            private set;
        }
        public int cantidadSubcategorias {
            get;
            private set;
        }
        public double facturacion {
            get;
            private set;
        }
        public String productoMasVendido {
            get;
            private set;
        }
        public String productoMasFacturado {
            get;
            private set;
        }
        public String productoMasCaro {
            get;
            private set;
        }
        public String mejorVendedor {
            get;
            private set;
        }

    }
}
