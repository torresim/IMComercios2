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
    class srvAcuerdos
    {
        public srvAcuerdos()
        {

        }

        // GET
        public List<entAcuerdo> traerAcuerdos(int codigo)
        {
            var client = new RestClient(Globales.api + "/Acuerdos/" + codigo);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entAcuerdo> proveedores = JsonConvert.DeserializeObject<List<entAcuerdo>>(response.Content);
            return proveedores;
        }
    }
}
