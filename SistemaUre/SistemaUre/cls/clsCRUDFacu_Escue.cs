using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsCRUDFacu_Escue
    {
        private clsConec conec = null;

        public clsCRUDFacu_Escue(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsCRUDFacu_Escue()
        {
            conec = new clsConec();
        }


        public object cmd_insert_Facultad(string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_Insert_Facultad '" + descripcion + "'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool insert_Facultad(string descripcion)
        {
            try
            {
                cmd_insert_Facultad(descripcion);
            }
            catch (Exception)
            {
            }
            return true;

        }



        public object cmd_update_Facultad_Escuela(string descripcion)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool update_Facultad_Escuela(string descripcion)
        {
            try
            {
                cmd_insert_Facultad(descripcion);
            }
            catch (Exception){}return true;}


        public object cmd_insert_Escuela(string descripcion, string facultad)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_Insert_escuela '"+descripcion+"','"+facultad+"'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool insert_Escuela(string descripcion,string facultad)
        {
            try
            {
                cmd_insert_Escuela(descripcion,facultad);
            }
            catch (Exception)
            {
            }
            return true;

        }

        public object cmd_update_Facultad(string descripcion,int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_update_facultad '"+descripcion+"', "+codigo+"", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_Facultad(string descripcion, int codigo)
        {
            try
            {
                cmd_update_Facultad(descripcion,codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }


        public object cmd_update_Escuela(string descripcion,int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_update_escuela '" + descripcion + "', "+codigo+"", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_Escuela(string descripcion, int codigo)
        {
            try
            {
                cmd_update_Escuela(descripcion, codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }


        public object cmd_update_Escuela_estado(int estado, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_update_escuela_estado " + estado + ", " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_Escuela_estado(int estado, int codigo)
        {
            try
            {
                cmd_update_Escuela_estado(estado, codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }


        public object cmd_update_Facultad_estado(int estado, int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_update_facultad_estado " + estado + ", " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool update_Facultad_estado(int estado, int codigo)
        {
            try
            {
                cmd_update_Facultad_estado(estado, codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }


        public object cmd_delete_Facultad(int codigo)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec spt_delete_facultad " + codigo + "", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }

        public bool delete_Facultad(int codigo)
        {
            try
            {
                cmd_delete_Facultad(codigo);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
            }
            return true;

        }

        public DataTable Listar_Facultad()
        {
            string query = "select codigo, descripcion, estado from V_Facultad";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;            
        }

        public DataTable Listar_Facultad_combo()
        {
            string query = "select codigo, descripcion, estado from V_Facultad where estado = 'Activo'";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable listarFacultad_Escuela()
        {
            string query = "select codigo_facultad, descripcion_facultada,descripcion_escuela from V_Facu_Escue";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }

        public DataTable listar_Escuela()
        {
            string query = "Select codigo , descripcion_escuela, descripcion_facultad, estado from V_Escuela";
            clsConec get = new clsConec();
            DataTable dt = new DataTable();
            dt = get.obtenerTable(query);
            return dt;
        }



    }
}