using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios2.Modelos.Entidades
{
    class entCliente
    {
        public int id { get; set; }
        public int cod_cliente { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string telefonos { get; set; }
        public string contacto { get; set; }
        public int? cod_zona { get; set; }
        public string categoria_iva { get; set; }
        public string cuit { get; set; }
        public string codigo_postal { get; set; }
        public int? cod_cuenta { get; set; }
        public double? saldo_inicial { get; set; }
        public string moneda { get; set; }
        public int? cod_localidad { get; set; }
        public int? cod_vendedor { get; set; }
        public string percepcionDGR { get; set; }
        public string sedronar { get; set; }
        public double? percepciondgr_porc { get; set; }
        public string observaciones { get; set; }
        public double? saldo_inicial_tag_2 { get; set; }
        public string actualiza_saldo { get; set; }
        public string lista_precio { get; set; }
        public string mail { get; set; }
        public double? percepcion1 { get; set; }
        public double? percepcion2 { get; set; }
        public string origen { get; set; }
        public string cliente_campo { get; set; }
        public string cliente_cont { get; set; }
        public string razon_social { get; set; }
        public int? id_tipo_destino { get; set; }
        public int? id_grupo { get; set; }
        public int? tipo_merma { get; set; }
        public char? planilla { get; set; }
        public int? cod_rubro_cliente { get; set; }
        public string condicion_venta { get; set; }
        public int? cod_tipo_doc { get; set; }
        public string numero_doc { get; set; }
        public string control_margen_venta { get; set; }
        public int? cod_formula_iibb { get; set; }
        public char? habilitado { get; set; }
        public char? cod_compatibilidad { get; set; }
        public entCuentaPlan cod_cuenta_plan { get; set; }
        public entCodigoLocalidad cod_localidad_localidad { get; set; }
        public entVendedorVendedores cod_vendedor_vendedores { get; set; }
        public entListaPrecioCliente lista_precio_cab_lista_precio { get; set; }
        public entCondicionesVenta condicion_venta_condicion_venta_tipo { get; set; }
        public entRubrosCliente cod_rubro_cliente_rubros_clientes { get; set; }
    }
}
