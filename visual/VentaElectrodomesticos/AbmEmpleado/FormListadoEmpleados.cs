using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.AbmEmpleado
{
    public partial class FormListadoEmpleados : Form
    {

        private long messageFromParent;
        public long MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        private string nombre;
        private string apellido;
        private long dni = -1;
        private long sucursal_id = -1 ;
        private long provincia_id = -1;
        private long tipoempleado_id = -1;
        public FormListadoEmpleados(){
            InitializeComponent();
            cmbSucursal.Items.Insert(0, "Todos los Resultados");
            cmbProvincia.Items.Insert(0, "Todos los Resultados");
            cmbTipoEmpleado.Items.Insert(0, "Todos los Resultados");
            FillData();
            FillProvincias();
            FillSucursal();
            FillTipoEmpleado();
        }
        void FillData()
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                              "password=gd2011;server=localhost\\SQLSERVER2005;" +
                              "database=GD1C2011; ");
            try
            {
                String strDNI = (this.dni >= 0) ? strDNI = " AND dni=" + this.dni : "";
                String strSucursal = (this.sucursal_id >= 0) ? strSucursal = " AND sucursal_id=" + this.sucursal_id : "";
                String strTipoEmpleado = (this.tipoempleado_id >= 0) ? strTipoEmpleado = " AND tipoempleado_id=" + tipoempleado_id : "";
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.empleado WHERE " +
                    "  activo = 1 AND " +
                    "  LOWER(nombre) like  LOWER('%" +nombre+ "%') AND" +
                    "  LOWER(apellido) like  LOWER('%" +apellido+"%')" +
                    strDNI + strSucursal + strTipoEmpleado
                    , sqlConnection);
               /* MessageBox.Show("SELECT * FROM la_huerta.empleado WHERE " +
                    "  activo = 1 AND " +
                    "  LOWER(nombre) like  LOWER('%" +nombre+ "%') AND" +
                    "  LOWER(apellido) like  LOWER('%" +apellido+"%')" +
                    strDNI + strSucursal + strTipoEmpleado);*/
                sqlConnection.Open();
                DataSet ds1 = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(sqlCommand);
                adp1.Fill(ds1, "customer");
                dataEmpleados.DataSource = ds1;
                dataEmpleados.DataMember = "customer";
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
               /*                DataRow emptyRow = dt.NewRow();
                               emptyRow["nombre"] = "";
                               emptyRow["id"] = -1;
                               dt.Rows.Add(emptyRow); */
               cmbProvincia.DataSource = dt;
               cmbProvincia.DisplayMember = "nombre";
               cmbProvincia.ValueMember = "id";
               cmbProvincia.SelectedIndex = -1;
               sqlConnection.Close();
           }
           catch (NullReferenceException) { }
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
        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            this.sucursal_id = (cmbSucursal.SelectedItem != null) ? long.Parse(((DataRowView)cmbSucursal.SelectedItem)["id"].ToString()) : -1 ;
            this.tipoempleado_id = (cmbTipoEmpleado.SelectedItem != null) ? long.Parse(((DataRowView)cmbTipoEmpleado.SelectedItem)["id"].ToString()) : -1;
            this.dni = (txtDni.Text != "") ? long.Parse(txtDni.Text) : -1;
            FillData();
        }
        private void bSeleccionar_Click_1(object sender, EventArgs e)
        {
            long dni = long.Parse(dataEmpleados["dni", dataEmpleados.CurrentRow.Index].Value.ToString());
            this.messageFromParent = dni;
            this.Close();
        }
        void FillSucursal()
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                               "password=gd2011;server=localhost\\SQLSERVER2005;" +
                               "database=GD1C2011; ");
            try
            {
                string provincia =  ( this.provincia_id >= 0 ) ? " WHERE provincia_id = " + this.provincia_id : "" ;
                 SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.sucursal" + provincia, sqlConnection);
                sqlConnection.Open();
                SqlDataReader TheReader1 = sqlCommand.ExecuteReader();
                // Creamos un nuevo objeto DataTable
                DataTable dt = new DataTable();
                // Cargamos los datos del lector en el objeto DataTable
                dt.Load(TheReader1);
                // Configuramos el primer control ComboBox Provincias
                cmbSucursal.DataSource = dt;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "id";
                cmbSucursal.SelectedIndex = -1;
                sqlConnection.Close();
            }
            catch (NullReferenceException) { }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString(), "Error en la Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
        void FillTipoEmpleado()
        {
            SqlConnection sqlConnection = new SqlConnection("user id=gd;" +
                               "password=gd2011;server=localhost\\SQLSERVER2005;" +
                               "database=GD1C2011; ");
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM la_huerta.tipoempleado", sqlConnection);
                sqlConnection.Open();
                SqlDataReader TheReader1 = sqlCommand.ExecuteReader();
                // Creamos un nuevo objeto DataTable
                DataTable dt = new DataTable();
                // Cargamos los datos del lector en el objeto DataTable
                dt.Load(TheReader1);
                // Configuramos el primer control ComboBox Provincias
                cmbTipoEmpleado.DataSource = dt;
                cmbTipoEmpleado.DisplayMember = "nombre";
                cmbTipoEmpleado.ValueMember = "id";
                cmbTipoEmpleado.SelectedIndex = -1;
                sqlConnection.Close();
            }
            catch (NullReferenceException) { }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString(), "Error en la Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.provincia_id = (cmbProvincia.SelectedItem != null) ? long.Parse(((DataRowView)cmbProvincia.SelectedItem)["id"].ToString()) : -1;
            FillSucursal();
        }

    }
}
