using IMComercios2.Modelos;
using IMComercios2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Controladores
{
    class conLogin
    {
        srvLogin slog = new srvLogin();

        /// <summary>
        /// Constructor del controlador de Login
        /// </summary>
        /// <returns></returns>
        public conLogin()
        {

        }

        /// <summary>
        /// Logea desde la api con un usuario determinado
        /// </summary>
        /// <param name="usr">Entidad usuario con las credenciales para loguear</param>
        /// <returns>String con el Token en caso de exito (0=Faltan campos 1=Error credenciales)</returns>
        public string Logear(entUsuario usr)
        {
            var errores = false;
            if (usr.clave == "")
            {
                errores = true;
                Console.WriteLine("Debe Completar Contraseña");
            }
            if (usr.usuario == "")
            {
                errores = true;
                Console.WriteLine("Debe Completar Usuario");
            }

            if (!errores)
            {
                var respuesta = slog.Loguear(usr);
                if (respuesta.Item1 == System.Net.HttpStatusCode.OK)
                {
                    return slog.Loguear(usr).Item2;
                }
                else if(respuesta.Item1 == System.Net.HttpStatusCode.InternalServerError)
                     {
                         return "2";
                     }
                else
                {
                    return "1";
                }
            }
            return "0";
        }
    }
}
