using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace WebInventario2._0.Common
{
    public class UserActiveDirectory
    {
        private String _Nombre { get; set;}
        private String _Apellido { get; set; }
        private String _email { get; set; }
        private String _Password { get; set; }
        private String _Login { get; set; }
        private String _Server { get; set; } =  "GRUPOTOVA";
        private String _Mensaje { get; set; }


        UserActiveDirectory validarUsuario(String UserName, String Clave) { 
            
            String UsuarioDominio  = _Server + "\\" + UserName;
            DirectoryEntry directorio = new DirectoryEntry("LDAP://" + _Server, UsuarioDominio, Clave);
            UserActiveDirectory User = new UserActiveDirectory();

            try {
                if (String.IsNullOrEmpty(UserName.Trim()))
                {
                    User._Mensaje = "Login - El campo login es obligatorio";
                }
                else if (String.IsNullOrEmpty(Clave.Trim()))
                {
                    User._Mensaje = "Password- El campo Password es Obligatorio";
                }
                else { 
                    DirectorySearcher search = new DirectorySearcher(directorio);
                    search.SearchScope = SearchScope.Subtree;
                    search.Filter = "(sAMAccountName="+UserName+")";
                    SearchResultCollection results = search.FindAll();
                    if (results.Count > 0)
                    {
                        User._Login = GetValueProperty("sAMAccountName", UserName.Trim(), directorio);
                        User._Nombre = GetValueProperty("givenName", UserName.Trim(), directorio);
                        User._Apellido = GetValueProperty("sn", UserName.Trim(), directorio);
                        User._Mensaje = "EXITO";
                    }
                    else {
                        User._Login = "";
                        User._Nombre = "";
                        User._Apellido = "";
                        User._Mensaje = "Usuario o contraseña invalida";
                    }
                }
            } 
            catch(Exception ex) {
                User._Mensaje = ex.Message;
            }
            return User;
        }

        String GetValueProperty(String propiedad, String Usuario, DirectoryEntry Directorio) { 
            
            String valor = "";
            try {
                DirectorySearcher Busqueda = new DirectorySearcher(Directorio);
                Busqueda.Filter = "(SAMAccountName=" + Usuario + ")";
                Busqueda.PropertiesToLoad.Add(propiedad);
                SearchResult resultado = Busqueda.FindOne();
                if (resultado != null)
                {
                    valor = resultado.Properties[propiedad].ToString();
                }
            } 
            catch(Exception ex) {
                valor = "";
            }
            return valor;
        }
        

    }
}