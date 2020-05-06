using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Components;
using View.Options;
using View.src.DataBase;
using View.src.Tools;
using View.src.Tools.Objects;

namespace View
{
    public partial class ActualizarHabitacion : Form
    {
        private Bitmap[] camas = new Bitmap[]{
            global::View.Properties.Resources.cama___verde,
            global::View.Properties.Resources.cama___amarilla,
            global::View.Properties.Resources.cama___roja
        };

        private Habitacion _habitacion;
        private Habitacoines _habitacion_option;
        public ActualizarHabitacion(Habitacion habitacion,Habitacoines h)
        {
            InitializeComponent();
            cargarCB();
            this._habitacion = habitacion;
            this._habitacion_option = h;
            this.label_habitacion.Text = "Habitacion: " + _habitacion.Numero;
            txt_precio.Text = _habitacion.Precio.ToString();
            switch (_habitacion.Estatus)
            {
                case Cadenas.DISPONIBLE:
                    cb_estatus.SelectedIndex = 0;
                    pictureBox1.Image = camas[0];
                    break;
                case Cadenas.MANTENIMIENTO:
                    cb_estatus.SelectedIndex = 1;
                    pictureBox1.Image = camas[1];
                    break;
                case Cadenas.OCUPADO:
                    cb_estatus.SelectedIndex = 2;
                    pictureBox1.Image = camas[2];
                    break;
            }
            switch (_habitacion.Tipo)
            {
                case Cadenas.INDIVIDUAL:
                    cb_tipo.SelectedIndex = 0;
                    break;
                case Cadenas.DOBLE:
                    cb_tipo.SelectedIndex = 1;
                    break;
                case Cadenas.TRIPLE:
                    cb_tipo.SelectedIndex = 2;
                    break;
            }
        }

        private void cargarCB()
        {
            cb_estatus.Items.Add(Cadenas.DISPONIBLE);
            cb_estatus.Items.Add(Cadenas.MANTENIMIENTO);
            cb_estatus.Items.Add(Cadenas.OCUPADO);
            cb_tipo.Items.Add(Cadenas.INDIVIDUAL);
            cb_tipo.Items.Add(Cadenas.DOBLE);
            cb_tipo.Items.Add(Cadenas.TRIPLE);
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            String estatus = cb_estatus.SelectedItem.ToString();
            String tipo = cb_tipo.SelectedItem.ToString();
            float precio = float.Parse(txt_precio.Text);
            this._habitacion.Estatus = estatus;
            this._habitacion.Tipo = tipo;
            this._habitacion.Precio = precio;
            var actualizado = DataBase.updateHabitaciones(this._habitacion);
            if (actualizado)
            {
                MessageBox.Show("La habitación " + _habitacion.Numero + " ha sido actualizada");
                _habitacion_option.comboBox1_SelectedIndexChanged(new Object(), new EventArgs());
            }
            else
                MessageBox.Show("Hubo un error, intente de nuevo");
            this.Dispose();
            }
    }
}
