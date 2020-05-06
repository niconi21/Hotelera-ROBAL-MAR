using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.DataBase;
using View.src.Tools.Objects;
using View.Components;

namespace View.Options
{
    public partial class Habitacoines : UserControl
    {
        private List<Habitacion> _habitaciones;
        public Habitacoines()
        {
            InitializeComponent();
            llenarPiso();
            this.cb_pisos.SelectedIndex = 0;
        }
        private void llenarPiso()
        {
            var pisos = DataBase.getPisos();
            if (pisos != null)
            {
                foreach (var item in pisos)
                {
                    this.cb_pisos.Items.Add(item.Numero);
                }
            }
        }

        private void llenarHabitaciones()
        {
            int i = 0;
            foreach (Habitacion_component item in this.flowLayoutPanel1.Controls)
            {
                item.setHabitacion(_habitaciones.ElementAt(i));
                item.setOption(this);
                i++;
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int piso = (int)cb_pisos.SelectedItem - 1;
            _habitaciones = DataBase.getHabitaciones(piso);
            llenarHabitaciones();
        }
    }
}
