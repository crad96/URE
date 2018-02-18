using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaUre.cls;
using System.Data.SqlClient;

namespace SistemaUre.URE.Mantenimiento
{
    public partial class ActualizarDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenardepartamento();
                llenardto();
                llenararea();
                llenarcargo();
                llenarcategoria();
                llenardedicacion();
            }
        }


        protected void btn_BuscarPo_Click(object sender, EventArgs e)
        {
            clsPonencias cls = new clsPonencias();
            clsCrudDocente clsd = new clsCrudDocente();
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

                
                    clsConec cnn = new clsConec();
                    SqlCommand cmd = new SqlCommand("exec v_persona '" + DNI + "'", cnn.loadConeccion());
                    SqlDataReader datos = cmd.ExecuteReader();
                    



                    //txtNombresCom.Text = cls.ObtenerNombresCompletos(DNI);
                    if (datos.Read())
                    {
                        lblMensaje.Text = "El Personal está registrado!";

                        txtAPa.Text = (datos)["ape_paterno"].ToString();
                        txtAMa.Text = (datos)["ape_materno"].ToString();
                        txtNom.Text = (datos)["nomb_persona"].ToString();
                        txtDNIdocente.Text = (datos)["dni_persona"].ToString();
                        ddlsexo.SelectedValue = (datos)["sexo"].ToString();
                        txtFech_nac.Text = (datos)["fecha_nacimiento"].ToString();
                        dptnac.SelectedValue = (datos)["codi_departamento"].ToString();
                        
                        llenarprov(Convert.ToInt32(dptnac.SelectedValue));
                        provnac.SelectedValue = (datos)["codi_provincia"].ToString();

                        llenardistrito(Convert.ToInt32(provnac.SelectedValue));
                        disnac.SelectedValue = (datos)["codi_distrito"].ToString();

                        txtdomincilio.Text = (datos)["desc_domicilio"].ToString();

                        string tenen = (datos)["tenencia"].ToString();

                        if (tenen == "alquilado")
                        {
                            alquilado.Checked = true;
                        }
                        else if (tenen == "propio")
                        {
                            propio.Checked = true;
                        }

                        deptolu.SelectedValue = (datos)["domicilio departamento"].ToString();

                        llenarprovi(Convert.ToInt32(deptolu.SelectedValue));
                        provlu.SelectedValue = (datos)["domicilio provincia"].ToString();

                        llenardist(Convert.ToInt32(provlu.SelectedValue));
                        distlu.SelectedValue = (datos)["distrito domicilio"].ToString();
                        
                        string vive = (datos)["vive_en"].ToString();

                        if (vive == "residencial")
                        {
                            residencial.Checked = true;
                        }
                        else if (vive == "urbanizacion")
                        {
                            urbanizacion.Checked = true;
                        }
                        else if (vive == "pjoven")
                        {
                            pjoven.Checked = true;
                        }

                        if (vive == "otro")
                        {
                            otro.Checked = true;
                        }

                        txt_fecha.Text = (datos)["fecha_ingreso"].ToString();
                        ddlareatrabajo.SelectedValue = (datos)["codi_area"].ToString();
                        ddlcargo.SelectedValue = (datos)["codi_cargo"].ToString();
                        ddlnivel.SelectedValue = (datos)["codi_nivel"].ToString();
                        ddlcategoria.SelectedValue = (datos)["codi_categoria"].ToString();
                        ddldedicacion.SelectedValue = (datos)["codi_dedicacion"].ToString();
                        txtNaciona.Text = (datos)["nacionalidad"].ToString();
                        txtTel.Text = (datos)["telefono"].ToString();
                        ddlestadocivil.SelectedValue = (datos)["estado_civil"].ToString();
                        txtSeguro.Text = (datos)["carnet_seguro"].ToString();
                        txtGSangui.Text = (datos)["grupo_sanguineo"].ToString();
                        txtCelular.Text = (datos)["celular"].ToString();
                        txtCorreo.Text = (datos)["correo"].ToString();
                        txtCodTra.Text = (datos)["codi_trabajo"].ToString();
                        txtCodPla.Text = (datos)["codi_plaza"].ToString();
                        txtCodLe.Text = (datos)["codi_legajo"].ToString();

                    }
              
              
            }


        }



        private void llenararea()
        {
            clsCrudDocente cls = new clsCrudDocente();
            ddlareatrabajo.DataSource = cls.llenarDDLarea();
            ddlareatrabajo.DataTextField = "descripcion";
            ddlareatrabajo.DataValueField = "codigo";
            ddlareatrabajo.DataBind();
        }
        private void llenarcargo()
        {
            clsCrudDocente cls = new clsCrudDocente();
            ddlcargo.DataSource = cls.llenarDDLcargo();
            ddlcargo.DataTextField = "descripcion";
            ddlcargo.DataValueField = "codigo";
            ddlcargo.DataBind();
        }

        private void llenarcategoria()
        {
            clsCrudDocente cls = new clsCrudDocente();
            ddlcategoria.DataSource = cls.llenarDDLcategoria();
            ddlcategoria.DataTextField = "descripcion";
            ddlcategoria.DataValueField = "codigo";
            ddlcategoria.DataBind();
        }

        private void llenardedicacion()
        {
            clsCrudDocente cls = new clsCrudDocente();
            ddldedicacion.DataSource = cls.llenarDDLdedicacion();
            ddldedicacion.DataTextField = "descripcion";
            ddldedicacion.DataValueField = "codigo";
            ddldedicacion.DataBind();
        }



        private void llenardepartamento()
        {
            clsCrudDocente cls = new clsCrudDocente();
            dptnac.DataSource = cls.llenarDDLdepartamento();
            dptnac.DataTextField = "desc_departamento";
            dptnac.DataValueField = "codi_departamento";
            dptnac.DataBind();
            if (dptnac.Items.Count != 0)
            {
                int depId = Convert.ToInt32(dptnac.SelectedValue);
                llenarprov(depId);
            }
            else
            {
                provnac.Items.Clear();
                disnac.Items.Clear();
            }
        }

        private void llenarprov(int depId)
        {
            clsCrudDocente cls = new clsCrudDocente();
            provnac.DataSource = cls.llenarDDLprovincia(depId);
            provnac.DataTextField = "desc_provincia";
            provnac.DataValueField = "codi_provincia";
            provnac.DataBind();
            if (provnac.Items.Count != 0)
            {
                int provId = Convert.ToInt32(provnac.SelectedValue);

                llenardistrito(provId);
            }
            else
            {
                disnac.Items.Clear();
            }
        }
        private void llenardistrito(int provId)
        {
            clsCrudDocente cls = new clsCrudDocente();
            disnac.DataSource = cls.llenarDDLdistrito(provId);
            disnac.DataTextField = "desc_distrito";
            disnac.DataValueField = "codi_distrito";
            disnac.DataBind();
            if (disnac.Items.Count != 0)
            {
                int disId = Convert.ToInt32(disnac.SelectedValue);
            }
        }

        private void llenardto()
        {
            clsCrudDocente cls = new clsCrudDocente();
            deptolu.DataSource = cls.llenarDDLdepartamento();
            deptolu.DataTextField = "desc_departamento";
            deptolu.DataValueField = "codi_departamento";
            deptolu.DataBind();
            if (deptolu.Items.Count != 0)
            {
                int depId = Convert.ToInt32(deptolu.SelectedValue);
                llenarprovi(depId);
            }
            else
            {
                provlu.Items.Clear();
                provlu.Items.Clear();
            }
        }

        private void llenarprovi(int depId)
        {
            clsCrudDocente cls = new clsCrudDocente();
            provlu.DataSource = cls.llenarDDLprovincia(depId);
            provlu.DataTextField = "desc_provincia";
            provlu.DataValueField = "codi_provincia";
            provlu.DataBind();
            if (provlu.Items.Count != 0)
            {
                int provId = Convert.ToInt32(provlu.SelectedValue);
                llenardist(provId);
            }
            else
            {
                distlu.Items.Clear();
            }
        }
        private void llenardist(int provId)
        {
            clsCrudDocente cls = new clsCrudDocente();
            distlu.DataSource = cls.llenarDDLdistrito(provId);
            distlu.DataTextField = "desc_distrito";
            distlu.DataValueField = "codi_distrito";
            distlu.DataBind();
            if (distlu.Items.Count != 0)
            {
                int TrackId = Convert.ToInt32(distlu.SelectedValue);
            }
        }


        protected void dptnac_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dep = Convert.ToInt32(dptnac.SelectedValue);
            provnac.Items.Clear();
            llenarprov(dep);
        }

        protected void provnac_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prov = Convert.ToInt32(provnac.SelectedValue);
            disnac.Items.Clear();
            llenardistrito(prov);
        }

        protected void deptolu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dep = Convert.ToInt32(deptolu.SelectedValue);
            provlu.Items.Clear();
            llenarprovi(dep);
        }

        protected void provlu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int prov = Convert.ToInt32(provlu.SelectedValue);
            distlu.Items.Clear();
            llenardist(prov);
        }

        private void limpiarcontoles()
        {
            txtAPa.Text = string.Empty;
            txtAMa.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtDNIdocente.Text = string.Empty;
            ddlsexo.SelectedIndex = 0;
            txtFech_nac.Text = string.Empty;
            dptnac.SelectedIndex = 0;
            provnac.Items.Clear();
            disnac.Items.Clear();
            txtdomincilio.Text = string.Empty;
            alquilado.Checked = false;
            propio.Checked = false;
            deptolu.SelectedIndex = 0;
            provlu.Items.Clear();
            distlu.Items.Clear();
            residencial.Checked = false;
            urbanizacion.Checked = false;
            pjoven.Checked = false;
            otro.Checked = false;
            txt_fecha.Text = string.Empty;
            ddlareatrabajo.SelectedIndex = 0;
            ddlcargo.SelectedIndex = 0;
            ddlnivel.SelectedIndex = 0;
            ddlcategoria.SelectedIndex = 0;
            ddldedicacion.SelectedIndex = 0;
            txtNaciona.Text = string.Empty;
            txtTel.Text = string.Empty;
            ddlestadocivil.Items.Clear();
            txtSeguro.Text = string.Empty;
            txtGSangui.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCodTra.Text = string.Empty;
            txtCodPla.Text = string.Empty;
            txtCodLe.Text = string.Empty;
        }

     

        protected void btncancelar_docente_Click(object sender, EventArgs e)
        {
            limpiarcontoles();
        }

        protected void btnactualizar_docente_Click(object sender, EventArgs e)
        {
            string apepaterno = txtAPa.Text.Trim();
            string apematerno = txtAMa.Text.Trim();
            string nombre = txtNom.Text.Trim();
            string dni = txtDNIdocente.Text.Trim();
            string sexo = ddlsexo.SelectedValue;
            DateTime fecnac = Convert.ToDateTime(txtFech_nac.Text.Trim());
            int dtonac = Convert.ToInt32(dptnac.SelectedValue);
            int pronac = Convert.ToInt32(provnac.SelectedValue);
            int distnac = Convert.ToInt32(disnac.SelectedValue);
            string domici = txtdomincilio.Text.Trim();
            string tenencia = "";
            if (alquilado.Checked)
            {
                tenencia = alquilado.Text;
            }
            else if (propio.Checked)
            {
                tenencia = propio.Text;
            }
            int deptodom = Convert.ToInt32(deptolu.SelectedValue);
            int providom = Convert.ToInt32(provlu.SelectedValue);
            int disdom = Convert.ToInt32(distlu.SelectedValue);

            string vive = "";
            if (residencial.Checked)
            {
                vive = residencial.Text.Trim();
            }
            else if (urbanizacion.Checked)
            {
                vive = urbanizacion.Text.Trim();
            }
            else if (pjoven.Checked)
            {
                vive = pjoven.Text.Trim();
            }
            else if (otro.Checked)
            {
                vive = otro.Text.Trim();
            }

            DateTime fechaingreso = Convert.ToDateTime(txt_fecha.Text.Trim());
            int area = Convert.ToInt32(ddlareatrabajo.SelectedValue);
            int cargo = Convert.ToInt32(ddlcargo.SelectedValue);
            int gnivel = Convert.ToInt32(ddlnivel.SelectedValue);
            int categoria = Convert.ToInt32(ddlcategoria.SelectedValue);
            int dedicacion = Convert.ToInt32(ddldedicacion.SelectedValue);
            string nacionalidad = txtNaciona.Text.Trim();
            string telefono = txtTel.Text.Trim();
            string estadocivil = ddlestadocivil.SelectedValue;
            string carneseguro = txtSeguro.Text.Trim();
            string grsanguin = txtGSangui.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string codtrabajo = txtCodTra.Text.Trim();
            string codplaza = txtCodPla.Text.Trim();
            string codlegajo = txtCodLe.Text.Trim();
            string foto = "";

            clsCrudDocente cls = new clsCrudDocente();
            cls.update_docente(dtonac, pronac, distnac, domici, tenencia, vive, deptodom, providom, disdom,
                dni, apepaterno, apematerno, sexo, nombre, correo, carneseguro, grsanguin, fechaingreso, area, cargo,
                fecnac, nacionalidad, telefono, celular, estadocivil, codtrabajo, codplaza,
                codlegajo, 1, foto, 1, categoria, dedicacion, gnivel);
            limpiarcontoles();
        }

    }
}