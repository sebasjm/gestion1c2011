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
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lConfirmarPassword = new System.Windows.Forms.Label();
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
            this.chkListadoRoles.Items.AddRange(new object[] {
            resources.GetString("chkListadoRoles.Items"),
            resources.GetString("chkListadoRoles.Items1"),
            resources.GetString("chkListadoRoles.Items2")});
            resources.ApplyResources(this.chkListadoRoles, "chkListadoRoles");
            this.chkListadoRoles.Name = "chkListadoRoles";
            // 
            // tUsername
            // 
            resources.ApplyResources(this.tUsername, "tUsername");
            this.tUsername.Name = "tUsername";
            // 
            // tPassword
            // 
            resources.ApplyResources(this.tPassword, "tPassword");
            this.tPassword.Name = "tPassword";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEmpleado, "cmbEmpleado");
            this.cmbEmpleado.Name = "cmbEmpleado";
            // 
            // bCrearOtro
            // 
            resources.ApplyResources(this.bCrearOtro, "bCrearOtro");
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            resources.ApplyResources(this.bLimpiar, "bLimpiar");
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bCrear
            // 
            resources.ApplyResources(this.bCrear, "bCrear");
            this.bCrear.Name = "bCrear";
            this.bCrear.UseVisualStyleBackColor = true;
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
            // FormAbmUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lConfirmarPassword);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.bBuscarEmpleado);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.grpListadoRoles);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.lEmpleado);
            this.Name = "FormAbmUsuario";
            this.Load += new System.EventHandler(this.FormAbmUsuario_Load);
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
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bBuscarEmpleado;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lConfirmarPassword;
    }
}