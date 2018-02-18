using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsExpProfesional
    {
        private clsConec conec = null;

        public clsExpProfesional(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }
        public clsExpProfesional()
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


       public bool insert_expProf(string empresa_entidad, string cargo_desempeñado, string lug_experiencia, DateTime fecha_inicio, DateTime fecha_fin, string dni_persona)
       {
           try
           {
               cmd_insert_expProf(empresa_entidad, cargo_desempeñado, lug_experiencia, fecha_inicio, fecha_fin, dni_persona);
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }

       private object cmd_insert_expProf(string empresa_entidad, string cargo_desempeñado, string lug_experiencia, DateTime fecha_inicio, DateTime fecha_fin, string dni_persona)
       {

           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_insert_experienciaProfesional '" + empresa_entidad + "',  '" + cargo_desempeñado + "',  '" + lug_experiencia + "'   , '" + fecha_inicio + "' , '" + fecha_fin + "','" + dni_persona + "' ", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }

       public DataTable listar_expProf(string DNI)
       {
           string query = "Select codi, empresa_entidad, cargo_desempeñado,lug_experiencia, fecha_inicio,fecha_fin from V_experiencia_Profesional where dni_persona='" + DNI + "'";
           clsConec get = new clsConec();
           DataTable dt = new DataTable();
           dt = get.obtenerTable(query);
           return dt;
       }

       public object cmd_delete_expProf(int codi)
       {
           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_delete_experienciaProfesional " + codi + "", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }


       public bool delete_expProf(int codi)
       {
           try
           {
               cmd_delete_expProf(codi);
               return true;
           }
           catch (Exception ex) { string msj = ex.Message; return false; }
       }

    }
}