using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IMComercios2.Vistas.Utiles
{
    class ctrlTabDisenio: ParentControlDesigner
    {
		public override void Initialize(System.ComponentModel.IComponent component)
		{
			base.Initialize(component);

			if (this.Control is ctrlTab)
			{
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo1, "AreaTrabajo1");
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo2, "AreaTrabajo2");
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo3, "AreaTrabajo3");
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo4, "AreaTrabajo4");
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo5, "AreaTrabajo5");
				this.EnableDesignMode(((ctrlTab)this.Control).AreaTrabajo6, "AreaTrabajo6");
			}
		}
	}
}
