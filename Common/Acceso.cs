using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Channels;
using System.Web;
using WebInventario2._0.ServiciosGUC;

namespace WebInventario2._0.Common
{
    public class Acceso
    {
        SessionData sessionObj = new SessionData();
        public Boolean AccesoModulo(int AplicationId,String Controlador, String Vista, String Roles) {
            Boolean permiso = false;

            ServiciosGUC.ServiceClient a = new ServiciosGUC.ServiceClient();
            var u = a.AccesoModulo(AplicationId, Controlador, Vista, Roles);

            return permiso;
        }

        public String Autenticacion(String login, String pass, String aplicacion) {
            String mensaje = "";
            try {
                ServiciosGUC.ServiceClient a = new ServiciosGUC.ServiceClient("BasicHttpBinding_IService");
                var u = a.Authenticate(login, pass, aplicacion);
                var centrosCostosAlias = "";

                mensaje = u.Message;

                if (mensaje.Equals("OK")) {
                    sessionObj.setSession("UserId",u.UserID);
                    sessionObj.setSession("usuario", login);

                    foreach(var app in u.Applications){
                        sessionObj.setSession("RolId", app.ID_Role);
                        sessionObj.setSession("AplicacionId", (app.App_ID).ToString());
                        var centros = a.GetCentroCostoUsuario(app.Usuario_ID, 0, 1);
                        int cont = 0;

                        foreach (var centro in centros.CentrosCostos) {
                            centrosCostosAlias = centrosCostosAlias + centro.AliasCentro.ToString() + ",";
                            cont += 1;
                        }

                        if (cont > 0)
                        {
                            centrosCostosAlias = centrosCostosAlias.Substring(0, centrosCostosAlias.Length - 1);
                        }
                        else {
                            mensaje = "No tiene una Base Asociada, Por favor asociarla en el Sistema de Usuario Centralizado";
                        }
                    }
                }
            } 
            catch (Exception ex){
                mensaje = ex.Message;
            }
            return mensaje;
        }

        public String GetMenuCompleto()
        {
            String listaAnidad = "";
            ServiciosGUC.ServiceClient a = new ServiciosGUC.ServiceClient("BasicHttpBinding_IService");

            String ruta = getUrl(HttpContext.Current.Request.Url.OriginalString);
            String sAplicationId = sessionObj.getSession("AplicacionId");

            if (sAplicationId.Equals("")) {
                sAplicationId = "0";
            }

            String rol = sessionObj.getSession("RolId");
            int AplicacionId = Int32.Parse(sAplicationId);
            UserData obj = a.GetMenuCompletoSB(AplicacionId, rol, ruta);

            foreach (Application app in obj.Applications)
            {
                listaAnidad = app.Menu;
            }
            return listaAnidad;
        }

        public String getUrl(String url)
        {
            String ruta = url;
            String rutaaux = "";
            int pos = 0;
            int repeticiones = 4;
            int cont = 1;
            Char caracter = '/';

            if (ruta.IndexOf("localhost") == -1)
            {
                repeticiones = 4;
            }
            else
            {
                repeticiones = 3;
            }

            for (int i = 0; i < ruta.Length; i++)
            {
                if (cont <= repeticiones)
                {
                    if (ruta[i] == caracter)
                    {
                        cont += 1;
                    }
                }
                else
                {
                    pos = i;
                    break;
                }
            }
            rutaaux = ruta.Substring(0, pos - 1);

            return rutaaux;
        }
    }
}