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
    
    public partial class Parametros_Sugerencia_Conteo_Diario
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> TipoDato { get; set; }
        public string Valor { get; set; }
        public bool ACTIVO { get; set; }
        public Nullable<System.DateTime> Fec_Creacion { get; set; }
        public Nullable<System.DateTime> Fec_Modificacion { get; set; }
        public string Usuario_Creador { get; set; }
        public string Usuario_Modificador { get; set; }
    }
}
