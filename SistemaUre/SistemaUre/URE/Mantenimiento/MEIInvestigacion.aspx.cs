using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIInvestigacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsInvestigaciones cls = new clsInvestigaciones();
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
                listar_investigacion(DNI);
            }

        }

        public void listar_investigacion(string DNI)
        {
            clsInvestigaciones cl = new clsInvestigaciones();
            GridInvest.DataSource = cl.listar_investigacion(DNI);
            GridInvest.DataBind();

        }  

        protected void btnIngresar_Investigacion_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string titulo = txtTitulo.Text.Trim();
                string entidad = txtEntidad.Text.Trim();

                string añoInves = txtao.Text.Trim();
                int año = Convert.ToInt32(añoInves);

                string dni_persona = txtdniPe.Text.Trim();
                clsInvestigaciones cl = new clsInvestigaciones();

                if (titulo != "")
                {
                    cl.insert_investigacion(titulo, entidad, año,dni_persona);

                    txtTitulo.Text = "";
                    txtEntidad.Text = "";
                    txtao.Text = "";                

                    listar_investigacion(DNI);

                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {

            }
        }

    

        protected void GridInvest_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridInvest.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsInvestigaciones cl = new clsInvestigaciones();
            cl.delete_investigacion(Convert.ToInt32(codi.Text));

            GridInvest.EditIndex = -1;
            this.listar_investigacion(DNI);
        }
    }
}