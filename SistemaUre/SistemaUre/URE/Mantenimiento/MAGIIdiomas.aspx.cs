using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MAGIIdiomas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void GridIdioAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridIdioAdmin.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsIdiomas cl = new clsIdiomas();
            cl.delete_idiomas(Convert.ToInt32(codi.Text));

            GridIdioAdmin.EditIndex = -1;
            this.listar_idiomas(DNI);
        }

        protected void btnIngresar_AdmiIdiomas_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string desc_idioma =ComIdioma.Text.Trim();
                string habla = ComHabla.Text.Trim();
                string lee = ComLee.Text.Trim();
                string escribe = ComEscribe.Text.Trim();
                string lugar = txtLugar.Text.Trim();
                string dni_persona = txtdniPe.Text.Trim();
                clsIdiomas cl = new clsIdiomas();
                if (desc_idioma != "")
                {
                    cl.insert_idiomas(desc_idioma, habla, lee, escribe, lugar,dni_persona);

                    ComIdioma.Text = "";
                    ComHabla.Text = "";
                    ComLee.Text = "";
                    ComEscribe.Text = "";
                    txtLugar.Text = "";
                    listar_idiomas(DNI);

                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }

        }


        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsIdiomas cls = new clsIdiomas();
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
                listar_idiomas(DNI);
            }
        }

        private void listar_idiomas(string DNI)
        {
            clsIdiomas cl = new clsIdiomas();
            GridIdioAdmin.DataSource = cl.listar_idiomas(DNI);
            GridIdioAdmin.DataBind();

        }



    }
}