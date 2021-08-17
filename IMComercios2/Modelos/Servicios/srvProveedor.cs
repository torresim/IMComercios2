using IMComercios.Modelos.Entidades;
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
    class srvProveedor
    {
        public srvProveedor()
        {

        }

        // GET
        public List<entProveedor> traerProveedores()
        {
            //using (var db = new dbConexion().getConexion())
            //{
            //    var sql = "SELECT ";

            //    foreach (string i in tbl.Columnas)
            //    {
            //        sql += i + ",";
            //    }

            //    sql = sql.TrimEnd(',');

            //    sql += " FROM " + tbl.Tabla + " WHERE nombre LIKE '%" + tbl.Filtro + "%'";

            //    var clta = db.Query<T>(sql);
            //    return clta;
            //}
            var client = new RestClient(Globales.api + "/Proveedores");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            List<entProveedor> proveedores = JsonConvert.DeserializeObject<List<entProveedor>>(response.Content);
            return proveedores;
        }

        public List<entProveedor> traerProveedoresFiltro(string filtro)
        {
            var client = new RestClient(Globales.api + "/Buscar/proveedores/" + filtro);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            string json = response.Content.Replace("{\"results\":[", "[").Replace("]}", "]");
            List<entProveedor> proveedor = JsonConvert.DeserializeObject<List<entProveedor>>(json);
            return proveedor;
        }

        // GET
        public entProveedor traerProveedor(int id)
        {
            var client = new RestClient(Globales.api + "/Proveedores/" + id);
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("x-token", Globales.token);
            var response = client.Execute(request);
            entProveedor proveedor = JsonConvert.DeserializeObject<entProveedor>(response.Content);
            return proveedor;
        }

        // PUT
        public int guardarProveedor(entProveedor p)
        {
            var client = new RestClient(Globales.api + "/Proveedores/ " + p.id);
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
        public int agregarProveedor(entProveedor p)
        {
            var client = new RestClient(Globales.api + "/Proveedores/");
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("x-token", Globales.token);
            request.AddHeader("idproc", "782823");
            var json = JsonConvert.SerializeObject(p);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                entProveedor proveedor = JsonConvert.DeserializeObject<entProveedor>(response.Content);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // PUT
        public int eliminarProveedor(int id)
        {
            var client = new RestClient(Globales.api + "/Proveedores/ " + id);
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
