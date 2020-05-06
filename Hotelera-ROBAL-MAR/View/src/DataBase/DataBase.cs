using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.src.Tools;
using View.src.Tools.Objects;

namespace View.src.DataBase
{
    public static class DataBase
    {
        private static String _stringConnection = "server=DESKTOP-OE9RG4S; database=Hotelera_ROBAL_MAR ; integrated security = true";
        public static bool login(String usuario, String clave)
        {
            using (var connection = new SqlConnection(_stringConnection))
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
                        UsuarioCache.Apepat = reader.GetString(3);
                        UsuarioCache.Apemat = reader.GetString(4);
                        UsuarioCache.Usuaio = reader.GetString(5);
                        UsuarioCache.Clave = reader.GetString(6);
                        UsuarioCache.Curp = reader.GetString(7);
                        return true;
                    }
                    return false;
                }
            }
        }
        public static List<Piso> getPisos()
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Piso";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    List<Piso> pisos = null;
                    if (reader.HasRows)
                    {
                        pisos = new List<Piso>();
                        while (reader.Read())
                        {
                            pisos.Add(new Piso
                            {
                                ID = reader.GetInt32(0),
                                Numero = reader.GetInt32(1),
                            });
                        }
                        return pisos;
                    }
                    return pisos;
                }
            }
        }
        public static List<Habitacion> getHabitaciones(int piso)
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Habitacion WHERE piso = @piso";
                    command.Parameters.AddWithValue("@piso", piso);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    List<Habitacion> habitaciones = null;
                    if (reader.HasRows)
                    {
                        habitaciones = new List<Habitacion>();
                        while (reader.Read())
                        {
                            habitaciones.Add(new Habitacion
                            {
                                ID = reader.GetInt32(0),
                                Numero = reader.GetInt32(1),
                                Estatus = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Precio = (float)reader.GetSqlMoney(4).ToDouble(),
                                Piso = reader.GetInt32(5)
                            });
                        }
                        return habitaciones;
                    }
                    return habitaciones;
                }
            }
        }
        public static bool updateHabitaciones(Habitacion habitacion)
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Habitacion SET estatus = @estatus, tipo = @tipo, precio = @precio WHERE numero = @numero";
                    command.Parameters.AddWithValue("@numero", habitacion.Numero);
                    command.Parameters.AddWithValue("@estatus", habitacion.Estatus);
                    command.Parameters.AddWithValue("@tipo", habitacion.Tipo);
                    command.Parameters.AddWithValue("@precio", habitacion.Precio);
                    command.CommandType = CommandType.Text;
                    int row = command.ExecuteNonQuery();
                    if (row > 0)
                        return true;
                    return false;
                }
            }
        }
        internal static List<Habitacion> getHabitacionesDisponibles()
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Habitacion WHERE estatus = @estatus";
                    command.Parameters.AddWithValue("@estatus", Cadenas.DISPONIBLE);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    List<Habitacion> habitaciones = null;
                    if (reader.HasRows)
                    {
                        habitaciones = new List<Habitacion>();
                        while (reader.Read())
                        {
                            habitaciones.Add(new Habitacion
                            {
                                ID = reader.GetInt32(0),
                                Numero = reader.GetInt32(1),
                                Estatus = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Precio = (float)reader.GetSqlMoney(4).ToDouble(),
                                Piso = reader.GetInt32(5)
                            });
                        }
                        return habitaciones;
                    }
                    return habitaciones;
                }
            }
        }
        internal static bool InsertCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Cliente VALUES(@nombre,@apepat,@apemat,@curp)";
                    command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@apepat", cliente.Apepat);
                    command.Parameters.AddWithValue("@apemat", cliente.Apemat);
                    command.Parameters.AddWithValue("@curp", cliente.Curp);
                    command.CommandType = CommandType.Text;
                    var rows = command.ExecuteNonQuery();
                    
                    if (rows>0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        internal static List<Cliente> getClientes()
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cliente";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    List<Cliente> clientes = null;
                    if (reader.HasRows)
                    {
                        clientes = new List<Cliente>();
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apepat = reader.GetString(2),
                                Apemat = reader.GetString(3),
                                Curp = reader.GetString(4)
                            });
                        }
                        return clientes;
                    }
                    return clientes;
                }
            }
        }
        internal static Cliente getCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cliente WHERE curp = @curp";
                    command.Parameters.AddWithValue("@curp", cliente.Curp);
                    
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    Cliente clienteDB = null;
                    if (reader.HasRows)
                    {
                        reader.Read();
                        clienteDB = new Cliente();

                        clienteDB.ID = reader.GetInt32(0);
                            clienteDB.Nombre = reader.GetString(1);
                            clienteDB.Apepat = reader.GetString(2);
                            clienteDB.Apemat = reader.GetString(3);
                            clienteDB.Curp = reader.GetString(4);
                        

                        return clienteDB;
                    }
                    return clienteDB;
                }
            }
        }

        internal static bool InsertHistorial(Historial historial)
        {
            using (var connection = new SqlConnection(_stringConnection))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Historial VALUES(@cliente,@personal,@habitacion,@pagoDia,@montoTotal,@fechaInicio,null)";
                    command.Parameters.AddWithValue("@cliente", historial.Cliente);
                    command.Parameters.AddWithValue("@personal", historial.Personal);
                    command.Parameters.AddWithValue("@habitacion", historial.Habiacion);
                    command.Parameters.AddWithValue("@pagoDia", historial.PagoDia);
                    command.Parameters.AddWithValue("@montoTotal", historial.MontoTotal);
                    command.Parameters.AddWithValue("@fechaInicio", historial.FechaInicio);
                    command.CommandType = CommandType.Text;
                    var rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
