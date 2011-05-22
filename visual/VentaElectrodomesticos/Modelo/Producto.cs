using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Producto {
        public Producto(int codigo) {
            this.codigo = codigo;
        }
        public Int32 codigo {
            get;
            private set;
        }
        public String nombre {
            get;
            set;
        }
        public String descripcion {
            get;
            set;
        }
        public Double precio {
            get;
            set;
        }
        public Int16 marca_id {
            get;
            set;
        }
        public Int16 categoria_id {
            get;
            set;
        }
        public Marca marca {
            get { return Context.instance.dao.marca.findById(marca_id); }
        }
        public Categoria categoria {
            get { return Context.instance.dao.categoria.findById(categoria_id); }
        }
    }
}
