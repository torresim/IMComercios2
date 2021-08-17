using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.Utiles;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Servicios
{
    class srvCliente
    {
        public srvCliente()
        {

        }

        // GET
        public List<entCliente> traerClientes()
        {
            var client = new RestClient(Globales.api + "/Clientes");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entCliente> proveedores = JsonConvert.DeserializeObject<List<entCliente>>(response.Content);
            return proveedores;
        }

        public List<entCliente> traerClienteFiltro(string filtro)
        {
            var client = new RestClient(Globales.api + "/Buscar/clientes/" + filtro);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            string json = response.Content.Replace("{\"results\":[", "[").Replace("]}", "]");
            List<entCliente> proveedor = JsonConvert.DeserializeObject<List<entCliente>>(json);
            return proveedor;
        }

        // GET
        public entCliente traerCliente(int id)
        {
            var client = new RestClient(Globales.api + "/Clientes/" + id);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            entCliente proveedor = JsonConvert.DeserializeObject<entCliente>(response.Content);
            return proveedor;
        }

        // PUT
        public int guardarCliente(entCliente p)
        {
            var client = new RestClient(Globales.api + "/Clientes/ " + p.id);
            var request = new RestRequest("/", Method.PUT);
            request.AddHeader("x-token", Globales.token);
            var json = JsonConvert.SerializeObject(p);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Post
        public int agregarCliente(entCliente p)
        {
            var client = new RestClient(Globales.api + "/Clientes");
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("x-token", Globales.token);
            request.AddHeader("idproc", "465213");
            var json = JsonConvert.SerializeObject(p);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                entCliente proveedor = JsonConvert.DeserializeObject<entCliente>(response.Content);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // PUT
        public int eliminarCliente(int id)
        {
            var client = new RestClient(Globales.api + "/Clientes/ " + id);
            var request = new RestRequest("/", Method.DELETE);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
