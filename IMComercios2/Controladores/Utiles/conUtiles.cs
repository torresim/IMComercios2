using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Utiles
{
    public class conUtiles
    {
        srvUtiles utiles = new srvUtiles();

        /// <summary>
        /// Constructor del controlador de Utiles
        /// </summary>
        /// <returns></returns>
        public conUtiles()
        {

        }

        /// <summary>
        /// Trae el listado de provincias de la base de datos atravez de la api
        /// </summary>
        /// <returns>Lista de provincias</returns>
        public DataTable traerProvincias()
        {
            return utiles.traerProvincias();
        }

        /// <summary>
        /// Trae el listado de localidades de una provincia desde la base de datos atravez de la api
        /// </summary>
        /// <param name="provincia">Codigo de provincia</param>
        /// <returns>Lista de localidades</returns>
        public DataTable traerLocalidades(int provincia)
        {
            return utiles.traerLocalidades(provincia);
        }
    }
}
