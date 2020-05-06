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
using View.src.Tools;


namespace View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.label_nombre.Text = UsuarioCache.Nombre + " " + UsuarioCache.Apepat + "," + UsuarioCache.Apemat;
            this.label_tipo.Text = "Tipo de personal:\n" + (UsuarioCache.TipoPersonal == 0 ? Cadenas.GERENTE : Cadenas.PERSONAL);
            View.Options.Cliente cliente = new View.Options.Cliente();
            configurarContenedor(cliente);
            if (UsuarioCache.TipoPersonal == 1)
            {
                this.panel5.Visible = false;
            }
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
            View.Options.Cliente cliente = new View.Options.Cliente();
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

        private void panel9_Click(object sender, EventArgs e)
        {
            UsuarioCache.Nombre = "";
            UsuarioCache.Apepat= "";
            UsuarioCache.Apemat = "";
            UsuarioCache.Clave = "";
            UsuarioCache.Usuaio = "";
            UsuarioCache.TipoPersonal = 1;
            UsuarioCache.ID = -1;
            Login login = new Login();
            login.Show();
            this.Dispose();
        }


        

    }
}
