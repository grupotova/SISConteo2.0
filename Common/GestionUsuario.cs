using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using WebInventario2._0.Models;

namespace WebInventario2._0.Common
{
    public class GestionUsuario
    {
        public int VerificaUsuario(String aplicacion, String login, int activedir, String clave)
        {
            int valor;
            String cadenaconexion = "";
            cadenaconexion = ConfigurationManager.ConnectionStrings["TOVA_USER_ConnectionString"].ConnectionString;
            SqlConnection objConexion = new SqlConnection(cadenaconexion);
            objConexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT DBO.FN_VerificaUsuario(@aplicacion, @login, @activedir, @clave)", objConexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 1800;
            cmd.Parameters.AddWithValue("@aplicacion", aplicacion);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@activedir", activedir);
            cmd.Parameters.AddWithValue("@clave", Pass(clave));

            valor = (int) cmd.ExecuteScalar();
            objConexion.Close();

            return valor;
        }
        public int BuscarUsuario(String login) {
            int valor;
            String cadenaconexion = "";
            cadenaconexion = ConfigurationManager.ConnectionStrings["TOVA_USER_ConnectionString"].ConnectionString;
            SqlConnection objConexion = new SqlConnection(cadenaconexion);
            objConexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT DBO.FN_BuscarUsuario(@login)", objConexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 1800;
            cmd.Parameters.AddWithValue("@login", login);

            valor = (int)cmd.ExecuteScalar();
            objConexion.Close();

            return valor;
        }

        public String getUserId(String login, String clave) {
            TOVA_USER db = new TOVA_USER();
            String valor = "";
            var result = (from x in db.Usuario
                     where x.Login == login && x.Password == clave
                     && x.Activo == 1
                     select x).FirstOrDefault();
            if (result != null) {
                valor = result.Usuario_ID.ToString();
            }
            return valor;
        }
        public String Pass(String clave)
        {
            String valor;
            UnicodeEncoding ueCodigo = new UnicodeEncoding();  
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            Byte[] bHash = Md5.ComputeHash(ueCodigo.GetBytes(clave.Trim()));
            valor = Convert.ToBase64String(bHash);
            return valor;
        }
    }
}