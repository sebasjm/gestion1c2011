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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bAgregarOtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(9, 15);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ABM de Empleado",
            "ABM de Rol",
            "ABM de Usuario",
            "ABM de Cliente",
            "ABM de Producto",
            "Asignación de stock",
            "Facturación",
            "Efectuar Pago",
            "Tablero de Control",
            "Clientes Premium",
            "Mejores Categorías"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 51);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(322, 124);
            this.checkedListBox1.TabIndex = 2;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(12, 204);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(259, 204);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(93, 204);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 61;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // bAgregarOtro
            // 
            this.bAgregarOtro.Location = new System.Drawing.Point(178, 204);
            this.bAgregarOtro.Name = "bAgregarOtro";
            this.bAgregarOtro.Size = new System.Drawing.Size(75, 23);
            this.bAgregarOtro.TabIndex = 63;
            this.bAgregarOtro.Text = "Agregar Otro";
            this.bAgregarOtro.UseVisualStyleBackColor = true;
            // 
            // FormAbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 242);
            this.Controls.Add(this.bAgregarOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "FormAbmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bAgregarOtro;
    }
}