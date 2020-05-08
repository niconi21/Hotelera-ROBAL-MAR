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

namespace View.Options
{
    public partial class Personal : UserControl
    {
        private List<src.Tools.Objects.Personal> _empleados;
        private src.Tools.Objects.Personal _personal;
        private int _index;
        public Personal()
        {
            InitializeComponent();
            llenarPersonal();

        }

        public void llenarPersonal()
        {
            _empleados = DataBase.getEmpleados();
            
            tablaPersonal.DataSource = _empleados;
        }
        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            RegistroPersonal registro = new RegistroPersonal(this);
            registro.Show();
        }

        private void tablaPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _index = e.RowIndex;
                _personal = _empleados.ElementAt(_index);
                this.btn_modificarEmpleado.Enabled = true;
            }
            catch { }
        }

        private void btn_modificarEmpleado_Click(object sender, EventArgs e)
        {
            RegistroPersonal actualizar = new RegistroPersonal(this,_personal);
            actualizar.Show();
        }


        
    }

}
