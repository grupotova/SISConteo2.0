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
    
    public partial class sp_GetHeader_Ajuste_CSV_Result
    {
        public int id_ajuste { get; set; }
        public int id_tipo_ajuste { get; set; }
        public Nullable<int> id_tipo_conteo { get; set; }
        public string id_conteo { get; set; }
        public int @base { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string usuario_crea { get; set; }
        public Nullable<decimal> total_monto { get; set; }
        public Nullable<int> total_piezas { get; set; }
        public Nullable<int> cantidad_sku { get; set; }
        public string num_documento { get; set; }
        public Nullable<System.DateTime> fecha_csv { get; set; }
        public string usuario_csv { get; set; }
        public string DESCRIPCION { get; set; }
        public string motivo { get; set; }
        public Nullable<int> Archivos_AjustesManuales_Id { get; set; }
    }
}
