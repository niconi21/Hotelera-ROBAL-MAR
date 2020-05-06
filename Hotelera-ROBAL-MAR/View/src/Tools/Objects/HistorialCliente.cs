using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class HistorialCliente
    {
        private String _pagoDia;
        public int ID { get; set; }
        public String cliente{ get; set; }
        public String Curp { get; set; }
        public int Habitacion { get; set; }
        public String PagoDia { get { return _pagoDia; } set { _pagoDia = "$" + value; } }
        public String FechaInicio { get; set; }
    }
}
