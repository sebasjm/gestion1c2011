﻿namespace VentaElectrodomesticos.AsignacionStock
{
    partial class FormAsignacionStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lProducto = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.lAuditor = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbAuditor = new System.Windows.Forms.ComboBox();
            this.bProducto = new System.Windows.Forms.Button();
            this.bAuditor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAsignarOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lProducto
            // 
            this.lProducto.AutoSize = true;
            this.lProducto.Location = new System.Drawing.Point(13, 13);
            this.lProducto.Name = "lProducto";
            this.lProducto.Size = new System.Drawing.Size(53, 13);
            this.lProducto.TabIndex = 0;
            this.lProducto.Text = "Producto:";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(12, 46);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 1;
            this.lSucursal.Text = "Sucursal:";
            // 
            // lAuditor
            // 
            this.lAuditor.AutoSize = true;
            this.lAuditor.Location = new System.Drawing.Point(16, 82);
            this.lAuditor.Name = "lAuditor";
            this.lAuditor.Size = new System.Drawing.Size(43, 13);
            this.lAuditor.TabIndex = 2;
            this.lAuditor.Text = "Auditor:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(73, 13);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 3;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(73, 46);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 4;
            // 
            // cmbAuditor
            // 
            this.cmbAuditor.FormattingEnabled = true;
            this.cmbAuditor.Location = new System.Drawing.Point(73, 82);
            this.cmbAuditor.Name = "cmbAuditor";
            this.cmbAuditor.Size = new System.Drawing.Size(121, 21);
            this.cmbAuditor.TabIndex = 5;
            // 
            // bProducto
            // 
            this.bProducto.Location = new System.Drawing.Point(215, 13);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(75, 23);
            this.bProducto.TabIndex = 6;
            this.bProducto.Text = "Buscar";
            this.bProducto.UseVisualStyleBackColor = true;
            // 
            // bAuditor
            // 
            this.bAuditor.Location = new System.Drawing.Point(215, 82);
            this.bAuditor.Name = "bAuditor";
            this.bAuditor.Size = new System.Drawing.Size(75, 23);
            this.bAuditor.TabIndex = 7;
            this.bAuditor.Text = "Buscar";
            this.bAuditor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(19, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // bAsignarOtro
            // 
            this.bAsignarOtro.Location = new System.Drawing.Point(206, 276);
            this.bAsignarOtro.Name = "bAsignarOtro";
            this.bAsignarOtro.Size = new System.Drawing.Size(75, 23);
            this.bAsignarOtro.TabIndex = 66;
            this.bAsignarOtro.Text = "Asignar Otro";
            this.bAsignarOtro.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(110, 276);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 65;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(16, 276);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 64;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(306, 276);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 63;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // FormAsignacionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 312);
            this.Controls.Add(this.bAsignarOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAuditor);
            this.Controls.Add(this.bProducto);
            this.Controls.Add(this.cmbAuditor);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lAuditor);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProducto);
            this.Name = "FormAsignacionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProducto;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label lAuditor;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbAuditor;
        private System.Windows.Forms.Button bProducto;
        private System.Windows.Forms.Button bAuditor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button bAsignarOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
    }
}