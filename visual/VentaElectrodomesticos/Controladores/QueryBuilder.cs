using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Controladores {
    class QueryBuilder {

        private string query;
        private List<object> filters;
        private bool firstFilter = true;
        //para insert
        private bool firstColumn = true;
        private bool firstValue = true;

        public QueryBuilder() {
            query = "";
            filters = new List<object>();
        }

        public QueryBuilder select() {
            query += "SELECT * ";
            return this;
        }

        public QueryBuilder from(string table) {
            query += "FROM " + table;
            return this;
        }

        

        public QueryBuilder filterIf(bool condition, string filter, object param) {
            if (condition) {
                query += (firstFilter ? " WHERE " : " and ") + filter;
                firstFilter = false;
            }
            filters.Add(param);
            return this;
        }

        public string build() {
            return query;
        }

        public object[] getParams() {
            return filters.ToArray();
        }
        // PARA INSERT:
        public QueryBuilder insert(String table)
        {
            query += "INSERT INTO " + table;
            return this;
        }
        public QueryBuilder columns(List<String> columnas)
        {
            query += " ( ";
            foreach (String columna in columnas) {
                query += (firstColumn ? "" : " , ") + columna;
                firstColumn = false;
            }
                       
            query += " ) ";
            return this;
        }
        public QueryBuilder values(List<String> valores)
        {
            query += " VALUES ( ";
            foreach (String valor in valores)
            {
                query += (firstValue ? "" : " , ") + valor;
                firstValue = false;
            }
            query += " ) ";
            return this;
        }
    }
}
