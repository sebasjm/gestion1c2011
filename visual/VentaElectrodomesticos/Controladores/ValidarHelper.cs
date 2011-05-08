using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;


namespace VentaElectrodomesticos.Controladores {
    class ValidarHelper {
        public static void validarCampo(TextBox textBox, Label etiqueta ,String cadena)        {
            if (textBox.Text == "")            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe escribir " + cadena, "Error", MessageBoxButtons.OK);            }
            else            {
                etiqueta.Visible = false;
            }
        }
        public static void validarCampo(Label textBox, Label etiqueta, String cadena)        {
            if (textBox.Text == "")            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe escribir " + cadena, "Error", MessageBoxButtons.OK);            }
            else            {
                etiqueta.Visible = false;
            }
        }
        public static void validarCampo(ComboBox cmbBox, Label etiqueta, String cadena)        {
            if (cmbBox.SelectedIndex == 0)            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe seleccionar " + cadena, "Error", MessageBoxButtons.OK);            }            
            else            {
                etiqueta.Visible = false;
            }
        }
        public static void validarCampo(CheckedListBox chkBox, Label etiqueta, String cadena)
        {
            Boolean estado = false;
            for (int i = 0; i < chkBox.Items.Count; i++)
            {
                if (chkBox.GetItemChecked(i)) estado = true;
            } 
            if (estado == false)
            {
                etiqueta.Visible = true;
                MessageBox.Show("Se debe seleccionar " + cadena, "Error", MessageBoxButtons.OK);
            }
            else
            {
                etiqueta.Visible = false;
            }
        }
    }
}
