using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools
{
    class HoteleraException : Exception
    {
        private String _mensaje;
        public HoteleraException(String mensaje)
        {
            this._mensaje = mensaje;
        }
        public override string ToString()
        {
            return "Error: "+_mensaje;
        }
    }
}
