using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsPonencias
    {
        private clsConec conec = null;

    public clsPonencias(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

    public clsPonencias()
        {
            conec = new clsConec();
        }

    public string ObtenerNombresCompletos(string dni)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("select Persona from V_nombresCompletos where dni='"+dni+"'",cnn.loadConeccion());
        string Nombres = Convert.ToString(cmd.ExecuteScalar());
        return Nombres;
    }

    public bool existeDatos(string dni)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("select count(*) from V_nombresCompletos where dni='" + dni + "'",cnn.loadConeccion());
        int numRegistro = Convert.ToInt32(cmd.ExecuteScalar());
       
        if(numRegistro!=0)
        {
            return true;
        }

        return false;

    }

    public bool insert_ponencias(string nombrePonencia, string evento, string ciudad, DateTime fecha, string dni_persona)
    {
        try
        {
            cmd_insert_ponencias(nombrePonencia, evento, ciudad, fecha, dni_persona);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    private object cmd_insert_ponencias(string nombrePonencia, string evento, string ciudad, DateTime fecha, string dni_persona)
    {

        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_ponencias '" + nombrePonencia + "',  '" + evento + "'  , '" + ciudad + "' , '" + fecha + "','" + dni_persona + "' ", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    

    public DataTable listar_ponencias(string DNI)
    {
        string query = "Select codi, nombrePonencia, evento, ciudad, fecha,dni_persona from V_ponencias where dni_persona='"+DNI+"'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }



    public object cmd_update_ponencias(int codi, string nombrePonencia, string evento, string ciudad,
        DateTime fecha)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_update_ponencias  " + codi + ",'" + nombrePonencia + "',  '" + evento + "'  , '" + ciudad + "' , '" + fecha + "' ", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool update_ponencias(int codi, string nombrePonencia, string evento, string ciudad, DateTime fecha)
    {
        try
        {
            cmd_update_ponencias(codi, nombrePonencia, evento, ciudad, fecha);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }


    public object cmd_delete_ponencias(int codi)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_delete_ponencias " + codi + "", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool delete_ponencias(int codi)
    {
        try
        {
            cmd_delete_ponencias(codi);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }


    }
}