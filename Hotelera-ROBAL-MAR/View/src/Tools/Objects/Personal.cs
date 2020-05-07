using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class Personal
    {
        private String _nombre;
        private String _apepat;
        private String _apemat;
        private String _curp;
        private String _usuario;
        private String _clave;

        public int ID { get; set; }
        public int TipoPersonal { get; set; }
        public String Nombre
        {
            get { return _nombre; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el nombre del empleado"); else this._nombre = value; }
        }
        public String Apepat
        {
            get { return _apepat; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el apellido parteno del empleado"); else this._apepat = value; }
        }
        public String Apemat
        {
            get { return _apemat; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el apellido materno del empleado"); else this._apemat = value; }
        }
        public String Curp
        {
            get { return _curp; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el CURP del empleado"); else this._curp = value; }
        }
        public String Usuaio
        {
            get { return _curp; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa el usuario del empleado"); else this._curp = value; }
        }
        public String Clave
        {
            get { return _curp; }
            set { if (value.Equals("")) throw new HoteleraException("Ingresa la clave del empleado"); else this._curp = value; }
        }
    }
}
