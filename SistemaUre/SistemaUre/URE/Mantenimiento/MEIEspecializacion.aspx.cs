using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIEspecializacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_uni();
            }

        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsEspecializacion cls = new clsEspecializacion();
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
                listar_especializacion(DNI);
            }
        }

        private void listar_especializacion(string DNI)
        {
            clsEspecializacion cl = new clsEspecializacion();
            GridEspecializacion.DataSource = cl.listar_especializacion(DNI);
            GridEspecializacion.DataBind();
        }

        public void cargar_uni()
        {
            clsEspecializacion cls = new clsEspecializacion();
            Combouni.DataSource = cls.Listar_univer_combo();        
            Combouni.DataTextField = "universidad";
            Combouni.DataValueField = "codigo";
            Combouni.DataBind();
            
        }

        protected void btnIngresar_Especializacion_Click(object sender, EventArgs e)
        {

            try
            {
            string DNI = txtdniPe.Text;

            string Especializacion = txtEspecia.Text.ToString().Trim();
            string universidad = Combouni.SelectedItem.ToString();
            string fecha = txtfecha.Text.ToString().Trim();
            string dni_persona = txtdniPe.Text.Trim();
            clsEspecializacion cl = new clsEspecializacion();
            if (Especializacion != "")
            {
                cl.insert_especializacion(Especializacion, universidad, fecha, dni_persona);

                txtEspecia.Text = "";               
                txtfecha.Text = "";
                listar_especializacion(DNI);


            }
            else { }

            }
            catch (Exception)
            {

                throw;
            }
           


         
        }

        protected void GridEspecializacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridEspecializacion.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsEspecializacion cl = new clsEspecializacion();
           cl.delete_especializacion(Convert.ToInt32(codi.Text));

            GridEspecializacion.EditIndex = -1;
            this.listar_especializacion(DNI);

        }
    }
}