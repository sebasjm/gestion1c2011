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
        public List<Empleado> getEmpleados(string nombre, string apellido, int dni, int sucursal_id, int tipoempleado_id)
        {
            String strDNI = (dni >= 0) ? strDNI = " AND dni=" + dni : "";
            String strSucursal = (sucursal_id >= 0) ? strSucursal = " AND sucursal_id=" + sucursal_id : "";
            String strTipoEmpleado = (tipoempleado_id >= 0) ? strTipoEmpleado = " AND tipoempleado_id=" + tipoempleado_id : "";
            List<Empleado> empleados = connection.query<Empleado>(
                "SELECT * FROM la_huerta.empleado WHERE " +
                " activo = 1 AND " +
                " LOWER(nombre) like  LOWER('%{0}%') AND" +
                " LOWER(apellido) like  LOWER('%{1}%')" +
                strDNI + strSucursal + strTipoEmpleado ,
                nombre,
                apellido
            );
            return empleados;
        }
        class EmpleadoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                                //MessageBox.Show("ID : " + sdr.GetValue(0) + "NOMBRE :" + sdr.GetValue(1));
                // TODO : Ver porque tipo empleado tiene un espacio en la primary
                String dni = (string)sdr.GetValue(0).ToString().Trim(' ');
                String tipoEmpleado_id = (string)sdr.GetValue(5).ToString().Trim(' ');
                String sucursal_id = (string)sdr.GetValue(6).ToString().Trim(' ');
                String activo= (string)sdr.GetValue(7).ToString().Trim(' ');
                String usuario_id = ((string)sdr.GetValue(8).ToString().Trim(' ') == "") ? "-1" : (string)sdr.GetValue(8).ToString().Trim(' ');

                return new Empleado {
                    dni = (int)Int32.Parse(dni) ,
                    nombre = (string)sdr.GetValue(1) ,
                    apellido = (string)sdr.GetValue(2) ,
                    mail = (string)sdr.GetValue(3) ,
                    direccion = (string)sdr.GetValue(4) ,
                    tipoEmpleado_id =(int)Int32.Parse(tipoEmpleado_id),
                    sucursal_id = (int)Int32.Parse(sucursal_id),
                    activo = (Boolean)sdr.GetValue(7),
                    usuario_id = (int)Int32.Parse(usuario_id)
                };
            }
        }
    }
}
