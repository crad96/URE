using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIDistinciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }

        }

        protected void btnIngresar_Especializacion_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string entidad = txtdistincion.Text.Trim();
                string distincion = txtdistincion.Text.Trim();
                string fec = txtFecha.Text.Trim();
                DateTime fecha = Convert.ToDateTime(fec);
               
                string dni_persona = txtdniPe.Text.Trim();
                clsDistinciones cl = new clsDistinciones();
                if (entidad != "")
                {
                    cl.insert_distincion_Reci(entidad, distincion,fecha, dni_persona);

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
            clsDistinciones cl = new clsDistinciones();
            GridDistincion_Reci.DataSource = cl.listar_distincionReci(DNI);
            GridDistincion_Reci.DataBind();
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsDistinciones cls = new clsDistinciones();
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

        protected void GridDistincion_Reci_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridDistincion_Reci.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsDistinciones cl = new clsDistinciones();
            cl.delete_distincionReci(Convert.ToInt32(codi.Text));

            GridDistincion_Reci.EditIndex = -1;
            this.listar_distincionReci(DNI);
        }



    }
}