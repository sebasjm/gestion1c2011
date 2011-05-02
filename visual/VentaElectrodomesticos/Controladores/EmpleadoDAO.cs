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
                    nombre = (string)sdr.GetValue(1),
                    apellido = (string)sdr.GetValue(2),
                    mail = (string)sdr.GetValue(3),
                    direccion = (string)sdr.GetValue(4),
                    tipoEmpleadoId = (Byte)sdr.GetValue(5),
                    sucursalId = (Int32)sdr.GetValue(6),
                    usuarioId = sdr.IsDBNull(8) ? null : (Int32?)sdr.GetValue(8)
                };
            }
        }

        public List<Empleado> search(string nombre, string apellido, int dni, Provincia prov, Sucursal suc, TipoEmpleado tipoEmp) {
            QueryBuilder q = new QueryBuilder();

            q.select()
                .from("la_huerta.Empleado")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre)
                .filterIf(apellido.Length != 0, "apellido like '%{1}%' ", apellido)
                .filterIf(dni != 0, "dni = {2} ", dni)
                .filterIf(suc != null, "sucursal_id = {3} ", suc != null ? suc.id : 0)
                .filterIf(tipoEmp != null, "tipoEmpleado_id = {4} ", tipoEmp != null ? tipoEmp.id : 0);
            
            return connection.query<Empleado>( q.build() , q.getParams() );
        }
    }
}
