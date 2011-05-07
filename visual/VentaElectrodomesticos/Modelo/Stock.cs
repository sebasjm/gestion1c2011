using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Modelo {
    class Stock {
        public Stock(Int16 _sucursal , Int32 _producto  )
        {
            this.sucursal_id = _sucursal;
            this.producto_codigo = _producto;
        }
        public Int16 sucursal_id {
            get; private set;
        }
        public Int32 producto_codigo {
            get; private set;
        }
        public Int32 stock {
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
