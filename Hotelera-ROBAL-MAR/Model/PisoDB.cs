using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PisoDB
    {
        public List<Object> getPisosDB()
        {
            using (var connection = (new Conexion()).getConexion())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Piso";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    List<Object> pisos = null;
                    if (reader.HasRows)
                    {
                        pisos = new List<object>();
                        while (reader.Read())
                        {
                            pisos.Add(reader.GetInt32(1));
                        }
                    }
                    return pisos;
                }
            }
        }
    }
}
