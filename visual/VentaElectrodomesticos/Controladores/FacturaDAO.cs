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

        class FacturaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Factura(sdr.GetInt32(0)) {
                    descuento = sdr.GetDouble(1)     ,
                    total = sdr.GetDouble(2),
                    fecha = sdr.GetDateTime(3),
                    cuotas = sdr.GetByte(4),
                    cliente_dni = sdr.GetInt32(5),
                    empleado_dni = sdr.GetInt32(6),
                    cuotasPagas = sdr.GetByte(7)
                };
            }
        }

        public List<Factura> search(Cliente cliente, Sucursal sucursal) {
            QueryBuilder q = new QueryBuilder().select()
                .from("la_huerta.Factura as f JOIN la_huerta.Empleado as e ON e.dni = f.empleado_dni")
                .filterIf(cliente != null && cliente.dni != 0, " f.cliente_dni = {0}", cliente == null ? 0 : cliente.dni)
                .filterIf(sucursal != null && sucursal.id != 0, " e.sucursal_id = {1}", sucursal == null ? 0 : sucursal.id)
                .filter(" f.cuotas_pagas < f.cuotas");
            return connection.query<Factura>(q.build(), q.getParams());
        }

        private static readonly String INSERT_PAGO = "INSERT INTO la_huerta.Pago VALUES ({0},getdate(),{1},2014908)";
        private static readonly String UPDATE_FACTURA_COUTAS = "UPDATE la_huerta.Factura SET cuotas_pagas = cuotas_pagas + {0} where numero = {1}";

        public void pagar(Factura factura, int cuotas) {
            connection.update(INSERT_PAGO, factura.numero, cuotas);
            connection.update(UPDATE_FACTURA_COUTAS, cuotas, factura.numero);
        }
        private static readonly String INSERT_FACTURA = "";
        private static readonly String ULTIMA_FACTURA_CREADA_DEL_CLIENTE = "SELECT TOP 1 * FROM la_huerta.Factura WHERE cliente_dni = {0} AND empleado_dni = {1} ORDER BY fecha desc";

        public void nuevo(double descuento, double total, byte cuotas, Cliente cliente, List<ItemFacturaMock> list) {
            connection.update(INSERT_FACTURA, "");
            connection.find<Factura>(ULTIMA_FACTURA_CREADA_DEL_CLIENTE,cliente.dni);
        }
    }
}
