﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TOVA_USER_Entities : DbContext
    {
        public TOVA_USER_Entities()
            : base("name=TOVA_USER_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acceso> Acceso { get; set; }
        public virtual DbSet<AccesoRol> AccesoRol { get; set; }
        public virtual DbSet<Aplicacion> Aplicacion { get; set; }
        public virtual DbSet<AplicacionRol> AplicacionRol { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CentroCosto> CentroCosto { get; set; }
        public virtual DbSet<CentroCostoUsuario> CentroCostoUsuario { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuOperacion> MenuOperacion { get; set; }
        public virtual DbSet<MenuOperacionRol> MenuOperacionRol { get; set; }
        public virtual DbSet<MenuRol> MenuRol { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioAplicacion> UsuarioAplicacion { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }
    
        public virtual int PA_GetDataAcceso(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataAcceso", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataAplicacion(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataAplicacion", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataCargo(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataCargo", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataMenu(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataMenu", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataMenuRolAplicacion(string aplicacionID, string rolesID)
        {
            var aplicacionIDParameter = aplicacionID != null ?
                new ObjectParameter("AplicacionID", aplicacionID) :
                new ObjectParameter("AplicacionID", typeof(string));
    
            var rolesIDParameter = rolesID != null ?
                new ObjectParameter("RolesID", rolesID) :
                new ObjectParameter("RolesID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataMenuRolAplicacion", aplicacionIDParameter, rolesIDParameter);
        }
    
        public virtual int PA_GetDataRol(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataRol", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataUsuario(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataUsuario", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    
        public virtual int PA_GetDataUsuarioEvaluaciones(string search, string page_init, string cant_page, string campo_orden, string tipo_orden)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var page_initParameter = page_init != null ?
                new ObjectParameter("page_init", page_init) :
                new ObjectParameter("page_init", typeof(string));
    
            var cant_pageParameter = cant_page != null ?
                new ObjectParameter("cant_page", cant_page) :
                new ObjectParameter("cant_page", typeof(string));
    
            var campo_ordenParameter = campo_orden != null ?
                new ObjectParameter("campo_orden", campo_orden) :
                new ObjectParameter("campo_orden", typeof(string));
    
            var tipo_ordenParameter = tipo_orden != null ?
                new ObjectParameter("tipo_orden", tipo_orden) :
                new ObjectParameter("tipo_orden", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_GetDataUsuarioEvaluaciones", searchParameter, page_initParameter, cant_pageParameter, campo_ordenParameter, tipo_ordenParameter);
        }
    }
}