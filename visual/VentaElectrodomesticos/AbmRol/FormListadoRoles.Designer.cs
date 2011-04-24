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
            this.lRoles = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Location = new System.Drawing.Point(265, 243);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bSeleccionar.TabIndex = 84;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(11, 243);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 83;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(95, 243);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 82;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(265, 42);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 80;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // lRoles
            // 
            this.lRoles.FormattingEnabled = true;
            this.lRoles.Items.AddRange(new object[] {
            "Analista",
            "Vendedor",
            "Administrador"});
            this.lRoles.Location = new System.Drawing.Point(12, 82);
            this.lRoles.Name = "lRoles";
            this.lRoles.Size = new System.Drawing.Size(328, 147);
            this.lRoles.TabIndex = 85;
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
            // FormListadoRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 282);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lRoles);
            this.Controls.Add(this.bSeleccionar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bBuscar);
            this.Name = "FormListadoRoles";
            this.Text = "Listado de Selección de Roles";
            this.Load += new System.EventHandler(this.FormListadoRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSeleccionar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ListBox lRoles;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
    }
}