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
        Marca marca;
        public FormAbmMarca()
        {
            InitializeComponent();
            bModificar.Visible = false;
            bBorrar.Visible = false;
            List<Marca> result = Context.instance.dao.marca.load();
            ViewHelper.fillDataGridMarcas(dataMarcas, result);
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
        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar la Marca?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el borrado
                Context.instance.dao.marca.eliminar((int)this.marca.id);
                this.Close();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar la Marca?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la modificacion
                this.marca.nombre = txtMarca.Text;
                Context.instance.dao.marca.modificar(this.marca);
                this.Close();
            }
        }
        private void limpiar() {
            txtMarca.Text = "";
            bCrear.Show();
            bModificar.Hide();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear la Marca?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creación del rol
                Marca marca = new Marca(null);
                marca.nombre = txtMarca.Text;
                Context.instance.dao.marca.insertar(marca);
                this.limpiar();
            }
        }

        private void dataMarcas_CellClick(object sender,
    DataGridViewCellEventArgs e)
        {

            Marca Article = (Marca)this.dataMarcas.se;


            //this.marca = (Marca)dataMarcas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            this.marca = (Marca)dataMarcas.SelectedRows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            /*
            if ((string)cell.Value == "")
            {
                
                    cell.Value = "o";
                }
                else
                {
                    cell.Value = "x";
                }

            int index = dataMarcas.SelectedCells[0].RowIndex;
            string Column_ID = (string)dataMarcas["nombre", index].Value;

            txtMarca.Text = Column_ID;*/

            if (this.marca != null)
            {
                txtMarca.Text = this.marca.nombre;
               
            }
            bModificar.Show();
        }

    }
}
