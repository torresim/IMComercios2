using IMComercios.Modelos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios.Modelos.BaseDatos
{
    class dbConexion
    {
        private string cadenaConexion = string.Empty;

        public dbConexion()
        {
            cadenaConexion = "Server=" + entDsn.Server + ";Database=" + entDsn.Database + "; Uid=" + entDsn.Uid + ";Pwd=" + entDsn.Pwd + ";";
        }

        public MySqlConnection getConexion()
        {
            MySqlConnection dbConnection = new MySqlConnection(cadenaConexion);
            return dbConnection;
        }
    }
}