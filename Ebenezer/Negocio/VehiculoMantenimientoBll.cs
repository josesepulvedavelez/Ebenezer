using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VehiculoMantenimientoBll
    {
        VehiculoMantenimientoDal vehiculoMantenimientoDal;
        bool result;
        List<VehiculoMantenimientoEnt> lst;
        List<VehiculoEnt> lstVehiculosId;

        public List<VehiculoMantenimientoEnt> ListarMantenimientos()
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            lst = vehiculoMantenimientoDal.ListarMantenimientos();

            return lst;
        }

        public List<VehiculoMantenimientoEnt> ListarMantenimientosByDate(DateTime inicio, DateTime fin, int clienteId)
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            lst = vehiculoMantenimientoDal.ListarMantenimientosByDate(inicio, fin, clienteId);

            return lst;
        }

        public List<VehiculoMantenimientoEnt> ListarMantenimientosById(int vehiculoId)
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            lst = vehiculoMantenimientoDal.ListarMantenimientosById(vehiculoId);

            return lst;
        }

        public List<VehiculoEnt> ListarVehiculosId()
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            lstVehiculosId = vehiculoMantenimientoDal.ListarVehiculosId();

            return lstVehiculosId;
        }

        public bool AgregarMantenimiento(VehiculoMantenimientoEnt vehiculoMantenimientoEnt)
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            result = vehiculoMantenimientoDal.AgregarMantenimiento(vehiculoMantenimientoEnt);

            return result;
        }

        public bool ActualizarMantenimiento(VehiculoMantenimientoEnt vehiculoMantenimientoEnt)
        {
            vehiculoMantenimientoDal = new VehiculoMantenimientoDal();
            result = vehiculoMantenimientoDal.ActualizarMantenimiento(vehiculoMantenimientoEnt);

            return result;
        }

    }
}
