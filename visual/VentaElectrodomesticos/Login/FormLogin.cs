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
            String cadena = Login.sha256encrypt(tUsername.Text);
            try {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT username FROM la_huerta.Usuario where password = '" + cadena + "'", myConnection);

                SqlDataReader myReader = myCommand.ExecuteReader();

                lPassword.Text = myReader.HasRows ? "yeah!" : "ouch!";

            } catch (Exception es) {
                tUsername.Text = es.ToString();
                Console.WriteLine(es.ToString());
            }
        }
    }
}
