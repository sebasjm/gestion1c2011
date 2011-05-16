using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using VentaElectrodomesticos.Modelo;

namespace VentaElectrodomesticos.Vista {
    class Validator {
        abstract class ValidationEntry {
            public Group group;
            public class Group {
                public bool done = false;
            }
            abstract public bool validate();
        }
        class TextBoxValidationEntry : ValidationEntry {
            public TextBox campo;
            public Func<TextBox, bool> isValid;
            public Label label;

            public override bool validate() {
                if (isValid(campo)) {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                group.done = true;
                return false;
            }
        }
        class ComboValidationEntry : ValidationEntry {
            public ComboBox campo;
            public Func<ComboBox, bool> isValid;
            public Label label;

            public override bool validate() {
                if (isValid(campo)) {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                group.done = true;
                return false;
            }
        }

        List<ValidationEntry> checks = new List<ValidationEntry>();

        public class Text {
            public readonly static Func<TextBox, bool> nombre = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[A-Z][ a-zA-Z]*$").Success;
            };
            public readonly static Func<TextBox, bool> mail = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3}$").Success;
            };
            public readonly static Func<TextBox, bool> numerico = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9]+$").Success;
            };
            public readonly static Func<TextBox, bool> telefono = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^\\+?[0-9][ 0-9]*$").Success;
            };
            public readonly static Func<TextBox, bool> moneda = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^\\d+(?:,\\d{1,2})?$").Success;
            };
            public readonly static Func<TextBox, bool> obligatorio = (TextBox campo) => {
                return campo.Text.Length != 0;
            };
        }

        public class Combo {
            public readonly static Func<ComboBox, bool> obligatorio = (ComboBox campo) => {
                return campo.SelectedIndex != 0;
            };
        }

        public Validator add(TextBox c, Label l, params Func<TextBox, bool>[] criteriaList) {
            ValidationEntry.Group g = new ValidationEntry.Group();
            foreach (Func<TextBox, bool> criteria in criteriaList) {
                checks.Add(new TextBoxValidationEntry() { group = g, campo = c, isValid = criteria, label = l });
            }
            return this;
        }

        public Validator add(ComboBox c, Label l, params Func<ComboBox, bool>[] criteriaList) {
            ValidationEntry.Group g = new ValidationEntry.Group();
            foreach (Func<ComboBox, bool> criteria in criteriaList) {
                checks.Add(new ComboValidationEntry() { group = g, campo = c, isValid = criteria, label = l });
            }
            return this;
        }

        public bool check() {
            bool result = true;
            foreach (ValidationEntry ve in checks)
                if (!ve.group.done) result = ve.validate() && result;
            foreach (ValidationEntry ve in checks)
                ve.group.done = false;
            return result;
        }

        // hernann .sssssssssssssssssssssssssssssssssssssssssss


       
        class CheckListBoxValidationEntry : ValidationEntry
        {
            public CheckedListBox campo;
            public Func<CheckedListBox, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        // Validadores de Objetos Identidad
        class ClienteValidationEntry : ValidationEntry
        {
            public Cliente campo;
            public Func<Cliente, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        class EmpleadoValidationEntry : ValidationEntry
        {
            public Empleado campo;
            public Func<Empleado, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        class ProductoValidationEntry : ValidationEntry
        {
            public Producto campo;
            public Func<Producto, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        class UsuarioValidationEntry : ValidationEntry
        {
            public Usuario campo;
            public Func<Usuario, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        class CategoriaValidationEntry : ValidationEntry
        {
            public Categoria campo;
            public Func<Categoria, bool> isValid;
            public Label label;
            public override bool validate()
            {
                if (isValid(campo))
                {
                    label.Visible = false;
                    return true;
                }
                label.Visible = true;
                return false;
            }
        }
        class PasswordIgualValidationEntry : ValidationEntry
        {
            public TextBox campo1;
            public TextBox campo2;
            public Func<TextBox, TextBox, bool> isValid;
            public Label label1;
            public Label label2;
            public override bool validate()
            {
                if (isValid(campo1, campo2))
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    return true;
                }
                label1.Visible = true;
                label2.Visible = true;
                return false;
            }
        }
        // Fin de validadores de objetos

        public readonly static Func<TextBox, bool> nombre = (TextBox campo) =>
        {
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[a-zA-Z]{1,50}$").Success;
        };
        public readonly static Func<TextBox, bool> password = (TextBox campo) =>
        {
            /*  Valida una contraseña segura. Se debe estar entre 
             * 8 y 10 caracteres, contener al menos un dígito y un 
             * carácter alfabético, y no debe contener caracteres especiales. */
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$").Success;
        };
        public readonly static Func<TextBox, bool> direccion = (TextBox campo) =>
        {
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[a-zA-Z]{1,50}$").Success;
        };

        public readonly static Func<TextBox, bool> mail = (TextBox campo) =>
        {
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3}$").Success;
        };
        public readonly static Func<TextBox, bool> numerico = (TextBox campo) =>
        {
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9]+$").Success;
        };
        public readonly static Func<TextBox, bool> telefono = (TextBox campo) =>
        {
            return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^\\+?[0-9][ 0-9]*$").Success;
        };
        public readonly static Func<TextBox, bool> vacio = (TextBox campo) =>
        {
            return campo.Text.Length != 0;
        };
        public readonly static Func<ComboBox, bool> nulo = (ComboBox campo) =>
        {
            return campo.SelectedIndex != 0;
        };
        // Valido si los campos son iguales.
        public readonly static Func<TextBox, TextBox, bool> passwordIgual = (TextBox campo1, TextBox campo2) =>
        {
            return (campo1.Text == campo2.Text);
        };
        // Validadores especiales
        public readonly static Func<CheckedListBox, bool> sin_elementos = (CheckedListBox campo) =>
        {
            bool result = false;
            for (int i = 0; i < campo.Items.Count; ++i)
            {
                result = campo.GetItemChecked(i) || result;
            }
            return result;
        };
        public readonly static Func<Cliente, bool> cliente = (Cliente campo) =>
        {
            return true;
        };
        public readonly static Func<Empleado, bool> empleado = (Empleado campo) =>
        {
            return true;
        };
        public readonly static Func<Producto, bool> producto = (Producto campo) =>
        {
            return true;
        };
        public readonly static Func<Usuario, bool> usuario = (Usuario campo) =>
        {
            return true;
        };
        public readonly static Func<Categoria, bool> categoria = (Categoria campo) =>
        {
            return true;
        };
        // Fin de validadores especiales

        // Validadores Especiales
        public Validator add(CheckedListBox c, Label l, params Func<CheckedListBox, bool>[] criteriaList)
        {
            foreach (Func<CheckedListBox, bool> criteria in criteriaList)
            {
                checks.Add(new CheckListBoxValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        public Validator add(Cliente c, Label l, params Func<Cliente, bool>[] criteriaList)
        {
            foreach (Func<Cliente, bool> criteria in criteriaList)
            {
                checks.Add(new ClienteValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        public Validator add(Empleado c, Label l, params Func<Empleado, bool>[] criteriaList)
        {
            foreach (Func<Empleado, bool> criteria in criteriaList)
            {
                checks.Add(new EmpleadoValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        public Validator add(Producto c, Label l, params Func<Producto, bool>[] criteriaList)
        {
            foreach (Func<Producto, bool> criteria in criteriaList)
            {
                checks.Add(new ProductoValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        public Validator add(Usuario c, Label l, params Func<Usuario, bool>[] criteriaList)
        {
            foreach (Func<Usuario, bool> criteria in criteriaList)
            {
                checks.Add(new UsuarioValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        public Validator add(Categoria c, Label l, params Func<Categoria, bool>[] criteriaList)
        {
            foreach (Func<Categoria, bool> criteria in criteriaList)
            {
                checks.Add(new CategoriaValidationEntry() { campo = c, isValid = criteria, label = l });
            }
            return this;
        }
        // Validar Password Igual
        public Validator add(TextBox c1, TextBox c2, Label l1, Label l2, params Func<TextBox, TextBox, bool>[] criteriaList)
        {
            foreach (Func<TextBox, TextBox, bool> criteria in criteriaList)
            {
                checks.Add(new PasswordIgualValidationEntry() { campo1 = c1, campo2 = c2, isValid = criteria, label1 = l1, label2 = l2 });
            }
            return this;
        }
    }
}
