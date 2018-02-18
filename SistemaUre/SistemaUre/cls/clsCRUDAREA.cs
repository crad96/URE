using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsCRUDArea
    {
        private clsConec conec = null;

        public clsCRUDArea(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsCRUDArea()
        {
            conec = new clsConec();
        }



        public object cmd_insert_area(string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_Insertar_Area '" + descripcion + "'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool insert_area(string descripcion)
        {
            try
            {
                cmd_insert_area(descripcion);
            }
            catch (Exception)
            {
            }
            return true;
            
        }



        public DataTable listarArea()
        {
            string query = "select * from v_area";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;            
        }

        public object cmd_update_area_estado(int estado, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_area_estado " + estado + ", " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_area_estado(int estado, int codigo)
        {
            try
            {
                cmd_update_area_estado(estado, codigo);
                return true;
            }
            catch (Exception ex){string msj = ex.Message;}return false;
        }


        public object cmd_update_area(int codigo, string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_Actualizar_Area "+codigo+", '"+descripcion+"'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_area(int codigo, string descripcion)
        {
            try
            {
                cmd_update_area(codigo, descripcion);
                return true;
            }
            catch (Exception ex) { string msj = ex.Message; } return false;
        }
    }
}