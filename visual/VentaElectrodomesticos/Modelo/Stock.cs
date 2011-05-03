using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Stock {
        public int sucursal_id {
            get; set;
        }
        public int producto_codigo {
            get; set;
        }
        public int stock
        {
            get; set;
        }
        public Sucursal sucursal
        {
            get { 
                return Context.instance.dao.sucursal.findById(Byte.Parse( "" + this.sucursal_id )) ;
            }
        }
    }
}
