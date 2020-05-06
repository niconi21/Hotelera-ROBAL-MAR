using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.Tools.Objects;
using View.src.DataBase;
using View.src.Tools;

namespace View.src.Views.Pages
{
    public partial class ClienteFecha : Form
    {
        private Cliente _cliente;
        private Habitacion _habitacion;
        private Historial _historial;
        private View.Options.Cliente _option;
        public ClienteFecha(Cliente cliente, Habitacion habitacion,View.Options.Cliente option)
        {
            InitializeComponent();
            _cliente = cliente;
            _habitacion = habitacion;
            _option = option;
        }

        private void actualizarHabitacion()
        {
            _habitacion.Estatus = Cadenas.DISPONIBLE;
            DataBase.DataBase.updateHabitaciones(_habitacion);
        }
        private void actualizarHistorial()
        {
            _historial = DataBase.DataBase.getHistorial(_cliente.ID, _habitacion.ID);
            _historial.MontoTotal = (float)(_historial.PagoDia * obtenerFecha());
            DataBase.DataBase.updateHistorial(_historial,true);
        }

        private int obtenerFecha()
        {
            _historial.FechaFinal = this.dateTimePicker1.Value;
            var dias = (int)(_historial.FechaFinal - _historial.FechaInicio).TotalDays;
            return dias;
        }

        private void btn_finalizarCliente_Click(object sender, EventArgs e)
        {
            actualizarHabitacion();
            actualizarHistorial();
            obtenerFecha();
            MessageBox.Show("El cliente ha sido dado de baja");
            _option.llenarHabitaciones();
            _option.llenarTablaClientes();
            this.Dispose();
        }
        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
