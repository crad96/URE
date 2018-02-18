using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SistemaUre.cls
{
    public class clsCRUDUniversidad
    {
        private clsConec conec = null;

        public clsCRUDUniversidad(string host, string database, string user, string pass)
        {
            conec = new clsConec(host, database, user, pass);
        }

        public clsCRUDUniversidad()
        {
            conec = new clsConec();
        }

        public object cmd_insert_uni(string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd=new SqlCommand("exec sp_Insertar_universidad'"+descripcion+"'",cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool insert_uni(string descripcion)
        {
            try
            {
                cmd_insert_uni(descripcion);
            }
            catch
            {

            }
            return true;
        }

        public DataTable listarUni()
        {
            string query = "Select codigo, descripcion from v_uni";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public object cmd_update_universidad(string descripcion, int codigo)
        {
           clsConec cnn=new clsConec();
           SqlCommand cmd=new SqlCommand("exec sp_update_cargo "+codigo+", '"+descripcion+"'") ;
           return cmd.ExecuteScalar();
        }

        public bool update_universidad(string descripcion, int codigo)
        {
            try
            {
                cmd_update_universidad(descripcion, codigo);
                return true;
            }
            catch(Exception ex)
            {
                string msj = ex.Message; 
                return false;
            }
        }

        public object cmd_delete_universidad(int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_delete_cargo " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool delete_universidad(int codigo)
        {
            try
            {
                cmd_delete_universidad(codigo);
                return true;
            }
            catch (Exception ex) { string msj = ex.Message; return false; }
        }



    }


}