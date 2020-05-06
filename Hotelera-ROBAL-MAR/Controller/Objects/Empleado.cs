using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Empleado
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apepat { get; set; }
        public String Apemat { get; set; }
        public String CURP { get; set; }
        public List<Direccion> Direcciones{ get; set; }
        public List<Telefono> Telefonos { get; set; }
    }
}
