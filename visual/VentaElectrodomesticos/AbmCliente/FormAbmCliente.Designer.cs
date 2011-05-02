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
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.txtDeptoPiso = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lDeptoPiso = new System.Windows.Forms.Label();
            this.lNumero = new System.Windows.Forms.Label();
            this.lCalle = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(18, 241);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(94, 23);
            this.bCancelar.TabIndex = 44;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(332, 241);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(105, 23);
            this.bCrear.TabIndex = 43;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.txtNumero);
            this.grpDireccion.Controls.Add(this.txtCalle);
            this.grpDireccion.Controls.Add(this.label8);
            this.grpDireccion.Controls.Add(this.label7);
            this.grpDireccion.Controls.Add(this.txtDeptoPiso);
            this.grpDireccion.Controls.Add(this.lDeptoPiso);
            this.grpDireccion.Controls.Add(this.lNumero);
            this.grpDireccion.Controls.Add(this.lCalle);
            this.grpDireccion.Location = new System.Drawing.Point(18, 141);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(419, 79);
            this.grpDireccion.TabIndex = 42;
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
            this.bLimpiar.Location = new System.Drawing.Point(131, 241);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(94, 23);
            this.bLimpiar.TabIndex = 61;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCrearOtro
            // 
            this.bCrearOtro.Location = new System.Drawing.Point(332, 270);
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.Size = new System.Drawing.Size(105, 23);
            this.bCrearOtro.TabIndex = 62;
            this.bCrearOtro.Text = "Crear y Continuar";
            this.bCrearOtro.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(193, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(193, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(420, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(420, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(420, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(101, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(222, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "*";
            // 
            // FormAbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 307);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.grpDireccion);
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
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.TextBox txtDeptoPiso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lDeptoPiso;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label lCalle;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}