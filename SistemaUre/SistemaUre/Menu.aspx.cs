using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre
{


    public partial class Menu1 : System.Web.UI.Page
    {
            
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNDOCENTE_Click(object sender, EventArgs e)
        {           
            Session["Valor"] = "d";
            Response.Redirect("/URE/Mantenimiento/MDocente.aspx");
        }

        protected void BTNADMINISTRATIVO_Click(object sender, EventArgs e)
        {
            Session["Valor"] = "a";
            Response.Redirect("/URE/Mantenimiento/MDocente.aspx");
        }
    }
}