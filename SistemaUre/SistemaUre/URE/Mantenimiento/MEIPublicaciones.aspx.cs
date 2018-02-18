using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;


namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIPublicaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsPublicacion cls = new clsPublicacion();
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
                listar_publicaciones(DNI);
            }
        }


        public void listar_publicaciones(string DNI)
        {
            clsPublicacion cl = new clsPublicacion();
            GridPublicaciones.DataSource = cl.listar_publicaciones(DNI);
            GridPublicaciones.DataBind();

        }      
    

        protected void GridPublicaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridPublicaciones.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsPublicacion cl = new clsPublicacion();
            cl.delete_publicaciones(Convert.ToInt32(codi.Text));

            GridPublicaciones.EditIndex = -1;
            this.listar_publicaciones(DNI);
        }

        protected void btnIngresar_public_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string titulo_publicacion = txtTitulo.Text.Trim();
                string editorial = txtEditorial.Text.Trim();
                string ciudad = txtCiudad.Text.Trim();

                string fechaPub = txtFech.Text.Trim();
                DateTime fecha = Convert.ToDateTime(fechaPub);

                string indexada = txtIndexad.Text.Trim();
                string dni_persona = txtdniPe.Text.Trim();

                clsPublicacion cl = new clsPublicacion();

                if (titulo_publicacion != "")
                {
                    cl.insert_publicaciones(titulo_publicacion, editorial, ciudad, fecha, indexada, dni_persona);
                    txtTitulo.Text = "";
                    txtEditorial.Text = "";
                    txtCiudad.Text = "";
                    txtFech.Text = "";
                    txtIndexad.Text = "";


                    listar_publicaciones(DNI);

                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {

            }
        }
        





    }
}