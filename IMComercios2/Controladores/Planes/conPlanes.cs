using IMComercios2.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Planes
{
    public class conPlanes
    {
        srvPlanes planes = new srvPlanes();

        public conPlanes()
        {

        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entPlanes> traerPlanes(string h,string concepto)
        {
            return planes.traerPlanes(h,concepto);
        }
    }
}
