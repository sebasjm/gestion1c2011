using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Rol {
        public Rol(Byte? _id) {
            this.id = _id;
        }
        public Byte? id {
            get; private set;
        }
        public String nombre {
            get; set;
        }
        public String descripcion {
            get; set;
        }
        public List<Funcionalidad> funcionalidades
        {
            get { return Context.instance.dao.rol.getFuncionalidades(this.id); }
        }
    }
}
