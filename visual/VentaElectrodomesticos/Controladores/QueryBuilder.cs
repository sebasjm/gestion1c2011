using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Controladores {
    class Campo
    {
        public Campo(String col , object val) {
            this.columna = col;
            this.valor = val;
        }
        // En caso de que se repite el contenido se anula los campos
        public Campo(String col, object val, object val2)
        {
            if (val != val2)
            {
                this.columna = col;
                this.valor = val;
            }
            else {
                this.columna = null;
                this.valor = null;
            }
        }
        public string columna { get; set; }
        public Object valor { get; set; }
    }
    class QueryBuilder {
        private string query;
        private List<object> filters;
        private bool firstFilter = true;
        //para insert y update
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
        public QueryBuilder filter(string filter) { return filterIf(true, filter); }
        public QueryBuilder filter(string filter, object param) { return filterIf(true, filter, param); }
        public QueryBuilder filterIf(bool condition, string filter) { return filterIf(condition, filter, null); }
        public QueryBuilder filterIf(bool condition, string filter, object param) {
            if (condition) {
                query += (firstFilter ? " WHERE " : " and ") + filter;
                firstFilter = false;
            }
            if (param!=null) filters.Add(param);
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
        public QueryBuilder valores_insert(List<Campo> columnas)
        {
            query += " ( ";
            foreach (Campo columna in columnas)
            {
                if (columna.valor != null) 
                    query += (firstColumn ? "" : " , ") + columna.columna;
                firstColumn = false;
            }
            query += " ) VALUES ( ";
            foreach (Campo columna in columnas)
            {
                if(columna.valor != null) 
                    query += (firstValue ? "" : " , ") + this.addValue(columna.valor);
                firstValue = false;
            }
            query += " ) ";
            return this;
        }
        public String addValue(Object valor)
        {
            if (valor.GetType() == typeof(String))
            {
                return  "'" + (String)valor + "'";
            }
            if (valor.GetType() == typeof(int))
            {
                return "" + valor;
            }
            if (valor.GetType() == typeof(System.Double))
            {
                return Convert.ToString(valor);
            }
            if (valor.GetType() == typeof(System.Int16))
            {
                return "" + valor;
            }
            if (valor.GetType() == typeof(System.Byte))
            {
                return "" + valor;
            }
            return (String)valor;
        }
        // Para Update
        public QueryBuilder update(String table)
        {
            query += "UPDATE " + table;
            return this;
        }
        public QueryBuilder valores_update(List<Campo> columnas)
        {
            query += " SET ";
            foreach (Campo columna in columnas)
            {
                if (columna.valor != null) 
                    query += (firstColumn ? "" : " , ") + columna.columna + "=" + this.addValue(columna.valor);
                firstColumn = false;
            }
           return this;
        }
        // Para delete
        public QueryBuilder delete(String table)
        {
            query += "DELETE FROM " + table;
            return this;
        }
    }
}
