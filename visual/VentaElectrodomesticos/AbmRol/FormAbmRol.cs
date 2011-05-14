﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmRol
{
    public partial class FormAbmRol : Form
    {
        public FormAbmRol()
        {
            InitializeComponent();
            fillPermisos();
            bModificar.Visible = false;
            bBorrar.Visible = false;
            lErrorNombre.Visible = false;
            lErrorRoles.Visible = false;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoRoles form = new FormListadoRoles();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarRol((Rol)form.MessageFromParent);
                bCrearOtro.Hide();
                bLimpiar.Visible = false;
                bCrear.Visible = false;
                bModificar.Visible = true;
                bBorrar.Visible = true;
            }
        }
        private void cargarRol(Rol rol){
            this.limpiar();
            txtNombre.Text = rol.nombre;
        }
        private void fillPermisos()
        {
            List<string> permisos = new List<string>();
            permisos.Add("ABM de Empleado");
            permisos.Add("ABM de Rol");
            permisos.Add("ABM de Usuario");
            permisos.Add("ABM de Cliente");
            permisos.Add("ABM de Producto");
            permisos.Add("Asignación de stock");
            permisos.Add("Facturación");
            permisos.Add("Efectuar Pago");
            permisos.Add("Tablero de Control");
            permisos.Add("Clientes Premium");
            permisos.Add("Mejores Categorías");
            for (int n = 0; n < permisos.Count; n++)
            {
                chkListadoRoles.Items.Add(permisos[n]);
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        private void limpiar() {
            this.txtNombre.Text = "";
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false); 
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            this.validadCampos();
            if (MessageBox.Show("¿Esta seguro que desea modificar al Rol?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la modificacion
                this.Close();
            }
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            this.validadCampos();
            if (MessageBox.Show("¿Esta seguro que desea modificar el Rol?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.Close();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea borrar el Rol?", "Confirmar Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la modificacion
            }
        }
        private bool validadCampos()
        {
            // TODO : Ver como cargar el objeto empleado
            ValidarHelper validador = new ValidarHelper();
            validador.validarCampo(txtNombre, lErrorNombre, "Nombre");
            validador.validarCampo(chkListadoRoles, lErrorRoles, "Roles");
            return validador.getEstado();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            this.validadCampos();
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Rol?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
            }
        }
    }
}
