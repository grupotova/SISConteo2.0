using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace WebInventario2._0.Common
{
    public class SessionData
    {
        private String Session;
        
        public String  getSession(String name) { 
            
            Session = Convert.ToString(HttpContext.Current.Session[name]);
            
            return Session; 
        }
        public void setSession(String name, String data) {
            HttpContext.Current.Session[name] = data;
        }

        public void destroySession() {
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.RemoveAll();
        }

        public Boolean VerificarSession() {
            Boolean msg_session = false;
            SessionData sesion = new SessionData();

            if (!string.IsNullOrEmpty(getSession("ID").ToString())) {
                msg_session = true;
            }
            return msg_session;
        }
    }

}