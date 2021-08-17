using IMComercios.Controladores;
using IMComercios.Modelos.Entidades;
using IMComercios2.Controladores.Planes;
using IMComercios2.Controladores.Utiles;
using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.Utiles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static IMComercios2.Vistas.Utiles.Funciones;

namespace IMComercios2.Vistas.TablasMaestras
{
    public partial class tblProveedoresFormulario : tblMaestraFormBase
    {
        public entProveedor eproveedor = new entProveedor();
        public Funciones fn = new Funciones();
        conProveedores proveedores = new conProveedores();
        public conUtiles utiles = new conUtiles();
        public conPlanes planes = new conPlanes();
        int id_proveedor;

        public tblProveedoresFormulario(int valor)
        {
            InitializeComponent();
            eproveedor.id = valor;
            preprarCombos();
            cargarFormulario();
        }

        /// <summary>
        /// Carga el formulario con los datos del proveedor si se desea editar
        /// </summary>
        private void cargarFormulario()
        {
            if (eproveedor.id > 0)
            {
                eproveedor = proveedores.traerProveedor(eproveedor.id);
                this.lblTituloEntidad.Text = eproveedor.nombre;
                this.id_proveedor = eproveedor.id;
                this.txtCodProveedor.Text = eproveedor.cod_proveedor.ToString();
                this.txtNombre.Text = eproveedor.nombre;
                this.txtTelefono.Text = eproveedor.telefono;
                this.txtContacto.Text = eproveedor.contacto;
                this.txtDomicilio.Text = eproveedor.domicilio;
                this.txtDomicilio2.Text = eproveedor.domicilio_2;
                this.txtCodigoPostal.Text = eproveedor.codigo_postal;
                this.txtEmail.Text = eproveedor.email;
                this.txtSaldoInicial.Text = eproveedor.saldo_inicial.ToString();
                if(eproveedor.habilitado == 'S' ) this.chkHabilitado.Checked = true;
                this.cbIva.cbCombo.SelectedValue = this.cbIva.cbCombo.FindString(eproveedor.categoria_iva);
                this.txtCuit.Text = eproveedor.cuit;
                this.cbIva.cbCombo.SelectedValue = eproveedor.categoria_iva;

                if (eproveedor.cod_localidad != null && eproveedor.cod_localidad != 0)
                {
                    if (eproveedor.cod_localidad_localidad.cod_provincia != null)
                    {
                        this.cbProvincia.cbCombo.SelectedValue = eproveedor.cod_localidad_localidad.cod_provincia;
                        this.cbLocalidad.cbCombo.SelectedValue = eproveedor.cod_localidad;
                    }
                }
                else
                {
                    //this.cbProvincia.cbCombo.SelectedValue = 0;
                    this.cbLocalidad.cbCombo.SelectedValue = 0;
                }
                this.cbCuenta.cbCombo.SelectedValue = eproveedor.cod_cuenta; //1110300
            }
            else
            {
                this.btnEliminar.Enabled = false;
                this.id_proveedor = 0;
            }
        }

        //Singleton
        private static tblProveedoresFormulario Instancia = null;
        public static tblProveedoresFormulario ObtenerInstacia(int valor)
        {
            if (Instancia == null || Instancia.IsDisposed)
            {

                Instancia = new tblProveedoresFormulario(valor);
            }
            Instancia.BringToFront();

            return Instancia;
        }

        private void preprarCombos()
        {
            //Provincia
            cbProvincia.cbCombo.ValueMember = "codigo";
            cbProvincia.cbCombo.DisplayMember = "nombre";
            cbProvincia.cbCombo.DataSource = utiles.traerProvincias();
            //cbProvincia.cbCombo.SelectedValue = 21;
            cbProvincia.cbCombo.SelectedIndexChanged += cambiaProvincia;

            //Localidad
            cbLocalidad.cbCombo.ValueMember = "codigo";
            cbLocalidad.cbCombo.DisplayMember = "nombre";
            cbLocalidad.cbCombo.DataSource = utiles.traerLocalidades(21);
            //cbLocalidad.cbCombo.SelectedValue = 4;

            //Cctble
            cbCuenta.cbCombo.ValueMember = "id";
            cbCuenta.cbCombo.DisplayMember = "descripcion";
            cbCuenta.cbCombo.DataSource = planes.traerPlanes("S","Proveedores");
            //cbCuenta.cbCombo.SelectedValue = 2110001;

            //Categoria Iva
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("RI", "Responsable Inscripto");
            comboSource.Add("RN", "Responsable NO Inscripto");
            comboSource.Add("IM", "Responsable Inscripto M");
            comboSource.Add("CF", "Consumidor Final");
            comboSource.Add("EX", "Exento");
            comboSource.Add("RM", "Monotributo");
            cbIva.cbCombo.DataSource = new BindingSource(comboSource,null);
            cbIva.cbCombo.DisplayMember = "Value";
            cbIva.cbCombo.ValueMember = "Key";
        }

