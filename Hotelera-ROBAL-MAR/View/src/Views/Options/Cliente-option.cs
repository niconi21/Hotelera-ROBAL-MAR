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
using View.src.Tools;

namespace View.Options
{
    public partial class Cliente : UserControl
    {
        private List<Habitacion> _habitaciones;
        public Cliente()
        {
            InitializeComponent();
            llenarHabitaciones();
            lbl_fechaInicial.Text = "Fecha de llegada \n" + DateTime.Now.ToLongDateString();
        }

        private void llenarHabitaciones()
        {
            _habitaciones = DataBase.getHabitacionesDisponibles();
            foreach (var item in _habitaciones)
            {
                this.cb_hsbitacion.Items.Add("Habitacion: " + item.Numero + " - Estatus: " + item.Estatus);
            }
        }
        private void llenarTablaClientes()
        {
            var clientes = DataBase.getClientes();
            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(tabla_clientes);
            
        }
        private void btn_registrarCliente_Click(object sender, EventArgs e)
        {
            src.Tools.Objects.Cliente cliente = new src.Tools.Objects.Cliente
            {
                Nombre = txt_nombre.Text,
                Apepat = txt_apepat.Text,
                Apemat = txt_apemat.Text,
                Curp = txt_curp.Text,
            };
            if (DataBase.InsertCliente(cliente))
            {
                cliente = DataBase.getCliente(cliente);
                var fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                src.Tools.Objects.Historial historial = new src.Tools.Objects.Historial
                {
                    Cliente = cliente.ID,
                    Personal = UsuarioCache.ID,
                    Habiacion = _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).ID,
                    PagoDia = _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Precio,
                    MontoTotal = 0,
                    FechaInicio = fecha
                };
                if (DataBase.InsertHistorial(historial))
                {
                    _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Estatus = Cadenas.OCUPADO;
                    if (DataBase.updateHabitaciones(_habitaciones.ElementAt(cb_hsbitacion.SelectedIndex)))
                    {
                        MessageBox.Show("El cliente ha sido registrado");
                    }
                }
            }

        }

        private void cb_hsbitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_precio.Text = "Precio por día: $" + _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Precio;
        }
    }
}
