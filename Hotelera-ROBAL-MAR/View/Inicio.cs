using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Options;

namespace View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void configurarContenedor(Control c)
        {
            this.panel_contenedor.Controls.Clear();
            c.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(c);
        }

        private void panel_habitaciones_Click(object sender, EventArgs e)
        {
            Habitacoines habitacion = new Habitacoines();
            configurarContenedor(habitacion);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            configurarContenedor(personal);
        }
    }
}
