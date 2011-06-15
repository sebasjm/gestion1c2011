namespace VentaElectrodomesticos.AbmCliente
{
    partial class FormListadoClientes
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
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.grpFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lProvincia = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.chkEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.grpFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.AllowUserToResizeRows = false;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(9, 127);
            this.dataClientes.MultiSelect = false;
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(398, 207);
            this.dataClientes.TabIndex = 9;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(13, 342);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(320, 98);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 7;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(97, 342);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 6;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // grpFiltrosBusqueda
            // 
            this.grpFiltrosBusqueda.Controls.Add(this.cmbProvincia);
            this.grpFiltrosBusqueda.Controls.Add(this.lProvincia);
            this.grpFiltrosBusqueda.Controls.Add(this.txtDni);
            this.grpFiltrosBusqueda.Controls.Add(this.lDni);
            this.grpFiltrosBusqueda.Controls.Add(this.lApellido);
            this.grpFiltrosBusqueda.Controls.Add(this.lNombre);
            this.grpFiltrosBusqueda.Controls.Add(this.txtApellido);
            this.grpFiltrosBusqueda.Controls.Add(this.txtNombre);
            this.grpFiltrosBusqueda.Location = new System.Drawing.Point(9, 6);
            this.grpFiltrosBusqueda.Name = "grpFiltrosBusqueda";
            this.grpFiltrosBusqueda.Size = new System.Drawing.Size(398, 86);
            this.grpFiltrosBusqueda.TabIndex = 5;
            this.grpFiltrosBusqueda.TabStop = false;
            this.grpFiltrosBusqueda.Text = "Filtros Búsqueda de Cliente";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(265, 50);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 43;
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(202, 53);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(51, 13);
            this.lProvincia.TabIndex = 40;
            this.lProvincia.Text = "Provincia";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(265, 24);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(121, 20);
            this.txtDni.TabIndex = 39;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(204, 24);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(26, 13);
            this.lDni.TabIndex = 38;
            this.lDni.Text = "DNI";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(35, 50);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 37;
            this.lApellido.Text = "Apellido";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(35, 23);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 36;
            this.lNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(89, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(332, 342);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bSeleccionar.TabIndex = 10;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // chkEliminados
            // 
            this.chkEliminados.AutoSize = true;
            this.chkEliminados.Location = new System.Drawing.Point(9, 98);
            this.chkEliminados.Name = "chkEliminados";
            this.chkEliminados.Size = new System.Drawing.Size(76, 17);
            this.chkEliminados.TabIndex = 44;
            this.chkEliminados.Text = "Eliminados";
            this.chkEliminados.UseVisualStyleBackColor = true;
            // 
            // FormListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 387);
            this.Controls.Add(this.chkEliminados);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.grpFiltrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormListadoClientes";
            this.Text = "Listado de Selección de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.grpFiltrosBusqueda.ResumeLayout(false);
            this.grpFiltrosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.GroupBox grpFiltrosBusqueda;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.CheckBox chkEliminados;
    }
}