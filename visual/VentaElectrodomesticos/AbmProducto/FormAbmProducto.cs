﻿using System;
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
using VentaElectrodomesticos.Vista;
namespace VentaElectrodomesticos.AbmProducto
{
    public partial class FormAbmProducto : Form
    {
        List<Categoria> items = new List<Categoria>();
        Validator validator;
        Categoria categoria = null;
        Producto producto;
        public FormAbmProducto()        {
            InitializeComponent();
            buildtree();
            bBorrar.Visible = false;
            bModificar.Visible = false;
            validator = new Validator()
                .add(txtCodigoProducto, lErrorCodigo, Validator.Text.obligatorio, Validator.Text.numerico)
                .add(txtDescripcion, lErrorDescripcion, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtNombre, lErrorNombre, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(treeCategorias, lErrorCategoria, Validator.Tree.obligatorio)
                .add(txtPrecio, lErrorPrecio, Validator.Text.obligatorio, Validator.Text.numerico);
            ViewHelper.fillComboMarcas(cmbMarcas);
            txtCodigoProducto.Text = "" + Context.instance.dao.producto.findNextId();
        }

        private void buildtree() {
            this.items = Context.instance.dao.categoria.load();
            ViewHelper.fillTreeViewCategorias(treeCategorias, this.items);

        }
        private void bBuscar_Click(object sender, EventArgs e)        {
            FormListadoProductos form = new FormListadoProductos();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarProducto((Producto)form.MessageFromParent);
                bCrearOtro.Hide();
                bBorrar.Visible = true;
                bModificar.Visible = true;
                bCrear.Visible = false;
            }
        }
        private void cargarProducto(Producto prod) {
            this.limpiar();
            this.producto = prod;
            txtCodigoProducto.Text = "" + prod.codigo;
            txtDescripcion.Text = prod.descripcion;
            txtNombre.Text = prod.nombre;
            txtPrecio.Text = "" + prod.precio;
           /* Categoria cate = null;
            foreach (TreeNode node in treeCategorias.Nodes)
            {
                cate = (Categoria)node.Tag;
                if (cate.id == prod.categoria_id)
                {
                    treeCategorias.SelectedNode = node;
                }
            }*/
            TreeNode nodo = llamadaRecursivaSeleccionarCategoria(prod.categoria_id);
            treeCategorias.Select();
            labelCategoria.Text = ((Categoria)nodo.Tag).nombre;
        }
        private TreeNode buscarCategoria(TreeNode treeNode, int id_seleccionado)
        {
            Categoria cate = (Categoria)treeNode.Tag;
            if (cate.id == id_seleccionado)
            {
                treeCategorias.SelectedNode = treeNode;
                return treeNode;
            }
            else { 
            foreach (TreeNode tn in treeNode.Nodes)
            {
                TreeNode nodo = buscarCategoria(tn, id_seleccionado);
                if (nodo != null)
                {
                    return nodo;
                }
            }
            return null;
            }
        }
        private TreeNode llamadaRecursivaSeleccionarCategoria(int categoria)
        {
            foreach (TreeNode n in treeCategorias.Nodes)
            {
               TreeNode nodo = buscarCategoria(n ,categoria);
               if (nodo != null) {
                   return nodo;
               }
            }
            return null;
        }
        private void treeCategorias_AfterSelect(object sender, TreeViewEventArgs e)        {
            TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
            if (NodoSeleccionado != null)
            {
                this.categoria = (Categoria)NodoSeleccionado.Tag;
                labelCategoria.Text = categoria.nombre;
            }
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!this.validar()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar el Producto?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la modificacion
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                short marca_id = this.gestorMarcas();
                if (marca_id == 0) return;
                this.producto.nombre = txtNombre.Text;
                this.producto.marca_id = marca_id;
                this.producto.descripcion = txtDescripcion.Text;
                this.producto.categoria_id = (cate == null) ? this.producto.categoria_id : cate.id;
                this.producto.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.modificar(this.producto);
                this.Close();
            }
        }
        private void bBorrar_Click(object sender, EventArgs e)        {
            if (!this.validar()) return;
            if (MessageBox.Show("¿Esta seguro que desea borrar el Producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la eliminacion del producto
                Context.instance.dao.producto.eliminar(Int32.Parse(txtCodigoProducto.Text));
                this.Close();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)        {
            this.Close();
        }
        private bool validar() {
            if (((cmbMarcas.SelectedIndex != 0) && (txtMarca.Text == "")) ||
                ((cmbMarcas.SelectedIndex == 0) && (txtMarca.Text != "")) ||
                ((cmbMarcas.SelectedIndex == null) && (txtMarca.Text != ""))
                )
            {
                lErrorMarca.Hide();
            }
            else {
                lErrorMarca.Show();
            }
            return (validator.check())&&(
                ((cmbMarcas.SelectedIndex != 0) && (txtMarca.Text == "")) ||
                ((cmbMarcas.SelectedIndex == 0) && (txtMarca.Text != "")) ||
                ((cmbMarcas.SelectedIndex == null) && (txtMarca.Text != ""))
                );
        }
        private short gestorMarcas() {
            short marca_id = 0;
            if (((cmbMarcas.SelectedIndex == 0) && (txtMarca.Text != "")) ||
                ((cmbMarcas.SelectedIndex == null) && (txtMarca.Text != "")))
            {
                Marca marca = Context.instance.dao.marca.findByNombre(txtMarca.Text);
                if (marca == null)
                {
                    if (MessageBox.Show("¿Esta seguro que desea crear la Marca?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // proceder con la creación de la marca
                        Context.instance.dao.marca.insertar( txtMarca.Text);
                    }
                    else
                    {
                       return 0;
                    }
                }
            }
            if (((cmbMarcas.SelectedIndex == 0) && (txtMarca.Text != "")) ||
                ((cmbMarcas.SelectedIndex == null) && (txtMarca.Text != "")))
            {
                Marca marca = Context.instance.dao.marca.findByNombre(txtMarca.Text);
                marca_id = (short)marca.id;
            }
            if ((cmbMarcas.SelectedIndex != 0) && (txtMarca.Text == ""))
            {
                marca_id = (short)cmbMarcas.SelectedIndex;
            }
            return marca_id;
        }
        private void bCrear_Click(object sender, EventArgs e)        {
            if (!this.validar()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear el Producto?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creacion del producto
                Producto productoNew = new Producto(Int32.Parse(txtCodigoProducto.Text));
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                short marca_id  = this.gestorMarcas() ;
                if(marca_id == 0) return;
                productoNew.nombre = txtNombre.Text;
                productoNew.descripcion = txtDescripcion.Text;
                productoNew.categoria_id = cate.id;
                productoNew.marca_id = marca_id;
                productoNew.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.insertar(productoNew);
                this.Close();
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)        {
            this.limpiar();
            bCrear.Visible = true;
            bCrearOtro.Visible = true;
            bModificar.Visible = false;
            bBorrar.Visible = false;
        }
        private void limpiar() {
            txtCodigoProducto.Text = "" + Context.instance.dao.producto.findNextId();
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            labelCategoria.Text = "";
            txtPrecio.Text = "";
            treeCategorias.CollapseAll();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            if (!this.validar()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Producto?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
                Producto productoNew = new Producto(Int32.Parse(txtCodigoProducto.Text));
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                short marca_id = this.gestorMarcas();
                if (marca_id == 0) return;
                productoNew.nombre = txtNombre.Text;
                productoNew.descripcion = txtDescripcion.Text;
                productoNew.categoria_id = cate.id;
                productoNew.marca_id = marca_id;
                productoNew.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.insertar(productoNew);
                this.limpiar();
            }
        }
    }
}
