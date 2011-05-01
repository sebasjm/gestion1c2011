using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Modelo {
    interface Mapper<E> {
        E getInstance(SqlDataReader sdr);
    }

}
