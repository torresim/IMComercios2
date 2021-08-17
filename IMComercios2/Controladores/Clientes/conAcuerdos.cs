using IMComercios2.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Clientes
{
    class conAcuerdos
    {
        srvAcuerdos acuerdos = new srvAcuerdos();

        public conAcuerdos()
        {

        }

        public List<entAcuerdo> traerAcuerdos(int codigo)
        {
            return acuerdos.traerAcuerdos(codigo);
        }
    }
}
