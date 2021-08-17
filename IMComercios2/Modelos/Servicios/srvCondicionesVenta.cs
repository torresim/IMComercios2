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
    public class srvCondicionesVenta
    {
        public srvCondicionesVenta()
        {

        }

        // GET
        public List<entCondicionesVenta> traerCondicionesVenta()
        {
            var client = new RestClient(Globales.api + "/Compartidos/CondicionesVenta");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entCondicionesVenta> planes = JsonConvert.DeserializeObject<List<entCondicionesVenta>>(response.Content);
            return planes;
        }
    }
}
