using IMComercios.Vistas.TablasMaestras;
using IMComercios2.Controladores.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.TablasMaestras
{
    public partial class tblClientes : tblMaestraBase
    {
        conClientes clientes = new conClientes();

        public tblClientes()
        {
            InitializeComponent();
        }

        public override void preprarABM()
        {
            this.abm.Tabla = "clientes";
            this.abm.Columnas = new List<string>() {
                "cod_cliente",
                "nombre",
                "telefono",
                "domicilio",
                "mail"
            };
            this.abm.Clave = "id";
            base.preprarABM();
        }

        public override void setGrilla()
        {
            if (this.abm.Filtro == "") dgGrilla.DataSource = clientes.traerClientes();
            else dgGrilla.DataSource = clientes.traerClientesFiltro(this.abm.Filtro);
        }

        public override void editarGrilla(int valor)
        {
            tblClientesFormulario clientes = new tblClientesFormulario(valor);
            if (clientes.ShowDialog() == DialogResult.OK)
            {
                base.aplicarFiltro();
            }
        }

        public override void eliminarGrilla(int valor)
        {

        }
    }
}
