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
using View.Options;

namespace View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            configurarContenedor(cliente);
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
        private void label2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            configurarContenedor(cliente);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            configurarContenedor(historial);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        

    }
}
