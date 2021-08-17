using IMComercios2.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Utiles
{
    class conCondicionesVenta
    {
        srvCondicionesVenta condiciones = new srvCondicionesVenta();

        /// <summary>
        /// Constructor del controlador de Proveedores
        /// </summary>
        /// <returns></returns>
        public conCondicionesVenta()
        {

        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entCondicionesVenta> traerCondicionesVenta()
        {
            return condiciones.traerCondicionesVenta();
        }
    }
}
