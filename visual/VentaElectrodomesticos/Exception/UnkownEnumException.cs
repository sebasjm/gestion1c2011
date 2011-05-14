using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Exception {
    class UnkownEnumException : System.Exception {
        public UnkownEnumException(String ex)
            : base(ex)
        {
            
        }
    }
}
