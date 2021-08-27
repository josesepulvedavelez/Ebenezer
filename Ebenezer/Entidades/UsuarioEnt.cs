using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioEnt
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Rol { get; set; }
        public int UsuarioId { get; set; }        
    }
}
