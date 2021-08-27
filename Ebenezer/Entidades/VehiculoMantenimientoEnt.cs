using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoMantenimientoEnt
    {
        public string Cliente { get; set; }
        public int ClienteId { get; set; }
        public string Placa { get; set; }
        public int VehiculoId { get; set; }
        public DateTime Garantia { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string PorGarantia { get; set; }
        public string Actividades { get; set; }
        public string Notas { get; set; }
        public string Usuario { get; set; }
        public int VehiculoMantenimientoId { get; set; }
    }
}
