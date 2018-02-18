using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              
            
            estadobtn.Text = "Iniciar Sesion";
              //Session.Remove("Valor");

              if (Session["estado"] == "desactivo".ToString())
              {
                  estadobtn.Text = "Iniciar Sesion";

              }

              if (Session["estado"] == "activo".ToString())
              {
                  estadobtn.Text = "Cerrar Sesion";
              }
        }

        protected void estadobtn_Click(object sender, EventArgs e)
        {
           
        
            if (Session["estado"] == "activo".ToString())
            {
                Session.Abandon();
                Session.Clear();
                Session["estado"] = "desactivo";
            }

            Response.Redirect("Login.aspx");     
        }

    
    }
}