        private void cambiaProvincia(object sender, EventArgs e)
        {
            //cbLocalidad.cbCombo.cbText.Text = "";
            cbLocalidad.cbCombo.DataSource = utiles.traerLocalidades(
                Int32.Parse(cbProvincia.cbCombo.SelectedValue.ToString())
                );
        }

        public override bool validarGuardarFormulario()
        {
            bool validado = true;

            if (base.validarGuardarFormulario())
            {
                if (this.txtNombre.Text == "") validado = false;
                if (this.cbCuenta.cbText.Text == "") validado = false;
                if (this.cbIva.cbText.Text == "") validado = false;
            }
            else validado = false;

            if(!validado) fn.mensaje(TipoVentana.Alerta, "Los campos marcados son obligatorios. Por favor revise e intente de nuevo.");

            return validado;
        }

        public override void guardar_Click()
        {
            if (fn.mensaje(TipoVentana.Pregunta, "¿Esta seguro que desea guardar los cambios?") == DialogResult.OK)
            {
      
                if (guardar_cambios() == 1)
                {
                    fn.mensaje(TipoVentana.Correcto, "Los datos del proveedor se guardaron correctamente");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    fn.mensaje(TipoVentana.Alerta, "No se pudieron guardar los cambios por favor revise");
                }
            }
        }

        public override void eliminar_click()
        {
            if (fn.mensaje(TipoVentana.Pregunta, "¿Esta seguro que desea eliminar al proveedor?") == DialogResult.OK)
            {

                if (eliminar_proveedor() == 1)
                {
                    fn.mensaje(TipoVentana.Correcto, "El proveedor fue eliminado con éxito");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    fn.mensaje(TipoVentana.Alerta, "No se pudo eliminar el proveedor por favor revise");
                }
            }
        }

        private int eliminar_proveedor()
        {
            return proveedores.eliminarProveedor(eproveedor.id);
        }

        private int guardar_cambios()
        {
            eproveedor.cod_proveedor = Int32.Parse(this.txtCodProveedor.Text);
            eproveedor.nombre = this.txtNombre.Text;
            eproveedor.telefono = this.txtTelefono.Text;
            eproveedor.contacto = this.txtContacto.Text;
            eproveedor.domicilio = this.txtDomicilio.Text;
            eproveedor.domicilio_2 = this.txtDomicilio2.Text;
            eproveedor.codigo_postal = this.txtCodigoPostal.Text;
            eproveedor.email = this.txtEmail.Text;

            if (this.cbLocalidad.cbCombo.SelectedValue != null)
            {
                eproveedor.cod_localidad = Int32.Parse(this.cbLocalidad.cbCombo.SelectedValue.ToString());
            }
            else
            {
                eproveedor.cod_localidad = 0;
            }

            if (this.txtSaldoInicial.Text == "") eproveedor.saldo_inicial = null;
            else eproveedor.saldo_inicial = Double.Parse(this.txtSaldoInicial.Text);

            if (this.chkHabilitado.Checked) eproveedor.habilitado = 'S';
            else eproveedor.habilitado = 'N';

            eproveedor.cod_cuenta = Int32.Parse(this.cbCuenta.cbCombo.SelectedValue.ToString());
            eproveedor.categoria_iva = this.cbIva.cbCombo.SelectedValue.ToString();

            eproveedor.cuit = this.txtCuit.Text;

            int guardar;
            if (eproveedor.cod_proveedor == 0) guardar = proveedores.agregarProveedor(eproveedor);
            else guardar = proveedores.guardarProveedor(eproveedor);
            return guardar;
        }

        private void tblProveedoresFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
