using DevExpress.XtraRichEdit.Import.Doc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebInventario2._0.Common
{
    public class PA_TOVA_SIB_Inventario
    {   
        private String cadenaConexion;
        SqlConnection conn;
        SqlCommand cmd;
        public PA_TOVA_SIB_Inventario(String cadenaConexion){
            this.cadenaConexion = cadenaConexion;
        }

        public void openConn() { 
            this.conn = new SqlConnection(this.cadenaConexion);
            this.conn.Open();
        }  
       public void closeConn() { this.conn.Close(); } 

        public Boolean ExecuteScalar( String command, IDictionary<String,String> parameters) {

            Boolean valor = false;

            this.cmd = new SqlCommand(command,this.conn);
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandTimeout = 1800;
            foreach (KeyValuePair<String,String> x in parameters)
            {
                cmd.Parameters.AddWithValue(x.Key,x.Value);
            }

            valor = Convert.ToBoolean(cmd.ExecuteScalar().ToString());

            return valor;
        }
        public SqlDataReader ExecuteReaderSP(String command, IDictionary<String, String> parameters) {
            
            this.cmd = new SqlCommand(command, this.conn);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandTimeout = 1800;

            foreach (KeyValuePair<String, String> x in parameters)
            {
                cmd.Parameters.AddWithValue(x.Key, x.Value);
            }

            SqlDataReader reader = this.cmd.ExecuteReader();

            return reader;
        }
        public int ExecuteNonQuery(String command, IDictionary<String, String> parameters)
        {

            this.cmd = new SqlCommand(command, this.conn);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandTimeout = 1800;

            foreach (KeyValuePair<String, String> x in parameters)
            {
                cmd.Parameters.AddWithValue(x.Key, x.Value);
            }

            int reader = this.cmd.ExecuteNonQuery();

            return reader;
        }

        public SqlDataReader ExecuteReaderQuery(String command, IDictionary<String, String> parameters)
        {

            this.cmd = new SqlCommand(command, this.conn);
            this.cmd.CommandTimeout = 1800;

            foreach (KeyValuePair<String, String> x in parameters)
            {
                cmd.Parameters.AddWithValue(x.Key, x.Value);
            }

            SqlDataReader reader = this.cmd.ExecuteReader();

            return reader;
        }

    }
}