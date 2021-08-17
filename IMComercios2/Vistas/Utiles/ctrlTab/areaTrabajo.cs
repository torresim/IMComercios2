using System.ComponentModel;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    [
    Designer(typeof(areaTrabajoDisenio))
    ]
    public partial class areaTrabajo : Panel
    {
        public areaTrabajo()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
    }
}
