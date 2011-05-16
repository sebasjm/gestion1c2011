using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VentaElectrodomesticos.Modelo
{
    class Funcionalidad
    {
        public Funcionalidad(Byte _id)
        {
            this.id = _id;
        }
        public Byte id
        {
            get;
            private set;
        }
        public String nombre
        {
            get;
            set;
        }
        public String descripcion
        {
            get;
            set;
        }
    }
}
