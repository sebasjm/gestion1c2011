﻿namespace VentaElectrodomesticos.Login
{
    partial class FormLogin
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.lErrorUser = new System.Windows.Forms.Label();
            this.lErrorPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bAceptar.Location = new System.Drawing.Point(139, 82);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 16;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bCancelar.Location = new System.Drawing.Point(14, 82);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(94, 42);
            this.tPassword.MaxLength = 20;
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(120, 20);
            this.tPassword.TabIndex = 14;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(94, 10);
            this.tUsername.MaxLength = 10;
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(120, 20);
            this.tUsername.TabIndex = 13;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lPassword.Location = new System.Drawing.Point(14, 45);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 11;
            this.lPassword.Text = "Password";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lUsername.Location = new System.Drawing.Point(14, 13);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 10;
            this.lUsername.Text = "Username";
            // 
            // lErrorUser
            // 
            this.lErrorUser.AutoSize = true;
            this.lErrorUser.Location = new System.Drawing.Point(78, 17);
            this.lErrorUser.Name = "lErrorUser";
            this.lErrorUser.Size = new System.Drawing.Size(0, 13);
            this.lErrorUser.TabIndex = 17;
            // 
            // lErrorPass
            // 
            this.lErrorPass.AutoSize = true;
            this.lErrorPass.Location = new System.Drawing.Point(78, 45);
            this.lErrorPass.Name = "lErrorPass";
            this.lErrorPass.Size = new System.Drawing.Size(0, 13);
            this.lErrorPass.TabIndex = 18;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(236, 120);
            this.Controls.Add(this.lErrorPass);
            this.Controls.Add(this.lErrorUser);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lErrorUser;
        private System.Windows.Forms.Label lErrorPass;

    }
}