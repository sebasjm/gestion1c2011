namespace VentaElectrodomesticos.AbmUsuario
{
    partial class FormAbmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbmUsuario));
            this.lEmpleado = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.grpListadoRoles = new System.Windows.Forms.GroupBox();
            this.chkListadoRoles = new System.Windows.Forms.CheckedListBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lConfirmarPassword = new System.Windows.Forms.Label();
            this.lErrorEmpleado = new System.Windows.Forms.Label();
            this.lErrorUsername = new System.Windows.Forms.Label();
            this.lErrorPassword = new System.Windows.Forms.Label();
            this.lErrorConfirmPass = new System.Windows.Forms.Label();
            this.lErrorRoles = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.grpListadoRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lEmpleado
            // 
            resources.ApplyResources(this.lEmpleado, "lEmpleado");
            this.lEmpleado.Name = "lEmpleado";
            // 
            // lUsername
            // 
            resources.ApplyResources(this.lUsername, "lUsername");
            this.lUsername.Name = "lUsername";
            // 
            // lPassword
            // 
            resources.ApplyResources(this.lPassword, "lPassword");
            this.lPassword.Name = "lPassword";
            // 
            // grpListadoRoles
            // 
            this.grpListadoRoles.Controls.Add(this.chkListadoRoles);
            resources.ApplyResources(this.grpListadoRoles, "grpListadoRoles");
            this.grpListadoRoles.Name = "grpListadoRoles";
            this.grpListadoRoles.TabStop = false;
            // 
            // chkListadoRoles
            // 
            this.chkListadoRoles.FormattingEnabled = true;
            resources.ApplyResources(this.chkListadoRoles, "chkListadoRoles");
            this.chkListadoRoles.Name = "chkListadoRoles";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // bCrearOtro
            // 
            resources.ApplyResources(this.bCrearOtro, "bCrearOtro");
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            this.bCrearOtro.Click += new System.EventHandler(this.bCrearOtro_Click);
            // 
            // bLimpiar
            // 
            resources.ApplyResources(this.bLimpiar, "bLimpiar");
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            resources.ApplyResources(this.bCancelar, "bCancelar");
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            resources.ApplyResources(this.bCrear, "bCrear");
            this.bCrear.Name = "bCrear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bBuscarEmpleado
            // 
            resources.ApplyResources(this.bBuscarEmpleado, "bBuscarEmpleado");
            this.bBuscarEmpleado.Name = "bBuscarEmpleado";
            this.bBuscarEmpleado.UseVisualStyleBackColor = true;
            this.bBuscarEmpleado.Click += new System.EventHandler(this.bBuscarEmpleado_Click);
            // 
            // txtConfirmarPassword
            // 
            resources.ApplyResources(this.txtConfirmarPassword, "txtConfirmarPassword");
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            // 
            // bBuscar
            // 
            resources.ApplyResources(this.bBuscar, "bBuscar");
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lConfirmarPassword
            // 
            resources.ApplyResources(this.lConfirmarPassword, "lConfirmarPassword");
            this.lConfirmarPassword.Name = "lConfirmarPassword";
            // 
            // lErrorEmpleado
            // 
            resources.ApplyResources(this.lErrorEmpleado, "lErrorEmpleado");
            this.lErrorEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lErrorEmpleado.ForeColor = System.Drawing.Color.Red;
            this.lErrorEmpleado.Name = "lErrorEmpleado";
            // 
            // lErrorUsername
            // 
            resources.ApplyResources(this.lErrorUsername, "lErrorUsername");
            this.lErrorUsername.BackColor = System.Drawing.Color.Transparent;
            this.lErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lErrorUsername.Name = "lErrorUsername";
            // 
            // lErrorPassword
            // 
            resources.ApplyResources(this.lErrorPassword, "lErrorPassword");
            this.lErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.lErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lErrorPassword.Name = "lErrorPassword";
            // 
            // lErrorConfirmPass
            // 
            resources.ApplyResources(this.lErrorConfirmPass, "lErrorConfirmPass");
            this.lErrorConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lErrorConfirmPass.ForeColor = System.Drawing.Color.Red;
            this.lErrorConfirmPass.Name = "lErrorConfirmPass";
            // 
            // lErrorRoles
            // 
            resources.ApplyResources(this.lErrorRoles, "lErrorRoles");
            this.lErrorRoles.BackColor = System.Drawing.Color.Transparent;
            this.lErrorRoles.ForeColor = System.Drawing.Color.Red;
            this.lErrorRoles.Name = "lErrorRoles";
            // 
            // bBorrar
            // 
            resources.ApplyResources(this.bBorrar, "bBorrar");
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bModificar
            // 
            resources.ApplyResources(this.bModificar, "bModificar");
            this.bModificar.Name = "bModificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // txtEmpleado
            // 
            resources.ApplyResources(this.txtEmpleado, "txtEmpleado");
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            // 
            // FormAbmUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lErrorConfirmPass);
            this.Controls.Add(this.lErrorPassword);
            this.Controls.Add(this.lErrorUsername);
            this.Controls.Add(this.lErrorEmpleado);
            this.Controls.Add(this.lConfirmarPassword);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.bBuscarEmpleado);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.grpListadoRoles);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.lEmpleado);
            this.Controls.Add(this.lErrorRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbmUsuario";
            this.grpListadoRoles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEmpleado;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.GroupBox grpListadoRoles;
        private System.Windows.Forms.CheckedListBox chkListadoRoles;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bBuscarEmpleado;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lConfirmarPassword;
        private System.Windows.Forms.Label lErrorEmpleado;
        private System.Windows.Forms.Label lErrorUsername;
        private System.Windows.Forms.Label lErrorPassword;
        private System.Windows.Forms.Label lErrorConfirmPass;
        private System.Windows.Forms.Label lErrorRoles;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.TextBox txtEmpleado;
    }
}