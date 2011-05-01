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
    public partial class FormListadoClientes : Form
    {
        private int messageFromParent;
        public int MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        private string nombre;
        private string apellido;
        private int dni;

        public FormListadoClientes()
        {
            InitializeComponent();
            FillData();
            FillProvincias();
        }

        void FillData()
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                              "password=gd2011;server=localhost\\SQLSERVER2005;" +
                              "database=GD1C2011; ");
            try
            {

                String strDNI = "";
                if (dni != 0){ strDNI = " AND dni=" + dni  ; }
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.cliente WHERE " +
                    "  LOWER(nombre) like  LOWER('%" +nombre+ "%') AND" +
                    "  LOWER(apellido) like  LOWER('%" +apellido+"%')" +
                    strDNI
                    , sqlConnection);
                sqlConnection.Open();
                DataSet ds1 = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(sqlCommand);
                adp1.Fill(ds1, "customer");
                dataClientes.DataSource = ds1;
                dataClientes.DataMember = "customer";
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
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = -1;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.messageFromParent = 0;
            this.Close();
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            int dni =  System.Int32.Parse(dataClientes["dni", dataClientes.CurrentRow.Index].Value.ToString());
            this.messageFromParent = dni;
            this.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            if (txtDni.Text == "") { this.dni = 0; }
            else {
            this.dni = System.Int32.Parse(txtDni.Text);}
            FillData();
        }
   }
}
