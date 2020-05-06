using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class HoteleraException : Exception
    {
        private String _mensaje = "";
        public HoteleraException(String mensaje)
        {
            _mensaje = mensaje;
        }
        public override string ToString()
        {
            return "Error: " + _mensaje;
        }
    }
}
