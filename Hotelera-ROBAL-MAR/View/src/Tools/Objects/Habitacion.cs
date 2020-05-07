using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.src.Tools.Objects
{
    public class Habitacion
    {
        private float _precio;
        public int ID { get; set; }
        public int Numero { get; set; }
        public String Estatus { get; set; }
        public String Tipo { get; set; }
        public float Precio
        {
            get { return _precio; }
            set { if (value<0.0f) throw new HoteleraException("Ingresa un precio mayor a $0"); else this._precio = value; }
        }
        public int Piso { get; set; }
    }
}
