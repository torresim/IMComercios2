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
    public class srvListaPrecios
    {
        public srvListaPrecios()
        {

        }

        // GET
        public List<entListaPrecios> traerListaPrecio(int cod_empresa)
        {
            var client = new RestClient(Globales.api + "/Compartidos/ListasPrecios/" + cod_empresa);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entListaPrecios> planes = JsonConvert.DeserializeObject<List<entListaPrecios>>(response.Content);
            return planes;
        }
    }
}
