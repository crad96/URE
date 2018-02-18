using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsEspecializacion
    {
         private clsConec conec = null;
        public clsEspecializacion(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

        public clsEspecializacion()
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

    public bool insert_especializacion(string nomb_esp, string desc_universidad, string fecha_espe,
          string dni_persona)
    {
        try
        {
            cmd_insert_especializacion(nomb_esp, desc_universidad , fecha_espe, dni_persona);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    private object cmd_insert_especializacion(string nomb_esp, string desc_universidad, string fecha_espe,
          string dni_persona)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_especializacion '" + nomb_esp + "',  '" + desc_universidad + "'  , '" + fecha_espe  + "',  '" + dni_persona + "' ", cnn.loadConeccion());
        return cmd.ExecuteScalar();
        
    }

    public DataTable listar_especializacion(string DNI)
    {
        string query = "Select codi,Especializacion, universidad, fecha from v_especializacion where dni_persona='" + DNI + "'";
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

    public object cmd_delete_especializacion(int codi)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_delete_especializacion " + codi + "", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool delete_especializacion(int codi)
    {
        try
        {
            cmd_delete_especializacion(codi);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }

    }
}