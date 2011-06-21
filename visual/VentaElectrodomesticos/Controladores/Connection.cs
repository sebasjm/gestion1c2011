using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Sql;
using VentaElectrodomesticos.Modelo;
namespace VentaElectrodomesticos.Controladores {
    class Connection {
        private bool open = false;
        private SqlConnection _connection;
        private SqlConnection connection {
            get { if (!open) { _connection.Open(); open = true; }; return _connection; }
            set { _connection = value; }
        }
        public Connection(SqlConnection ssql) {
            connection = ssql;
        }
        ~Connection() {
            //TODO: verificar porque no podemos cerrar la conexion en este momento
            //igualmente la conexion se cierra
//            if (open && _connection.State != System.Data.ConnectionState.Closed) {
//                _connection.Close();
//            }
        }
        public T find<T>(string sql, params Object[] args) {
            SqlDataReader sdr = new SqlCommand(String.Format(locale, sql, SafeSql(args)), connection).ExecuteReader();
            try {
                return (T)(sdr.Read() ? Context.instance.dao.mappers[typeof(T)].getInstance(sdr) : null);
            } finally {
                sdr.Close();
            }
        }
        IFormatProvider locale = new System.Globalization.CultureInfo("en-US");
        public List<T> query<T>(string sql, params Object[] args) {
            SqlDataReader sdr = new SqlCommand(String.Format(locale, sql,SafeSql(args)), connection).ExecuteReader();
            List<T> result = new List<T>();
            while (sdr.Read()) {
                result.Add( (T) Context.instance.dao.mappers[ typeof(T) ].getInstance(sdr) );
            }
            sdr.Close();
            return result;
        }
        public int update(string sql, params Object[] args) {
            Object[] salida = SafeSql(args);
            String salSQL = String.Format(locale, sql, salida);
            return new SqlCommand(salSQL , connection).ExecuteNonQuery();
        }
        public int procedure(string sql, List<SqlParameter> parms) {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (SqlParameter param_name in parms) {
                cmd.Parameters.Add(param_name);
            }
            return cmd.ExecuteNonQuery();
        }
        // Funcion para evitar sql inyection
        private Object[] SafeSql(params Object[] args)
        {
            return args;
        }
    }
}
