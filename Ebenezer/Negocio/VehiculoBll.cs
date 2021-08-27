using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VehiculoBll
    {
        VehiculoDal vehiculoDal;
        bool result;
        List<VehiculoEnt> lst;
        List<ClienteEnt> lstClienteId;
        public List<VehiculoEnt> ListarVehiculos()
        {
            vehiculoDal = new VehiculoDal();
            lst = vehiculoDal.ListarVehiculos();

            return lst;
        }

        public List<VehiculoEnt> ListarVehiculosById(int clienteId)
        {
            vehiculoDal = new VehiculoDal();
            lst = vehiculoDal.ListarVehiculosById(clienteId);

            return lst;
        }

        public List<ClienteEnt> ListarClientesId()
        {
            vehiculoDal = new VehiculoDal();
            lstClienteId = vehiculoDal.ListarClientesId();

            return lstClienteId;
        }

        public bool AgregarVehiculo(VehiculoEnt vehiculoEnt)
        {
            vehiculoDal = new VehiculoDal();
            result = vehiculoDal.AgregarVehiculo(vehiculoEnt);

            return result;
        }

        public bool ActualizarVehiculo(VehiculoEnt vehiculoEnt)
        {
            vehiculoDal = new VehiculoDal();
            result = vehiculoDal.ActualizarVehiculo(vehiculoEnt);

            return result;
        }

    }
}
