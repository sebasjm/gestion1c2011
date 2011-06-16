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
                .from("EL_GRUPO.Factura as f JOIN EL_GRUPO.Empleado as e ON e.dni = f.empleado_dni")
                .filterIf(cliente != null && cliente.dni != 0, " f.cliente_dni = {0}", cliente == null ? 0 : cliente.dni)
                .filterIf(sucursal != null && sucursal.id != 0, " e.sucursal_id = {1}", sucursal == null ? 0 : sucursal.id)
                .filter(" f.cuotas_pagas < f.cuotas");
            return connection.query<Factura>(q.build(), q.getParams());
        }

        private static readonly String INSERT_PAGO = "INSERT INTO EL_GRUPO.Pago VALUES ({0},getdate(),{1},{2})";
        private static readonly String UPDATE_FACTURA_COUTAS = "UPDATE EL_GRUPO.Factura SET cuotas_pagas = cuotas_pagas + {0} where numero = {1}";

        public void pagar(Factura factura, int cuotas) {
            Empleado empleado = Context.instance.security.loggedUser.empleado;
            pagar(factura.numero, cuotas, empleado.dni);
        }

        private void pagar(int numero, int cuotas, int dni) {
            connection.update(INSERT_PAGO, numero, cuotas, dni);
            connection.update(UPDATE_FACTURA_COUTAS, cuotas, numero);
        }

        private static readonly String INSERT_FACTURA = "INSERT INTO EL_GRUPO.Factura (descuento, total, fecha, cuotas, cliente_dni, empleado_dni, cuotas_pagas) VALUES({0},{1},getdate(),{2},{3},{4},0)";
        private static readonly String ULTIMA_FACTURA_CREADA_DEL_CLIENTE = "SELECT MAX(numero) FROM EL_GRUPO.Factura WHERE cliente_dni = {0} AND empleado_dni = {1}";
        private static readonly String INSERT_ITEM_FACTURA = "INSERT INTO EL_GRUPO.ItemFactura VALUES ( {0},{1},{2},{3})";
        private static readonly String UPDATE_STOCK_CANTIDAD = "UPDATE EL_GRUPO.Stock SET stock = stock - {0} WHERE sucursal_id = {1} AND producto_codigo = {2}";

        public void nueva(double descuento, double total, byte cuotas, Cliente cliente, List<ItemFacturaMock> list) {
            if ((cliente == null)) return;
            Empleado empleado = Context.instance.security.loggedUser.empleado;
            connection.update(INSERT_FACTURA, 
                descuento,
                total,
                cuotas,
                cliente.dni,
                empleado.dni
            );
            int nro_factura = connection.find<int>(ULTIMA_FACTURA_CREADA_DEL_CLIENTE,cliente.dni,empleado.dni);
            if (cuotas == 1) {
                pagar(nro_factura,cuotas,empleado.dni);
            }
            foreach (ItemFactura itf in list) {
                connection.update(INSERT_ITEM_FACTURA,
                    nro_factura,
                    itf.producto_codigo,
                    itf.precio,
                    itf.cantidad
                );
                connection.update(UPDATE_STOCK_CANTIDAD,
                    itf.cantidad,
                    empleado.sucursalId,
                    itf.producto_codigo
                );
            }
        }
    }
}
