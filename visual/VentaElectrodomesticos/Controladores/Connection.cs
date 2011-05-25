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
            if (open && _connection.State != System.Data.ConnectionState.Closed) {
//                _connection.Close();
            }
        }

        public T find<T>(string sql, params Object[] args) {
            SqlDataReader sdr = new SqlCommand(String.Format(sql, args), connection).ExecuteReader();
            return (T) (sdr.Read() ? Context.instance.dao.mappers[typeof(T)].getInstance(sdr) : null);
        }

        public List<T> query<T>(string sql, params Object[] args) {
            SqlDataReader sdr = new SqlCommand(String.Format(sql, args), connection).ExecuteReader();
            List<T> result = new List<T>();
            while (sdr.Read()) {
                result.Add( (T) Context.instance.dao.mappers[ typeof(T) ].getInstance(sdr) );
            }
            sdr.Close();
            return result;
        }

        public int update(string sql, params Object[] args) {
            return new SqlCommand(String.Format(sql, args), connection).ExecuteNonQuery();
        }

    }

}
