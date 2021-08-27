using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteBll
    {
        ClienteDal clienteDal;
        bool result;
        List<ClienteEnt> lst;

        public List<ClienteEnt> ListarClientes()
        {
            clienteDal = new ClienteDal();
            lst = clienteDal.ListarClientes();

            return lst;
        }

        public bool AgregarCliente(ClienteEnt clienteEnt)
        {
            clienteDal = new ClienteDal();
            result = clienteDal.AgregarCliente(clienteEnt);

            return result;
        }

        public bool ActualizarCliente(ClienteEnt clienteEnt)
        {
            clienteDal = new ClienteDal();
            result = clienteDal.ActualizarCliente(clienteEnt);

            return result;
        }

    }
}
