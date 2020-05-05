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
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();


        }

        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            RegistroPersonal registro = new RegistroPersonal();
            registro.Show();
        }


        
    }

}
