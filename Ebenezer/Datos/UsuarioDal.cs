using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDal
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string sqlLoguear = "SELECT COUNT(*) FROM USUARIO WHERE usuario=@usuario AND contraseña=@contraseña AND Rol=@Rol";
        string sqlSeleccionarUsuarios = "SELECT * FROM USUARIO";
        string sqlAgregarUsuario = "INSERT INTO USUARIO(Usuario, Contraseña, Nombres, Rol) VALUES(@Usuario, @Contraseña, @Nombres, @Rol)";
        string sqlActualizarUsuario = "UPDATE USUARIO SET Usuario=@Usuario, Contraseña=@Contraseña, Nombres=@Nombres, Rol=@Rol WHERE UsuarioId=@UsuarioId";
        int result;

        public bool Loguear(UsuarioEnt usuarioEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlLoguear, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuarioEnt.Usuario);
                    comando.Parameters.AddWithValue("@contraseña", usuarioEnt.Contraseña);
                    comando.Parameters.AddWithValue("@Rol", usuarioEnt.Rol);

                    result = (int)comando.ExecuteScalar();
                }
            }

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UsuarioEnt> ListarUsuarios()
        {
            List<UsuarioEnt> lst = new List<UsuarioEnt>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand(sqlSeleccionarUsuarios, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        UsuarioEnt usuarioEnt = new UsuarioEnt()
                        {
                            Usuario = Convert.ToString(lector["Usuario"]),
                            Contraseña = Convert.ToString(lector["Contraseña"]),
                            Nombres = Convert.ToString(lector["Nombres"]),
                            Rol = Convert.ToString(lector["Rol"]),
                            UsuarioId = Convert.ToInt32(lector["UsuarioId"])                            
                        };

                        lst.Add(usuarioEnt);
                    }
                }
            }

            return lst;
        }

        public bool AgregarUsuario(UsuarioEnt usuarioEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlAgregarUsuario, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuarioEnt.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", usuarioEnt.Contraseña);
                    comando.Parameters.AddWithValue("@Nombres", usuarioEnt.Nombres);
                    comando.Parameters.AddWithValue("@Rol", usuarioEnt.Rol);

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

        public bool ActualizarUsuario(UsuarioEnt usuarioEnt)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand(sqlActualizarUsuario, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuarioEnt.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", usuarioEnt.Contraseña);
                    comando.Parameters.AddWithValue("@Nombres", usuarioEnt.Nombres);
                    comando.Parameters.AddWithValue("@Rol", usuarioEnt.Rol);
                    comando.Parameters.AddWithValue("@UsuarioId", usuarioEnt.UsuarioId);

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
