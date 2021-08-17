using IMComercios2.Modelos.Entidades;
using IMComercios2.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Controladores.Clientes
{
    class conClientes
    {
        srvCliente clientes = new srvCliente();

        /// <summary>
        /// Constructor del controlador de Proveedores
        /// </summary>
        /// <returns></returns>
        public conClientes()
        {

        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entCliente> traerClientes()
        {
            return clientes.traerClientes();
        }

        /// <summary>
        /// Trae la lista completa de proveedores desde la api
        /// </summary>
        /// <returns>La lista completa de proveedores </returns>
        public List<entCliente> traerClientesFiltro(string filtro)
        {
            return clientes.traerClienteFiltro(filtro);
        }

        /// <summary>
        /// Trae un proveedor desde la api
        /// </summary>
        /// <param name="id">El codigo de identificacion del proveedor</param>
        /// <returns>Un Proveedor </returns>
        public entCliente traerCliente(int id)
        {
            return clientes.traerCliente(id);
        }

        /// <summary>
        /// Guarda un proveedor existente utilizando el servicio de la api
        /// </summary>
        /// <param name="p">Entidad Proveedor (entProveedor)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int guardarCliente(entCliente p)
        {
            return clientes.guardarCliente(p);
        }

        /// <summary>
        /// Agrega un nuevo proveedor utilizando el servicio de la api
        /// </summary>
        /// <param name="p">Entidad Proveedor (entProveedor)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int agregarCliente(entCliente p)
        {
            return clientes.agregarCliente(p);
        }

        /// <summary>
        /// Elimina un nuevo proveedor utilizando el servicio de la api
        /// </summary>
        /// <param name="id">Codigo de Proveedor (int)</param>
        /// <returns>Un numero entero (1=Ok 0=Error) </returns>
        public int eliminarCliente(int id)
        {
            return clientes.eliminarCliente(id);
        }
    }
}
