using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaUre.cls
{
    public class clsCrudDocente
    {
        private clsConec conec = null;

        public clsCrudDocente(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsCrudDocente()
        {
            conec = new clsConec();
        }

        public DataTable llenarDDLdepartamento()
        {

            string query = "select * from v_Departamento";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;                   
        }

        public DataTable llenarDDLprovincia(int deparid)
        {

            string query = "select * from v_provincia where codi_departamento="+deparid;
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable llenarDDLdistrito(int provinid)
        {

            string query = "select * from v_distrito where codi_provincia=" + provinid;
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable llenarDDLarea()
        {

            string query = "select * from v_area;";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable llenarDDLnivel()
        {

            string query = "select * from v_nivel";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable llenarDDLcargo()
        {

            string query = "select * from V_Cargo" ;
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }
        public DataTable llenarDDLcategoria()
        {

            string query = "select * from V_CATEGORIA";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }
        public DataTable llenarDDLdedicacion()
        {

            string query = "  select * from v_Dedicacion" ;
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public object cmd_insert_docente(int codi_departamento , int codi_provincia , int codi_distrito , 
        string desc_domicilio , string tenencia , string vive_en  , int codi_departamentodom , int codi_provinciadom , 
        int codi_distritodom ,string dni_persona  , string ape_paterno , string ape_materno, string sexo  ,
        string nomb_persona , string  correo , string carnet_seguro ,string grupo_sanguineo , DateTime fecha_ingreso ,
        int area  , int cargo,  DateTime fecha_nacimiento , string nacionalidad , string telefono ,string celular, 
        string estado_civil, string codi_trabajo , string codi_plaza , string codi_legajo ,int estado , string foto , 
        int tipo,int codi_categoria,int codi_dedicacion,int grupo_nivel)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_insert_persona " + codi_departamento + ","+codi_provincia+","
            + codi_distrito + ",'" + desc_domicilio + "','" + tenencia + "','" + vive_en + "'," + codi_departamentodom+","
            + codi_provinciadom + "," + codi_distritodom + ",'" + dni_persona + "','" + ape_paterno + "','"
            + ape_materno + "','" + sexo + "','" + nomb_persona + "','" + correo + "','"+carnet_seguro+"','"
            + grupo_sanguineo + "','" + fecha_ingreso + "'," + area + "," + cargo + ",'" + fecha_nacimiento + "','" 
            + nacionalidad + "','" + telefono + "','" + celular + "','" + estado_civil + "','"+ codi_trabajo + "','" 
            + codi_plaza + "','" + codi_legajo + "',"+ estado + ",'" + foto + "'," + tipo + "," 
            + codi_categoria + "," + codi_dedicacion+  "," +grupo_nivel+ "" , cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool insert_docente(int codi_departamento, int codi_provincia, int codi_distrito,
        string desc_domicilio, string tenencia, string vive_en, int codi_departamentodom, int codi_provinciadom,
        int codi_distritodom, string dni_persona, string ape_paterno, string ape_materno, string sexo,
        string nomb_persona, string correo, string carnet_seguro, string grupo_sanguineo, DateTime fecha_ingreso,
        int area, int cargo, DateTime fecha_nacimiento, string nacionalidad, string telefono, string celular,
        string estado_civil, string codi_trabajo, string codi_plaza, string codi_legajo, int estado, string foto,
        int tipo, int codi_categoria, int codi_dedicacion, int grupo_nivel)
        {
            try
            {
                cmd_insert_docente(codi_departamento ,  codi_provincia ,  codi_distrito , 
         desc_domicilio ,  tenencia ,  vive_en  ,  codi_departamentodom ,  codi_provinciadom , 
         codi_distritodom , dni_persona  ,  ape_paterno ,  ape_materno,  sexo  ,
         nomb_persona ,   correo ,  carnet_seguro , grupo_sanguineo ,  fecha_ingreso ,
         area  ,  cargo,   fecha_nacimiento ,  nacionalidad ,  telefono , celular, 
         estado_civil,  codi_trabajo ,  codi_plaza ,  codi_legajo , estado ,  foto , 
         tipo, codi_categoria, codi_dedicacion, grupo_nivel);
            }
            catch (Exception)
            {
            }
            return true;

        }


        public object cmd_update_docente(int codi_departamento, int codi_provincia, int codi_distrito,
       string desc_domicilio, string tenencia, string vive_en, int codi_departamentodom, int codi_provinciadom,
       int codi_distritodom, string dni_persona, string ape_paterno, string ape_materno, string sexo,
       string nomb_persona, string correo, string carnet_seguro, string grupo_sanguineo, DateTime fecha_ingreso,
       int area, int cargo, DateTime fecha_nacimiento, string nacionalidad, string telefono, string celular,
       string estado_civil, string codi_trabajo, string codi_plaza, string codi_legajo, int estado, string foto,
       int tipo, int codi_categoria, int codi_dedicacion, int grupo_nivel)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_persona " + codi_departamento + "," + codi_provincia + ","
            + codi_distrito + ",'" + desc_domicilio + "','" + tenencia + "','" + vive_en + "'," + codi_departamentodom + ","
            + codi_provinciadom + "," + codi_distritodom + ",'" + dni_persona + "','" + ape_paterno + "','"
            + ape_materno + "','" + sexo + "','" + nomb_persona + "','" + correo + "','" + carnet_seguro + "','"
            + grupo_sanguineo + "','" + fecha_ingreso + "'," + area + "," + cargo + ",'" + fecha_nacimiento + "','"
            + nacionalidad + "','" + telefono + "','" + celular + "','" + estado_civil + "','" + codi_trabajo + "','"
            + codi_plaza + "','" + codi_legajo + "'," + estado + ",'" + foto + "'," + tipo + ","
            + codi_categoria + "," + codi_dedicacion + "," + grupo_nivel + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool update_docente(int codi_departamento, int codi_provincia, int codi_distrito,
        string desc_domicilio, string tenencia, string vive_en, int codi_departamentodom, int codi_provinciadom,
        int codi_distritodom, string dni_persona, string ape_paterno, string ape_materno, string sexo,
        string nomb_persona, string correo, string carnet_seguro, string grupo_sanguineo, DateTime fecha_ingreso,
        int area, int cargo, DateTime fecha_nacimiento, string nacionalidad, string telefono, string celular,
        string estado_civil, string codi_trabajo, string codi_plaza, string codi_legajo, int estado, string foto,
        int tipo, int codi_categoria, int codi_dedicacion, int grupo_nivel)
        {
            try
            {
                cmd_update_docente(codi_departamento, codi_provincia, codi_distrito,
                desc_domicilio, tenencia, vive_en, codi_departamentodom, codi_provinciadom,
                codi_distritodom, dni_persona, ape_paterno, ape_materno, sexo,
                nomb_persona, correo, carnet_seguro, grupo_sanguineo, fecha_ingreso,
                area, cargo, fecha_nacimiento, nacionalidad, telefono, celular,
                estado_civil, codi_trabajo, codi_plaza, codi_legajo, estado, foto,
                tipo, codi_categoria, codi_dedicacion, grupo_nivel);
            }
            catch (Exception)
            {
            }
            return true;

        }



    }
}

