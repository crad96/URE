using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace SistemaUre.cls
{
    public class clsPublicacion
    {
        private clsConec conec = null;

         public clsPublicacion(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }
         public clsPublicacion()
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
         
 
        public bool insert_publicaciones(string titulo_publicacion, string editorial, string ciudad, DateTime fecha, string indexada, string dni_persona)
       {
           try
           {
               cmd_insert_publicaciones(titulo_publicacion, editorial,ciudad, fecha, indexada, dni_persona);
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }

       private object cmd_insert_publicaciones(string titulo_publicacion, string editorial, string ciudad, DateTime fecha, string indexada, string dni_persona)
       {

           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_insert_publicacion '" + titulo_publicacion + "',  '" + editorial + "'  , '" + ciudad + "' , '" + fecha + "','" + indexada + "','" + dni_persona + "' ", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }

       public DataTable listar_publicaciones(string DNI)
       {
           string query = "Select codi, titulo_publicacion, editorial, ciudad, fecha,indexada,dni_persona from V_publicacion where dni_persona='" + DNI + "'";
           clsConec get = new clsConec();
           DataTable dt = new DataTable();
           dt = get.obtenerTable(query);
           return dt;
       }

       public object cmd_delete_publicaciones(int codi)
       {
           clsConec cnn = new clsConec();
           SqlCommand cmd = new SqlCommand("exec sp_delete_publicacion " + codi + "", cnn.loadConeccion());
           return cmd.ExecuteScalar();
       }


       public bool delete_publicaciones(int codi)
       {
           try
           {
               cmd_delete_publicaciones(codi);
               return true;
           }
           catch (Exception ex) { string msj = ex.Message; return false; }
       }

}
}



