using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Entidades
{
    public class entListaPrecios
    {
        public int cod_lista { get; set; }
        public string descripcion { get; set; }
        public string aplica_a { get; set; }
        public char habilitado { get; set; }
    }
}
