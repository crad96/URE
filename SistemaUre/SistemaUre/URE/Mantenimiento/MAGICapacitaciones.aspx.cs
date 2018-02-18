using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MAGICapacitaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

 
        public void listar_capacAdmin(string DNI)
        {
            clsAdminCapacitaciones cl = new clsAdminCapacitaciones();
            GridAdminCapac.DataSource = cl.listar_capacAdmin(DNI);
            GridAdminCapac.DataBind();

        }      
    
  

        protected void GridAdminCapac_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
             string DNI = txtdniPe.Text;
            GridViewRow r = GridAdminCapac.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsAdminCapacitaciones cl = new clsAdminCapacitaciones();
            cl.delete_capacAdmin(Convert.ToInt32(codi.Text));

            GridAdminCapac.EditIndex = -1;
            this.listar_capacAdmin(DNI);
        }
        

        protected void btnIngresar_ACapacitaciones_Click(object sender, EventArgs e)
        {
        try
            {
                string DNI = txtdniPe.Text;
                string institucion = txtIns.Text.Trim();
                string nomb_curs = txtNomCapa.Text.Trim();

                string fechaCur = txtFechOb.Text.Trim();
                DateTime fecha_obtencion = Convert.ToDateTime(fechaCur);


                string n_horasNuevo = txtNHor.Text.Trim();
                int n_hora = Convert.ToInt32(n_horasNuevo);
           

                string dni_persona = txtdniPe.Text.Trim();

                clsAdminCapacitaciones cl = new clsAdminCapacitaciones();

                if (institucion != "")
                {
                    cl.insert_capacAdmin(institucion, nomb_curs, fecha_obtencion, n_hora, dni_persona);
                    txtIns.Text = "";
                    txtNomCapa.Text = "";
                    txtFechOb.Text = "";
                    txtNHor.Text = "";                    
                    

                    listar_capacAdmin(DNI);

                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {

            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsAdminCapacitaciones cls = new clsAdminCapacitaciones();
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
                listar_capacAdmin(DNI);
            }
        }

       
    }
}
