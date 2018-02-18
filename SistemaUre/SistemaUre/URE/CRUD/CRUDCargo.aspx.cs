using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.CRUD
{
    public partial class CRUDCargo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar_Cargo();
            }
        }


        public void Listar_Cargo () {
            clsCRUDCargo cl = new clsCRUDCargo();
            List_Cargo_G.DataSource = cl.listar_cargo();
            List_Cargo_G.DataBind();
        }

        protected void btnIngresar_Cargo_Click(object sender, EventArgs e)
        {
            try
            {   string descripcion = txtDescripcion.Text.Trim();
                clsCRUDCargo cl = new clsCRUDCargo();
                if (descripcion != "")
                {
                    cl.insert_cargo(descripcion);
                    txtDescripcion.Text = "";
                    Listar_Cargo();
                }
                else{}
            }
            catch (Exception ex){ex.Message.ToString();}
        }


        protected void List__RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow r = List_Cargo_G.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox descripcion = (r.FindControl("txtDescripcion") as TextBox);

            string _codi = Convert.ToString(codi.Text).ToString();
            int nuevoCodi = int.Parse(_codi);
            string _descripcion = Convert.ToString(descripcion.Text);


            clsCRUDCargo c = new clsCRUDCargo();
            c.update_cargo(_descripcion, nuevoCodi);

            List_Cargo_G.EditIndex = -1;
            this.Listar_Cargo();
        }

        protected void List__RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
             List_Cargo_G.EditIndex = -1;
             this.Listar_Cargo();
        }

        protected void List_Cargo_G_RowEditing(object sender, GridViewEditEventArgs e)
        {
            List_Cargo_G.EditIndex = e.NewEditIndex;
            this.Listar_Cargo();
        }

        protected void List_Cargo_G_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow r = List_Cargo_G.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);


            clsCRUDCargo cl = new clsCRUDCargo();
            cl.delete_cargo(Convert.ToInt32(codi.Text));
           
            List_Cargo_G.EditIndex = -1;
            this.Listar_Cargo();
           
        }  
    }
}