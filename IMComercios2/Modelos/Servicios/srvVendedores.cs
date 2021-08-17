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
    public class srvVendedores
    {
        public srvVendedores()
        {

        }

        // GET
        public List<entVendedores> traerVendedores()
        {
            var client = new RestClient(Globales.api + "/Compartidos/Vendedores");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entVendedores> planes = JsonConvert.DeserializeObject<List<entVendedores>>(response.Content);
            return planes;
        }
    }
}
