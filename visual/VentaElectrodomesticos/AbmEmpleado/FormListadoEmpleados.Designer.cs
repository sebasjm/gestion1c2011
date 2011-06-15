namespace VentaElectrodomesticos.AbmEmpleado
{
    partial class FormListadoEmpleados
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
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.grpFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lTipoEmpleado = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.lProvincia = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.chkEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
            this.grpFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEmpleados
            // 
            this.dataEmpleados.AllowUserToAddRows = false;
            this.dataEmpleados.AllowUserToDeleteRows = false;
            this.dataEmpleados.AllowUserToOrderColumns = true;
            this.dataEmpleados.AllowUserToResizeRows = false;
            this.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleados.Location = new System.Drawing.Point(14, 167);
            this.dataEmpleados.MultiSelect = false;
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.ReadOnly = true;
            this.dataEmpleados.RowHeadersVisible = false;
            this.dataEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmpleados.Size = new System.Drawing.Size(847, 207);
            this.dataEmpleados.TabIndex = 4;
            // 
            // grpFiltrosBusqueda
            // 
            this.grpFiltrosBusqueda.Controls.Add(this.cmbTipoEmpleado);
            this.grpFiltrosBusqueda.Controls.Add(this.cmbSucursal);
            this.grpFiltrosBusqueda.Controls.Add(this.cmbProvincia);
            this.grpFiltrosBusqueda.Controls.Add(this.lTipoEmpleado);
            this.grpFiltrosBusqueda.Controls.Add(this.lSucursal);
            this.grpFiltrosBusqueda.Controls.Add(this.lProvincia);
            this.grpFiltrosBusqueda.Controls.Add(this.txtDni);
            this.grpFiltrosBusqueda.Controls.Add(this.lDni);
            this.grpFiltrosBusqueda.Controls.Add(this.lApellido);
            this.grpFiltrosBusqueda.Controls.Add(this.lNombre);
            this.grpFiltrosBusqueda.Controls.Add(this.txtApellido);
            this.grpFiltrosBusqueda.Controls.Add(this.txtNombre);
            this.grpFiltrosBusqueda.Location = new System.Drawing.Point(13, 13);
            this.grpFiltrosBusqueda.Name = "grpFiltrosBusqueda";
            this.grpFiltrosBusqueda.Size = new System.Drawing.Size(492, 119);
            this.grpFiltrosBusqueda.TabIndex = 0;
            this.grpFiltrosBusqueda.TabStop = false;
            this.grpFiltrosBusqueda.Text = "Filtros Búsqueda de Empleado";
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(336, 77);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEmpleado.TabIndex = 45;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbSucursal.Location = new System.Drawing.Point(336, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 44;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(336, 20);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 43;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // lTipoEmpleado
            // 
            this.lTipoEmpleado.AutoSize = true;
            this.lTipoEmpleado.Location = new System.Drawing.Point(227, 84);
            this.lTipoEmpleado.Name = "lTipoEmpleado";
            this.lTipoEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lTipoEmpleado.TabIndex = 42;
            this.lTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(227, 53);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(48, 13);
            this.lSucursal.TabIndex = 41;
            this.lSucursal.Text = "Sucursal";
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(227, 23);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(51, 13);
            this.lProvincia.TabIndex = 40;
            this.lProvincia.Text = "Provincia";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(106, 77);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 39;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(35, 77);
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
            this.txtApellido.Location = new System.Drawing.Point(106, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(430, 138);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(787, 380);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bSeleccionar.TabIndex = 13;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(13, 380);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 12;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(97, 380);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 11;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // chkEliminados
            // 
            this.chkEliminados.AutoSize = true;
            this.chkEliminados.Location = new System.Drawing.Point(751, 19);
            this.chkEliminados.Name = "chkEliminados";
            this.chkEliminados.Size = new System.Drawing.Size(75, 17);
            this.chkEliminados.TabIndex = 14;
            this.chkEliminados.Text = "eliminados";
            this.chkEliminados.UseVisualStyleBackColor = true;
            // 
            // FormListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 417);
            this.Controls.Add(this.chkEliminados);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dataEmpleados);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.grpFiltrosBusqueda);
            this.Name = "FormListadoEmpleados";
            this.Text = "Listado de Selección de Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
            this.grpFiltrosBusqueda.ResumeLayout(false);
            this.grpFiltrosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltrosBusqueda;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lTipoEmpleado;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.DataGridView dataEmpleados;
        private System.Windows.Forms.CheckBox chkEliminados;
    }
}