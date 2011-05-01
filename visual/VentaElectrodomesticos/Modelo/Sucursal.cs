using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo
{
    class Sucursal
    {
        public int id
        {
            get;
            set;
        }
        public string direccion
        {
            get;
            set;
        }
        public string telefono
        {
            get;
            set;
        }
        public int tipoSucursal_id
        {
            get;
            set;
        }
        public int provincia_id
        {
            get;
            set;
        }

    }
}
