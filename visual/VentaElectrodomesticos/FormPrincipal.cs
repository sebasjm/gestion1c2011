using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Login;
using VentaElectrodomesticos.AbmEmpleado;
using VentaElectrodomesticos.AbmRol;
using VentaElectrodomesticos.AbmUsuario;
using VentaElectrodomesticos.AbmCliente;
using VentaElectrodomesticos.AbmProducto;
using VentaElectrodomesticos.AsignacionStock;
using VentaElectrodomesticos.Facturacion;
using VentaElectrodomesticos.EfectuarPago;
using VentaElectrodomesticos.TableroControl;
using VentaElectrodomesticos.ClientesPremium;
using VentaElectrodomesticos.MejoresCategorias;

namespace VentaElectrodomesticos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            FormLogin login = new FormLogin();
            login.ShowDialog(this);
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmEmpleado form = new FormAbmEmpleado();
            form.ShowDialog(this);
        }

        private void aBMDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmRol form = new FormAbmRol();
            form.ShowDialog(this);
        }

        private void aBMDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmUsuario form = new FormAbmUsuario();
            form.ShowDialog(this);
        }

        private void aBMDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmCliente form = new FormAbmCliente();
            form.ShowDialog(this);
        }

        private void aBMDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmProducto form = new FormAbmProducto();
            form.ShowDialog(this);
        }

        private void asignaciónDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignacionStock form = new FormAsignacionStock();
            form.ShowDialog(this);
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturacion form = new FormFacturacion();
            form.ShowDialog(this);
        }

        private void efectuarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEfectuarPago form = new FormEfectuarPago();
            form.ShowDialog(this);
        }

        private void tableroDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTableroControl form = new FormTableroControl();
            form.ShowDialog(this);
        }

        private void clientesPremiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesPremium form = new FormClientesPremium();
            form.ShowDialog(this);
        }

        private void mejoresCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMejoresCategorias form = new FormMejoresCategorias();
            form.ShowDialog(this);
        }
    }
}
