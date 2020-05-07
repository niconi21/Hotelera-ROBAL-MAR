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

namespace View.Options
{
    public partial class Historial : UserControl
    {
        private List<HistorialGanancias> _ganancias;
        public Historial()
        {
            InitializeComponent();
            llenarGanancias();
        }

        public void llenarGanancias()
        {
            _ganancias = DataBase.getHistorialGanancias();
            tabla_ganancias.DataSource = _ganancias;
            float total = 0.0f;
            if (_ganancias != null)
            {
                foreach (HistorialGanancias item in _ganancias)
                {
                    total += item.Ganancia;
                }
                lbl_ganancias.Text = "Total de ganancias: \n$" + total;
            }
        }

        private void btn_grafica_Click(object sender, EventArgs e)
        {
            Grafica grafica = new Grafica();
            grafica.Show();
        }
    }
}
