﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsAdminDistin
    {
         private clsConec conec = null;

    public clsAdminDistin(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

    public clsAdminDistin()
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


    public bool insert_distincion_Reci(string entidad, string distincion, DateTime fecha,
         string dni_persona)
    {
        try
        {
            cmd_insert_distincionReci(entidad, distincion , fecha, dni_persona);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    private object cmd_insert_distincionReci(string entidad, string distincion, DateTime fecha,
        string dni_persona)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_distinAdmin '" + entidad + "',  '" + distincion + "'  , '" + fecha + "',  '" + dni_persona + "' ", cnn.loadConeccion());
        return cmd.ExecuteScalar();
        
    }

    public DataTable listar_distincionReci(string DNI)
    {
        string query = "Select codi,entidad, distincion, fecha from v_distinAdmin where dni_persona='" + DNI + "'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }

    public object cmd_delete_distincionReci(int codi)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_delete_distinAdmin " + codi + "", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool delete_distincionReci(int codi)
    {
        try
        {
            cmd_delete_distincionReci(codi);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }


    }
}