using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsCRUDCargo
    {
        private clsConec conec = null;

        public clsCRUDCargo(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsCRUDCargo()
        {
            conec = new clsConec();
        }

        public object cmd_insert_cargo(string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_insert_cargo '" + descripcion + "'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool insert_cargo(string descripcion)
        {
            try
            {
                cmd_insert_cargo(descripcion);
            }
            catch (Exception)
            {
            }
            return true;

        }
        public DataTable listar_cargo()
        {
            string query = "Select codigo , descripcion from V_Cargo";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }



        public object cmd_update_cargo(string descripcion, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_cargo '" + codigo + "', " + descripcion + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_cargo(string descripcion, int codigo)
        {
            try
            {
                cmd_update_cargo(descripcion, codigo);
                return true;
            }
            catch (Exception ex){string msj = ex.Message;return false;}
        }

        public object cmd_delete_cargo(int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_delete_cargo " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool delete_cargo(int codigo)
        {
            try
            {
                cmd_delete_cargo(codigo);
                return true;
            }
            catch (Exception ex) { string msj = ex.Message; return false; }
        }
    }
}