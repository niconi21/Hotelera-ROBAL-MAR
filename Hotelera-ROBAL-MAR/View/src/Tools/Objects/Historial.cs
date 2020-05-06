using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class Historial
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Personal { get; set; }
        public int Habiacion { get; set; }
        public float PagoDia { get; set; }
        public float MontoTotal { get; set; }
        public String FechaInicio { get; set; }
        public String FechaFinal{ get; set; }
    }
}
