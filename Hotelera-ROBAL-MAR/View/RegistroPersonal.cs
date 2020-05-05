using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class RegistroPersonal : Form
    {
        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
