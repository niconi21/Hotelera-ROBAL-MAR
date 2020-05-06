using Controller.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Info
{
    public class Pisos_info
    {
        public List<Piso> getPisos()
        {
            var pisosDB = (new PisoDB()).getPisosDB();
            var pisos = new List<Piso>();
            for (int i = 0; i < pisosDB.Count; i++)
            {
                pisos.Add(new Piso{
                    Numero = (int)pisosDB.ElementAt(i)
                });
            }
            return pisos;
        }
    }
}
