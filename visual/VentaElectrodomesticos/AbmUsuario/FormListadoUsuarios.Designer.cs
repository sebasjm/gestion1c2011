namespace VentaElectrodomesticos.AbmUsuario
{
    partial class FormListadoUsuarios
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
            this.bBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lEmpleado = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.bBuscar = new System.Windows.Forms.Button();
            this.grpListadoRoles = new System.Windows.Forms.GroupBox();
            this.chkListadoRoles = new System.Windows.Forms.CheckedListBox();
            this.lNombreEmpleado = new System.Windows.Forms.Label();
            this.bSeleccionar = new System.Windows.Forms.Button();
            this.chkEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.grpListadoRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscarEmpleado
            // 
            this.bBuscarEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bBuscarEmpleado.Location = new System.Drawing.Point(332, 14);
            this.bBuscarEmpleado.Name = "bBuscarEmpleado";
            this.bBuscarEmpleado.Size = new System.Drawing.Size(101, 23);
            this.bBuscarEmpleado.TabIndex = 82;
            this.bBuscarEmpleado.Text = "Buscar Empleado";
            this.bBuscarEmpleado.UseVisualStyleBackColor = true;
            this.bBuscarEmpleado.Click += new System.EventHandler(this.bBuscarEmpleado_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(117, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 20);
            this.txtUsername.TabIndex = 80;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lUsername.Location = new System.Drawing.Point(9, 48);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(61, 13);
            this.lUsername.TabIndex = 79;
            this.lUsername.Text = "Username :";
            // 
            // lEmpleado
            // 
            this.lEmpleado.AutoSize = true;
            this.lEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lEmpleado.Location = new System.Drawing.Point(9, 15);
            this.lEmpleado.Name = "lEmpleado";
            this.lEmpleado.Size = new System.Drawing.Size(60, 13);
            this.lEmpleado.TabIndex = 78;
            this.lEmpleado.Text = "Empleado :";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(11, 404);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 86;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(95, 404);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 85;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.AllowUserToAddRows = false;
            this.dataUsuarios.AllowUserToDeleteRows = false;
            this.dataUsuarios.AllowUserToOrderColumns = true;
            this.dataUsuarios.AllowUserToResizeRows = false;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Location = new System.Drawing.Point(12, 233);
            this.dataUsuarios.MultiSelect = false;
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.ReadOnly = true;
            this.dataUsuarios.RowHeadersVisible = false;
            this.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsuarios.Size = new System.Drawing.Size(421, 165);
            this.dataUsuarios.TabIndex = 84;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(358, 204);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 83;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // grpListadoRoles
            // 
            this.grpListadoRoles.Controls.Add(this.chkListadoRoles);
            this.grpListadoRoles.Location = new System.Drawing.Point(12, 71);
            this.grpListadoRoles.Name = "grpListadoRoles";
            this.grpListadoRoles.Size = new System.Drawing.Size(421, 127);
            this.grpListadoRoles.TabIndex = 88;
            this.grpListadoRoles.TabStop = false;
            this.grpListadoRoles.Text = "Listado de Roles";
            // 
            // chkListadoRoles
            // 
            this.chkListadoRoles.FormattingEnabled = true;
            this.chkListadoRoles.Location = new System.Drawing.Point(7, 20);
            this.chkListadoRoles.Name = "chkListadoRoles";
            this.chkListadoRoles.Size = new System.Drawing.Size(408, 94);
            this.chkListadoRoles.TabIndex = 0;
            // 
            // lNombreEmpleado
            // 
            this.lNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNombreEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lNombreEmpleado.Location = new System.Drawing.Point(117, 14);
            this.lNombreEmpleado.Name = "lNombreEmpleado";
            this.lNombreEmpleado.Size = new System.Drawing.Size(209, 19);
            this.lNombreEmpleado.TabIndex = 89;
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(351, 404);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bSeleccionar.TabIndex = 90;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // chkEliminados
            // 
            this.chkEliminados.AutoSize = true;
            this.chkEliminados.Location = new System.Drawing.Point(12, 204);
            this.chkEliminados.Name = "chkEliminados";
            this.chkEliminados.Size = new System.Drawing.Size(76, 17);
            this.chkEliminados.TabIndex = 97;
            this.chkEliminados.Text = "Eliminados";
            this.chkEliminados.UseVisualStyleBackColor = true;
            // 
            // FormListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 437);
            this.Controls.Add(this.chkEliminados);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.lNombreEmpleado);
            this.Controls.Add(this.grpListadoRoles);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dataUsuarios);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBuscarEmpleado);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.lEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoUsuarios";
            this.Text = "Listado de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.grpListadoRoles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscarEmpleado;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lEmpleado;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.DataGridView dataUsuarios;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox grpListadoRoles;
        private System.Windows.Forms.CheckedListBox chkListadoRoles;
        private System.Windows.Forms.Label lNombreEmpleado;
        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.CheckBox chkEliminados;
    }
}