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
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Vista;
namespace VentaElectrodomesticos.Login {
    public partial class FormLogin : Form {

        private Validator validator;

        public FormLogin() {
            InitializeComponent();
            validator = new Validator()
                .add(tUsername, lErrorUser, Validator.Text.texto);
        }
        private void bAceptar_Click(object sender, EventArgs e) {

            try {
                if (!validator.check()) {
                    MessageBox.Show("El usuario tiene un formato invalido", "Error");
                    return;
                }
                Context.instance.authenticate(tUsername.Text, tPassword.Text);
            } catch (WrongUserOrPasswordException) {
                Usuario user = Context.instance.dao.user.findByName(tUsername.Text);
                Context.instance.dao.user.intentos(tUsername.Text, true);
                if ((!(user == null)) && (user.intentos == 2)) {
                    Context.instance.dao.user.desahabilitar(tUsername.Text);
                }
                MessageBox.Show("Usuario o Contraseña incorrecta", "Error");
                return;
            }
            Context.instance.dao.user.intentos(tUsername.Text, false);
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e) {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (Context.instance.security == null || Context.instance.security.loggedUser == null) {
                Application.Exit();
            }
        }
    }
}
