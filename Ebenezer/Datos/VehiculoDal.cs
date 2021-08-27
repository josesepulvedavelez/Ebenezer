using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VehiculoDal
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string sqlListarVehiculos = "SELECT * FROM VEHICULOVIEW";
        string sqlListarVehiculosById = "SELECT * FROM VEHICULOVIEW WHERE ClienteId=@ClienteId";
        string sqlAgregarVehiculo = "INSERT INTO VEHICULO(Fecha, Placa, Marca, Modelo, Garantia, Notas, ClienteId, UsuarioLog) VALUES(@Fecha, @Placa, @Marca, @Modelo, @Garantia, @Notas, @ClienteId, @UsuarioLog)";
        string sqlListarClientesId = "SELECT Cliente, ClienteId FROM CLIENTE";
        string sqlActualizarVehiculo = "UPDATE VEHICULO SET Fecha=@Fecha, Placa=@placa, Marca=@Marca, Modelo=@Modelo, Garantia=@Garantia, Notas=@Notas, ClienteId=@ClienteId WHERE VehiculoId=@VehiculoId";
        int result;

        public List<VehiculoEnt> ListarVehiculos()
        {
            List<VehiculoEnt> lst = new List<VehiculoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarVehiculos, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoEnt vehiculoEnt = new VehiculoEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Placa = Convert.ToString(lector["Placa"]),
                            Marca = Convert.ToString(lector["Marca"]),
                            Modelo = Convert.ToString(lector["Modelo"]),
                            Garantia = Convert.ToDateTime(lector["Garantia"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            VehiculoId = Convert.ToInt32(lector["VehiculoId"]),
                            UsuarioLog = Convert.ToString(lector["UsuarioLog"])
                        };

                        lst.Add(vehiculoEnt);
                    }
                }
            }

            return lst;
        }

        public List<VehiculoEnt> ListarVehiculosById(int clienteId)
        {
            List<VehiculoEnt> lst = new List<VehiculoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarVehiculosById, conexion))
                {
                    comando.Parameters.AddWithValue("@ClienteId", clienteId);

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoEnt vehiculoEnt = new VehiculoEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Placa = Convert.ToString(lector["Placa"]),
                            Marca = Convert.ToString(lector["Marca"]),
                            Modelo = Convert.ToString(lector["Modelo"]),
                            Garantia = Convert.ToDateTime(lector["Garantia"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            VehiculoId = Convert.ToInt32(lector["VehiculoId"]),
                            UsuarioLog = Convert.ToString(lector["UsuarioLog"])
                        };

                        lst.Add(vehiculoEnt);
                    }                    
                }
            }

            return lst;
        }

        public List<ClienteEnt> ListarClientesId()
        {
            List<ClienteEnt> lst = new List<ClienteEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarClientesId, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ClienteEnt clienteEnt = new ClienteEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"])
                        };

                        lst.Add(clienteEnt);
                    }
                }
            }

            return lst;
        }

        public bool AgregarVehiculo(VehiculoEnt vehiculoEnt)
        {            
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlAgregarVehiculo, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", vehiculoEnt.Fecha);
                    comando.Parameters.AddWithValue("@Placa", vehiculoEnt.Placa);
                    comando.Parameters.AddWithValue("@Marca", vehiculoEnt.Marca);
                    comando.Parameters.AddWithValue("@Modelo", vehiculoEnt.Modelo);
                    comando.Parameters.AddWithValue("@Garantia", vehiculoEnt.Garantia);
                    comando.Parameters.AddWithValue("@Notas", vehiculoEnt.Notas);
                    comando.Parameters.AddWithValue("@ClienteId", vehiculoEnt.ClienteId);
                    comando.Parameters.AddWithValue("@UsuarioLog", vehiculoEnt.UsuarioLog);

                    conexion.Open();
                    result = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarVehiculo(VehiculoEnt vehiculoEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlActualizarVehiculo, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", vehiculoEnt.Fecha);
                    comando.Parameters.AddWithValue("@Placa", vehiculoEnt.Placa);
                    comando.Parameters.AddWithValue("@Marca", vehiculoEnt.Marca);
                    comando.Parameters.AddWithValue("@Modelo", vehiculoEnt.Modelo);
                    comando.Parameters.AddWithValue("@Garantia", vehiculoEnt.Garantia);
                    comando.Parameters.AddWithValue("@Notas", vehiculoEnt.Notas);
                    comando.Parameters.AddWithValue("@ClienteId", vehiculoEnt.ClienteId);                    
                    comando.Parameters.AddWithValue("@VehiculoId", vehiculoEnt.VehiculoId);

                    conexion.Open();
                    result = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
