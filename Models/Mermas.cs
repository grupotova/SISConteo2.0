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
    
    public partial class Mermas
    {
        public int Id { get; set; }
        public string CodigoBarra { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int IdUsuario { get; set; }
        public int IdLocalizacion { get; set; }
        public int IdTransaccion { get; set; }
        public int IdBase { get; set; }
        public Nullable<bool> Marcado { get; set; }
    }
}
