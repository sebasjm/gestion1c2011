using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
namespace VentaElectrodomesticos.Controladores {
    class EmpleadoDAO {
        private Connection connection;
        public EmpleadoDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Empleado), new EmpleadoMapper());
        }
        class EmpleadoMapper: Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Empleado( (Int32)sdr.GetValue(0) ) {
                    nombre = sdr.GetString(1),
                    apellido = sdr.GetString(2),
                    mail = sdr.GetString(3),
                    direccion = sdr.GetString(4),
                    tipoEmpleadoId = sdr.GetByte(5),
                    sucursalId = sdr.GetByte(6),
                    usuarioId = sdr.IsDBNull(8) ? -1 : (Int32)sdr.GetValue(8)
                };
            }
        }
        public List<Empleado> search(string nombre, string apellido, int dni, Sucursal suc, TipoEmpleado tipoEmp) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Empleado")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre)
                .filterIf(apellido.Length != 0, "apellido like '%{1}%' ", apellido)
                .filterIf(dni != 0, "dni = {2} ", dni)
                .filterIf(suc != null && suc.id != 0, "sucursal_id = {3} ", suc != null ? suc.id : 0)
                .filterIf(tipoEmp != null && tipoEmp.id != 0, "tipoEmpleado_id = {4} ", tipoEmp != null ? tipoEmp.id : 0);
            return connection.query<Empleado>( q.build() , q.getParams() );
        }
    }
}
