using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Entidades
{
    class entLocalidad
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int cod_provincia { get; set; }
        public int cod_afip_localidad { get; set; }
        public int cod_postal { get; set; }
    }
}
