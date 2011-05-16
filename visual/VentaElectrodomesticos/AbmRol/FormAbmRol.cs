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
        ValidatorHelper validator;
        Rol rol = null;
        public FormAbmRol()
        {
            InitializeComponent();
            ViewHelper.fillFuncionalidades(chkListadoRoles);
            bModificar.Visible = false;
            bBorrar.Visible = false;
            lErrorNombre.Visible = false;
            lErrorRoles.Visible = false;
            validator = new ValidatorHelper()
                .add(txtNombre, lErrorNombre, ValidatorHelper.vacio, ValidatorHelper.nombre)
                .add(chkListadoRoles, lErrorRoles, ValidatorHelper.sin_elementos )
                ;
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
            this.rol = rol;
            List < Funcionalidad >  func = this.rol.funcionalidades;

            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
            {
                Funcionalidad funca = (Funcionalidad)chkListadoRoles.Items[i];
                List<Funcionalidad> results = func.FindAll(
                    delegate(Funcionalidad p) { return p.id == funca.id; }

                    );
                if (results.Count > 0)
                {
                    chkListadoRoles.SetItemChecked(i, true);
                }
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
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear al Rol?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creación del rol
                this.rol = new Rol(null);
                this.rol.nombre = txtNombre.Text;
                this.rol.descripcion = txtNombre.Text;
                Context.instance.dao.rol.insertar(this.rol);
                // cargo el nuevo rol en el objeto Form
                this.rol = Context.instance.dao.rol.findByNombre(this.rol.nombre);
                for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                    if (chkListadoRoles.GetItemChecked(i))
                    {
                        Context.instance.dao.rol_funcionalidad.insertar(this.rol , (Funcionalidad)chkListadoRoles.Items[i]);
                    }
                    else {
                        Context.instance.dao.rol_funcionalidad.delete(this.rol, (Funcionalidad)chkListadoRoles.Items[i]);
                    }
                this.Close();
            }
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar el Rol?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.rol.nombre = txtNombre.Text;
                this.rol.descripcion = txtNombre.Text;
                Context.instance.dao.rol.modificar(this.rol);
                Context.instance.dao.rol.limpiarFuncionalidades(this.rol);
                for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                    if (chkListadoRoles.GetItemChecked(i))
                    {
                        Context.instance.dao.rol_funcionalidad.insertar(this.rol, (Funcionalidad)chkListadoRoles.Items[i]);
                    }
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
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Rol?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
            }
        }
    }
}
