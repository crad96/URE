using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.CRUD
{
    public partial class CRUDArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.listarArea();

            }
        }

        protected void btnAgregarArea_Click(object sender, EventArgs e)
        {
            string descripcion = txtDesc_area.Text;
            clsCRUDArea c = new clsCRUDArea();
            c.insert_area(descripcion);


            clsCRUDArea cl = new clsCRUDArea ();
            GridViewListar_area.DataSource = cl.listarArea();
            GridViewListar_area.DataBind();

        }

        protected void btnAgregararea_Click1(object sender, EventArgs e)
        {
            string desc_area = txtDesc_area.Text.ToString().Trim();

            clsCRUDArea cl = new clsCRUDArea();
            cl.insert_area(desc_area);


            listarArea();
        }

        public void listarArea()
        {
            clsCRUDArea cl= new clsCRUDArea();
            GridViewListar_area.DataSource = cl.listarArea();
            GridViewListar_area.DataBind();
        }


        protected void GridViewListar_area_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewListar_area.EditIndex = e.NewEditIndex;
            listarArea();
        }

        protected void GridViewListar_area_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow r = GridViewListar_area.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigoarea") as Label);
            TextBox descripcion = (r.FindControl("txtDescripcionarea") as TextBox);

            clsCRUDArea cl = new clsCRUDArea();
            cl.update_area(Convert.ToInt32(codi.Text), descripcion.Text);
            GridViewListar_area.EditIndex = -1;
            this.listarArea();
        }


        protected void GridViewListar_area_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow r = GridViewListar_area.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigoarea") as Label);
            Label estado = (r.FindControl("lblestadoarea") as Label);

            if (Convert.ToString(estado.Text).ToString() == "Activo")
            {
                clsCRUDArea cl = new clsCRUDArea();
                cl.update_area_estado(0, Convert.ToInt32(codi.Text));
            }
            else if (Convert.ToString(estado.Text).ToString() == "Inactivo")
            {
                clsCRUDArea cl = new clsCRUDArea();
                cl.update_area_estado(1, Convert.ToInt32(codi.Text));
            }

            GridViewListar_area.EditIndex = -1;
            this.listarArea();
        }

        protected void GridViewListar_area_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewListar_area.EditIndex = -1;
            this.listarArea();
        }

     
    }
}