namespace VentaElectrodomesticos.AbmMarca
{
    partial class FormAbmMarca
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
            this.bCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lErrorMarca = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(177, 183);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(116, 23);
            this.bCrear.TabIndex = 0;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(50, 21);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(221, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // lErrorMarca
            // 
            this.lErrorMarca.AutoSize = true;
            this.lErrorMarca.BackColor = System.Drawing.Color.Transparent;
            this.lErrorMarca.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.lErrorMarca.Location = new System.Drawing.Point(271, 21);
            this.lErrorMarca.Name = "lErrorMarca";
            this.lErrorMarca.Size = new System.Drawing.Size(22, 29);
            this.lErrorMarca.TabIndex = 75;
            this.lErrorMarca.Text = "*";
            this.lErrorMarca.Visible = false;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(177, 183);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(116, 23);
            this.bModificar.TabIndex = 85;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(67, 183);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(58, 23);
            this.bBorrar.TabIndex = 84;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            // 
            // bCrearOtro
            // 
            this.bCrearOtro.Location = new System.Drawing.Point(177, 212);
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.Size = new System.Drawing.Size(116, 23);
            this.bCrearOtro.TabIndex = 83;
            this.bCrearOtro.Text = "Crear y Continuar";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(3, 212);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(58, 23);
            this.bLimpiar.TabIndex = 82;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(3, 183);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(58, 23);
            this.bCancelar.TabIndex = 81;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 121);
            this.dataGridView1.TabIndex = 86;
            // 
            // FormAbmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 246);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.lErrorMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCrear);
            this.Name = "FormAbmMarca";
            this.Text = "Alta de Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lErrorMarca;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}