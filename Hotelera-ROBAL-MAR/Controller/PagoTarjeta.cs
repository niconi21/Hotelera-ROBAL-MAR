using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PagoTarjeta
    {
        public int ID { get; set; }
        public int IDmetodoPago { get; set; }
        public String Numero { get; set; }
        public String FechaExpiracion { get; set; }
        public int CCV { get; set; }
    }
}
