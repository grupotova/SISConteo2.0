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
    using System.Collections.Generic;
    
    public partial class Control_Inventario_Upc_20231226
    {
        public int ciu_id { get; set; }
        public string ciu_control_inventario { get; set; }
        public Nullable<short> ciu_localizacion { get; set; }
        public int ciu_base { get; set; }
        public decimal ciu_sku_id { get; set; }
        public string ciu_upc { get; set; }
        public Nullable<int> ciu_cantidad_conteo { get; set; }
        public Nullable<int> ciu_cantidad_conteo_mod { get; set; }
        public string ciu_comentario { get; set; }
        public string ciu_usuario_proceso { get; set; }
        public Nullable<System.DateTime> ciu_fecha_proceso { get; set; }
        public string ciu_usuario_mod { get; set; }
        public Nullable<System.DateTime> ciu_fecha_mod { get; set; }
    }
}