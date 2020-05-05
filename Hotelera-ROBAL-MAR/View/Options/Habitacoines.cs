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
using View.Components;

namespace View.Options
{
    public partial class Habitacoines : UserControl
    {
        public Habitacoines()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 100;
            int j = 0;
            foreach (Habitacion_component habitacion in flowLayoutPanel1.Controls)
            {
                habitacion.Numero = i += 1;
                if (j % 2 == 0)
                {
                    habitacion.Estatus = Cadenas.DISPONIBLE;
                }
                else if (j % 3 == 0)
                {
                    habitacion.Estatus = Cadenas.MANTENIMIENTO;
                }
                else
                {
                    habitacion.Estatus = Cadenas.OCUPADO;
                }
                j++;
                habitacion.Tipo = "Yolo";
                habitacion.Precio = 100.00f;
            }
        }
    }
}
