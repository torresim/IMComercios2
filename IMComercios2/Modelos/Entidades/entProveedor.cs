using IMComercios2.Modelos.Entidades;

namespace IMComercios.Modelos.Entidades
{
    public class entProveedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string contacto { get; set; }
        public string domicilio { get; set; }
        public string codigo_postal { get; set; }
        public string email { get; set; }
        public int cod_proveedor { get; set; }
        public string categoria_iva { get; set; }
        public string cuit { get; set; }
        public int cod_cuenta { get; set; }
        public double? saldo_inicial { get; set; }
        public string moneda { get; set; }
        public string codigo_cliente { get; set; }
        public int? cod_localidad { get; set; }
        public double? saldo_inicial_tag_2 { get; set; }
        public string tipo_retencion { get; set; }
        public string actualiza_saldo { get; set; }
        public string cod_externo { get; set; }
        public string alicuota { get; set; }
        public string sujeto_retencion { get; set; }
        public string hasta_iibb { get; set; }
        public string desde_iibb { get; set; }
        public string responsable_pago { get; set; }
        public string tipo_corredor { get; set; }
        public string proveedor_campo { get; set; }
        public string fletero_campo { get; set; }
        public string contratista_campo { get; set; }
        public string arranque { get; set; }
        public string formula { get; set; }
        public string grupo { get; set; }
        public string origen { get; set; }
        public string cod_formula_iibb { get; set; }
        public string cod_tipo_doc { get; set; }
        public string numero_doc { get; set; }
        public char habilitado { get; set; }
        public string domicilio_2 { get; set; }
        public string id_impositivo { get; set; }
        public entCuentaPlan cod_cuenta_plan { get; set; }
        public entCodigoLocalidad cod_localidad_localidad { get; set; }
    }
}
