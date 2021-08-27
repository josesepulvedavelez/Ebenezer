using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEnt
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string NitCc { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Telefonos { get; set; }
        public string Correo { get; set; }
        public string Notas { get; set; }
        public int ClienteId { get; set; }
        public string UsuarioLog { get; set; }
    }
}
