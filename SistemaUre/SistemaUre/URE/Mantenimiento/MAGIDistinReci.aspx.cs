using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MAGIDistinReci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void GridAdmiDisReci_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridAdmiDisReci.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsAdminDistin cl = new clsAdminDistin();
            cl.delete_distincionReci(Convert.ToInt32(codi.Text));

            GridAdmiDisReci.EditIndex = -1;
            this.listar_distincionReci(DNI);
        }

        protected void btnIngresar_DistinReci_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string entidad = txtdistincion.Text.Trim();
                string distincion = txtdistincion.Text.Trim();
                string fec = txtFecha.Text.Trim();
                DateTime fecha = Convert.ToDateTime(fec);

                string dni_persona = txtdniPe.Text.Trim();
                clsAdminDistin cl = new clsAdminDistin();
                if (entidad != "")
                {
                    cl.insert_distincion_Reci(entidad, distincion, fecha, dni_persona);

                    txtentidad.Text = "";
                    txtdistincion.Text = "";
                    txtFecha.Text = "";

                    listar_distincionReci(DNI);

                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void listar_distincionReci(string DNI)
        {
            clsAdminDistin cl = new clsAdminDistin();
            GridAdmiDisReci.DataSource = cl.listar_distincionReci(DNI);
            GridAdmiDisReci.DataBind();
        }


        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsAdminDistin cls = new clsAdminDistin();
            string DNI = txtdniPe.Text;

            if (DNI == "")
            {
                lblMensaje.Text = "Error! Debe ingresar DNI";
                txtdniPe.Focus();
                return;
            }

            if (cls.existeDatos(DNI) == false)
            {
                lblMensaje.Text = "El Personal, No existe!";
                txtdniPe.Focus();
                return;
            }
            else
            {
                txtNombresCom.Text = cls.ObtenerNombresCompletos(DNI);
                lblMensaje.Text = "El Personal está registrado!";
                listar_distincionReci(DNI);
            }
        }
    }
}