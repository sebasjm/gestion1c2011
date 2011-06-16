namespace VentaElectrodomesticos.ClientesPremium
{
    partial class FormClientesPremium
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
            this.cmbAnioAnalizar = new System.Windows.Forms.ComboBox();
            this.lAnioAnalizar = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lSucursal = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnioAnalizar
            // 
            this.cmbAnioAnalizar.FormattingEnabled = true;
            this.cmbAnioAnalizar.Location = new System.Drawing.Point(128, 39);
            this.cmbAnioAnalizar.Name = "cmbAnioAnalizar";
            this.cmbAnioAnalizar.Size = new System.Drawing.Size(121, 21);
            this.cmbAnioAnalizar.TabIndex = 32;
            this.cmbAnioAnalizar.SelectedIndexChanged += new System.EventHandler(this.cmbAnioAnalizar_SelectedIndexChanged);
            // 
            // lAnioAnalizar
            // 
            this.lAnioAnalizar.AutoSize = true;
            this.lAnioAnalizar.Location = new System.Drawing.Point(15, 42);
            this.lAnioAnalizar.Name = "lAnioAnalizar";
            this.lAnioAnalizar.Size = new System.Drawing.Size(78, 13);
            this.lAnioAnalizar.TabIndex = 31;
            this.lAnioAnalizar.Text = "Año a Analizar:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(128, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 30;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(15, 15);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 29;
            this.lSucursal.Text = "Sucursal:";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(696, 231);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 38;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(18, 75);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataClientes.Size = new System.Drawing.Size(753, 150);
            this.dataClientes.TabIndex = 39;
            // 
            // FormClientesPremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 266);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbAnioAnalizar);
            this.Controls.Add(this.lAnioAnalizar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientesPremium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Premium";
            this.Load += new System.EventHandler(this.FormClientesPremium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnioAnalizar;
        private System.Windows.Forms.Label lAnioAnalizar;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.DataGridView dataClientes;
    }
}