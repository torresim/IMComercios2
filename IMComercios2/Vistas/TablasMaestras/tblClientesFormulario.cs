using IMComercios2.Controladores.Clientes;
using IMComercios2.Controladores.Planes;
using IMComercios2.Controladores.Utiles;
using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IMComercios2.Vistas.Utiles.Funciones;

namespace IMComercios2.Vistas.TablasMaestras
{
    public partial class tblClientesFormulario : tblMaestraFormBase
    {
        entCliente ecliente = new entCliente();
        Funciones fn = new Funciones();
        conClientes clientes = new conClientes();
        conUtiles utiles = new conUtiles();
        conPlanes planes = new conPlanes();
        conAcuerdos acuerdos = new conAcuerdos();
        conListaPrecios lista = new conListaPrecios();
        conCondicionesVenta condiciones = new conCondicionesVenta();
        conVendedores vendedores = new conVendedores();
        conRubrosCliente rubros = new conRubrosCliente();

        int id_cliente;

        public tblClientesFormulario(int valor)
        {
            InitializeComponent();
            ecliente.id = valor;
            preprarCombos();
            cargarFormulario();
        }

        /// <summary>
        /// Carga el formulario con los datos del proveedor si se desea editar
        /// </summary>
        private void cargarFormulario()
        {
            if (ecliente.id > 0)
            {
                ecliente = clientes.traerCliente(ecliente.id);
                this.lblTituloEntidad.Text = ecliente.nombre;
                this.id_cliente = ecliente.id;
                this.txtCodCliente.Text = ecliente.cod_cliente.ToString();
                this.txtNombre.Text = ecliente.nombre;
                this.txtTelefono.Text = ecliente.telefonos;
                this.txtContacto.Text = ecliente.contacto;
                this.txtDomicilio.Text = ecliente.domicilio;
                this.txtCodigoPostal.Text = ecliente.codigo_postal;
                this.txtEmail.Text = ecliente.mail;
                if (ecliente.habilitado == 'S') this.chkHabilitado.Checked = true;
                this.cbIva.cbCombo.SelectedValue = this.cbIva.cbCombo.FindString(ecliente.categoria_iva);
                this.txtCuit.Text = ecliente.cuit;
                this.cbIva.cbCombo.SelectedValue = ecliente.categoria_iva;

                if (ecliente.control_margen_venta == "S")
                {
                    chMargenes.Checked = true;
                }
                else
                {
                    chMargenes.Checked = false;
                }

                if (ecliente.cod_localidad != null && ecliente.cod_localidad != 0)
                {
                    if (ecliente.cod_localidad_localidad.cod_provincia != null)
                    {
                        this.cbProvincia.cbCombo.SelectedValue = ecliente.cod_localidad_localidad.cod_provincia;
                        this.cbLocalidad.cbCombo.SelectedValue = ecliente.cod_localidad;
                    }
                }
                else
                {
                    this.cbProvincia.cbCombo.SelectedValue = 0;
                    this.cbLocalidad.cbCombo.SelectedValue = 0;
                }

                if(ecliente.lista_precio != null)
                {
                    this.cbListaPrecio.cbCombo.SelectedValue = Int32.Parse(ecliente.lista_precio);
                }

                if (ecliente.condicion_venta != null)
                {
                    this.cbCondicionVenta.cbCombo.SelectedValue = Int32.Parse(ecliente.condicion_venta);
                }

                if (ecliente.cod_vendedor != null)
                {
                    this.cbVendedores.cbCombo.SelectedValue = ecliente.cod_vendedor;
                }

                if (ecliente.cod_rubro_cliente != null)
                {
                    this.cbRubrosCliente.cbCombo.SelectedValue = ecliente.cod_rubro_cliente;
                }

                this.cbCuenta.cbCombo.SelectedValue = ecliente.cod_cuenta; 

                List<entAcuerdo> lst = new List<entAcuerdo>();
                lst.Add(new entAcuerdo() { id = 1, cod_cliente = 1234, fecha_desde = DateTime.Now, fecha_hasta = DateTime.Now, valor = 22.03 });
                lst.Add(new entAcuerdo() { id = 1, cod_cliente = 1234, fecha_desde = DateTime.Now, fecha_hasta = DateTime.Now, valor = 22.03 });
                lst.Add(new entAcuerdo() { id = 1, cod_cliente = 1234, fecha_desde = DateTime.Now, fecha_hasta = DateTime.Now, valor = 22.03 });
                this.ctrlGrilla1.DataSource = lst; // acuerdos.traerAcuerdos(ecliente.cod_cliente);
                //this.ctrlGrilla1.agregarBtn("Editar", "editar.ico", editarGrilla, "id");
                //this.ctrlGrilla1.agregarBtn("Quitar", "eliminar.ico", eliminarGrilla, "id");
                this.ctrlGrilla1.aplicarEstilo();
            }
            else
            {
                this.btnEliminar.Enabled = false;
                this.id_cliente = 0;
            }
        }

