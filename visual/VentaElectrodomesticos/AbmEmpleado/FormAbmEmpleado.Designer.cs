namespace VentaElectrodomesticos.AbmEmpleado
{
    partial class FormAbmEmpleado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lProvincia = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.lTipoEmpleado = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.txtDeptoPiso = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lDeptoPiso = new System.Windows.Forms.Label();
            this.lNumero = new System.Windows.Forms.Label();
            this.lCalle = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bAgregarOtro = new System.Windows.Forms.Button();
            this.grpDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(13, 21);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(13, 48);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 3;
            this.lApellido.Text = "Apellido";
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(13, 72);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(26, 13);
            this.lDni.TabIndex = 4;
            this.lDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(84, 72);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(13, 103);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(26, 13);
            this.lMail.TabIndex = 6;
            this.lMail.Text = "Mail";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(211, 18);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(49, 13);
            this.lTelefono.TabIndex = 7;
            this.lTelefono.Text = "Teléfono";
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(211, 48);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(51, 13);
            this.lProvincia.TabIndex = 12;
            this.lProvincia.Text = "Provincia";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(212, 75);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(48, 13);
            this.lSucursal.TabIndex = 13;
            this.lSucursal.Text = "Sucursal";
            // 
            // lTipoEmpleado
            // 
            this.lTipoEmpleado.AutoSize = true;
            this.lTipoEmpleado.Location = new System.Drawing.Point(209, 102);
            this.lTipoEmpleado.Name = "lTipoEmpleado";
            this.lTipoEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lTipoEmpleado.TabIndex = 14;
            this.lTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(318, 44);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 15;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(318, 72);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 16;
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(318, 100);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEmpleado.TabIndex = 17;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(84, 98);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(318, 18);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.txtDeptoPiso);
            this.grpDireccion.Controls.Add(this.txtNumero);
            this.grpDireccion.Controls.Add(this.txtCalle);
            this.grpDireccion.Controls.Add(this.lDeptoPiso);
            this.grpDireccion.Controls.Add(this.lNumero);
            this.grpDireccion.Controls.Add(this.lCalle);
            this.grpDireccion.Location = new System.Drawing.Point(20, 131);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(419, 79);
            this.grpDireccion.TabIndex = 23;
            this.grpDireccion.TabStop = false;
            this.grpDireccion.Text = "Dirección:";
            // 
            // txtDeptoPiso
            // 
            this.txtDeptoPiso.Location = new System.Drawing.Point(295, 37);
            this.txtDeptoPiso.Name = "txtDeptoPiso";
            this.txtDeptoPiso.Size = new System.Drawing.Size(100, 20);
            this.txtDeptoPiso.TabIndex = 28;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(180, 37);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 27;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(65, 37);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 26;
            // 
            // lDeptoPiso
            // 
            this.lDeptoPiso.AutoSize = true;
            this.lDeptoPiso.Location = new System.Drawing.Point(292, 22);
            this.lDeptoPiso.Name = "lDeptoPiso";
            this.lDeptoPiso.Size = new System.Drawing.Size(99, 13);
            this.lDeptoPiso.TabIndex = 25;
            this.lDeptoPiso.Text = "Departamento/Piso";
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(177, 22);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(44, 13);
            this.lNumero.TabIndex = 24;
            this.lNumero.Text = "Número";
            // 
            // lCalle
            // 
            this.lCalle.AutoSize = true;
            this.lCalle.Location = new System.Drawing.Point(65, 21);
            this.lCalle.Name = "lCalle";
            this.lCalle.Size = new System.Drawing.Size(30, 13);
            this.lCalle.TabIndex = 23;
            this.lCalle.Text = "Calle";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(364, 231);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 24;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(20, 231);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 25;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(138, 231);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 61;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // bAgregarOtro
            // 
            this.bAgregarOtro.Location = new System.Drawing.Point(255, 231);
            this.bAgregarOtro.Name = "bAgregarOtro";
            this.bAgregarOtro.Size = new System.Drawing.Size(75, 23);
            this.bAgregarOtro.TabIndex = 63;
            this.bAgregarOtro.Text = "Agregar Otro";
            this.bAgregarOtro.UseVisualStyleBackColor = true;
            // 
            // FormAbmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 272);
            this.Controls.Add(this.bAgregarOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.grpDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lTipoEmpleado);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProvincia);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormAbmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Empleado";
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label lTipoEmpleado;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.TextBox txtDeptoPiso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lDeptoPiso;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label lCalle;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bAgregarOtro;
    }
}