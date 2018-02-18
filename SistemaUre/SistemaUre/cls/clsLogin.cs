using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaUre.cls
{

    public class clsLogin
    {
        private clsConec conec = null;

        public clsLogin(string host, string dataBase, string user, string pass)
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsLogin()
        {
            conec = new clsConec();
        }

        public int cmd_verificar_login(string usuario, string contrasena)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("select count(*) from v_login where usuario='" + usuario + "' and contrasena='" + contrasena + "'", cnn.loadConeccion());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }


    }
 }
