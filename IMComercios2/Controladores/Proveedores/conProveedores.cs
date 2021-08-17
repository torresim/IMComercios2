using IMComercios.Modelos;
using IMComercios.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios.Controladores
{
    class conProveedores
    {
        srvProveedor proveedores = new srvProveedor();

        /// <summary>
        /// Constructor del controlador de Proveedores
        /// </summary>
        /// <returns></returns>
        public conProveedores()
        {

        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entProveedor> traerProveedores()
        {
            return proveedores.traerProveedores();
        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entProveedor> traerProveedoresFiltro(string filtro)
        {
            return proveedores.traerProveedoresFiltro(filtro);
        }

        /// <summary>
        /// Trae un proveedor desde la api
        /// </summary>
        /// <param name="id">El codigo de identificacion del proveedor</param>
        /// <returns>Un Proveedor </returns>
        public entProveedor traerProveedor(int id)
        {
            return proveedores.traerProveedor(id);
        }

        /// <summary>
        /// Guarda un proveedor existente utilizando el servicio de la api
        /// </summary>
        /// <param name="p">Entidad Proveedor (entProveedor)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int guardarProveedor(entProveedor p)
        {
            return proveedores.guardarProveedor(p);
        }

        /// <summary>
        /// Agrega un nuevo proveedor utilizando el servicio de la api
        /// </summary>
        /// <param name="p">Entidad Proveedor (entProveedor)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int agregarProveedor(entProveedor p)
        {
            return proveedores.agregarProveedor(p);
        }

        /// <summary>
        /// Elimina un nuevo proveedor utilizando el servicio de la api
        /// </summary>
        /// <param name="id">Codigo de Proveedor (int)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int eliminarProveedor(int id)
        {
            return proveedores.eliminarProveedor(id);
        }
    }
}
