using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Options
{
    public partial class Historial : UserControl
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btn_grafica_Click(object sender, EventArgs e)
        {
            Grafica grafica = new Grafica();
            grafica.Show();
        }
    }
}
