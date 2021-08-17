using IMComercios2.Vistas.Utiles;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Servicios
{
    class srvUtiles
    {
        public srvUtiles()
        {

        }

        // GET
        public DataTable traerProvincias()
        {
            //using (var db = new dbConexion().getConexion())
            //{
            //    var sql = "SELECT * FROM provincia";

            //    var clta = db.Query<T>(sql);
            //    return clta;
            //}
            var client = new RestClient(Globales.api + "/Provincias");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(response.Content);
            return dataTable;
        }

        // GET
        public DataTable traerLocalidades(int cod_provincia)
        {
            var client = new RestClient(Globales.api + "/Localidades/Provincia/" + cod_provincia);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(response.Content);
            return dataTable;
        }

        // GET
        public DataTable traerLocalidad(int cod_localidad)
        {
            var client = new RestClient(Globales.api + "/Localidades/" + cod_localidad);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(response.Content);
            return dataTable;
        }
    }
}
