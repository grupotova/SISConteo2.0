using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Channels;
using System.Web;

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
    }
}