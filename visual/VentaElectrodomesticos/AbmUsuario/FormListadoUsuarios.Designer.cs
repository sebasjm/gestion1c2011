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
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lEmpleado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBuscar = new System.Windows.Forms.Button();
            this.grpListadoRoles = new System.Windows.Forms.GroupBox();
            this.chkListadoRoles = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpListadoRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscarEmpleado
            // 
            this.bBuscarEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bBuscarEmpleado.Location = new System.Drawing.Point(332, 10);
            this.bBuscarEmpleado.Name = "bBuscarEmpleado";
            this.bBuscarEmpleado.Size = new System.Drawing.Size(101, 23);
            this.bBuscarEmpleado.TabIndex = 82;
            this.bBuscarEmpleado.Text = "Buscar Empleado";
            this.bBuscarEmpleado.UseVisualStyleBackColor = true;
            this.bBuscarEmpleado.Click += new System.EventHandler(this.bBuscarEmpleado_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(117, 12);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(209, 21);
            this.cmbEmpleado.TabIndex = 81;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(117, 45);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(316, 20);
            this.tUsername.TabIndex = 80;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(11, 404);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 86;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(95, 404);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 85;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 165);
            this.dataGridView1.TabIndex = 84;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(358, 204);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 83;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
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
            this.chkListadoRoles.Items.AddRange(new object[] {
            "Analista",
            "Funcional",
            "Empleado"});
            this.chkListadoRoles.Location = new System.Drawing.Point(7, 20);
            this.chkListadoRoles.Name = "chkListadoRoles";
            this.chkListadoRoles.Size = new System.Drawing.Size(408, 94);
            this.chkListadoRoles.TabIndex = 0;
            // 
            // FormListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 437);
            this.Controls.Add(this.grpListadoRoles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bBuscarEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.lEmpleado);
            this.Name = "FormListadoUsuarios";
            this.Text = "FormListadoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpListadoRoles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscarEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox grpListadoRoles;
        private System.Windows.Forms.CheckedListBox chkListadoRoles;
    }
}