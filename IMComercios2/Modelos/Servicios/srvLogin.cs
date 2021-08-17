using Dapper;
using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.Utiles;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Modelos
{
    class srvLogin
    {
        public srvLogin()
        {

        }

        //public bool Loguear()
        //{
        //    bool respuesta = false;
        //    string CdenaConexion = "Server=localhost;Database=" + bds + "; Uid=marcelo;Pwd=marcelo6;";
        //    using (var db = new MySqlConnection(CdenaConexion))
        //    {
        //        var sql = "SELECT * FROM usuarios WHERE usuario=@Usuario AND clave=@Pass";
        //        var usuario = db.Query(sql, usr).ToList();
        //        if (usuario.Count > 0) respuesta = true;
        //    }
        //    return respuesta;
        //}

        public Tuple<System.Net.HttpStatusCode, string> Loguear(entUsuario usr)
        {

            Tuple<System.Net.HttpStatusCode, string> respuesta = Tuple.Create(System.Net.HttpStatusCode.NoContent, "");

            var client = new RestClient(Globales.api + "/auth/login");

            JObject jObjectbody = new JObject();

            jObjectbody.Add("usuario", usr.usuario);
            jObjectbody.Add("clave", usr.clave);

            var request = new RestRequest("/", Method.POST);

            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);

            IRestResponse restResponse = client.Execute(request);
            entUsuarioLogin usuario = JsonConvert.DeserializeObject<entUsuarioLogin>(restResponse.Content);

            if(restResponse.StatusCode == 0) return Tuple.Create(System.Net.HttpStatusCode.InternalServerError, "");
            else return Tuple.Create(restResponse.StatusCode, usuario.token); ;
        }
    }
}
