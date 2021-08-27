using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDal
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string sqlSeleccionarClientes = "SELECT Fecha, Cliente, NitCc, Direccion, Contacto, Telefonos, Correo, Notas, ClienteId, UsuarioLog FROM CLIENTE";
        string sqlAgregarCliente = "INSERT INTO CLIENTE(Fecha, Cliente, NitCc, Direccion, Contacto, Telefonos, Correo, Notas, UsuarioLog) VALUES(@Fecha, @Cliente, @NitCc, @Direccion, @Contacto, @Telefonos, @Correo, @Notas, @UsuarioLog)";
        string sqlActualizarCliente = "UPDATE CLIENTE SET Fecha=@Fecha, Cliente=@Cliente, NitCc=@NitCc, Direccion=@Direccion, Contacto=@Contacto, Telefonos=@Telefonos, Correo=@Correo, Notas=@Notas WHERE ClienteId=@ClienteId";        
        int result;

        public List<ClienteEnt> ListarClientes()
        {
            List<ClienteEnt> lst = new List<ClienteEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlSeleccionarClientes, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ClienteEnt clienteEnt = new ClienteEnt()
                        {
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Cliente = Convert.ToString(lector["Cliente"]),
                            NitCc = Convert.ToString(lector["NitCc"]),
                            Direccion = Convert.ToString(lector["Direccion"]),
                            Contacto = Convert.ToString(lector["Contacto"]),
                            Telefonos = Convert.ToString(lector["Telefonos"]),
                            Correo = Convert.ToString(lector["Correo"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            UsuarioLog = Convert.ToString(lector["UsuarioLog"])
                        };

                        lst.Add(clienteEnt);
                    }
                }
            }

            return lst;
        }

        public bool AgregarCliente(ClienteEnt clienteEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlAgregarCliente, conexion))
                {                    
                    comando.Parameters.AddWithValue("@Fecha", clienteEnt.Fecha);
                    comando.Parameters.AddWithValue("@Cliente", clienteEnt.Cliente);
                    comando.Parameters.AddWithValue("@NitCc", clienteEnt.NitCc);
                    comando.Parameters.AddWithValue("@Direccion", clienteEnt.Direccion);
                    comando.Parameters.AddWithValue("@Contacto", clienteEnt.Contacto);
                    comando.Parameters.AddWithValue("@Telefonos", clienteEnt.Telefonos);
                    comando.Parameters.AddWithValue("@Correo", clienteEnt.Correo);
                    comando.Parameters.AddWithValue("@Notas", clienteEnt.Notas);
                    comando.Parameters.AddWithValue("@UsuarioLog", clienteEnt.UsuarioLog);

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

        public bool ActualizarCliente(ClienteEnt clienteEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlActualizarCliente, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", clienteEnt.Fecha);
                    comando.Parameters.AddWithValue("@Cliente", clienteEnt.Cliente);
                    comando.Parameters.AddWithValue("@NitCc", clienteEnt.NitCc);
                    comando.Parameters.AddWithValue("@Direccion", clienteEnt.Direccion);
                    comando.Parameters.AddWithValue("@Contacto", clienteEnt.Contacto);
                    comando.Parameters.AddWithValue("@Telefonos", clienteEnt.Telefonos);
                    comando.Parameters.AddWithValue("@Correo", clienteEnt.Correo);
                    comando.Parameters.AddWithValue("@Notas", clienteEnt.Notas);                    
                    comando.Parameters.AddWithValue("@ClienteId", clienteEnt.ClienteId);

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
