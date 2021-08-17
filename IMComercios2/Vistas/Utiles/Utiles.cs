using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    public class Funciones
    {
        public enum TipoVentana
        {
            Alerta,
            Pregunta,
            Info,
            Error,
            Correcto
        };

        public DialogResult mensaje(TipoVentana tipo, string msj)
        {
            frmModal frmMensaje = new frmModal(tipo, msj);
            DialogResult resultado = frmMensaje.ShowDialog();
            return resultado;
        }

        public void txtNecesario(ref TextBox c)
        {

        }
    }
}
