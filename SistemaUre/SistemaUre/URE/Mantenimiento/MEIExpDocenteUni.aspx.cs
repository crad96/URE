using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIExpDocenteUni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_uni();
            }

        }

        private void cargar_uni()
        {
            clsExperienciaDocente cls = new clsExperienciaDocente();
            Combouni.DataSource = cls.Listar_univer_combo();
            Combouni.DataTextField = "universidad";
            Combouni.DataValueField = "codigo";
            Combouni.DataBind();
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsExperienciaDocente cls = new clsExperienciaDocente();
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
                listar_experienciaDoc(DNI);
            }
        }

        private void listar_experienciaDoc(string DNI)
        {
            clsExperienciaDocente cl = new clsExperienciaDocente();
            GridExperienciaDoc.DataSource = cl.listar_experienciaDoc(DNI);
            GridExperienciaDoc.DataBind();
        }

        protected void btnIngresar_Especializacion_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
      
                string universidad = Combouni.SelectedItem.ToString();
                string desc_actividad = txtactividad.Text.ToString();
                string fec = txtFechaDes.Text.Trim();
                DateTime fecha_desde = Convert.ToDateTime(fec);
                string fec1 = txtFechaHas.Text.Trim();
                DateTime fecha_hasta = Convert.ToDateTime(fec1);    
                string dni_persona = txtdniPe.Text.Trim();
                clsExperienciaDocente cl = new clsExperienciaDocente();
                if (desc_actividad != "")
                {
                    cl.insert_experienciaDoce(universidad,desc_actividad,fecha_desde ,fecha_hasta, dni_persona);

                    txtactividad.Text = "";
                    txtFechaDes.Text = "";
                    txtFechaHas.Text = "";
                    listar_experienciaDoc(DNI);


                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        protected void GridExperienciaDoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridExperienciaDoc.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsExperienciaDocente cl = new clsExperienciaDocente();
            cl.delete_experienciaDoc(Convert.ToInt32(codi.Text));

            GridExperienciaDoc.EditIndex = -1;
            this.listar_experienciaDoc(DNI);
        }


    }
}