using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;
namespace VentaElectrodomesticos.Modelo {
    class Usuario {
        public Usuario(Int32 id) {
            this.id = id;
        }
        public Int32 id {
            get; private set;
        }
        public String username {
            get; set;
        }
        public String password {
            get; set;
        }
        public Int32 empleado_dni {
            get; set;
        }
        public Empleado empleado {
            get { return Context.instance.dao.empleado.findByDni(empleado_dni); }
        }
        public Byte intentos
        {
            get;
            set;
        }
    }
}
