using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo
{
    class RolFuncionalidad
    {
        public RolFuncionalidad(Byte _id , Byte _funcionalidad_id)
        {
            this.rol_id = _id;
            this.funcionalidad_id = _funcionalidad_id;
        }
        public Byte rol_id
        {
            get;
            private set;
        }
        public Byte funcionalidad_id
        {
            get;
            private set;
        }
    }
}
