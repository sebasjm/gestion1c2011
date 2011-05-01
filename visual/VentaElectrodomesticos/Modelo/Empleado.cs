using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Empleado {
        public int dni {
            get; set;
        }
        public string nombre {
            get; set;
        }
        public string apellido {
            get; set;
        }
        public string mail {
            get; set;
        }
        public string direccion {
            get; set;
        }
        public int tipoEmpleado_id {
            get; set;
        }
        public int sucursal_id {
            get; set;
        }
        public Boolean activo {
            get; set;
        }
        public int usuario_id {
            get; set;
        }
    }
}
