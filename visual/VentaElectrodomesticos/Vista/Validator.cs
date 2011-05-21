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

    }
}
