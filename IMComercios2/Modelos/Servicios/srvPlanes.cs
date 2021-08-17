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
    public class srvPlanes
    {
        public srvPlanes()
        {

        }

        // GET
        public List<entPlanes> traerPlanes(string h,string concepto)
        {
            var client = new RestClient(Globales.api + "/Compartidos/Planes/" + h + "/" + concepto);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entPlanes> planes = JsonConvert.DeserializeObject<List<entPlanes>>(response.Content);
            return planes;
        }

    }
}