        public void editarGrilla()
        {

        }

        //Singleton
        private static tblClientesFormulario Instancia = null;
        public static tblClientesFormulario ObtenerInstacia(int valor)
        {
            if (Instancia == null || Instancia.IsDisposed)
            {

                Instancia = new tblClientesFormulario(valor);
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
            cbProvincia.cbCombo.SelectedValue = 21;
            cbProvincia.cbCombo.SelectedIndexChanged += cambiaProvincia;


            //Localidad
            cbLocalidad.cbCombo.ValueMember = "codigo";
            cbLocalidad.cbCombo.DisplayMember = "nombre";
            cbLocalidad.cbCombo.DataSource = utiles.traerLocalidades(21);
            cbLocalidad.cbCombo.SelectedValue = 4;

            //Cctble
            cbCuenta.cbCombo.ValueMember = "id";
            cbCuenta.cbCombo.DisplayMember = "descripcion";
            cbCuenta.cbCombo.DataSource = planes.traerPlanes("S","Clientes");

            //Lista Precio
            cbListaPrecio.cbCombo.ValueMember = "cod_lista";
            cbListaPrecio.cbCombo.DisplayMember = "descripcion";
            cbListaPrecio.cbCombo.DataSource = lista.traerListaPrecio(0);

            //Condiciones de venta
            cbCondicionVenta.cbCombo.ValueMember = "codigo";
            cbCondicionVenta.cbCombo.DisplayMember = "descripcion";
            cbCondicionVenta.cbCombo.DataSource = condiciones.traerCondicionesVenta();

            //Vendedores
            cbVendedores.cbCombo.ValueMember = "cod_vendedor";
            cbVendedores.cbCombo.DisplayMember = "nombre";
            cbVendedores.cbCombo.DataSource = vendedores.traerVendedores();

            //Rubros
            cbRubrosCliente.cbCombo.ValueMember = "cod_rubro_cliente";
            cbRubrosCliente.cbCombo.DisplayMember = "descripcion";
            cbRubrosCliente.cbCombo.DataSource = rubros.traerRubrosCliente();

            //Categoria Iva
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("RI", "Responsable Inscripto");
            comboSource.Add("RN", "Responsable NO Inscripto");
            comboSource.Add("IM", "Responsable Inscripto M");
            comboSource.Add("CF", "Consumidor Final");
            comboSource.Add("EX", "Exento");
            comboSource.Add("RM", "Monotributo");
            cbIva.cbCombo.DataSource = new BindingSource(comboSource, null);
            cbIva.cbCombo.DisplayMember = "Value";
            cbIva.cbCombo.ValueMember = "Key";

            //Categoria Iva
            Dictionary<string, string> comboSource2 = new Dictionary<string, string>();
            comboSource2.Add("1", "CUIT");
            comboSource2.Add("2", "CUIL");
            comboSource2.Add("3", "DNI");
            comboSource2.Add("4", "LE");
            cbDocumentos.cbCombo.DataSource = new BindingSource(comboSource2, null);
            cbDocumentos.cbCombo.DisplayMember = "Value";
            cbDocumentos.cbCombo.ValueMember = "Key";
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

            if (!validado) fn.mensaje(TipoVentana.Alerta, "Los campos marcados son obligatorios. Por favor revise e intente de nuevo.");

            return validado;
        }

        public override void guardar_Click()
        {
            if (fn.mensaje(TipoVentana.Pregunta, "¿Esta seguro que desea guardar los cambios?") == DialogResult.OK)
            {

                if (guardar_cambios() == 1)
                {
                    fn.mensaje(TipoVentana.Correcto, "Los datos del cliente se guardaron correctamente");
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
            if (fn.mensaje(TipoVentana.Pregunta, "¿Esta seguro que desea eliminar al cliente?") == DialogResult.OK)
            {

                if (eliminar_proveedor() == 1)
                {
                    fn.mensaje(TipoVentana.Correcto, "El proveedor fue eliminado con éxito");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    fn.mensaje(TipoVentana.Alerta, "No se pudo eliminar el cliente por favor revise");
                }
            }
        }

        private int eliminar_proveedor()
        {
            return clientes.eliminarCliente(ecliente.id);
        }

        private int guardar_cambios()
        {
            ecliente.cod_cliente = Int32.Parse(this.txtCodCliente.Text);
            ecliente.nombre = this.txtNombre.Text;
            ecliente.telefonos = this.txtTelefono.Text;
            ecliente.contacto = this.txtContacto.Text;
            ecliente.domicilio = this.txtDomicilio.Text;
            ecliente.codigo_postal = this.txtCodigoPostal.Text;
            ecliente.mail = this.txtEmail.Text;

            if (this.cbLocalidad.cbCombo.SelectedValue != null)
            {
                ecliente.cod_localidad = Int32.Parse(this.cbLocalidad.cbCombo.SelectedValue.ToString());
            }
            else
            {
                ecliente.cod_localidad = 0;
            }

            if (this.chkHabilitado.Checked) ecliente.habilitado = 'S';
            else ecliente.habilitado = 'N';

            ecliente.cod_cuenta = Int32.Parse(this.cbCuenta.cbCombo.SelectedValue.ToString());
            ecliente.categoria_iva = this.cbIva.cbCombo.SelectedValue.ToString();

            ecliente.cod_vendedor = Int32.Parse(this.cbVendedores.cbCombo.SelectedValue.ToString());
            ecliente.lista_precio = this.cbListaPrecio.cbCombo.SelectedValue.ToString();
            ecliente.condicion_venta = this.cbCondicionVenta.cbCombo.SelectedValue.ToString();

            if (this.cbRubrosCliente.cbCombo.SelectedValue != null)
            {
                ecliente.cod_rubro_cliente = Int32.Parse(this.cbRubrosCliente.cbCombo.SelectedValue.ToString());
            }
            else
            {
                ecliente.cod_rubro_cliente = null;
            }

            ecliente.cuit = this.txtCuit.Text;
            ecliente.numero_doc = this.txtNroDoc.Text;

            if (chMargenes.Checked)
            {
                ecliente.control_margen_venta = "S";
            }
            else
            {
                ecliente.control_margen_venta = "N";
            }

            ecliente.cod_tipo_doc = Int32.Parse(this.cbDocumentos.cbCombo.SelectedValue.ToString());

            int guardar;
            if (ecliente.cod_cliente == 0) guardar = clientes.agregarCliente(ecliente);
            else guardar = clientes.guardarCliente(ecliente);
            return guardar;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chMargenes.Checked)
            {
                ctrlTab1.usarSolapa[1] = "Acuerdos de Crédito";
            }
            else
            {
                ctrlTab1.usarSolapa[1] = "-";
            }
            ctrlTab1.actualizaControl();
        }
    }
}
