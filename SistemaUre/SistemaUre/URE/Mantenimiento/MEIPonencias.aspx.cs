using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class MEIPonencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsPonencias cls=new clsPonencias();
            string DNI = txtdniPe.Text;

            if(DNI=="")
            {
                lblMensaje.Text = "Error! Debe ingresar DNI";
                txtdniPe.Focus();
                return;
            }

            if (cls.existeDatos(DNI)== false)
            {
                lblMensaje.Text = "El Personal, No existe!";
                txtdniPe.Focus();
                return;
            }
            else
            {
                txtNombresCom.Text = cls.ObtenerNombresCompletos(DNI);
                lblMensaje.Text = "El Personal está registrado!";
                listar_ponencias(DNI);
            }

            
        }

        public void listar_ponencias(string DNI)
        {
            clsPonencias cl = new clsPonencias();
            GridPonencias.DataSource = cl.listar_ponencias(DNI);
            GridPonencias.DataBind();

        }      
     
        protected void btnIngresar_Ponencia_Click1(object sender, EventArgs e)
        {
            try
            {
                string DNI= txtdniPe.Text;
                string nombrePonencia = txtNPonencias.Text.Trim();
                string evento = txtEven.Text.Trim();
                string ciudad = txtCiudad.Text.Trim();
                string fechaRe = txtFech_po.Text.Trim();
                DateTime fecha = Convert.ToDateTime(fechaRe);
                string dni_persona = txtdniPe.Text.Trim();
                clsPonencias cl = new clsPonencias();

                if (nombrePonencia != "")
                {
                    cl.insert_ponencias(nombrePonencia, evento, ciudad, fecha, dni_persona);
                    txtNPonencias.Text = "";
                    listar_ponencias(DNI);
             
                }
                else { }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            {
   
            }
       }

        protected void GridPonencias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridPonencias.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox nombrePonencia = (r.FindControl("txtNPonencias") as TextBox);
            TextBox evento = (r.FindControl("txtEven") as TextBox);
            TextBox ciudad = (r.FindControl("txtCiudad") as TextBox);
            TextBox fecha = (r.FindControl("txtFech_po") as TextBox);

            string _codi = Convert.ToString(codi.Text).ToString();
            int nuevoCodi = int.Parse(_codi);
            string _nombrePonencia = Convert.ToString(nombrePonencia.Text);
            string _evento = Convert.ToString(evento.Text);
            string _ciudad = Convert.ToString(ciudad.Text);
            
            string _fecha = Convert.ToString(fecha.Text).ToString();
            DateTime fech = DateTime.Parse(_fecha);
           

            clsPonencias c = new clsPonencias();
            c.update_ponencias(nuevoCodi, _nombrePonencia, _evento, _ciudad, fech);

            GridPonencias.EditIndex = -1;
            this.listar_ponencias(DNI);




        }

        protected void GridPonencias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridPonencias.EditIndex = -1;
            this.listar_ponencias(DNI);
        }

        protected void GridPonencias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridPonencias.EditIndex = e.NewEditIndex;
            this.listar_ponencias(DNI);
        }

        protected void GridPonencias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridPonencias.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);

            clsPonencias cl = new clsPonencias();
            cl.delete_ponencias(Convert.ToInt32(codi.Text));

            GridPonencias.EditIndex = -1;
            this.listar_ponencias(DNI);
        }      
 }
}