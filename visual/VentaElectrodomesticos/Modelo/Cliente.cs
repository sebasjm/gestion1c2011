﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Cliente {
        public Cliente(Int32 dni) {
            this.dni = dni;
        }
        public Int32 dni {
            get;
            private set;
        }
        public String nombre {
            get;
            set;
        }
        public String apellido {
            get;
            set;
        }
        public String mail {
            get;
            set;
        }
        public String telefono {
            get;
            set;
        }
        public String direccion {
            get;
            set;
        }
        public Byte provinciaId {
            get;
            set;
        }
        public Provincia provincia {
            get { return Context.instance.dao.provincia.findById(provinciaId); }
        }
    }
}
