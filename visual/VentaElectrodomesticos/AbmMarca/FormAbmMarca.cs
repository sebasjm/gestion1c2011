using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Vista;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmMarca
{
    public partial class FormAbmMarca : Form
    {
        Validator validator;
        public FormAbmMarca()
        {
            InitializeComponent();
            bModificar.Visible = false;
            bBorrar.Visible = false;
            validator = new Validator()
                .add(txtMarca, lErrorMarca, Validator.Text.obligatorio, Validator.Text.nombre);
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear la Marca?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creación del rol
                Marca marca = new Marca(null);
                marca.nombre= txtMarca.Text;
                Context.instance.dao.marca.insertar(marca);
                this.Close();
            }
        }
    }
}
