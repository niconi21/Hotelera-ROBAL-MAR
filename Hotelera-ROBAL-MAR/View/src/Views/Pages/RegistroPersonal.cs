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
using View.src.DataBase;
using View.src.Tools;
using View.src.Tools.Objects;

namespace View
{
    public partial class RegistroPersonal : Form
    {
        private bool actualizado = false;
        private Personal _personal;
        private View.Options.Personal _option;
        public RegistroPersonal(View.Options.Personal option ,Personal personal = null)
        {
            InitializeComponent();
            _option = option;
            cb_personal.SelectedIndex = 0;
            if (personal != null)
            {
                _personal = personal;
                txt_nombre.Text = _personal.Nombre;
                txt_apepat.Text = _personal.Apepat;
                txt_apemat.Text = _personal.Apemat;
                txt_usuario.Text = _personal.Usuaio;
                txt_clave.Text = _personal.Clave;
                txt_curp.Text = _personal.Curp;
                cb_personal.SelectedIndex = _personal.TipoPersonal;
                actualizado = true;
            }
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
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!actualizado)
                {
                    try
                    {
                        Personal personal = new Personal
                        {
                            TipoPersonal = cb_personal.SelectedIndex,
                            Nombre = txt_nombre.Text,
                            Apepat = txt_apepat.Text,
                            Apemat = txt_apemat.Text,
                            Usuaio = txt_usuario.Text,
                            Clave = txt_clave.Text,
                            Curp = txt_curp.Text
                        };

                        if (!DataBase.InsertPersonal(personal))
                            MessageBox.Show("El empleado no fue registrado");
                        else
                            MessageBox.Show("El empleado fue registrado");
                        _option.llenarPersonal();
                        this.Dispose();
                    }
                    catch (HoteleraException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    _personal = new Personal
                    {
                        ID = _personal.ID,
                        TipoPersonal = cb_personal.SelectedIndex,
                        Nombre = txt_nombre.Text,
                        Apepat = txt_apepat.Text,
                        Apemat = txt_apemat.Text,
                        Usuaio = txt_usuario.Text,
                        Clave = txt_clave.Text,
                        Curp = txt_curp.Text
                    };
                    if (!DataBase.updateEmpleado(_personal))
                        MessageBox.Show("El empleado no fue actualizado");
                    else
                        MessageBox.Show("El empleado fue actualizado");
                    _option.llenarPersonal();
                    this.Dispose();
                }
                
            }
            catch(HoteleraException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
