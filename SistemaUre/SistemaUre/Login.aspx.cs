using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["estado"] == "activo".ToString())
            {
                Response.Redirect("Menu.aspx");
            }
        }

        protected void inicia_Sesion_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string contrasena = txtcontrasena.Text.Trim();

            clsLogin cl = new clsLogin();
            int nregistros= cl.cmd_verificar_login(usuario, contrasena);

            if (nregistros > 0)
            {
                Session["estado"] = "activo";
              Response.Redirect("Menu.aspx");
            }
            else
            {
                Session["estado"] = "desactivo";
                Response.Redirect("Login.aspx");
            }

    
        }


    }
}