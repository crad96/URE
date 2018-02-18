using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;
using System.Data;

namespace SistemaUre.URE.CRUD
{
    public partial class CRUDFacultad_Escuela : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (!Page.IsPostBack)
            {
                this.cargar_facu();
                this.listarFacultad();
                this.listarEscuela();

            }
         
        }

        public void cargar_facu ()
        {
            clsCRUDFacu_Escue cls = new clsCRUDFacu_Escue();
            DataTable dt = cls.Listar_Facultad_combo();
            ComboBoxFacultad.DataSource = dt;
            ComboBoxFacultad.DataMember = "codigo";
            ComboBoxFacultad.DataTextField = "descripcion";
            ComboBoxFacultad.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string desc_escuela = txtEscuela.Text.ToString().Trim();
            
            string desc_facultad = ComboBoxFacultad.SelectedItem.ToString();
            

            clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
            cl.insert_Escuela(desc_escuela,desc_facultad);


            listarEscuela();


            
        }



        protected void btnAgregarFacu_Click(object sender, EventArgs e)
        {
            string desc_facu = txtDesc_Facultad.Text.Trim();
            clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
            cl.insert_Facultad(desc_facu);
            txtDesc_Facultad.Text = "";
            cargar_facu();
            this.listarFacultad();
        }



        protected void btnFacultad_Click(object sender, EventArgs e)
        {
            cargar_facu();
            PanelEscuela.Visible = true;
       
        }

        public void listarFacultad()
        {
            clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
            GridViewListar_Facultad.DataSource = cl.Listar_Facultad();
            GridViewListar_Facultad.DataBind();
        }

        public void listarEscuela()
        {
            clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
            GridViewListar_Escuela.DataSource = cl.listar_Escuela();
            GridViewListar_Escuela.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            listarFacultad();
            this.cargar_facu();
            Panel_Facultad_vista.Visible = true;
   
        }


        protected void btnActua_Click(object sender, EventArgs e)
        {
            string s;
        }

        protected void btnOpcion_Click(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow rows in GridViewListar_Facultad.Rows)
            {
                    string codi_detalle = rows.Cells[1].Text;
                    clsCRUDFacu_Escue r = new clsCRUDFacu_Escue();
             
            }
        }

        protected void GridViewListar_Facultad_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewListar_Facultad.EditIndex = -1;
            this.listarFacultad();
        }


        protected void GridViewListar_Facultad_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewListar_Facultad.EditIndex = e.NewEditIndex;
            this.listarFacultad();
        }

        protected void GridViewListar_Facultad_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow r = GridViewListar_Facultad.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox descripcion = (r.FindControl("txtDescripcion") as TextBox);

            string _codi = Convert.ToString(codi.Text).ToString();
            int nuevoCodi = int.Parse(_codi);
            string _descripcion = Convert.ToString(descripcion.Text);


            clsCRUDFacu_Escue c = new clsCRUDFacu_Escue();
            c.update_Facultad(_descripcion, nuevoCodi);

            GridViewListar_Facultad.EditIndex = -1;
            this.listarFacultad();
            this.cargar_facu();
        }

        protected void btnUpdate_Escuela_Click(object sender, EventArgs e)
        {
            listarEscuela();
            Panel_Facultad_vista.Visible = false;
            
        }

        protected void GridViewListar_Escuela_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewListar_Escuela.EditIndex = e.NewEditIndex;
            listarEscuela();
        }

        protected void GridViewListar_Escuela_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewListar_Escuela.EditIndex = -1;
            this.listarEscuela();
        }

        protected void GridViewListar_Escuela_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow r = GridViewListar_Escuela.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            TextBox descripcion_escuela = (r.FindControl("txtDescripcion") as TextBox);

            string _codi = Convert.ToString(codi.Text).ToString();
            int nuevoCodi = int.Parse(_codi);
            string _descripcion = Convert.ToString(descripcion_escuela.Text);


            clsCRUDFacu_Escue c = new clsCRUDFacu_Escue();
            c.update_Escuela(_descripcion, nuevoCodi);

            GridViewListar_Escuela.EditIndex = -1;
            this.listarEscuela();
        }

        protected void GridViewListar_Escuela_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow r = GridViewListar_Escuela.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            Label estado = (r.FindControl("lblestado") as Label);

            if (Convert.ToString(estado.Text).ToString() == "Activo")
            {
                clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
                cl.update_Escuela_estado(2, Convert.ToInt32(codi.Text));
            }
            else if (Convert.ToString(estado.Text).ToString() == "Inactivo")
            {
                clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
                cl.update_Escuela_estado(1, Convert.ToInt32(codi.Text));
            }

            GridViewListar_Escuela.EditIndex = -1;
            this.listarEscuela();
        }

        protected void GridViewListar_Facultad_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            GridViewRow r = GridViewListar_Facultad.Rows[e.RowIndex];
            Label codi = (r.FindControl("lblcodigo") as Label);
            Label estado = (r.FindControl("lblestado") as Label);


            if (Convert.ToString(estado.Text).ToString() == "Activo")
            {
                clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
                cl.update_Facultad_estado(2, Convert.ToInt32(codi.Text));
            }
            else if (Convert.ToString(estado.Text).ToString() == "Inactivo")
            {
                clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
                cl.update_Facultad_estado(1, Convert.ToInt32(codi.Text));
            }

            GridViewListar_Facultad.EditIndex = -1;
            this.listarFacultad();
            this.cargar_facu();


            //GridViewRow r = GridViewListar_Facultad.Rows[e.RowIndex];
            //Label codi = (r.FindControl("lblcodigo") as Label);

            //clsCRUDFacu_Escue cl = new clsCRUDFacu_Escue();
            //cl.delete_Facultad(Convert.ToInt32(codi.Text));
            //listarFacultad();
            //cargar_facu();


        }

 






     }
}