using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;
using System.Text.RegularExpressions;


namespace VentaElectrodomesticos.Controladores {
    class ValidarHelper {
        private int estado = 0;
        private TextBox textbox;
        public ValidarHelper validarCampo(TextBox textBox, Label etiqueta ,String cadena)        {
            this.textbox = textBox;
            if (textBox.Text == "")            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe escribir " + cadena, "Error", MessageBoxButtons.OK);
                estado++;
            }
            else            {
                etiqueta.Visible = false;
            }
            return this;
        }
        public ValidarHelper validarCampo(Label textBox, Label etiqueta, String cadena)        {
            
            if (textBox.Text == "")            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe escribir " + cadena, "Error", MessageBoxButtons.OK);
                estado++;
            }
            else            {
                etiqueta.Visible = false;
            }
            return this;
        }
        public ValidarHelper validarCampo(ComboBox cmbBox, Label etiqueta, String cadena)        {
            if (cmbBox.SelectedIndex == 0)            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe seleccionar " + cadena, "Error", MessageBoxButtons.OK);
                estado++;
            }            
            else            {
                etiqueta.Visible = false;
            }
            return this;
        }
        public ValidarHelper validarCampo(CheckedListBox chkBox, Label etiqueta, String cadena)
        {
            Boolean valor = false;
            for (int i = 0; i < chkBox.Items.Count; i++)
            {
                if (chkBox.GetItemChecked(i)) valor = true;
            }
            if (valor == false)
            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe seleccionar " + cadena, "Error", MessageBoxButtons.OK);
                estado++;
            }
            else
            {
                etiqueta.Visible = false;
            }
            return this;
        }
        public ValidarHelper validarEmail() {
            Match rex = Regex.Match(this.textbox.Text.Trim(' '), "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase);
            if (rex.Success == false)
            {
                MessageBox.Show("Please Enter a valid Email-Address ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado++;
            }
            return this;
        }
        public bool getEstado() {
            if (estado > 0)
                return true;
            return false;
        }
    }
}
