using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View.Components
{
    public partial class Telefono_component : UserControl
    {
        public Telefono_component()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool validacion = true;
            foreach (var item in this.Controls)
            {
                try
                {
                    TextBox txt = item as TextBox;
                    if (txt.Text.Equals(""))
                    {
                        validacion = false;
                        this.labe_error.Visible = true;
                    }
                }
                catch { }

            }
            return validacion;
        }

        public Telefono getDireccion()
        {
            if (!validar())
            {
                throw new HoteleraException("Llene los campos de las direcciónes por favor");
            }
            return new Telefono
            {
                Tipo = comboBox1.SelectedText,
                Numero = txt_numero.Text
            };
        }
    }
}
