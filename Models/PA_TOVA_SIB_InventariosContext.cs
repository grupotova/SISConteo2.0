using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebInventario2._0.Models
{
    public partial class PA_TOVA_SIB_InventariosContext : DbContext
    {
        public PA_TOVA_SIB_InventariosContext()
            : base("name=PA_TOV_SIB_InventariosContext")
        {
        }

        public virtual DbSet<AF_LOG> AF_LOG { get; set; }
        public virtual DbSet<Ajustes> Ajustes { get; set; }
        public virtual DbSet<Ajustes_Inventario_MERCH> Ajustes_Inventario_MERCH { get; set; }
        public virtual DbSet<AjustesProveedoresNacionales> AjustesProveedoresNacionales { get; set; }
        public virtual DbSet<Archivos_AjustesManuales> Archivos_AjustesManuales { get; set; }
        public virtual DbSet<Archivos_ConteosManuales> Archivos_ConteosManuales { get; set; }
        public virtual DbSet<Bultos_Carga_Descarga_Posterior> Bultos_Carga_Descarga_Posterior { get; set; }
        public virtual DbSet<BultosNoIdentificados> BultosNoIdentificados { get; set; }
        public virtual DbSet<BultosSinMaestroArticulos> BultosSinMaestroArticulos { get; set; }
        public virtual DbSet<Ciclico_Producto> Ciclico_Producto { get; set; }
        public virtual DbSet<Ciclico_Ubicacion> Ciclico_Ubicacion { get; set; }
        public virtual DbSet<Ciclico_UbicacionCodigo> Ciclico_UbicacionCodigo { get; set; }
        public virtual DbSet<Ciclico_Zonificacion> Ciclico_Zonificacion { get; set; }
        public virtual DbSet<ComplementosMuebleria> ComplementosMuebleria { get; set; }
        public virtual DbSet<CondicionSugerencia_ConteoDiario> CondicionSugerencia_ConteoDiario { get; set; }
        public virtual DbSet<ConteoCiclico> ConteoCiclico { get; set; }
        public virtual DbSet<ConteoCiclico_Auditoria> ConteoCiclico_Auditoria { get; set; }
        public virtual DbSet<ConteoCiclico_Conteo> ConteoCiclico_Conteo { get; set; }
        public virtual DbSet<ConteoCiclico_DivisionesZonas> ConteoCiclico_DivisionesZonas { get; set; }
        public virtual DbSet<ConteoCiclico_UpcNoExiste> ConteoCiclico_UpcNoExiste { get; set; }
        public virtual DbSet<ConteoDiario> ConteoDiario { get; set; }
        public virtual DbSet<ConteoDiario_Analisis> ConteoDiario_Analisis { get; set; }
        public virtual DbSet<ConteoDiario_Detalle> ConteoDiario_Detalle { get; set; }
        public virtual DbSet<ConteoDiario_DetGruposAprobacionAjustes> ConteoDiario_DetGruposAprobacionAjustes { get; set; }
        public virtual DbSet<ConteoDiario_GruposAprobacionAjustes> ConteoDiario_GruposAprobacionAjustes { get; set; }
        public virtual DbSet<Control_Inv_EstilosTmp> Control_Inv_EstilosTmp { get; set; }
        public virtual DbSet<Control_Inv_Upc_SinDoc> Control_Inv_Upc_SinDoc { get; set; }
        public virtual DbSet<Control_Inventario_Documentos> Control_Inventario_Documentos { get; set; }
        public virtual DbSet<Control_Inventario_Estados> Control_Inventario_Estados { get; set; }
        public virtual DbSet<Control_Inventario_Sku> Control_Inventario_Sku { get; set; }
        public virtual DbSet<Control_Inventario_TiposAjustes> Control_Inventario_TiposAjustes { get; set; }
        public virtual DbSet<Control_Inventario_TiposConteo> Control_Inventario_TiposConteo { get; set; }
        public virtual DbSet<Control_Inventario_Upc> Control_Inventario_Upc { get; set; }
        public virtual DbSet<ControlesCargaEnviados> ControlesCargaEnviados { get; set; }
        public virtual DbSet<DepartamentosZonas> DepartamentosZonas { get; set; }
        public virtual DbSet<DepositoPiso> DepositoPiso { get; set; }
        public virtual DbSet<Detalle_Ajustes_Inventario_MERCH> Detalle_Ajustes_Inventario_MERCH { get; set; }
        public virtual DbSet<Detalle_Archivos_AjustesManuales> Detalle_Archivos_AjustesManuales { get; set; }
        public virtual DbSet<Detalle_Archivos_ConteosManuales> Detalle_Archivos_ConteosManuales { get; set; }
        public virtual DbSet<DivisionesZonas> DivisionesZonas { get; set; }
        public virtual DbSet<EntradasTemporales> EntradasTemporales { get; set; }
        public virtual DbSet<EntradasTemporalesAutorizaciones> EntradasTemporalesAutorizaciones { get; set; }
        public virtual DbSet<EntradasTemporalesCalculos> EntradasTemporalesCalculos { get; set; }
        public virtual DbSet<Estatus_ConteoDiario> Estatus_ConteoDiario { get; set; }
        public virtual DbSet<Estatus_TareasConteoDiario> Estatus_TareasConteoDiario { get; set; }
        public virtual DbSet<Inventario_Conteo> Inventario_Conteo { get; set; }
        public virtual DbSet<Inventario_DetalleConteo> Inventario_DetalleConteo { get; set; }
        public virtual DbSet<InventarioAntesTomaStevens> InventarioAntesTomaStevens { get; set; }
        public virtual DbSet<InventarioAntesTomaStevensCaja> InventarioAntesTomaStevensCaja { get; set; }
        public virtual DbSet<InventarioDeposito> InventarioDeposito { get; set; }
        public virtual DbSet<InventarioPiso> InventarioPiso { get; set; }
        public virtual DbSet<JerarquiasMERCH> JerarquiasMERCH { get; set; }
        public virtual DbSet<LogGeneracion_Tareas_ConteoDiario> LogGeneracion_Tareas_ConteoDiario { get; set; }
        public virtual DbSet<Mermas> Mermas { get; set; }
        public virtual DbSet<MotivosAjustes_ConteoDiario> MotivosAjustes_ConteoDiario { get; set; }
        public virtual DbSet<param_condicion> param_condicion { get; set; }
        public virtual DbSet<Parametros_Sugerencia_Conteo_Diario> Parametros_Sugerencia_Conteo_Diario { get; set; }
        public virtual DbSet<RegistroAuditorias> RegistroAuditorias { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tareas_ConteoDiario> Tareas_ConteoDiario { get; set; }
        public virtual DbSet<Tareas_Motivos> Tareas_Motivos { get; set; }
        public virtual DbSet<TransaccionesVentasNoMarcadas> TransaccionesVentasNoMarcadas { get; set; }
        public virtual DbSet<UbicacionesTerminadas> UbicacionesTerminadas { get; set; }
        public virtual DbSet<VentasNoProcesadas> VentasNoProcesadas { get; set; }
        public virtual DbSet<VentasNoProcesadas_Acciones> VentasNoProcesadas_Acciones { get; set; }
        public virtual DbSet<VentasNoProcesadas_Recorrido> VentasNoProcesadas_Recorrido { get; set; }
        public virtual DbSet<Ajustes_SecuenciaArchivos> Ajustes_SecuenciaArchivos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AF_LOG>()
                .Property(e => e.ActivoFijo)
                .IsUnicode(false);

            modelBuilder.Entity<AF_LOG>()
                .Property(e => e.Base)
                .IsUnicode(false);

            modelBuilder.Entity<AF_LOG>()
                .Property(e => e.AreaComercial)
                .IsUnicode(false);

            modelBuilder.Entity<AF_LOG>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes>()
                .Property(e => e.ProveedorNacional)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.id_conteo)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.usuario_crea)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.total_monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.num_documento)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.usuario_csv)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_Inventario_MERCH>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<AjustesProveedoresNacionales>()
                .Property(e => e.ProveedorNacional)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_AjustesManuales>()
                .Property(e => e.NomArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_AjustesManuales>()
                .Property(e => e.NomOrigArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_AjustesManuales>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_AjustesManuales>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_ConteosManuales>()
                .Property(e => e.NomArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_ConteosManuales>()
                .Property(e => e.NomOrigArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_ConteosManuales>()
                .Property(e => e.CodDivision)
                .IsUnicode(false);

            modelBuilder.Entity<Archivos_ConteosManuales>()
                .Property(e => e.grouping_label)
                .IsUnicode(false);

            modelBuilder.Entity<Bultos_Carga_Descarga_Posterior>()
                .Property(e => e.Bulto)
                .IsFixedLength();

            modelBuilder.Entity<BultosNoIdentificados>()
                .Property(e => e.Bulto)
                .IsFixedLength();

            modelBuilder.Entity<BultosNoIdentificados>()
                .Property(e => e.Ctrlcarga)
                .IsFixedLength();

            modelBuilder.Entity<BultosSinMaestroArticulos>()
                .Property(e => e.Bulto)
                .IsFixedLength();

            modelBuilder.Entity<BultosSinMaestroArticulos>()
                .Property(e => e.Ctrlcarga)
                .IsFixedLength();

            modelBuilder.Entity<BultosSinMaestroArticulos>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclico_Producto>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclico_Ubicacion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclico_Zonificacion>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclico_Zonificacion>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<Ciclico_Zonificacion>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ComplementosMuebleria>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<ComplementosMuebleria>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<ComplementosMuebleria>()
                .Property(e => e.ReferenciaMaster)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionSugerencia_ConteoDiario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionSugerencia_ConteoDiario>()
                .Property(e => e.Usuario_Creador)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionSugerencia_ConteoDiario>()
                .Property(e => e.Usuario_Modificador)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.TipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.codigo_estilo)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<ConteoCiclico_Auditoria>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.TipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.codigo_estilo)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<ConteoCiclico_Conteo>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_DivisionesZonas>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_DivisionesZonas>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_DivisionesZonas>()
                .Property(e => e.Tipo_Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_UpcNoExiste>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_UpcNoExiste>()
                .Property(e => e.TipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_UpcNoExiste>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoCiclico_UpcNoExiste>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.CodDivision)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.Usuario_Status)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.Usuario_Actual)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario>()
                .Property(e => e.grouping_label)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.sku_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.motivo_ajuste)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.Usuario_Proc)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.tot_costo_teorico)
                .HasPrecision(14, 2);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.costo_promedio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.motivo_ajuste_analisis)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.comentario_analisis)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.motivo_ajuste_aprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Analisis>()
                .Property(e => e.comentario_aprobacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Detalle>()
                .Property(e => e.sku_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ConteoDiario_Detalle>()
                .Property(e => e.condicion)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_Detalle>()
                .Property(e => e.tot_costo)
                .HasPrecision(14, 2);

            modelBuilder.Entity<ConteoDiario_GruposAprobacionAjustes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_GruposAprobacionAjustes>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_GruposAprobacionAjustes>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<ConteoDiario_GruposAprobacionAjustes>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);

            modelBuilder.Entity<Control_Inv_EstilosTmp>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Control_Inv_EstilosTmp>()
                .Property(e => e.style_id)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Control_Inv_Upc_SinDoc>()
                .Property(e => e.sd_sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Control_Inventario_Sku>()
                .Property(e => e.cis_sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Control_Inventario_Sku>()
                .Property(e => e.cis_estilo_id)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Control_Inventario_Sku>()
                .Property(e => e.cis_costo)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Control_Inventario_TiposAjustes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Control_Inventario_TiposConteo>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Control_Inventario_Upc>()
                .Property(e => e.ciu_sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<ControlesCargaEnviados>()
                .Property(e => e.Ctrlcarga)
                .IsFixedLength();

            modelBuilder.Entity<DepartamentosZonas>()
                .Property(e => e.Departamento)
                .IsUnicode(false);

            modelBuilder.Entity<DepartamentosZonas>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<DepartamentosZonas>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<DepartamentosZonas>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DepositoPiso>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<DepositoPiso>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_Ajustes_Inventario_MERCH>()
                .Property(e => e.sku_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Detalle_Ajustes_Inventario_MERCH>()
                .Property(e => e.costo_promedio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Detalle_Ajustes_Inventario_MERCH>()
                .Property(e => e.monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Detalle_Archivos_AjustesManuales>()
                .Property(e => e.UPC)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_Archivos_AjustesManuales>()
                .Property(e => e.ESTILO)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_Archivos_AjustesManuales>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_Archivos_AjustesManuales>()
                .Property(e => e.TALLA)
                .IsUnicode(false);

            modelBuilder.Entity<Detalle_Archivos_ConteosManuales>()
                .Property(e => e.UPC)
                .IsUnicode(false);

            modelBuilder.Entity<DivisionesZonas>()
                .Property(e => e.Division)
                .IsUnicode(false);

            modelBuilder.Entity<DivisionesZonas>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<DivisionesZonas>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<DivisionesZonas>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.FuenteEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.No_camion)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Movtransp)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Ctrlcarga)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Bto_cons)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Bulto)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Referencia)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporales>()
                .Property(e => e.Numlinea)
                .IsFixedLength();

            modelBuilder.Entity<EntradasTemporalesAutorizaciones>()
                .Property(e => e.Causa)
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporalesAutorizaciones>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporalesCalculos>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<EntradasTemporalesCalculos>()
                .Property(e => e.FuenteEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_ConteoDiario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_ConteoDiario>()
                .Property(e => e.Usuario_Creador)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_ConteoDiario>()
                .Property(e => e.Usuario_Modificador)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_TareasConteoDiario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_TareasConteoDiario>()
                .Property(e => e.Usuario_Creador)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_TareasConteoDiario>()
                .Property(e => e.Usuario_Modificador)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.tipo_ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.style_code)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_Conteo>()
                .Property(e => e.Usuario_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.tipo_ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.style_code)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.IdUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario_DetalleConteo>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioAntesTomaStevensCaja>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.codigo_estilo)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<InventarioDeposito>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.codigo_estilo)
                .IsUnicode(false);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.sku_id)
                .HasPrecision(13, 0);

            modelBuilder.Entity<InventarioPiso>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Mermas>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<Mermas>()
                .Property(e => e.Hora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MotivosAjustes_ConteoDiario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivosAjustes_ConteoDiario>()
                .Property(e => e.Usuario_Creador)
                .IsUnicode(false);

            modelBuilder.Entity<MotivosAjustes_ConteoDiario>()
                .Property(e => e.Usuario_Modificador)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Sugerencia_Conteo_Diario>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Sugerencia_Conteo_Diario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Sugerencia_Conteo_Diario>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Sugerencia_Conteo_Diario>()
                .Property(e => e.Usuario_Creador)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros_Sugerencia_Conteo_Diario>()
                .Property(e => e.Usuario_Modificador)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroAuditorias>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroAuditorias>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.style_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.style_code)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.Usuario_Status)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.tipo_ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.Usuario_Asignado)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_ConteoDiario>()
                .Property(e => e.ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas_Motivos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionesTerminadas>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas>()
                .Property(e => e.CodigoBarra)
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas>()
                .Property(e => e.CodigoLigado)
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas>()
                .Property(e => e.HoraFin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VentasNoProcesadas_Acciones>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_SecuenciaArchivos>()
                .Property(e => e.Usuario_Crea)
                .IsUnicode(false);

            modelBuilder.Entity<Ajustes_SecuenciaArchivos>()
                .Property(e => e.Usuario_Mod)
                .IsUnicode(false);
        }
    }
}
