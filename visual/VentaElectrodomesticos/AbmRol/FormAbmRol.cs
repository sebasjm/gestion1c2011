using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Vista;

namespace VentaElectrodomesticos.AbmRol
{
    public partial class FormAbmRol : Form
    {
        Validator validator;
        Rol rol = null;
        public FormAbmRol()
        {
            InitializeComponent();
            ViewHelper.fillFuncionalidades(chkListadoRoles);
            bModificar.Visible = false;
            bBorrar.Visible = false;
            lErrorNombre.Visible = false;
            lErrorRoles.Visible = false;
            validator = new Validator()
                .add(txtNombre, lErrorNombre, Validator.Text.obligatorio, Validator.Text.nombre)
//                .add(chkListadoRoles, lErrorRoles, Validator.sin_elementos )
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
                bCrear.Hide();
                if (form.rolesActivos)
                {
                    bModificar.Show();
                    bBorrar.Show();
                }
                else
                {
                    bBorrar.Show();
                    bBorrar.Text = "Habilitar";
                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    chkListadoRoles.Enabled = false;
                }
            }
        }
        private void cargarRol(Rol rol){
            this.limpiar();
            txtNombre.Text = rol.nombre;
            txtDescripcion.Text = rol.descripcion;
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
            bCrear.Visible = true;
            bCrearOtro.Visible = true;
            bModificar.Visible = false;
            bBorrar.Visible = false;
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false);
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            chkListadoRoles.Enabled = true;
            bCrearOtro.Show();
            bCrear.Show();
            bModificar.Hide();
            bBorrar.Hide();
            bBorrar.Text = "Borrar";
        }
        private void bCrearOtro_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Rol?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con el Guardado y la Creacion de otro
                create_from_form();
                limpiar();
            }
        }
        private void create_from_form(){
            // proceder con la creación del rol
                this.rol = new Rol(null);
                this.rol.nombre = txtNombre.Text;
                this.rol.descripcion = txtDescripcion.Text;
                Context.instance.dao.rol.insertar(this.rol);
                // cargo el nuevo rol en el objeto Form
                this.rol = Context.instance.dao.rol.findByNombre(this.rol.nombre);
                for (int i = 0; i < chkListadoRoles.Items.Count; ++i){
                    if (chkListadoRoles.GetItemChecked(i)) {
                        Context.instance.dao.rol_funcionalidad.insertar(this.rol, (Funcionalidad)chkListadoRoles.Items[i]);
                    }
                }
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear al Rol?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                create_from_form();
                limpiar();
                this.Close();
            }
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar el Rol?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.rol.nombre = txtNombre.Text;
                this.rol.descripcion = txtDescripcion.Text;
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
            if ("Habilitar".Equals(bBorrar.Text))
            {
                if (MessageBox.Show("¿Esta seguro que desea habilitar al Rol?", "Confirmar Habilitación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la habilitación
                    Context.instance.dao.rol.habilitar((Int32)rol.id);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Rol?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la eliminación
                    Context.instance.dao.rol.eliminar((Int32)rol.id);
                    this.Close();
                }
            }
        }
    }
}
