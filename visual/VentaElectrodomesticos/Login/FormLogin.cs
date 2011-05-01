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
        private void bAceptar_Click(object sender, EventArgs e) {
            try {
                Context.instance.authenticate(tUsername.Text, tPassword.Text);
            } catch (WrongUserOrPasswordException ) {
                tUsername.Text = "Usuario o Contraseña incorrecta";
                return;
            }
            tUsername.Text = "right!";
        }
    }
}
