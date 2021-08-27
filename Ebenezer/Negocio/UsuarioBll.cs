using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioBll
    {
        UsuarioDal usuarioDal;
        bool result;
        List<UsuarioEnt> lst;

        public bool Loguear(UsuarioEnt usuarioEnt)
        {
            usuarioDal = new UsuarioDal();
            result = usuarioDal.Loguear(usuarioEnt);

            return result;
        }

        public List<UsuarioEnt> ListarUsuarios()
        {
            usuarioDal = new UsuarioDal();
            lst = usuarioDal.ListarUsuarios();

            return lst;
        }

        public bool AgregarUsuario(UsuarioEnt usuarioEnt)
        {
            usuarioDal = new UsuarioDal();
            result = usuarioDal.AgregarUsuario(usuarioEnt);

            return result;
        }

        public bool ActualizarUsuario(UsuarioEnt usuarioEnt)
        {
            usuarioDal = new UsuarioDal();
            result = usuarioDal.ActualizarUsuario(usuarioEnt);

            return result;
        }
    }
}
