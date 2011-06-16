namespace VentaElectrodomesticos.AbmRol
{
    partial class FormListadoRoles
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.chkListadoRoles = new System.Windows.Forms.CheckedListBox();
            this.labelRoles = new System.Windows.Forms.Label();
            this.dataRoles = new System.Windows.Forms.DataGridView();
            this.chkEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(265, 328);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bSeleccionar.TabIndex = 84;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(11, 328);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 83;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(95, 328);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 82;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(265, 190);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 80;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 20);
            this.txtNombre.TabIndex = 87;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(15, 19);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 86;
            this.lNombre.Text = "Nombre";
            // 
            // chkListadoRoles
            // 
            this.chkListadoRoles.FormattingEnabled = true;
            this.chkListadoRoles.Location = new System.Drawing.Point(18, 60);
            this.chkListadoRoles.Name = "chkListadoRoles";
            this.chkListadoRoles.Size = new System.Drawing.Size(322, 124);
            this.chkListadoRoles.TabIndex = 88;
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(156, 44);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(34, 13);
            this.labelRoles.TabIndex = 89;
            this.labelRoles.Text = "Roles";
            // 
            // dataRoles
            // 
            this.dataRoles.AllowUserToAddRows = false;
            this.dataRoles.AllowUserToDeleteRows = false;
            this.dataRoles.AllowUserToResizeRows = false;
            this.dataRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRoles.Location = new System.Drawing.Point(18, 217);
            this.dataRoles.MultiSelect = false;
            this.dataRoles.Name = "dataRoles";
            this.dataRoles.ReadOnly = true;
            this.dataRoles.RowHeadersVisible = false;
            this.dataRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRoles.Size = new System.Drawing.Size(321, 102);
            this.dataRoles.TabIndex = 90;
            // 
            // chkEliminados
            // 
            this.chkEliminados.AutoSize = true;
            this.chkEliminados.Location = new System.Drawing.Point(18, 196);
            this.chkEliminados.Name = "chkEliminados";
            this.chkEliminados.Size = new System.Drawing.Size(76, 17);
            this.chkEliminados.TabIndex = 97;
            this.chkEliminados.Text = "Eliminados";
            this.chkEliminados.UseVisualStyleBackColor = true;
            // 
            // FormListadoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 370);
            this.Controls.Add(this.chkEliminados);
            this.Controls.Add(this.dataRoles);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.chkListadoRoles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoRoles";
            this.Text = "Listado de Selección de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.CheckedListBox chkListadoRoles;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.DataGridView dataRoles;
        private System.Windows.Forms.CheckBox chkEliminados;
    }
}