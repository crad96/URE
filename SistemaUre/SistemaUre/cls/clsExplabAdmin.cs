using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsExplabAdmin
    {
        private clsConec conec = null;

    public clsExplabAdmin(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }
        public clsExplabAdmin()
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


       public bool insert_expAdmin(string empresa_entidad, string ocupacion, string lugar, DateTime fecha_inicio, DateTime fecha_fin, string dni_persona)
       {
           try
           {
               cmd_insert_expAdmin(empresa_entidad, ocupacion, lugar, fecha_inicio, fecha_fin, dni_persona);
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }

       private object cmd_insert_expAdmin(string empresa_entidad, string ocupacion, string lugar, DateTime fecha_inicio, DateTime fecha_fin, string dni_persona)
       {

           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_insert_expeLaboAdmin '" + empresa_entidad + "',  '" + ocupacion + "',  '" + lugar + "'   , '" + fecha_inicio + "' , '" + fecha_fin + "','" + dni_persona + "' ", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }

       public DataTable listar_expAdmin(string DNI)
       {
           string query = "Select codi, empresa_entidad, ocupacion,lugar, fecha_inicio,fecha_fin from V_expeLaboAdmin where dni_persona='" + DNI + "'";
           clsConec get = new clsConec();
           DataTable dt = new DataTable();
           dt = get.obtenerTable(query);
           return dt;
       }

       public object cmd_delete_expAdmin(int codi)
       {
           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_delete_expeLaboAdmin " + codi + "", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }


       public bool delete_expAdmin(int codi)
       {
           try
           {
               cmd_delete_expAdmin(codi);
               return true;
           }
           catch (Exception ex) { string msj = ex.Message; return false; }
       }

    }
}