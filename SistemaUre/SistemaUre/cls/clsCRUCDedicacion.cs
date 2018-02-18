using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsCRUCDedicacion
    {
         private clsConec conec = null;

        public clsCRUCDedicacion(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsCRUCDedicacion()
        {
            conec = new clsConec();
        }



        public object cmd_insert_Dedicacion(string descripcion, string estado)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_Insert_Dedicacion'" + descripcion + "','"+estado+"'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool insert_dedicacion(string descripcion,string estado)
        {
            try
            {
                cmd_insert_Dedicacion(descripcion,estado);
            }
            catch (Exception)
            {
            }
            return true;
            
        }

        public DataTable Listar_Dedicacion_combo()
        {
            string query = "select codigo, descripcion, estado from v_Dedicacion where estado = 'Activo'";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }


        public DataTable listarDedicacion()
        {
            string query = "select * from v_Dedicacion";
            clsConec gg = new clsConec();
            DataTable tb = new DataTable();
            tb = gg.obtenerTable(query);
            return tb;
        }


        public object cmd_update_Dedicacion(string descripcion, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_Dedicacion " + codigo + ",' " + descripcion + "'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }
        public bool update_Dedicacion(string descripcion, int codigo)
        {
            try
            {
                cmd_update_Dedicacion(descripcion, codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public object cmd_delete_Dediciacion(int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_delete_Dedicacion " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool delete_Dedicaion(int codigo)
        {
            try
            {
                cmd_delete_Dediciacion(codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }




        public object cmd_update_Dedicacion_estado(int estado, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_Dedicacion_estado " + estado + ", " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_Dedicacion_estado(int estado, int codigo)
        {
            try
            {
                cmd_update_Dedicacion_estado(estado, codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }
    }
}