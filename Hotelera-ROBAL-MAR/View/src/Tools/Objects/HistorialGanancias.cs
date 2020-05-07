using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class HistorialGanancias
    {
        public String Cliente { get; set; }
        public String Empleado { get; set; }
        public int Habitacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal{ get; set; }
        public int DiasHospedados { get; set; }
        public float Ganancia { get; set; }

    }
}
