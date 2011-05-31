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
        class EmpleadoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Empleado((Int32)sdr.GetValue(0)) {
                    nombre = sdr.GetString(1),
                    apellido = sdr.GetString(2),
                    mail = sdr.GetString(3),
                    telefono = sdr.GetString(4),
                    direccion = sdr.GetString(5),
                    tipoEmpleadoId = sdr.GetByte(6),
                    sucursalId = sdr.GetByte(7),                 
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
                .filterIf(tipoEmp != null && tipoEmp.id != 0, "tipoEmpleado_id = {4} ", tipoEmp != null ? tipoEmp.id : 0)
                .filter("activo = 1 ");
            return connection.query<Empleado>(q.build(), q.getParams());
        }

        private static readonly String INSERT = "INSERT INTO la_huerta.Empleado VALUES({0},'{1}','{2}','{3}','{4}','{5}',{6},{7},1,NULL)";
        private static readonly String UPDATE = "UPDATE la_huerta.Empleado SET nombre='{1}',apellido='{2}',mail='{3}',telefono='{4}',direccion='{5}',tipoEmpleado_id={6},sucursal_id={7} WHERE dni={0}";
        private static readonly String DELETE = "UPDATE la_huerta.Empleado SET activo=0 WHERE dni={0}";

        public void insertar(Empleado empleado) {
            connection.update(
                INSERT,
                empleado.dni,
                empleado.nombre,
                empleado.apellido,
                empleado.mail,
                empleado.telefono,
                empleado.direccion,
                empleado.tipoEmpleadoId,
                empleado.sucursalId
            );
        }
        public void modificar(Empleado empleado) {
            connection.update(
                UPDATE,
                empleado.dni,
                empleado.nombre,
                empleado.apellido,
                empleado.mail,
                empleado.telefono,
                empleado.direccion,
                empleado.tipoEmpleadoId,
                empleado.sucursalId
            );
        }
        public void eliminar(int dni) {
            connection.update(
                DELETE,
                dni
            );
        }
        public Empleado findByDni(int dni){
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Empleado")
                .filter("dni = {0}", dni);
            return connection.find<Empleado>(q.build(), q.getParams());
        }
    }
}
