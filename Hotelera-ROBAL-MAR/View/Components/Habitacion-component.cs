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
    public partial class Habitacion_component : UserControl
    {
        private int _numero;
        private String _estatus;
        private String _tipo;
        private float _precio;
        
        private Bitmap[] camas = new Bitmap[]{
            global::View.Properties.Resources.cama___verde,
            global::View.Properties.Resources.cama___amarilla,
            global::View.Properties.Resources.cama___roja
        };
        public int Numero { get { return _numero; } set { _numero = value; this.label_habitacion.Text = "Habitación: " + _numero; } }
        public String Estatus
        {
            get
            {
                return _estatus;
            }
            set
            {
                _estatus = value;
                this.label_estatus.Text = "Estatus: " + _estatus;
                switch (_estatus)
                {
                    case Cadenas.DISPONIBLE:
                        this.pictureBox1.Image = camas[0];
                        break;
                    case Cadenas.MANTENIMIENTO:
                        this.pictureBox1.Image = camas[1];
                        break;
                    case Cadenas.OCUPADO:
                        this.pictureBox1.Image = camas[2];
                        break;

                }
            }
        }
        public String Tipo { get { return _tipo; } set { _tipo = value; this.label_tipo.Text = "Tipo: " + _tipo; } }
        public float Precio { get { return _precio; } set { _precio = value; this.label_precio.Text = "Precio: $" + _precio; } }
        
        public Habitacion_component()
        {
            InitializeComponent();
        }
    }
}
