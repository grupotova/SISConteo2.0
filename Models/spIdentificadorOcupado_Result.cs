//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebInventario2._0.Models
{
    using System;
    
    public partial class spIdentificadorOcupado_Result
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public string CodigoBarra { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int Base { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<bool> Marcado { get; set; }
        public Nullable<int> IdTransaccion { get; set; }
        public string codigo_estilo { get; set; }
        public Nullable<decimal> sku_id { get; set; }
        public Nullable<bool> ajuste_conteo { get; set; }
        public string comentario { get; set; }
        public string control_inventario { get; set; }
        public short estado { get; set; }
    }
}
