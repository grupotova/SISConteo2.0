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
    
    public partial class ConteoCiclico_UpcNoExiste
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public string TipoUbicacion { get; set; }
        public string CodigoBarra { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int Base { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string control_inventario { get; set; }
        public int Producto_ID { get; set; }
    }
}
