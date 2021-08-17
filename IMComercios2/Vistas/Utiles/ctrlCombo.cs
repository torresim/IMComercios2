using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace IMComercios2.Vistas.Utiles
{
    public partial class ctrlCombo : UserControl
    {
        public ctrlCombo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cbCombo.DroppedDown = true;
        }

        private void cbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbText.Text = cbCombo.Text;
        }
    }
}
