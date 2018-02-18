using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIExProfesional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsExpProfesional cls = new clsExpProfesional();
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
                listar_expProf(DNI);
            }
        }

        public void listar_expProf(string DNI)
        {
            clsExpProfesional cl = new clsExpProfesional();
            GridExpProfesional.DataSource = cl.listar_expProf(DNI);
            GridExpProfesional.DataBind();

        }
        protected void btnIngresar_expProf_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string empresa_entidad = txtEntidad.Text.Trim();
                string cargo_desempeñado = txtCargo.Text.Trim();
                string lug_experiencia = txtLugar.Text.Trim();

                string fechaExPIn = txtFech_de.Text.Trim();
                DateTime fecha_inicio = Convert.ToDateTime(fechaExPIn);

                string fechaExPFi = txtFech_has.Text.Trim();
                DateTime fecha_fin = Convert.ToDateTime(fechaExPFi);
               

                string dni_persona = txtdniPe.Text.Trim();

                clsExpProfesional cl = new clsExpProfesional();

                if (empresa_entidad != "")
                {
                    cl.insert_expProf(empresa_entidad, cargo_desempeñado, lug_experiencia, fecha_inicio, fecha_fin, dni_persona);
                    txtEntidad.Text = "";
                    txtCargo.Text = "";
                    txtLugar.Text = "";
                    txtFech_de.Text = "";
                    txtFech_has.Text = "";


                    listar_expProf(DNI);

                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {

            }
        }

        protected void GridExpProfesional_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridExpProfesional.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsExpProfesional cl = new clsExpProfesional();
            cl.delete_expProf(Convert.ToInt32(codi.Text));

            GridExpProfesional.EditIndex = -1;
            this.listar_expProf(DNI);
        }

       
    }
}