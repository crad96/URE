using SistemaUre.cls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaUre.URE.Mantenimiento
{
    public partial class MDemeritos : System.Web.UI.Page
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
                listar_Desmeritos(DNI);
            }
        }

        private void listar_Desmeritos(string DNI)
        {
            clsResoluciones cl = new clsResoluciones();
            GridDemeritos.DataSource = cl.listar_Desmeritos(DNI);
            GridDemeritos.DataBind();
        }

        protected void btnIngresar_MDesmerito_Click(object sender, EventArgs e)
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



                
                
                string nombreArchivo = imaXD.FileName;
                string foto = "../../Files/Resolucion/" + nombreArchivo;
                imaXD.SaveAs(Server.MapPath(foto));


                clsResoluciones cl = new clsResoluciones();
                if (num_resolucion != ""){
                   
                    cl.insert_Desmeritos(dni_persona,num_resolucion,Descripcion,fecha_registro,fecha_resol,foto,13);

                    txtDescrip.Text = "";
                    txtfecha_registro.Text = "";
                    txtfecha_resolucion.Text = "";
                    txtNumReso.Text = "";
                    listar_Desmeritos(DNI);

                }
                else { }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridDemeritos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridDemeritos.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            clsResoluciones cl = new clsResoluciones();
            cl.delete_resoluciones(Convert.ToInt32(codi.Text));

            GridDemeritos.EditIndex = -1;
            this.listar_Desmeritos(DNI);
        }

        protected void GridDemeritos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridViewRow r = GridDemeritos.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox num_resolucion = (r.FindControl("txtNumReso") as TextBox);
            TextBox Descripcion = (r.FindControl("txtDescrip") as TextBox);
            TextBox fecha_registro = (r.FindControl("txtfecha_registro") as TextBox);
            TextBox fecha_resol = (r.FindControl("txtfecha_resolucion") as TextBox);


            //string _codi = Convert.ToString(codi.Text).ToString();
            //int nuevoCodi = int.Parse(_codi);

            int nuevoCodi = Convert.ToInt32(codi.Text);
            string _numRe = Convert.ToString(num_resolucion.Text);
            string _descripcion = Convert.ToString(Descripcion.Text);
            string _feReg = Convert.ToString(fecha_registro.Text).ToString();
            DateTime nueFecReg = DateTime.Parse(_feReg);
            string _feRes = Convert.ToString(fecha_resol.Text).ToString();
            DateTime nueFecRes = DateTime.Parse(_feRes);

            clsResoluciones c = new clsResoluciones();


            c.update_Desmeritos(nuevoCodi, _numRe, _descripcion, nueFecReg, nueFecRes);
            GridDemeritos.EditIndex = -1;
            this.listar_Desmeritos(DNI);
        }

        protected void GridDemeritos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridDemeritos.EditIndex = e.NewEditIndex;
            this.listar_Desmeritos(DNI);
        }

        protected void GridDemeritos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            string DNI = txtdniPe.Text;
            GridDemeritos.EditIndex = -1;
            this.listar_Desmeritos(DNI);
        }

      
    }
}