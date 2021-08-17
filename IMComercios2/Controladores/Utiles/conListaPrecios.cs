using IMComercios2.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Clientes
{
    class conListaPrecios
    {
        srvListaPrecios lista = new srvListaPrecios();

        /// <summary>
        /// Constructor del controlador de Proveedores
        /// </summary>
        /// <returns></returns>
        public conListaPrecios()
        {

        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entListaPrecios> traerListaPrecio(int cod_empresa)
        {
            return lista.traerListaPrecio(cod_empresa);
        }
    }
}
