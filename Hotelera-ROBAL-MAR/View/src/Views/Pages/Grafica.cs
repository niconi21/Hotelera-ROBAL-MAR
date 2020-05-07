using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.DataBase;
using View.src.Tools.Objects;

namespace View
{
    public partial class Grafica : Form
    {
        private Thread _hiloGrafica;
        private delegate void del();
        private List<HistorialGanancias> _ganancias;
        private void del_grafica()
        {
            try
            {
                if (InvokeRequired)
                {
                    del grafica = new del(del_grafica);
                    Invoke(grafica);
                }
                else
                {
                    _ganancias = DataBase.getHistorialGanancias();
                    grafica_ganancias.Series.Clear();
                    int i = 0;
                    foreach (var ganancia in _ganancias)
                    {
                        try
                        {
                            grafica_ganancias.Series.Add("Fecha del " + ganancia.FechaFinal.ToLongDateString());
                            grafica_ganancias.Series[i].Points.AddY(ganancia.Ganancia);
                            i++;
                        }
                        catch
                        {
                            grafica_ganancias.Series.FindByName("Fecha del " + ganancia.FechaFinal.ToLongDateString()).Points.AddY(ganancia.Ganancia);
                        }
                    }
                }
            }
            catch { }

        }
        public Grafica()
        {
            InitializeComponent();
            _ganancias = DataBase.getHistorialGanancias();
            _hiloGrafica = new Thread(graficar);
            _hiloGrafica.Start();
        }
        private void graficar()
        {
            while (true)
            {
                del_grafica();
                Thread.Sleep(1000);
            }
        }
        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void Grafica_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._hiloGrafica.Abort();
        }

       


    }
}
