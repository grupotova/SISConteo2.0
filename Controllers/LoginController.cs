using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebInventario2._0.Common;
using WebInventario2._0.Models.FormModels;

namespace WebInventario2._0.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult IniciarSesion(LoginModel model) {

            String login;
            String pass;
            String aplicacion = "INV";

            UserActiveDirectory DirectorioActivo = new UserActiveDirectory();
            UserActiveDirectory _ActiveDirectory = new UserActiveDirectory();

            Acceso objeto = new Acceso();

            login = model.usuario;
                pass = model.contrasenia;

            String mensaje = objeto.Autenticacion(login, pass,aplicacion);
            if (mensaje.Equals("OK")) {
                return RedirectToAction("Principal","login");
            }
            else{
                model.mensaje = mensaje;
            }

            return RedirectToAction("Login","login");

        }
        public ActionResult Principal () {
            return View();
        }
    }
}