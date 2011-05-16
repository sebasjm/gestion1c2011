namespace VentaElectrodomesticos.AbmCliente
{
    partial class FormAbmCliente
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lProvincia = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lErrorNombre = new System.Windows.Forms.Label();
            this.lErrorApellido = new System.Windows.Forms.Label();
            this.lErrorDNI = new System.Windows.Forms.Label();
            this.lErrorMail = new System.Windows.Forms.Label();
            this.lErrorTelefono = new System.Windows.Forms.Label();
            this.lErrorProvincia = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lErrorDireccion = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(18, 175);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(94, 23);
            this.bCancelar.TabIndex = 44;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(332, 175);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(105, 23);
            this.bCrear.TabIndex = 43;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(293, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(293, 56);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(121, 20);
            this.txtMail.TabIndex = 40;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(293, 110);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 37;
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(222, 113);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(51, 13);
            this.lProvincia.TabIndex = 34;
            this.lProvincia.Text = "Provincia";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(222, 84);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 33;
            this.lTelefono.Text = "Teléfono";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(222, 56);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(26, 13);
            this.lMail.TabIndex = 32;
            this.lMail.Text = "Mail";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(87, 110);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 31;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(16, 110);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(26, 13);
            this.lDni.TabIndex = 30;
            this.lDni.Text = "DNI";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(16, 83);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 29;
            this.lApellido.Text = "Apellido";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(16, 56);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 28;
            this.lNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(87, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(131, 175);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(94, 23);
            this.bLimpiar.TabIndex = 61;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCrearOtro
            // 
            this.bCrearOtro.Location = new System.Drawing.Point(332, 204);
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.Size = new System.Drawing.Size(105, 23);
            this.bCrearOtro.TabIndex = 62;
            this.bCrearOtro.Text = "Crear y Continuar";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            this.bCrearOtro.Visible = false;
            this.bCrearOtro.Click += new System.EventHandler(this.bCrearOtro_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(12, 12);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(100, 22);
            this.bBuscar.TabIndex = 63;
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
            this.lErrorNombre.Location = new System.Drawing.Point(193, 56);
            this.lErrorNombre.Name = "lErrorNombre";
            this.lErrorNombre.Size = new System.Drawing.Size(22, 29);
            this.lErrorNombre.TabIndex = 64;
            this.lErrorNombre.Text = "*";
            this.lErrorNombre.Visible = false;
            // 
            // lErrorApellido
            // 
            this.lErrorApellido.AutoSize = true;
            this.lErrorApellido.BackColor = System.Drawing.Color.Transparent;
            this.lErrorApellido.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lErrorApellido.Location = new System.Drawing.Point(193, 83);
            this.lErrorApellido.Name = "lErrorApellido";
            this.lErrorApellido.Size = new System.Drawing.Size(22, 29);
            this.lErrorApellido.TabIndex = 65;
            this.lErrorApellido.Text = "*";
            this.lErrorApellido.Visible = false;
            // 
            // lErrorDNI
            // 
            this.lErrorDNI.AutoSize = true;
            this.lErrorDNI.BackColor = System.Drawing.Color.Transparent;
            this.lErrorDNI.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorDNI.ForeColor = System.Drawing.Color.Red;
            this.lErrorDNI.Location = new System.Drawing.Point(193, 109);
            this.lErrorDNI.Name = "lErrorDNI";
            this.lErrorDNI.Size = new System.Drawing.Size(22, 29);
            this.lErrorDNI.TabIndex = 66;
            this.lErrorDNI.Text = "*";
            this.lErrorDNI.Visible = false;
            // 
            // lErrorMail
            // 
            this.lErrorMail.AutoSize = true;
            this.lErrorMail.BackColor = System.Drawing.Color.Transparent;
            this.lErrorMail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lErrorMail.Location = new System.Drawing.Point(420, 56);
            this.lErrorMail.Name = "lErrorMail";
            this.lErrorMail.Size = new System.Drawing.Size(22, 29);
            this.lErrorMail.TabIndex = 67;
            this.lErrorMail.Text = "*";
            this.lErrorMail.Visible = false;
            // 
            // lErrorTelefono
            // 
            this.lErrorTelefono.AutoSize = true;
            this.lErrorTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lErrorTelefono.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorTelefono.ForeColor = System.Drawing.Color.Red;
            this.lErrorTelefono.Location = new System.Drawing.Point(420, 83);
            this.lErrorTelefono.Name = "lErrorTelefono";
            this.lErrorTelefono.Size = new System.Drawing.Size(22, 29);
            this.lErrorTelefono.TabIndex = 68;
            this.lErrorTelefono.Text = "*";
            this.lErrorTelefono.Visible = false;
            // 
            // lErrorProvincia
            // 
            this.lErrorProvincia.AutoSize = true;
            this.lErrorProvincia.BackColor = System.Drawing.Color.Transparent;
            this.lErrorProvincia.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorProvincia.ForeColor = System.Drawing.Color.Red;
            this.lErrorProvincia.Location = new System.Drawing.Point(420, 112);
            this.lErrorProvincia.Name = "lErrorProvincia";
            this.lErrorProvincia.Size = new System.Drawing.Size(22, 29);
            this.lErrorProvincia.TabIndex = 69;
            this.lErrorProvincia.Text = "*";
            this.lErrorProvincia.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(87, 137);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(327, 20);
            this.txtDireccion.TabIndex = 72;
            // 
            // lErrorDireccion
            // 
            this.lErrorDireccion.AutoSize = true;
            this.lErrorDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lErrorDireccion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.lErrorDireccion.Location = new System.Drawing.Point(420, 143);
            this.lErrorDireccion.Name = "lErrorDireccion";
            this.lErrorDireccion.Size = new System.Drawing.Size(22, 29);
            this.lErrorDireccion.TabIndex = 73;
            this.lErrorDireccion.Text = "*";
            this.lErrorDireccion.Visible = false;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(15, 140);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(55, 13);
            this.lDireccion.TabIndex = 71;
            this.lDireccion.Text = "Dirrección";
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(131, 175);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(94, 23);
            this.bBorrar.TabIndex = 74;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(332, 175);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(105, 23);
            this.bModificar.TabIndex = 75;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Visible = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // FormAbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 243);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lErrorDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.lErrorProvincia);
            this.Controls.Add(this.lErrorTelefono);
            this.Controls.Add(this.lErrorMail);
            this.Controls.Add(this.lErrorDNI);
            this.Controls.Add(this.lErrorApellido);
            this.Controls.Add(this.lErrorNombre);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lProvincia);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormAbmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lErrorNombre;
        private System.Windows.Forms.Label lErrorApellido;
        private System.Windows.Forms.Label lErrorDNI;
        private System.Windows.Forms.Label lErrorMail;
        private System.Windows.Forms.Label lErrorTelefono;
        private System.Windows.Forms.Label lErrorProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lErrorDireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;

    }
}