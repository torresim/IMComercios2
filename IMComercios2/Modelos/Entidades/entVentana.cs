using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Modelos.Entidades
{
    public class entVentana
    {
        public Form ventana { get; set; }
        public int estado { get; set; } //0 - Normal, 1 - Maximizado, 2 - Minimizado
        public int tipo { get; set; } //0 - De panel,  1 - Flotante
    }
}
