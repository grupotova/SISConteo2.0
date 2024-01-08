using System.Web.Mvc;
using WebInventario2._0.Services;

namespace WebInventario2._0.Controllers
{
    public class SeguimientoController : Controller
    {
        public ActionResult Avance(int baseId, string controlInventario)
        {
            var objSeguimientoService = new SeguimientoService();

            var response = objSeguimientoService.GetAvanceTotal(baseId, controlInventario);

            return View(response);
        }
    }
}