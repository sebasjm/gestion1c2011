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

namespace VentaElectrodomesticos.TableroControl
{
    public partial class FormTableroControl : Form
    {
        public FormTableroControl()
        {
            InitializeComponent();
            fillAnios();
            fillSucursal();
        }
        private void fillAnios()
        {
            for (int n = 1995; n <= 2100; n++)
            {
                cmbAnioAnalizar.Items.Add(n);
            }
        }
        void fillSucursal()
        {
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.load();
            try
            {
                cmbSucursal.DataSource = sucursalList;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
