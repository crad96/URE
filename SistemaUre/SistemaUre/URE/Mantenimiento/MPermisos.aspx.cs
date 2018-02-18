using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;


namespace SistemaUre.URE.Mantenimiento
{
    public partial class MPermisos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsResoluciones cls = new clsResoluciones();
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
                listar_permisos(DNI);
            }
        }

        private void listar_permisos(string DNI)
        {
            clsResoluciones cl = new clsResoluciones();
            GridPermisos.DataSource = cl.listar_permisos(DNI);
            GridPermisos.DataBind();
        }

        protected void btnIngresar_MPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string dni_persona = txtdniPe.Text.Trim();
                string num_resolucion = txtNumReso.Text.Trim();
                string Descripcion = txtDescrip.Text.Trim();

                string fec = txtfecha_registro.Text.Trim();
                DateTime fecha_registro = Convert.ToDateTime(fec);

                string fec1 = txtfecha_resolucion.Text.Trim();
                DateTime fecha_resol = Convert.ToDateTime(fec1);

                string nombreArchivo = imgPermisos.FileName;
                string foto = "../../Files/Resolucion/" + nombreArchivo;
                imgPermisos.SaveAs(Server.MapPath(foto));


                clsResoluciones cl = new clsResoluciones();
                if (num_resolucion != "")
                {

                    cl.insert_permisos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol,foto, 6);

                    txtDescrip.Text = "";
                    txtfecha_registro.Text = "";
                    txtfecha_resolucion.Text = "";
                    txtNumReso.Text = "";
                    listar_permisos(DNI);

                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridPermisos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridPermisos.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsResoluciones cl = new clsResoluciones();
            cl.delete_resoluciones(Convert.ToInt32(codi.Text));

            GridPermisos.EditIndex = -1;
            this.listar_permisos(DNI);
        }






    }
}