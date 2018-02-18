using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre.URE.CRUD
{
    public partial class CRUDDedicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar_dedicacion();
            }

        }
        public void Listar_dedicacion()
        {
            clsCRUCDedicacion cls = new clsCRUCDedicacion();
            GridViewListar_Dedicacion.DataSource =cls.listarDedicacion() ;
            GridViewListar_Dedicacion.DataBind();

        }

     
        protected void btnAgregarDedi_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDesc_Dedicacion.Text.Trim();
                string estado = DropDownListEstado.SelectedValue.ToString();
                
                clsCRUCDedicacion cl = new clsCRUCDedicacion();
                if (descripcion != "")
                {
                    cl.insert_dedicacion(descripcion,estado);

                    txtDesc_Dedicacion.Text = "";
                    Listar_dedicacion();
                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

       
        protected void GridViewListar_Dedicacion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewListar_Dedicacion.EditIndex = e.NewEditIndex;
            this.Listar_dedicacion();
        }

        protected void GridViewListar_Dedicacion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow r = GridViewListar_Dedicacion.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox descripcion = (r.FindControl("txtDescripcion") as TextBox);

            string _codi = Convert.ToString(codi.Text).ToString();
            int nuevoCodi = int.Parse(_codi);
            string _descripcion = Convert.ToString(descripcion.Text);


            clsCRUCDedicacion c = new clsCRUCDedicacion();
            c.update_Dedicacion(_descripcion, nuevoCodi);

            GridViewListar_Dedicacion.EditIndex = -1;
            this.Listar_dedicacion();
            
        }

        protected void GridViewListar_Dedicacion_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewListar_Dedicacion.EditIndex = -1;
            this.Listar_dedicacion();
        }

        protected void GridViewListar_Dedicacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow r = GridViewListar_Dedicacion.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            Label estado = (r.FindControl("lblestado") as Label);

            if (Convert.ToString(estado.Text).ToString() == "Administrativo")
            {
                clsCRUCDedicacion cl = new clsCRUCDedicacion();
                cl.update_Dedicacion_estado(2, Convert.ToInt32(codi.Text));
            }
            else if (Convert.ToString(estado.Text).ToString() == "Docente")
            {
                clsCRUCDedicacion cl = new clsCRUCDedicacion();
                cl.update_Dedicacion_estado(1, Convert.ToInt32(codi.Text));
            }

            GridViewListar_Dedicacion.EditIndex = -1;
            this.Listar_dedicacion();
        }
    }
}