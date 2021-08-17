using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Entidades
{
    public class entUsuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int? empresa { get; set; }
        public int? cod_vendedor { get; set; }
        public char cambiar_contrasenia { get; set; }
    }
}
