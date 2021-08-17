using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios.Modelos.Entidades
{
    public class entDsn
    {
        public static string Server { get; set; }
        public static string Database { get; set; }
        public static string Uid { get; set; }
        public static string Pwd { get; set; }
        public static int Port { get; set; }

        //public string getCadenaConexion()
        //{
        //    return "Server=" + this.Server + ";Database=" + this.Database + "; Uid=" + this.Uid + ";Pwd=" + this.Pwd + ";";
        //}
    }
}
