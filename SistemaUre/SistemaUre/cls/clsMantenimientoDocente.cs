using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaUre.cls;
using System.Data;


namespace SistemaUre.cls
{
    public class clsMantenimientoDocente
    {
        
        private clsConec conec = null;

        public clsMantenimientoDocente(string host, string dataBase, string user, string pass)
       
        {
            conec = new clsConec(host, dataBase, user, pass);
        }
        
        public clsMantenimientoDocente()
        {
            conec = new clsConec();
        }

        public DataTable listarDatosPrueba()
        {
            object[] parametros = new object[] {};
            return clsConec.ejecutarStoredProcedure(conec, "listar", parametros);
        }

        public DataTable listar_tb_pago_query_fraccionamiento(string codiinct, string codicnta, string aniocnta)
        {
            object[] parametros = new object[] { codiinct, codicnta, aniocnta };
            return clsConec.ejecutarStoredProcedure(conec, "stp_gf_tb_pago_listar_query_fraccionamiento", parametros);
        }

    }
}