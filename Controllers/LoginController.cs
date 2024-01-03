using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            return View(model);
        }
        public ActionResult IniciarSesion(LoginModel model) {

            String login;
            String pass;
            String aplicacion = "INV2";

            UserActiveDirectory DirectorioActivo = new UserActiveDirectory();
            UserActiveDirectory _ActiveDirectory = new UserActiveDirectory();

            Acceso objeto = new Acceso();

            login = model.usuario;
                pass = model.contrasenia;

            String mensaje = objeto.Autenticacion(login, pass,aplicacion);
            if (mensaje.Equals("OK")) {
                return RedirectToAction("Principal","Login");
            }
            else{
                model.mensaje = mensaje;
                return View("Login",model);
            } 

        }
        public ActionResult Principal () {
            return View();
        }
        public ActionResult Logout()
        {
            String usuario = Session["usuario"].ToString();
            String UserId = Session["UserId"].ToString();

            String cadenaConexion = ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 5400;

            cmd.CommandText = "[sp_ConteoDiario_Liberar_ByUser]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Usuario",UserId);
            cmd.Parameters.Add("@OK",SqlDbType.Bit);
            cmd.Parameters.Add("@mensaje_error",SqlDbType.VarChar,-1);
            cmd.Parameters["@OK"].Direction = ParameterDirection.Output;
            cmd.Parameters["@mensaje_error"].Direction = ParameterDirection.Output;

            conn.Open();
            cmd.ExecuteNonQuery();

            Boolean OK = Boolean.Parse(cmd.Parameters["@OK"].Value.ToString());

            SessionData objSession = new SessionData();
            objSession.destroySession();

            return RedirectToAction("Login","Login");
        }
    }
}