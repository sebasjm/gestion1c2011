using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class Empleado {

        public Empleado(int _dni) {
            dni = _dni;
            activo = true;
        }

        public Int32 dni {
            get; private set;
        }
        public String nombre {
            get; set;
        }
        public String apellido {
            get; set;
        }
        public String mail {
            get; set;
        }
        public String direccion {
            get; set;
        }
        public Byte tipoEmpleadoId {
            get; set;
        }
        public Int32 sucursalId {
            get; set;
        }
        public Boolean activo {
            get; private set;
        }
        public void habilitar() {
            activo = true;
        }
        public void bloquear() {
            activo = false;
        }
        public Int32? usuarioId {
            get; set;
        }
    }
}
