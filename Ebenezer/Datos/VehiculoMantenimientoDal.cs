using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VehiculoMantenimientoDal
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string sqlListarMantenimientos = "SELECT * FROM VehiculoMantenimientoView";
        string sqlListarMantenimientosByDate = "SELECT * FROM VehiculoMantenimientoView WHERE Fecha BETWEEN @finicio AND @ffin AND ClienteId=@ClienteId";
        string sqlListarMantenimientosById = "SELECT * FROM VehiculoMantenimientoView WHERE VehiculoId=@VehiculoId";
        string sqlAgregarMantenimientoVehiculo = "INSERT INTO VehiculoMantenimiento(Fecha, Tipo, PorGarantia, Actividades, Notas, Usuario, VehiculoId) VALUES(@Fecha, @Tipo, @PorGarantia, @Actividades, @Notas, @Usuario, @VehiculoId)";
        string sqlActualizarMantenimientovehiculo = "UPDATE VehiculoMantenimiento SET Fecha=@Fecha, Tipo=@Tipo, PorGarantia=@PorGarantia, Actividades=@Actividades, Notas=@Notas, Usuario=@Usuario, VehiculoId=@VehiculoId WHERE VehiculoMantenimientoId=@VehiculoMantenimientoId";
        string sqlListarVehiculosId = "SELECT Placa, vehiculoId FROM VEHICULO";
        int result;

        public List<VehiculoMantenimientoEnt> ListarMantenimientos()
        {
            List<VehiculoMantenimientoEnt> lst = new List<VehiculoMantenimientoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarMantenimientos, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoMantenimientoEnt vehiculoMantenimientoEnt = new VehiculoMantenimientoEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            Placa = Convert.ToString(lector["Placa"]),
                            VehiculoId = Convert.ToInt32(lector["vehiculoId"]),
                            Garantia = Convert.ToDateTime(lector["Garantia"]),
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            PorGarantia = Convert.ToString(lector["PorGarantia"]),
                            Actividades = Convert.ToString(lector["Actividades"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            Usuario = Convert.ToString(lector["Usuario"]),
                            VehiculoMantenimientoId = Convert.ToInt32(lector["VehiculoMantenimientoId"])
                        };

                        lst.Add(vehiculoMantenimientoEnt);
                    }
                }
            }

            return lst;
        }

        public List<VehiculoMantenimientoEnt> ListarMantenimientosByDate(DateTime inicio, DateTime fin, int clienteId)
        {
            List<VehiculoMantenimientoEnt> lst = new List<VehiculoMantenimientoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarMantenimientosByDate, conexion))
                {
                    comando.Parameters.AddWithValue("@finicio", inicio);
                    comando.Parameters.AddWithValue("@ffin", fin);
                    comando.Parameters.AddWithValue("@clienteId", clienteId);

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoMantenimientoEnt vehiculoMantenimientoEnt = new VehiculoMantenimientoEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            Placa = Convert.ToString(lector["Placa"]),
                            VehiculoId = Convert.ToInt32(lector["vehiculoId"]),
                            Garantia = Convert.ToDateTime(lector["Garantia"]),
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            PorGarantia = Convert.ToString(lector["PorGarantia"]),
                            Actividades = Convert.ToString(lector["Actividades"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            Usuario = Convert.ToString(lector["Usuario"]),
                            VehiculoMantenimientoId = Convert.ToInt32(lector["VehiculoMantenimientoId"])
                        };

                        lst.Add(vehiculoMantenimientoEnt);
                    }
                }
            }

            return lst;
        }

        public List<VehiculoMantenimientoEnt> ListarMantenimientosById(int vehiculoId)
        {
            List<VehiculoMantenimientoEnt> lst = new List<VehiculoMantenimientoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarMantenimientosById, conexion))
                {
                    comando.Parameters.AddWithValue("@VehiculoId", vehiculoId);

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoMantenimientoEnt vehiculoMantenimientoEnt = new VehiculoMantenimientoEnt()
                        {
                            Cliente = Convert.ToString(lector["Cliente"]),
                            ClienteId = Convert.ToInt32(lector["ClienteId"]),
                            Placa = Convert.ToString(lector["Placa"]),
                            VehiculoId = Convert.ToInt32(lector["vehiculoId"]),
                            Garantia = Convert.ToDateTime(lector["Garantia"]),
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            PorGarantia = Convert.ToString(lector["PorGarantia"]),
                            Actividades = Convert.ToString(lector["Actividades"]),
                            Notas = Convert.ToString(lector["Notas"]),
                            Usuario = Convert.ToString(lector["Usuario"]),
                            VehiculoMantenimientoId = Convert.ToInt32(lector["VehiculoMantenimientoId"])
                        };

                        lst.Add(vehiculoMantenimientoEnt);
                    }
                }
            }

            return lst;
        }

        public List<VehiculoEnt> ListarVehiculosId()
        {
            List<VehiculoEnt> lst = new List<VehiculoEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlListarVehiculosId, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        VehiculoEnt vehiculoEnt = new VehiculoEnt()
                        {
                            Placa = Convert.ToString(lector["Placa"]),
                            VehiculoId = Convert.ToInt32(lector["VehiculoId"])
                        };

                        lst.Add(vehiculoEnt);
                    }
                }
            }

            return lst;
        }

        public bool AgregarMantenimiento(VehiculoMantenimientoEnt vehiculoMantenimientoEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlAgregarMantenimientoVehiculo, conexion))
                {                    
                    comando.Parameters.AddWithValue("@Fecha", vehiculoMantenimientoEnt.Fecha);
                    comando.Parameters.AddWithValue("@Tipo", vehiculoMantenimientoEnt.Tipo);
                    comando.Parameters.AddWithValue("@PorGarantia", vehiculoMantenimientoEnt.PorGarantia);
                    comando.Parameters.AddWithValue("@Actividades", vehiculoMantenimientoEnt.Actividades);
                    comando.Parameters.AddWithValue("@Notas", vehiculoMantenimientoEnt.Notas);
                    comando.Parameters.AddWithValue("@Usuario", vehiculoMantenimientoEnt.Usuario);
                    comando.Parameters.AddWithValue("@VehiculoId", vehiculoMantenimientoEnt.VehiculoId);

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

        public bool ActualizarMantenimiento(VehiculoMantenimientoEnt vehiculoMantenimientoEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlActualizarMantenimientovehiculo, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", vehiculoMantenimientoEnt.Fecha);
                    comando.Parameters.AddWithValue("@Tipo", vehiculoMantenimientoEnt.Tipo);
                    comando.Parameters.AddWithValue("@PorGarantia", vehiculoMantenimientoEnt.PorGarantia);
                    comando.Parameters.AddWithValue("@Actividades", vehiculoMantenimientoEnt.Actividades);
                    comando.Parameters.AddWithValue("@Notas", vehiculoMantenimientoEnt.Notas);
                    comando.Parameters.AddWithValue("@Usuario", vehiculoMantenimientoEnt.Usuario);
                    comando.Parameters.AddWithValue("@VehiculoId", vehiculoMantenimientoEnt.VehiculoId);
                    comando.Parameters.AddWithValue("@VehiculoMantenimientoId", vehiculoMantenimientoEnt.VehiculoMantenimientoId);

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
