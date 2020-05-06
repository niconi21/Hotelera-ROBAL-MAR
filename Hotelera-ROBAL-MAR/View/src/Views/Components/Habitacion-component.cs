using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.Tools;
using View.src.Tools.Objects;
using View.Options;

namespace View.Components
{
    public partial class Habitacion_component : UserControl
    {
        private Habitacion _habitacion;
        private Habitacoines _habitacoin_options;
        
        private Bitmap[] camas = new Bitmap[]{
            global::View.Properties.Resources.cama___verde,
            global::View.Properties.Resources.cama___amarilla,
            global::View.Properties.Resources.cama___roja
        };
       
        public Habitacion_component()
        {
            InitializeComponent();
        }

        public void setHabitacion(Habitacion habitacion)
        {
            _habitacion = habitacion;
            this.label_habitacion.Text = "Habitación: " + _habitacion.Numero;
            this.label_estatus.Text = "Estatus: " + _habitacion.Estatus;
            switch (_habitacion.Estatus)
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
            this.label_tipo.Text = "Tipo: " + _habitacion.Tipo;
            this.label_precio.Text = "Precio: $" + _habitacion.Precio;
        }
        public void setOption(Habitacoines h)
        {
            _habitacoin_options = h;
        }
        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarHabitacion actualizar = new ActualizarHabitacion(_habitacion,_habitacoin_options);
            actualizar.Show();
        }
    }
}
