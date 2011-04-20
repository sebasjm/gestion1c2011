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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
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
            // bCancelar
            // 
            resources.ApplyResources(this.bCancelar, "bCancelar");
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            resources.ApplyResources(this.bAceptar, "bAceptar");
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            resources.ApplyResources(this.bLimpiar, "bLimpiar");
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormAbmUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
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
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bLimpiar;
    }
}