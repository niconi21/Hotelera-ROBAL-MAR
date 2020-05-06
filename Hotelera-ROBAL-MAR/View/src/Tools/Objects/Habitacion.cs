using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class Habitacion
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public String Estatus { get; set; }
        public String Tipo { get; set; }
        public float Precio { get; set; }
        public int Piso { get; set; }
    }
}
