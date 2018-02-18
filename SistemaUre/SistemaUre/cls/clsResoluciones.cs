using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaUre.cls
{
    public class clsResoluciones
    {private clsConec conec = null;

    public clsResoluciones(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }

    public clsResoluciones()
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


    //DESMERITO - 13
    public bool insert_Desmeritos(string dni_persona, string num_resolucion, string Descripcion,
       DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_Desmeritos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    private object cmd_insert_Desmeritos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();


        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 13, cnn.loadConeccion());

        return cmd.ExecuteScalar();

    }

    //----------------------------------------------//

     public object cmd_update_Desmeritos(int codigo, string num_resolucion, string Descripcion,
           DateTime fecha_registro, DateTime fecha_resol)
        {
            clsConec cnn = new clsConec();
            SqlCommand cmd = new SqlCommand("exec sp_update_resoluciones " + codigo + ", '" + num_resolucion + "', '" + Descripcion + "'  , '" + fecha_registro + "' , '" + fecha_resol + "'", cnn.loadConeccion());
            return cmd.ExecuteScalar();
        }


        public bool update_Desmeritos(int codigo, string num_resolucion, string Descripcion,
            DateTime fecha_registro, DateTime fecha_resol)
        {
            try
            {
                cmd_update_Desmeritos(codigo, num_resolucion, Descripcion, fecha_registro, fecha_resol);
                return true;
            }
            catch (Exception ex) { string msj = ex.Message; return false; }
        }


    public DataTable listar_Desmeritos(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol ,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='DESMERITOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }




 //CONTRATOS Y NOMBRAMIENTOS - 1

    public bool insert_contratos(string dni_persona, string num_resolucion, string Descripcion,DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_contratos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_contratos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 1, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_contratos(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='CONTRATOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //RENUNCIA Y LIQUIDACION - 2

    public bool insert_liquidacion(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_liquidacion(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_liquidacion(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 2, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_liquidacion(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='RENUNCIA'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //SEGURO DE VIDA  - 3

    public bool insert_seguroVida(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_seguroVida(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_seguroVida(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "' , " + 3, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_seguroVida(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='SEGURO VIDA'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //DESTAQUES  - 4

    public bool insert_destaques(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_destaques(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_destaques(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 4, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_destaques(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='DESTAQUES'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //DESCANSO MEDICO  - 5

    public bool insert_descanso(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_descanso(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_descanso(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 5, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_descanso(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='DESCANSOS MEDICOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //PERMISOS  - 6

    public bool insert_permisos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_permisos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_permisos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 6, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_permisos(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='PERMISOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //PROMOCIONES Y ASCENSOS  - 7

    public bool insert_acsensos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_acsensos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_acsensos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 7, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_acsensos(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='PROMOCIONES ASCENSOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //RENUMERACION PERSONAL  - 8

    public bool insert_personal(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_personal(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_personal(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 8, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_personal(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol, foto from v_resolucion where dni_persona='" + DNI + "'and tipo='RENUMERACION PERSONAL'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //RENUMERACION FAMILIAR  - 9

    public bool insert_familiar(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_familiar(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_familiar(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 9, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_familiar(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='RENUMERACION FAMILIAR'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //EXPERIENCIA LABORAL - 10

    public bool insert_expLabo(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_expLabo(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_expLabo(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 10, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_expLabo(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='EXPERIENCIA LABORAL'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //EVALUACIONES - 11

    public bool insert_evaluaciones(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_evaluaciones(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_evaluaciones(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 11, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_evaluaciones(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='EVALUACIONES'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //MERITOS - 12

    public bool insert_meritos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_meritos(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_meritos(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 12, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_meritos(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='MERITOS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //EXP DOCENTE INVSTIGACION - 14

    public bool insert_invesD(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_invesD(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_invesD(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "',  '" + foto + "', " + 14, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_invesD(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='EXP DOCENTE INVSTIGACION'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }


    //OTROS - 15

    public bool insert_otros(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        try
        {
            cmd_insert_otros(dni_persona, num_resolucion, Descripcion, fecha_registro, fecha_resol, foto, tipo);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    private object cmd_insert_otros(string dni_persona, string num_resolucion, string Descripcion, DateTime fecha_registro, DateTime fecha_resol, string foto, int tipo)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_insert_resolucion'" + dni_persona + "',  '" + num_resolucion + "'  , '" + Descripcion + "' , '" + fecha_registro + "' , '" + fecha_resol + "', '" + foto + "', " + 15, cnn.loadConeccion());
        return cmd.ExecuteScalar();

    }

    public DataTable listar_otros(string DNI)
    {
        string query = "Select codi,num_resolution, Descripcion, fecha_registro, fecha_resol,foto from v_resolucion where dni_persona='" + DNI + "'and tipo='OTROS'";
        clsConec get = new clsConec();
        DataTable dt = new DataTable();
        dt = get.obtenerTable(query);
        return dt;
    }





    public object cmd_delete_resoluciones(int codi)
    {
        clsConec cnn = new clsConec();
        SqlCommand cmd = new SqlCommand("exec sp_delete_resoluciones " + codi + "", cnn.loadConeccion());
        return cmd.ExecuteScalar();
    }


    public bool delete_resoluciones(int codi)
    {
        try
        {
            cmd_delete_resoluciones(codi);
            return true;
        }
        catch (Exception ex) { string msj = ex.Message; return false; }
    }


    }
}