using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebInventario2._0.Models;
using WebInventario2._0.Models.FormModels;

namespace WebInventario2._0.Controllers
{
    public class ConteoCiclicoController : Controller
    {
        // GET: Busqueda
        public ActionResult Busqueda()
        {
            return View();
        }
        public ActionResult Salir() {
            return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public ActionResult Buscar(BuscarModel model) {

            String docControl = model.documentoControl;
            int _base = model._Base;

            if (DocControl_Existe(docControl, _base))
            {
                if(DocControl_Generado(docControl,_base))
                    return RedirectToAction("", "");//TODO
            }
            else {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }

        private Boolean DocControl_Existe(String documentoControl, int _Base) {

            Boolean resp = false;
            PA_TOVA_SIB_InventariosContext db = new PA_TOVA_SIB_InventariosContext();

            var result = (from x in db.Control_Inventario_Upc
                          where x.ciu_control_inventario == documentoControl && x.ciu_base == _Base
                          select x.ciu_control_inventario).FirstOrDefault();

            if (result !=  null && result != "")
            {
                resp = true;
            }

            return resp;
        }
        private Boolean DocControl_Generado(String documentoControl, int _Base) {
            Boolean resp = false;
            PA_TOVA_SIB_InventariosContext db = new PA_TOVA_SIB_InventariosContext();

            var result = (from x in db.Control_Inventario_Upc
                          where x.ciu_control_inventario == documentoControl && x.ciu_base == _Base
                          && ((x.ciu_cantidad_conteo ?? 0) > 0)
                          select x.ciu_cantidad_conteo).FirstOrDefault();

            if (result != null )
            {
                resp = true;
            }

            return resp;
        }
        private Boolean VerificaEstadoAjustado(String docControl, int _base) {
            
            Boolean resp = false;
       
            return resp;
        }
    }
}