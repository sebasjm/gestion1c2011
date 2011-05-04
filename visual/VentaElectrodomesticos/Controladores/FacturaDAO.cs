using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;


namespace VentaElectrodomesticos.Controladores {
    class FacturaDAO {
        private Connection connection;
        public FacturaDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Factura), new FacturaMapper());
        }
        public List<Factura> search(int cliente_dni)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Factura")
                .filterIf(cliente_dni != 0, " cliente_dni = {0}", cliente_dni);
            return connection.query<Factura>( q.build(), q.getParams() );
        }
        class FacturaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                    int xnumero = sdr.IsDBNull(0) ? 0: (int)sdr.GetValue(0);
                    double xdescuento = (sdr.GetValue(1) == null || sdr.IsDBNull(1)) ? (double)0 : (double)sdr.GetValue(1);
                    double xtotal = (sdr.GetValue(2) == null || sdr.IsDBNull(2)) ? (double)0 : (double)sdr.GetValue(2);
                    DateTime xfecha = (DateTime)sdr.GetValue(3);
                    Byte xcuotas = sdr.IsDBNull(4) ? (Byte)0 : (Byte)sdr.GetValue(4);
                    Int32 xcliente_dni = sdr.IsDBNull(5) ? 0 : (Int32)sdr.GetValue(5);
                return new Factura() {
                    numero = xnumero,
                    descuento = xdescuento,
                    total = xtotal,
                    fecha = xfecha,
                    cuotas = xcuotas,
                    cliente_dni = xcliente_dni
                };
            }
        }
    }
}
