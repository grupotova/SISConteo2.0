using DevExpress.XtraRichEdit;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebInventario2._0.Common
{
    public class Export
    {
        public Export() { }

        public void exportarExcelOpenXML() {
            HttpServerUtility server = HttpContext.Current.Server;
            String rutaTmp = server.MapPath("~/archivos");
            String rutaPlantilla = server.MapPath("~/plantillas");
            String nombrePlantilla = "seguimientoConteo.xlsx";
            String _ArchivoTemporal = "";

            SpreadsheetDocument WBK = null;
            Sheet WSH = null;
            WorksheetPart WSHPart = null;
            SheetData WSD = null;
            Cell WCell = null;
            Row WRow = null;

            String _base, docControl, NombreArchivo, Fecha;
            String filePath;

            int fila = 2;

            DataTable dtResumen = new DataTable("Resumen");
            DataTable dtDetalle = new DataTable("Detalle");

            try{
                dtResumen = cargarResumen();

                if (nombrePlantilla.Trim().Length > 0)
                {
                    nombrePlantilla = System.IO.Path.Combine(rutaPlantilla, nombrePlantilla);

                    if (File.Exists(nombrePlantilla))
                    {
                        if (!Directory.Exists(rutaTmp))
                        {
                            Directory.CreateDirectory(rutaTmp);
                        }
                        else
                        {
                            _ArchivoTemporal = new UtilidadesWeb().crearArchivoAleatorio(rutaTmp, ".xlsx");
                        }
                        File.Copy(nombrePlantilla, _ArchivoTemporal, true);
                        if (File.Exists(_ArchivoTemporal))
                        {
                            WBK = SpreadsheetDocument.Open(_ArchivoTemporal, true);
                            if (WBK != null)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private DataTable cargarResumen() {

            String _base = HttpContext.Current.Session["base"].ToString();
            String docControl = HttpContext.Current.Session["docControl"].ToString();
            String connString = ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString;
            String cmd = "sp_SeguimientoConteo";

            DataTable dt = new DataTable();
            IDictionary<String,String> parameters = new Dictionary<String,String>();
            parameters.Add("@base", _base);
            parameters.Add("@DocInventario", docControl);

            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(connString);
            db.openConn();

            SqlDataReader reader = db.ExecuteReaderSP(cmd,parameters);
            dt.Load(reader);
            db.closeConn();
            return dt;
        }
        private DataTable cargarDetalle() {
            
        }
    }
}