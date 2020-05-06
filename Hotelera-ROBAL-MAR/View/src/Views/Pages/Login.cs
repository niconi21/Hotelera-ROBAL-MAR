    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.DataBase;

namespace View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            String usuario = txt_usuario.Text;
            String clave = txt_clave.Text;
            if (!usuario.Equals("") || !clave.Equals(""))
            {
                var validacion = DataBase.login(usuario,clave);
                if (validacion)
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    label_error.Text = "Error: usuario y/o contraseña incorrectos";
                    label_error.Visible = true;
                }
            }
            else
            {
                label_error.Text = "Error: Ingresa un usuario y/o contraseña";
                label_error.Visible = true;
            }
        }
    }
}
