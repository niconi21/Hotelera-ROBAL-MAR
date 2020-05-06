using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.Tools.Objects;
using View.src.Tools;
namespace View.Components
{
    public partial class Direccion_component : UserControl
    {
        public Direccion_component()
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

        public Direccion getDireccion()
        {
            if (!validar())
            {
                throw new HoteleraException("Llene los campos de las direcciónes por favor");
            }
            return new Direccion
            {
                Ciudad = txt_ciudad.Text,
                CP = txt_cp.Text,
                Colonia = txt_colonia.Text,
                Calle = txt_calle.Text,
                NumInt = txt_numInt.Text,
                NumExt = txt_numExt.Text,
                Referencias = txt_referencias.Text
            };
        }
    }
}
