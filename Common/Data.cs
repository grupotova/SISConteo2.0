using DevExpress.Web;
using DevExpress.XtraReports.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebInventario2._0.Models;
using WebInventario2._0.Models.FormModels;

namespace WebInventario2._0.Common
{
    public class Data
    {
        public DataTable ObtenerUpc(String documentoControl, int _base) { 
            DataTable datosTabla = new DataTable(); 
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            String cmd = "sp_Doc_Control_GenerarArchivoUPC";

            parameters.Add("@documento", documentoControl);
            parameters.Add("@base", _base.ToString());

            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_BasesConnectionString"].ConnectionString);
            db.openConn();
            SqlDataReader reader = db.ExecuteReaderSP(cmd,parameters);

            datosTabla.Load(reader);

            db.closeConn();

            return datosTabla;  
        }
        DataTable ObtenerSKU(String documentoControl, int _base) {
            DataTable datosTabla = new DataTable();
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            String cmd = "sp_Doc_Control_GenerarArchivoSKU";

            parameters.Add("@documento", documentoControl);
            parameters.Add("@base", _base.ToString());

            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_BasesConnectionString"].ConnectionString);
            db.openConn();
            SqlDataReader reader = db.ExecuteReaderSP(cmd, parameters);

            datosTabla.Load(reader);

            db.closeConn();

            return datosTabla;

        }
        Int64 ObtenerIdUsuarioInventario(String NomUsuario) {
            DataTable datosTabla = new DataTable();
            Int64 IdUsuario = -99999;
            IDictionary<String,String> parameters = new Dictionary<String, String>();
            String cmd = "SELECT * FROM [Usuarios] WHERE usuario = @usuario";

            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_BasesConnectionString"].ConnectionString);
            parameters.Add("@usuario",NomUsuario);

            db.openConn();

            SqlDataReader reader = db.ExecuteReaderQuery(cmd, parameters);
            datosTabla.Load(reader);
            db.closeConn();

            if (datosTabla.Rows.Count > 1) {
                IdUsuario = Convert.ToInt64(datosTabla.Rows[0]["Id"]);
            }

            return IdUsuario;
        }
        public Boolean DocControl_Existe(String documentoControl, int _Base)
        {

            Boolean resp = false;
            PA_TOVA_SIB_InventariosContext db = new PA_TOVA_SIB_InventariosContext();

            var result = (from x in db.Control_Inventario_Upc
                          where x.ciu_control_inventario == documentoControl && x.ciu_base == _Base
                          select x.ciu_control_inventario).FirstOrDefault();

            if (result != null && result != "")
            {
                resp = true;
            }

            return resp;
        }
        public Boolean DocControl_Generado(String documentoControl, int _Base)
        {
            Boolean resp = false;
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);
            DataTable dt = new DataTable();

            IDictionary<String, String> dict = new Dictionary<String, String>();

            dict.Add("@base", _Base.ToString());
            dict.Add("@documento", documentoControl);

            String command = "SELECT top 1 [ciu_cantidad_conteo] FROM [dbo].[Control_Inventario_Upc] upc where upc.ciu_control_inventario = @documento  and upc.ciu_base = @base and isnull(upc.ciu_cantidad_conteo,0) > 0";

            db.openConn();
            SqlDataReader reader = db.ExecuteReaderQuery(command, dict);
            dt.Load(reader);
            db.closeConn();

            if (dt.Rows.Count > 0)
            {
                resp = true;
            }
            return resp;
        }
        public Boolean VerificaEstadoAjustado(String docControl, int _base)
        {
            Boolean valor = false;
            String cadenaconexion = "";
            cadenaconexion = ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString;
            SqlConnection objconexion = new SqlConnection(cadenaconexion);
            objconexion.Open();
            SqlCommand objCommandSql = new SqlCommand("SELECT DBO.fn_VerificaEstadoInventario(@doccontrol ,@base, 1,1)", objconexion);
            objCommandSql.CommandType = System.Data.CommandType.Text;
            objCommandSql.CommandTimeout = 1800;
            objCommandSql.Parameters.AddWithValue("@doccontrol", docControl);
            objCommandSql.Parameters.AddWithValue("@base", _base);


            int resp = Int32.Parse(objCommandSql.ExecuteScalar().ToString());

            if (resp == 1)
                valor = true;

            return valor;

        }
        public void PorcentajeCostoPisoDep(String documentoControl, int _base, BuscarModel model)
        {
            DataTable valores = new DataTable();

            Decimal CostoPiso = 0, CostoDep = 0;
            Decimal dporPiso = 0, dporDep = 0;

            String cmd = "sp_PorcCostoPisoDeposito";
            IDictionary<String,String> parameters = new Dictionary<String,String>();
            PA_TOVA_SIB_Inventario db = new PA_TOVA_SIB_Inventario(ConfigurationManager.ConnectionStrings["PA_TOVA_SIB_InventarioConnectionString"].ConnectionString);

            parameters.Add("control_inventario",documentoControl);
            parameters.Add("base",_base.ToString());

            db.openConn();

            SqlDataReader reader = db.ExecuteReaderSP(cmd, parameters);

            valores.Load(reader);
            db.closeConn();

            if (valores.Rows.Count > 0)
            {
                foreach (DataRow x in valores.Rows)
                {
                    CostoPiso = Convert.ToDecimal(x["CostoTotalPiso"].ToString());
                    CostoDep = Convert.ToDecimal(x["CostoTotalDep"].ToString());
                    dporPiso = Convert.ToDecimal(x["PorcPiso"].ToString());
                    dporDep = Convert.ToDecimal(x["PorcDeposito"].ToString());
                }
            }
            else {
                dporPiso = 0;
                dporDep = 0;
                CostoPiso = 0;
                CostoDep = 0;
            }
            model.CostoPiso = CostoPiso;
            model.CostoDep = CostoDep;
            model.dporPiso = dporPiso;
            model.dporDep  = dporDep;

        }

    }
}