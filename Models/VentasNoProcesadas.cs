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
    
    public partial class VentasNoProcesadas
    {
        public int Id { get; set; }
        public int IdTransaccionDet { get; set; }
        public string CodigoBarra { get; set; }
        public int Departamento { get; set; }
        public string Referencia { get; set; }
        public string CodigoLigado { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public System.DateTime Fecha { get; set; }
        public string HoraFin { get; set; }
        public int IdAccion { get; set; }
        public int IdBase { get; set; }
    }
}
