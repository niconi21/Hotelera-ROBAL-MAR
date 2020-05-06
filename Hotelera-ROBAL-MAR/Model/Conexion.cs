using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conexion
    {
        private String _stringConecction = "server=DESKTOP-OE9RG4S; database=Hotelera_ROBAL_MAR ; integrated security = true";
        private SqlConnection _connection;
        public SqlConnection getConexion()
        {
            return this._connection = new SqlConnection(this._stringConecction);
        }

    }
}
