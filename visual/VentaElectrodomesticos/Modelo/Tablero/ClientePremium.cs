using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo.Tablero {

    class ClientePremium {

        public ClientePremium(int dni, String nombre, String apellido, double total, int cantidad, DateTime ultimaCompra, int ultimoVendedor) {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.total = total;
            this.cantidad = cantidad;
            this.ultimaCompra = ultimaCompra;
            this.ultimoVendedor_dni = ultimoVendedor;
        }

        public String nombre {
            get;
            private set;
        }
        public int dni {
            get;
            private set;
        }
        public String apellido {
            get; private set;
        }
        public double total {
            get; private set;
        }
        public int cantidad {
            get; private set;
        }
        public DateTime ultimaCompra {
            get; private set;
        }
        public int ultimoVendedor_dni {
            get; private set;
        }

    }
}
