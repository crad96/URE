using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEICursosDiplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsCursoDiploma cls = new clsCursoDiploma();
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
                listar_cursosDiplo(DNI);
            }


        }

        public void listar_cursosDiplo(string DNI)
        {
            clsCursoDiploma cl = new clsCursoDiploma();
            GridCursosDiplo.DataSource = cl.listar_cursosDiplo(DNI);
            GridCursosDiplo.DataBind();

        }      
    

        protected void btnIngresar_cursosDplo_Click(object sender, EventArgs e)
        {
            try
            {
                string DNI = txtdniPe.Text;
                string institucion_organizado = txtInst.Text.Trim();
                string nombre_curso = txtCurs.Text.Trim();

                string fechaCur = txtFech_ob.Text.Trim();
                DateTime fecha_obtencion = Convert.ToDateTime(fechaCur);


                string n_horasNuevo = txthoras.Text.Trim();
                int n_horas = Convert.ToInt32(n_horasNuevo);
           

                string dni_persona = txtdniPe.Text.Trim();

                clsCursoDiploma cl = new clsCursoDiploma();

                if (institucion_organizado != "")
                {
                    cl.insert_cursosDiplo(institucion_organizado, nombre_curso, fecha_obtencion, n_horas, dni_persona);
                    txtInst.Text = "";
                    txtCurs.Text = "";
                    txtFech_ob.Text = "";
                    txthoras.Text = "";                    
                    

                    listar_cursosDiplo(DNI);

                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {

            }
        }
       

        protected void GridCursosDiplo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridCursosDiplo.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsCursoDiploma cl = new clsCursoDiploma();
            cl.delete_cursosDiplo(Convert.ToInt32(codi.Text));

            GridCursosDiplo.EditIndex = -1;
            this.listar_cursosDiplo(DNI);
        }

       
    }
}