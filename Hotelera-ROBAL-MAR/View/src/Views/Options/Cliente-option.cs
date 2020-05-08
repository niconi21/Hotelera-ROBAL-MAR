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
using View.src.Views.Pages;

namespace View.Options
{
    public partial class Cliente : UserControl
    {
        private List<Habitacion> _habitaciones;
        private List<HistorialCliente> _clientes;
        private int _index;
        public Cliente()
        {
            InitializeComponent();
            llenarHabitaciones();
            llenarTablaClientes();
            lbl_fechaInicial.Text = "Fecha de llegada \n" + DateTime.Now.ToLongDateString();
        }
        public void llenarHabitaciones()
        {
            this.cb_hsbitacion.Items.Clear();
            _habitaciones = DataBase.getHabitacionesDisponibles();
            if (_habitaciones != null)
            {
                foreach (var item in _habitaciones)
                {
                    this.cb_hsbitacion.Items.Add("Habitacion: " + item.Numero + " - Precio: $" + item.Precio + " - Tipo: " + item.Tipo);
                }
                this.cb_hsbitacion.SelectedIndex = 0;
                vaciarCampos();
            }
        }
        public void llenarTablaClientes()
        {
            _clientes = DataBase.getClientes();
            
            tabla_clientes.DataSource = _clientes;
            vaciarCampos();   
        }
        private void btn_registrarCliente_Click(object sender, EventArgs e)
        {
            try
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
                        FechaInicio = DateTime.Today
                    };
                    if (DataBase.InsertHistorial(historial))
                    {
                        _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Estatus = Cadenas.OCUPADO;
                        if (DataBase.updateHabitaciones(_habitaciones.ElementAt(cb_hsbitacion.SelectedIndex)))
                        {
                            MessageBox.Show("El cliente ha sido registrado");
                        }
                        llenarHabitaciones();
                        llenarTablaClientes();
                    }
                }
            }
            catch (HoteleraException ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cb_hsbitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_precio.Text = "Precio por día: $" + _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Precio;
        }
        private void tabla_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _index = e.RowIndex;
                String[] nombre = _clientes.ElementAt(_index).cliente.Split(' ');
                txt_nombre.Text = nombre[0];
                txt_apepat.Text = nombre[1];
                txt_apemat.Text = nombre[2];
                txt_curp.Text = _clientes.ElementAt(_index).Curp;
                lbl_precio.Text = "Precio por día: " + _clientes.ElementAt(_index).PagoDia;
                lbl_fechaInicial.Text = "Fecha de llegada \n" + _clientes.ElementAt(_index).FechaInicio;
            }catch{}
        }
        private void btn_actualizarCliente_Click(object sender, EventArgs e)
        {
            //habitación anterior
            var habitacion = DataBase.getHabitacion(_clientes.ElementAt(_index).Habitacion);
            habitacion.Estatus = Cadenas.DISPONIBLE;
            DataBase.updateHabitaciones(habitacion);
            //habitacion nueva
            var habitacionNueva = DataBase.getHabitacion(_habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).Numero);
            habitacionNueva.Estatus = Cadenas.OCUPADO;
            DataBase.updateHabitaciones(habitacionNueva);
            var historial = DataBase.getHistorial(_clientes.ElementAt(_index).ID, habitacion.ID);
            historial.PagoDia = habitacion.Precio;
            historial.Habiacion = _habitaciones.ElementAt(cb_hsbitacion.SelectedIndex).ID;
            if (DataBase.updateHistorial(historial))
                MessageBox.Show("Cliente actualizado");
            else
                MessageBox.Show("Error en la actualizacion");
            llenarHabitaciones();
            llenarTablaClientes();
        }
        private void btn_finalizarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new src.Tools.Objects.Cliente
            {
                ID = _clientes.ElementAt(_index).ID,
                Curp = _clientes.ElementAt(_index).Curp
            };
            var habitacion = DataBase.getHabitacion(_clientes.ElementAt(_index).Habitacion);
            ClienteFecha fecha = new ClienteFecha(cliente,habitacion,this);
            fecha.Show();
        }
        private void vaciarCampos(){
            this.txt_nombre.Clear();
            this.txt_apepat.Clear();
            this.txt_apemat.Clear();
            this.txt_curp.Clear();
        }

    }
}
