using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoEnt
    {
        public string Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Garantia { get; set; }
        public string Notas { get; set; }
        public int VehiculoId { get; set; }
        public string UsuarioLog { get; set; }
    }
}
