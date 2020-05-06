﻿using System;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            Direccion_component direccion = new Direccion_component();
            this.flowLayout_direcciones.Controls.Add(direccion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefono_component telefono = new Telefono_component();
            this.flowLayout_telefonos.Controls.Add(telefono);
        }


    }
}
