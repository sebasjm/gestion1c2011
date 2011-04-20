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

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("user id=gd;" +
                                       "password=gd2011;server=localhost\\SQLSERVER2005;" +
                                       "database=GD1C2011; ");
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
                tUsername.Text = "resultado = " + resultado;
            }
            catch (Exception es)
            {
                tUsername.Text = es.ToString();
                Console.WriteLine(es.ToString());
            }
        }
    }
}
