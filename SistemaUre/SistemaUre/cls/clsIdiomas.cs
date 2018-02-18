using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
	public class clsIdiomas
	{
 private clsConec conec = null;

    public clsIdiomas(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

    public clsIdiomas()
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

    public bool insert_idiomas(string desc_idioma, string habla, string lee,
        string escribe, string lugar , string dni_persona)
    {
        try
        {
            cmd_insert_idiomas(desc_idioma, habla , lee, escribe,lugar, dni_persona);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    private object cmd_insert_idiomas(string desc_idioma, string habla, string lee,
        string escribe, string lugar, string dni_persona)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_idiomas '" + desc_idioma + "',  '" + habla + "'  , '" + lee + "' , '" + escribe + "' , '" + lugar + "',  '" + dni_persona + "' ", cnn.loadConeccion());
        return cmd.ExecuteScalar();
        
    }

    public DataTable listar_idiomas(string DNI)
    {
        string query = "Select codi,desc_idioma, habla, lee, escribe,lugar from v_idiomas where dni_persona='" + DNI + "'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }

    public object cmd_delete_idiomas(int codi)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_delete_idiomas " + codi + "", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool delete_idiomas(int codi)
    {
        try
        {
            cmd_delete_idiomas(codi);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }


    }
}