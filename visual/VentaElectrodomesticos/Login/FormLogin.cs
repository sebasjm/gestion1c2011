using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Exception;

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

        private void bAceptar_Click(object sender, EventArgs e) {
            try {
                Context.instance.authenticate(tUsername.Text, tPassword.Text);
            } catch (WrongUserOrPasswordException ex) {
                tUsername.Text = "Wrong username or password";
                return;
            }
            tUsername.Text = "right!";
        }

    }
}
