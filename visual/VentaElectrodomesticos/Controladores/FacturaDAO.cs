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
                return new Factura(sdr.GetInt32(0)) {
                    descuento = sdr.GetDouble(1)     ,
                    total = sdr.GetDouble(2),
                    fecha = sdr.GetDateTime(3),
                    cuotas = sdr.GetByte(4),
                    cliente_dni = sdr.GetInt32(5)
                };
            }
        }
    }
}
