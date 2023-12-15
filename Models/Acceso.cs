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
    
    public partial class Acceso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acceso()
        {
            this.AccesoRol = new HashSet<AccesoRol>();
        }
    
        public int ID { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int UsuarioCreador { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public int UsuarioModificador { get; set; }
        public string Controlador { get; set; }
        public string Vista { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Activo { get; set; }
        public Nullable<int> Aplicacion_ID { get; set; }
    
        public virtual Aplicacion Aplicacion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccesoRol> AccesoRol { get; set; }
    }
}
