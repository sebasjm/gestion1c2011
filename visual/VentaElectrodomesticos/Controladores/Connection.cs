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
            if (open)
                _connection.Close();
        }

        public List<T> query<T>(string sql, params Object[] args) {
            string s = String.Format(sql, args);
            SqlCommand cmd = new SqlCommand( String.Format(sql,args), connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            List<T> result = new List<T>();
            while (sdr.Read()) {
                result.Add( (T) Context.instance.dao.mappers[ typeof(T) ].getInstance(sdr) );
            }
            sdr.Close();
            return result;
        }

        public int update(string sql) {
            return 0;
        }

    }

}
