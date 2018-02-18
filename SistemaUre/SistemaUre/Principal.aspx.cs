using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre
{
    public partial class Principal1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["estado"] == "desactivo".ToString())
            {
                Response.Redirect("Login.aspx");
                Inicio.Text = "Iniciar Sesion";
                
            }
            if (Session["estado"] == "activo".ToString())
            {
                Inicio.Text = "Cerrar Sesion";
            }
        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
 
        }

        protected void Inicio1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}