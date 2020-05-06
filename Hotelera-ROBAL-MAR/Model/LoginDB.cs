using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Model
{
    public class LoginDB 
    {
        public bool login(String usuario, String clave)
        {
            using (var connection = (new Conexion()).getConexion())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Personal WHERE usuario = @usuario AND clave = @clave";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        UsuarioCache.ID = reader.GetInt32(0);
                        UsuarioCache.TipoPersonal = reader.GetInt32(1);
                        UsuarioCache.Nombre = reader.GetString(2);
                        UsuarioCache.Apepat= reader.GetString(3);
                        UsuarioCache.Apemat = reader.GetString(4);
                        UsuarioCache.CURP = reader.GetString(7);
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
            //var connection = (new Conexion()).getConexion();
            //connection.Open();
            //var command = new SqlCommand();
            
