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
    
    public partial class Archivos_ConteosManuales
    {
        public int Archivos_ConteosManuales_Id { get; set; }
        public string NomArchivo { get; set; }
        public string NomOrigArchivo { get; set; }
        public int Usuario_Carga { get; set; }
        public Nullable<System.DateTime> fecha_carga { get; set; }
        public Nullable<int> lineas_cargadas { get; set; }
        public Nullable<int> Base { get; set; }
        public string CodDivision { get; set; }
        public Nullable<System.DateTime> fecha_conteo { get; set; }
        public Nullable<int> ConteoDiario_ID { get; set; }
        public string grouping_label { get; set; }
    }
}
