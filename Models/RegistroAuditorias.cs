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
    
    public partial class RegistroAuditorias
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public string CodigoBarra { get; set; }
        public int CantidadAjustada { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdUsuarioAutoriza { get; set; }
        public int IdUsuarioAuditado { get; set; }
        public int IdBase { get; set; }
    }
}