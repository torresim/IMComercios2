using IMComercios.Controladores;
using IMComercios.Modelos.Entidades;
using IMComercios.Vistas.TablasMaestras;
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
    public partial class tblProveedores : tblMaestraBase
    {
        conProveedores proveedores = new conProveedores();

        public tblProveedores()
        {
            InitializeComponent();
        }

        public override void preprarABM()
        {
            this.abm.Tabla = "proveedores";
            this.abm.Columnas = new List<string>() {
                "cod_proveedor",
                "nombre",
                "telefono",
                "domicilio",
                "email"
            };
            this.abm.Clave = "id";
            base.preprarABM();
        }

        public override void setGrilla()
        {
            if(this.abm.Filtro == "") dgGrilla.DataSource = proveedores.traerProveedores();
            else dgGrilla.DataSource = proveedores.traerProveedoresFiltro(this.abm.Filtro);
        }

        public override void editarGrilla(int valor)
        {
            tblProveedoresFormulario proveedores = new tblProveedoresFormulario(valor);

            if (proveedores.ShowDialog() == DialogResult.OK)
            {
                base.aplicarFiltro();
            }
        }

        public override void eliminarGrilla(int valor)
        {

        }
    }
}
