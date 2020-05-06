using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Validations
{
    public class ValidateLogin
    {
        public bool validateLogin(String usuario, String clave)
        {
            return (new LoginDB()).login(usuario, clave);
        }
    }
}
