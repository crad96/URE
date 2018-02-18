using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsExperienciaDocente
    { 
        private clsConec conec = null;
        public clsExperienciaDocente(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsExperienciaDocente()
        {
            conec = new clsConec();
        }

        public string ObtenerNombresCompletos(string dni)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("select Persona from V_nombresCompletos where dni='" + dni + "'", cnn.loadConeccion());
            string Nombres = Convert.ToString(cmd.ExecuteScalar());
            return Nombres;
        }

        public bool existeDatos(string dni)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("select count(*) from V_nombresCompletos where dni='" + dni + "'", cnn.loadConeccion());
            int numRegistro = Convert.ToInt32(cmd.ExecuteScalar());

            if (numRegistro != 0)
            {
                return true;
            }

            return false;

        }

        public bool insert_experienciaDoce(string desc_universidad,string desc_actividad, DateTime fecha_desde,
         DateTime fecha_hasta,string dni_persona)
        {
            try
            {
                cmd_insert_experienciaDoce(desc_universidad, desc_actividad,fecha_desde,fecha_hasta, dni_persona);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private object cmd_insert_experienciaDoce(string desc_universidad,string desc_actividad,DateTime fecha_desde, DateTime fecha_hasta,
              string dni_persona)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_insert_experienciaDoc'" + desc_universidad + "',  '" + desc_actividad + "'  , '" + fecha_desde + "',  '" + fecha_hasta + "',  '" + dni_persona + "' ", cnn.loadConeccion());
            return cmd.ExecuteScalar();

        }

        public DataTable listar_experienciaDoc(string DNI)
        {
            string query = "Select codi, universidad,desc_actividad ,fecha_desde,fecha_hasta  from v_experienciaDoc where dni_persona='" + DNI + "'";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }
        public DataTable Listar_univer_combo()
        {
            string query = "select codigo, universidad from v_universidad ";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public object cmd_delete_experienciaDoc(int codi)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_delete_experienciaDoc " + codi + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool delete_experienciaDoc(int codi)
        {
            try
            {
                cmd_delete_experienciaDoc(codi);
                return true;
            }
            catch (Exception ex) { string msj = ex.Message; return false; }
        }

    }
}