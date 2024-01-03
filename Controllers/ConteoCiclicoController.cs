using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Mvc;
using WebInventario2._0.Common;
using WebInventario2._0.Models;
using WebInventario2._0.Models.FormModels;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace WebInventario2._0.Controllers
{
    public class ConteoCiclicoController : Controller
    {
        // GET: Busqueda
        public ActionResult Busqueda()
        {
            return View();
        }
        public ActionResult Prueba()
        {
            return View();
        }
        public ActionResult AjustarConteo(String SKU, String codEstilo)
        {
            SessionData session = new SessionData();
            BuscarModel model = new BuscarModel();
            session.setSession("sku",SKU);

            model.documentoControl = "500533";//session.getSession("docControl");
            model._Base = 1;//Int32.Parse(session.getSession("base"));
            model.sku = SKU;
            model.cod_estilo = codEstilo;

            return View("AjustarConteo",model);
        }
        [HttpPost]
        public ActionResult AjustarConteo(BuscarModel model)
        {
            return View(model);
        }
        [HttpPost]
        public ActionResult Busqueda(BuscarModel model)
        {
            return View();
        }
        public ActionResult GestorDocumentos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Conteo(BuscarModel model)
        {
            return View(model);
        }
        public ActionResult Conteo()
        {
            SessionData session = new SessionData();
            Data data = new Data();

            if (!session.getSession("usuario").ToString().Equals(""))
            {
                BuscarModel model = new BuscarModel();
                model.documentoControl = session.getSession("docControl");
                model._Base = Int32.Parse(session.getSession("base"));

                data.PorcentajeCostoPisoDep(model.documentoControl, model._Base, model);
                return View("Conteo", model);
            }
            else
            {
                return View();
            }
            //return View();
        }
        public ActionResult Modificaciones()
        {
            return View();
        }

        public ActionResult NoSurtido()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpcSinTeorico(BuscarModel model)
        {
            return View(model);
        }
            public ActionResult UpcSinTeorico()
        {
            SessionData session = new SessionData();
            BuscarModel model = new BuscarModel();
            model.documentoControl = session.getSession("docControl");
            model._Base = Int32.Parse(session.getSession("base"));

            return View("UpsSinTeorico");
        }
        public ActionResult Diferencias()
        {
            return View();
        }
        public ActionResult ContadoSinInventarioActual() {
            return View();
        }
        [HttpPost]
        public ActionResult InventarioGenerado(BuscarModel model)
        {
            return View(model);
        }
        public ActionResult InventarioGenerado(){
            SessionData session = new SessionData();
            BuscarModel model = new BuscarModel();
            model.documentoControl = session.getSession("docControl");
            model._Base = Int32.Parse(session.getSession("base"));

            return View("InventarioGenerado",model); 
        }

        [HttpPost]
        public ActionResult SeguimientoConteo(BuscarModel model) {
            return View(model);
        }
        public ActionResult SeguimientoConteo()
        {
            SessionData session = new SessionData();
            BuscarModel model = new BuscarModel();
            session.setSession("docControl", "500533");
            session.setSession("base","1");
            model.documentoControl = "500533";//session.getSession("docControl");
            model._Base = 1;//Int3 .Parse(session.getSession("base"));

            return View("SeguimientoConteo",model);
        }
        public ActionResult Salir()
        {
            return RedirectToAction("Principal", "Login");
        }

        public ActionResult IngresarNuevoUpc()
        {
            SessionData session = new SessionData();
            BuscarModel model = new BuscarModel();
            model.documentoControl = session.getSession("docControl");
            model._Base = Int32.Parse(session.getSession("base"));

            return View();
        }
        [HttpPost]
        public ActionResult IngresarNuevoUpc(IngresarUPCNuevoModel model) {
            return View(model);
        }

        public ActionResult Generar() {
            SessionData session = new SessionData();    
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);
            IDictionary<String,String> parameters = new Dictionary<String,String>();

            String usuario = session.getSession("usuario");
            String _base = session.getSession("base");
            String documentoControl = session.getSession("docControl");

            String cmd = "sp_Control_Inventario_UpdConteo";

            parameters.Add("@control_inventario",documentoControl);
            parameters.Add("@base",_base);
            parameters.Add("@usuario",usuario);

            db.openConn();

            int x = db.ExecuteNonQuery(cmd,parameters);

            db.closeConn();

            BuscarModel model = new BuscarModel();
            model._Base = Int32.Parse(_base);
            model.documentoControl = documentoControl;

            if (x == -1)
            {
                return View("Conteo",model);
            }
            else {
                model.mensaje = "No se puedo completar la generacion de conteo";
                return View("SeguimientoConteo", model);
            }
        }

        [HttpPost]
        public ActionResult Buscar(BuscarModel model)
        {
            Data data = new Data();
            SessionData session = new SessionData();
            String docControl = model.documentoControl;
            int _base = model._Base;

            if ( session.getSession("usuario") != "")
            {
                if (data.DocControl_Existe(docControl, _base))
                {
                    if (data.DocControl_Generado(docControl, _base))
                    {
                        if (data.VerificaEstadoAjustado(docControl, _base))
                        {
                            session.setSession("base",_base.ToString());
                            session.setSession("docControl", docControl);
                            return RedirectToAction("InventarioGenerado", "ConteoCiclico");

                        }
                        else
                        {
                            session.setSession("base", _base.ToString());
                            session.setSession("docControl", docControl);
                            return RedirectToAction("conteo","ConteoCiclico"); ;
                        }
                    }
                    else
                    {
                        session.setSession("base", _base.ToString());
                        session.setSession("docControl", docControl);
                        return RedirectToAction("SeguimientoConteo", "ConteoCiclico");
                    }
                }
                else
                {
                    model.mensaje = "No Existe El documento de Control";
                    return View("Busqueda", model);
                }
            }
            else {

                model.mensaje = "Session Inactiva";
                return View("Busqueda",model);
            }
        }

        WebInventario2._0.Models.PA_TOVA_SIB_InventariosEntities db = new WebInventario2._0.Models.PA_TOVA_SIB_InventariosEntities();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            SessionData session = new SessionData();
            String docControl = "501626"; //session.getSession("docControl");
            int _base = 16;// Int32.Parse(session.getSession("base"));
            var model = db.sp_ConsultaConteoNOGenerado(_base, docControl);

            return PartialView("~/Views/ConteoCiclico/_GridViewPartial.cshtml", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            int _base = Int32.Parse(session.getSession("base"));

            var model = db.sp_DetalleUpcSinTeorico(_base, docControl);
            return PartialView("~/Views/ConteoCiclico/_GridView1Partial.cshtml", model.ToList());
        }

       
        [ValidateInput(false)]
        public ActionResult GridView2Partial()
        {
            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            int _base = Int32.Parse(session.getSession("base"));

            var model = db.sp_ConsultaNoSurtidos(_base, docControl);
            return PartialView("~/Views/ConteoCiclico/_GridView2Partial.cshtml", model.ToList());
        }


        [ValidateInput(false)]
        public ActionResult GridView3Partial()
        {
            IDictionary<String, String> dict = new Dictionary<String,String>();
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);

            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            String _base = session.getSession("base");


            dict.Add("@sd_base",_base);
            dict.Add("@sd_control_inventario", docControl);
            String command = "EXECUTE dbo.[sp_ConsultaModificaciones] @sd_base, @sd_control_inventario"; 

            db.openConn();
            SqlDataReader reader = db.ExecuteReaderQuery(command, dict);
            DataTable dt = new DataTable();
            dt.Load(reader);

            db.closeConn();

            var model = dt;

            return PartialView("~/Views/ConteoCiclico/_GridView3Partial.cshtml", model);
        }

        [ValidateInput(false)]
        public ActionResult GridView4Partial()
        {
            IDictionary<String, String> dict = new Dictionary<String, String>();
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);

            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            String _base = session.getSession("base");

            dict.Add("@sd_base", _base);
            dict.Add("@sd_control_inventario", docControl);
            String command = "EXECUTE  [dbo].[sp_ConsultadeDiferencias] @sd_base, @sd_control_inventario";

            db.openConn();
            SqlDataReader reader = db.ExecuteReaderQuery(command, dict);
            
            DataTable dt = new DataTable();
            dt.Load(reader);

            db.closeConn();
            var model = dt;

            return PartialView("~/Views/ConteoCiclico/_GridView4Partial.cshtml", model);
        }

        [ValidateInput(false)]
        public ActionResult GridArtSinInvActPartial()
        {

            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            int _base = Int32.Parse(session.getSession("base"));

            var model = db.sp_RepUbicacionesInv0MERCH(_base, docControl);
            return PartialView("~/Views/ConteoCiclico/_GridArtSinInvActPartial.cshtml", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult GridInvGeneradoPartial()
        {
            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            int _base = Int32.Parse(session.getSession("base"));

            var model = db.sp_ConsultaConteoGenerado(_base, docControl);
            return PartialView("~/Views/ConteoCiclico/_GridInvGeneradoPartial.cshtml", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult GridSeguimientoPartial()
        {
            SessionData session = new SessionData();
            String docControl = "500533";//session.getSession("docControl");
            int _base = 1; //Int32.Parse(session.getSession("base"));

            var model = db.sp_SeguimientoConteo_2023(_base,docControl);
            return PartialView("~/Views/ConteoCiclico/_GridSeguimientoPartial.cshtml", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult GridIngresoUPCPartial()
        {
            IDictionary<String, String> dict = new Dictionary<String, String>();
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);

            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            String _base = session.getSession("base");

            dict.Add("@Base", _base);
            dict.Add("@DocControl", docControl);

            String command = "select ROW_NUMBER() OVER (ORDER BY [control_inventario]) as N, control_inventario, Base, Identificador, codigo_estilo, CodigoBarra, Cantidad,comentario as Ajuste,Fecha FROM(SELECT control_inventario, Base, Identificador, codigo_estilo, CodigoBarra, Cantidad, substring(comentario, 1, 19) as comentario, Fecha FROM InventarioPiso WHERE(control_inventario = @DocControl) AND(Base = @Base) AND(Marcado = 1) AND(estado = 1) AND(Identificador = 'PV0000') UNION ALL SELECT control_inventario, Base, Identificador, codigo_estilo, CodigoBarra, Cantidad, substring(comentario, 1, 19) as comentario, Fecha FROM InventarioDeposito WHERE(control_inventario = @DocControl) AND(Base = @Base) AND(Marcado = 1) AND(estado = 1) AND(Identificador = 'DP0000') ) as inv order by control_inventario,Identificador,codigo_estilo,CodigoBarra,Fecha";

            db.openConn();
            SqlDataReader reader = db.ExecuteReaderQuery(command, dict);

            DataTable dt = new DataTable();
            dt.Load(reader);

            db.closeConn();
            var model = dt;

            return PartialView("~/Views/ConteoCiclico/_GridIngresoUPCPartial.cshtml", model);
        }
        public ActionResult GridDetallesConteoPartial(String documentoControl ,String localizacion, String sku) {

            ViewData["sku"] = sku;

            IDictionary<String, String> dict = new Dictionary<String, String>();
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);

            SessionData session = new SessionData();
            String docControl = session.getSession("docControl");
            String _base = session.getSession("base");

            dict.Add("@upc_control_iventario", documentoControl);
            dict.Add("@upc_localizacion",localizacion);
            dict.Add("@upc_sku_id", sku);

            String command = "SELECT ciu_id, ciu_control_inventario, ciu_localizacion,ciu_base, ciu_sku_id, ciu_upc, ciu_cantidad_conteo_mod FROM Control_Inventario_Upc WHERE (ciu_control_inventario = @upc_control_iventario) AND (ciu_localizacion = @upc_localizacion) AND (ciu_sku_id = @upc_sku_id)";

            db.openConn();
            SqlDataReader reader = db.ExecuteReaderQuery(command, dict);

            DataTable dt = new DataTable();
            dt.Load(reader);

            db.closeConn();
            var model = dt;


            return PartialView("~/Views/ConteoCiclico/_GridDetallesConteoPartial.cshtml", model);
        }

        [ValidateInput(false)]
        public ActionResult GridAjustarConteoPartial()
        {
            SessionData session = new SessionData();
            int _base = 1; //Int32.Parse(session.getSession("base"));
            String docControl = "500533";// session.getSession("docControl");
            Decimal sku = 15964200007;// Decimal.Parse(session.getSession("sku"));

            var model = db.sp_Obtener_Conteos_a_Modificar(_base,docControl,sku);
            return PartialView("~/Views/ConteoCiclico/_GridAjustarConteoPartial.cshtml", model.ToList());
        }
    }
}