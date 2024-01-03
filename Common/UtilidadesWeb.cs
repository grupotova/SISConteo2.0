using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebInventario2._0.Models;

namespace WebInventario2._0.Common
{
    public class UtilidadesWeb
    {
        public Boolean SessionExpirada() {
            if (!(HttpContext.Current.Session == null)) {
                if (HttpContext.Current.Session.IsNewSession == true) {
                    String coockieHeaders = HttpContext.Current.Request.Headers["Cookie"];

                    if (!(coockieHeaders == null) && (coockieHeaders.IndexOf("ASP.NET_SessionId") >= 0)) { 
                      /*Es un visitante existente pero la sesion de ASP.NET ha caducado*/
                    }
                }
            }
            /*La sesion ha caducado y la funcion devolvera False
             Podria ser nueva sesion, o sesion activa existente*/
            return false;
        }

        public void DescargaArchivo(HttpResponse response, String nombreArchivo, String rutaTmp) {
            response.Clear();
            response.AddHeader("Content-Disposition", "attachment; filename=" + nombreArchivo);
            response.ContentType = "application/octet-stream";

            String fileTmp = Path.Combine(rutaTmp,nombreArchivo);

            response.WriteFile(fileTmp);
            response.End();
        }
        public void DescargarArchivoExcel(HttpResponse response, String nombreArchivo, String rutaTmp) {
            response.Clear();
            response.AddHeader("Content-Disposition", "attachment; filename=" + nombreArchivo);
            response.ContentType = "application/vnd.xls";

            String fileTmp = Path.Combine(rutaTmp, nombreArchivo);

            response.WriteFile(fileTmp);
            response.End();
        }
        public String crearArchivoAleatorio(String ruta, String extension) {
            String myFileName = "";
            myFileName = Path.Combine(ruta,Path.GetRandomFileName());
            myFileName = Path.ChangeExtension(myFileName, extension);

            while (File.Exists(myFileName)){
                myFileName = Path.Combine(ruta, Path.GetRandomFileName());
                myFileName = Path.ChangeExtension(myFileName, extension);

            }
            return myFileName;
        }
    }
}