using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;
namespace VentaElectrodomesticos.Controladores {
    class RolFuncionalidadDAO {
        private Connection connection;
        public RolFuncionalidadDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(RolFuncionalidad), new RolFuncionalidadMapper());
        }
        
        class RolFuncionalidadMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new RolFuncionalidad (sdr.GetByte(0) , sdr.GetByte(1)){
                };
            }
        }
        public static readonly String INSERT_ROL_FUNCIONALIDAD = "INSERT INTO la_huerta.RolFuncionalidad VALUES ({0},{1})";
        public void insertar(Rol rol , Funcionalidad fun)
        {      
            connection.update(INSERT_ROL_FUNCIONALIDAD, rol.id, fun.id);
        }
        public void delete(Rol rol, Funcionalidad fun)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<RolFuncionalidad>(q.build(), q.getParams());
        }
    }
}
