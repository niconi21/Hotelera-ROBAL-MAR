using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class Cliente
    {
        private String _nombre;
        private String _apepat;
        private String _apemat;
        private String _curp;
        public int ID { get; set; }
        public String Nombre
        {
            get { return _nombre; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el nombre del cliente"); else this._nombre = value; }
        }
        public String Apepat
        {
            get { return _apepat; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el apellido parteno del cliente"); else this._apepat = value; }
        }
        public String Apemat
        {
            get { return _apemat; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el apellido materno del cliente"); else this._apemat = value; }
        }
        public String Curp
        {
            get { return _curp; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el CURP del cliente"); else this._curp = value; }
        }
    }
}
