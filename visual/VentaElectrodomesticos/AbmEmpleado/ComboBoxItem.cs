using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.AbmEmpleado
{
    public class ComboBoxItem
    {
        private string display;
        private int value;

        public ComboBoxItem(string display, string value2)
        {
            this.display = display;
            this.value = Int32.Parse(value2);
        }

        public string Display
        {
            set { display = value; }
            get { return display; }
        }

        public int Value
        {
            set { this.value = value; }
            get { return value; }
        }
    }
}
