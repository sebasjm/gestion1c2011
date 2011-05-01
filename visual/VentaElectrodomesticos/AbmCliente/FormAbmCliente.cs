using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            form.MessageFromParent = 0;
            form.ShowDialog(this);
            if (form.MessageFromParent != 0) {
                this.cargarCliente(form.MessageFromParent);
            }
            bCrearOtro.Hide();
            bLimpiar.Text = "Borrar";
            bCrear.Text = "Modificar";
        }
        public void cargarCliente(int dni)
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                              "password=gd2011;server=localhost\\SQLSERVER2005;" +
                              "database=GD1C2011; ");
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.cliente WHERE dni=" + dni
                    , sqlConnection);
                sqlConnection.Open();
                SqlDataReader dataReader = null;
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        txtApellido.Text = dataReader["apellido"].ToString();
                        txtNombre.Text = dataReader["nombre"].ToString();
                        txtDni.Text = dataReader["dni"].ToString();
                        txtMail.Text = dataReader["mail"].ToString();
                    }
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString(), "Error en la Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        void FillProvincias()
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                               "password=gd2011;server=localhost\\SQLSERVER2005;" +
                               "database=GD1C2011; ");
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.provincia", sqlConnection);
                sqlConnection.Open();
                SqlDataReader TheReader1 = sqlCommand.ExecuteReader();
                // Creamos un nuevo objeto DataTable
                DataTable dt = new DataTable();
                // Cargamos los datos del lector en el objeto DataTable
                dt.Load(TheReader1);
                // Configuramos el primer control ComboBox Provincias
                cmbProvincia.DataSource = dt;
                cmbProvincia.DisplayMember = "nombre";
                cmbProvincia.ValueMember = "id";
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString(), "Error en la Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
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
