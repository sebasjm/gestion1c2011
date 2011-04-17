using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace VentaElectrodomesticos.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("user id=gd;" +
                                       "password=gd2011;server=localhost\\SQLSERVER2005;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD1C2011; " +
                                       "connection timeout=1");
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT TOP 5 cli_nombre, cli_apellido FROM gd_esquema.Maestra", myConnection);

                String resultado = "";

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    resultado = resultado + myReader["cli_nombre"].ToString() + " = " + myReader["cli_apellido"].ToString() + "\n";
                }
                label1.Text = "resultado = " + resultado;
            }
            catch (Exception es)
            {
                label1.Text = es.ToString();
                Console.WriteLine(es.ToString());
            }
        }
    }
}
