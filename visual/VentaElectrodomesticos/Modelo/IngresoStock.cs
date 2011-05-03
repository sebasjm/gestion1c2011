﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Modelo {
    class IngresoStock {
        public int sucursal_id {
            get; set;
        }
        public int producto_codigo {
            get; set;
        }
        public DateTime fecha
        {
            get;
            set;
        }
        public int stock {
            get; set;
        }
    }
}