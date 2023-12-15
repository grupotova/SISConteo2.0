using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebInventario2._0.Models
{
    public partial class TOVA_USER : DbContext
    {
        public TOVA_USER()
            : base("name=TOVA_USER")
        {
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>()
                .Property(e => e.Controlador)
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .Property(e => e.Vista)
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Acceso>()
                .HasMany(e => e.AccesoRol)
                .WithRequired(e => e.Acceso)
                .HasForeignKey(e => e.Acceso_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.RutaSetup)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Desarrollador)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Soporte)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.NombreDB)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.IPDB)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .Property(e => e.Lenguaje)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicacion>()
                .HasMany(e => e.AplicacionRol)
                .WithRequired(e => e.Aplicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aplicacion>()
                .HasMany(e => e.UsuarioAplicacion)
                .WithRequired(e => e.Aplicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CentroCosto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CentroCosto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CentroCosto>()
                .Property(e => e.Padre)
                .IsFixedLength();

            modelBuilder.Entity<CentroCosto>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<CentroCosto>()
                .HasMany(e => e.CentroCostoUsuario)
                .WithRequired(e => e.CentroCosto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Icono)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Controlador)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Vista)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.MenuOperacion)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.MenuRol)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenuOperacion>()
                .HasMany(e => e.MenuOperacionRol)
                .WithRequired(e => e.MenuOperacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.MenuOperacion)
                .WithRequired(e => e.Operacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.AccesoRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.AplicacionRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.MenuOperacionRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.MenuRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.UsuarioRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NumAsociado)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Acceso)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Acceso1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.AccesoRol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.AccesoRol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Aplicacion)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Aplicacion1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.AplicacionRol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.AplicacionRol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Cargo)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Cargo1)
                .WithOptional(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.CentroCosto)
                .WithOptional(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.CentroCosto1)
                .WithOptional(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Menu)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Menu1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.MenuOperacionRol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.MenuOperacionRol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.MenuRol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.MenuRol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Operacion1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Rol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Rol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Usuario1)
                .WithRequired(e => e.Usuario2)
                .HasForeignKey(e => e.UsuarioCreador);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Usuario11)
                .WithRequired(e => e.Usuario3)
                .HasForeignKey(e => e.UsuarioModificador);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioAplicacion)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Usuario_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioAplicacion1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioAplicacion2)
                .WithRequired(e => e.Usuario2)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioRol)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Usuario_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioRol1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuarioCreador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioRol2)
                .WithRequired(e => e.Usuario2)
                .HasForeignKey(e => e.UsuarioModificador)
                .WillCascadeOnDelete(false);
        }
    }
}
