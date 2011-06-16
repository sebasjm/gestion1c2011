namespace VentaElectrodomesticos.AbmRol
{
    partial class FormAbmRol
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
            this.lNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkListadoRoles = new System.Windows.Forms.CheckedListBox();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lErrorNombre = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.lErrorRoles = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(12, 48);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 45);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // chkListadoRoles
            // 
            this.chkListadoRoles.FormattingEnabled = true;
            this.chkListadoRoles.Location = new System.Drawing.Point(15, 110);
            this.chkListadoRoles.Name = "chkListadoRoles";
            this.chkListadoRoles.Size = new System.Drawing.Size(322, 124);
            this.chkListadoRoles.TabIndex = 2;
            // 
            // bCrearOtro
            // 
            this.bCrearOtro.Location = new System.Drawing.Point(222, 269);
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.Size = new System.Drawing.Size(116, 23);
            this.bCrearOtro.TabIndex = 76;
            this.bCrearOtro.Text = "Crear y Continuar";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            this.bCrearOtro.Click += new System.EventHandler(this.bCrearOtro_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(12, 269);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(58, 23);
            this.bLimpiar.TabIndex = 75;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(12, 240);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(58, 23);
            this.bCancelar.TabIndex = 74;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(222, 240);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(116, 23);
            this.bCrear.TabIndex = 73;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(15, 12);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(100, 22);
            this.bBuscar.TabIndex = 77;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lErrorNombre
            // 
            this.lErrorNombre.AutoSize = true;
            this.lErrorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lErrorNombre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lErrorNombre.Location = new System.Drawing.Point(315, 45);
            this.lErrorNombre.Name = "lErrorNombre";
            this.lErrorNombre.Size = new System.Drawing.Size(22, 29);
            this.lErrorNombre.TabIndex = 78;
            this.lErrorNombre.Text = "*";
            this.lErrorNombre.Visible = false;
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(76, 240);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(58, 23);
            this.bBorrar.TabIndex = 79;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(221, 240);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(116, 23);
            this.bModificar.TabIndex = 80;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // lErrorRoles
            // 
            this.lErrorRoles.AutoSize = true;
            this.lErrorRoles.BackColor = System.Drawing.Color.Transparent;
            this.lErrorRoles.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorRoles.ForeColor = System.Drawing.Color.Red;
            this.lErrorRoles.Location = new System.Drawing.Point(343, 151);
            this.lErrorRoles.Name = "lErrorRoles";
            this.lErrorRoles.Size = new System.Drawing.Size(22, 29);
            this.lErrorRoles.TabIndex = 81;
            this.lErrorRoles.Text = "*";
            this.lErrorRoles.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(76, 71);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 20);
            this.txtDescripcion.TabIndex = 83;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(12, 74);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 82;
            this.lDescripcion.Text = "Descripcion";
            // 
            // FormAbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 313);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lErrorRoles);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lErrorNombre);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.chkListadoRoles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.FormAbmRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckedListBox chkListadoRoles;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lErrorNombre;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Label lErrorRoles;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
    }
}