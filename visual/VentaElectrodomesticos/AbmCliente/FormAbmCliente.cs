using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmCliente
{
    public partial class FormAbmCliente : Form
    {
        public FormAbmCliente()
        {
            InitializeComponent();
            FillProvincias();
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarCliente((Cliente)form.MessageFromParent);
                bCrearOtro.Hide();
                bLimpiar.Text = "Borrar";
                bCrear.Text = "Modificar";
            }
        }
        private void cargarCliente(Cliente cargoCliente)
        {
                txtApellido.Text = cargoCliente.apellido;
                txtNombre.Text = cargoCliente.nombre;
                txtDni.Text = cargoCliente.dni.ToString();
                txtMail.Text = cargoCliente.mail;
        }
        void FillProvincias()
        {
            List<Provincia> provinciasList = Context.instance.dao.provincia.load();
            try
            {
                cmbProvincia.DataSource = provinciasList;
                cmbProvincia.DisplayMember = "nombre";
                cmbProvincia.ValueMember = "id";
                cmbProvincia.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Borrar")
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con el borrado
                }
            }

        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Crear")
            {
                if (MessageBox.Show("¿Esta seguro que desea crear al cliente?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la creacion
                }
            }else{
                if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                }
            }
        }
     }
}
