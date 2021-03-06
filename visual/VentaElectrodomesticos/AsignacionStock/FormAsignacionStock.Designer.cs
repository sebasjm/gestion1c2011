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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lProducto = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.lAuditor = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.bProducto = new System.Windows.Forms.Button();
            this.bAuditor = new System.Windows.Forms.Button();
            this.dataStock = new System.Windows.Forms.DataGridView();
            this.bAsignarOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.Label();
            this.txtAuditor = new System.Windows.Forms.Label();
            this.lErrorAuditor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).BeginInit();
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
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(73, 46);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(117, 21);
            this.cmbSucursal.TabIndex = 4;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // bProducto
            // 
            this.bProducto.Location = new System.Drawing.Point(204, 8);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(75, 23);
            this.bProducto.TabIndex = 6;
            this.bProducto.Text = "Buscar";
            this.bProducto.UseVisualStyleBackColor = true;
            this.bProducto.Click += new System.EventHandler(this.bProducto_Click);
            // 
            // bAuditor
            // 
            this.bAuditor.Location = new System.Drawing.Point(204, 81);
            this.bAuditor.Name = "bAuditor";
            this.bAuditor.Size = new System.Drawing.Size(75, 23);
            this.bAuditor.TabIndex = 7;
            this.bAuditor.Text = "Buscar";
            this.bAuditor.UseVisualStyleBackColor = true;
            this.bAuditor.Click += new System.EventHandler(this.bAuditor_Click);
            // 
            // dataStock
            // 
            this.dataStock.AllowUserToAddRows = false;
            this.dataStock.AllowUserToDeleteRows = false;
            this.dataStock.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataStock.Location = new System.Drawing.Point(19, 120);
            this.dataStock.MultiSelect = false;
            this.dataStock.Name = "dataStock";
            this.dataStock.RowHeadersVisible = false;
            this.dataStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStock.Size = new System.Drawing.Size(568, 259);
            this.dataStock.TabIndex = 8;
            // 
            // bAsignarOtro
            // 
            this.bAsignarOtro.Location = new System.Drawing.Point(431, 385);
            this.bAsignarOtro.Name = "bAsignarOtro";
            this.bAsignarOtro.Size = new System.Drawing.Size(75, 23);
            this.bAsignarOtro.TabIndex = 66;
            this.bAsignarOtro.Text = "Asignar Otro";
            this.bAsignarOtro.UseVisualStyleBackColor = true;
            this.bAsignarOtro.Click += new System.EventHandler(this.bAsignarOtro_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(100, 385);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 65;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(19, 385);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 64;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(512, 385);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 63;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(72, 12);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(117, 19);
            this.txtProducto.TabIndex = 67;
            // 
            // txtAuditor
            // 
            this.txtAuditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuditor.Location = new System.Drawing.Point(73, 81);
            this.txtAuditor.Name = "txtAuditor";
            this.txtAuditor.Size = new System.Drawing.Size(117, 19);
            this.txtAuditor.TabIndex = 68;
            // 
            // lErrorAuditor
            // 
            this.lErrorAuditor.AutoSize = true;
            this.lErrorAuditor.BackColor = System.Drawing.Color.Transparent;
            this.lErrorAuditor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorAuditor.ForeColor = System.Drawing.Color.Red;
            this.lErrorAuditor.Location = new System.Drawing.Point(285, 82);
            this.lErrorAuditor.Name = "lErrorAuditor";
            this.lErrorAuditor.Size = new System.Drawing.Size(22, 29);
            this.lErrorAuditor.TabIndex = 76;
            this.lErrorAuditor.Text = "*";
            this.lErrorAuditor.Visible = false;
            // 
            // FormAsignacionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.lErrorAuditor);
            this.Controls.Add(this.txtAuditor);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.bAsignarOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.dataStock);
            this.Controls.Add(this.bAuditor);
            this.Controls.Add(this.bProducto);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lAuditor);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsignacionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Stock";
            this.Load += new System.EventHandler(this.FormAsignacionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProducto;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label lAuditor;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button bProducto;
        private System.Windows.Forms.Button bAuditor;
        private System.Windows.Forms.DataGridView dataStock;
        private System.Windows.Forms.Button bAsignarOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label txtAuditor;
        private System.Windows.Forms.Label lErrorAuditor;
    }
}