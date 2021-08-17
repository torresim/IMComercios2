using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.TablasMaestras
{
    public partial class tblMaestraFormBase : Form
    {
        public tblMaestraFormBase()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (validarGuardarFormulario()) guardar_Click();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (validarEliminarFormulario()) eliminar_click();
        }

        public virtual bool validarGuardarFormulario()
        {
            return true;
        }

        public virtual bool validarEliminarFormulario()
        {
            return true;
        }

        public virtual void guardar_Click()
        {
            //
        }

        public virtual void eliminar_click()
        {
            //
        }

        private void lblTituloEntidad_Click(object sender, EventArgs e)
        {

        }
    }
}
