using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUre.cls
{
    class clsConec
    {
        private string localDefault;
        public string LocalDefault
        {
            get { return localDefault; }
            set { localDefault = value; }
        }

        private SqlTransaction t;
        
        SqlConnection cn = null;
        public SqlConnection Cn
        {
            get { return cn; }
            set { cn = value; }
        }
        public clsConec()
        {
            loadDatos();      
            //psw = "12345";
            user = "localhost";
            bd = "BD_URE";

        }
        public clsConec(String Host)
        {
            host = Host;
            psw = "GGGGG";
            user = "postgres";
            bd = "GGG";
        }
        private string IPs(string dominio)
        {
            try
            {
                String ip = "";
                IPAddress[] MisIP = Dns.GetHostAddresses(dominio);
                foreach (IPAddress MiIp in MisIP)
                {
                    ip = MiIp.ToString();
                }
                return ip;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return String.Empty;
            }
        }
        public clsConec(Boolean conectado)
        {
            loadDatos();
            psw = "HHH#";
            user = "HH";
            bd = "HHH";
            if (conectado)
                conectar();
        }

        public SqlConnection loadConeccion()
        {
            //string cadenaConexion = "Server=MYSQL5011.myASP.NET;Database=db_a15e19_angel;Uid=a15e19_angel;Pwd=crad2016";
            String cadenaConexion = "Data Source=localhost;Initial Catalog=" + bd + ";Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            return cnn;
        }

        public DataTable obtenerTable(string consulta)
        {
            // loadConeccion();
            //MySqlConnection cnn = new MySqlConnection(cadenaConexion);
            //cnn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(consulta, loadConeccion());
            DataTable ds = new DataTable();
            ad.Fill(ds);
            return ds;
        }

        public clsConec(string _host, string _dataBase, string _user, string _pass)
        {
            host = _host;
            psw = _pass;
            user = _user;
            bd = _dataBase;
        }

        private string host;
        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string psw;
        public string Psw
        {
            get { return psw; }
            set { psw = value; }
        }
        private string bd;
        public string Bd
        {
            get { return bd; }
            set { bd = value; }
        }
        public void conectar()
        {
            if (cn == null)
            {
                cn = new SqlConnection("Data Source=localhost;Initial Catalog=" + bd + ";Integrated Security=True");
                // cn = new SqlConnection("Data Source=" + host + ";Database=" + bd);                
            }          
            if (cn.State != System.Data.ConnectionState.Open)
            {
                try { cn.Open(); }
                catch (Exception ex) { 
                  //  MessageBox.Show("No se pudo conectar al servidor \n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
        public void conectarPooling()
        {

            if (cn == null)
            {
                cn = new SqlConnection("Server=" + host + ";Port=5432;User Id=" + user + ";Password=" + psw + ";Database=" + bd + ";Pooling=true;");
                
            }
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();

            }
        }
        public int ejecutarConsultaYCerrar(String consulta)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand(consulta, cn);
            result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Dispose();
            return result;
        }
        public DataTable abrirConsultaYCerrar(String consulta)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            da.Fill(dt);
            da.Dispose();
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Dispose();
            return dt;
        }
        public void desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }
        private void loadDatos()
        {
            try
            {
                String line = ""; Int32 i = 0;
                String ruta = Environment.CurrentDirectory + "\\config.ini";
                StreamReader sr = new StreamReader(ruta);

                while ((line = sr.ReadLine()) != null)
                {
                    if (i == 0)
                        host = IPs(line);
                    else if (i == 1)
                        localDefault = IPs(line);
                    i++;
                }
            }
            catch
            {
                host = "localhost";
                localDefault = "10";
            }
        }
        public static String loadDatos(int j)
        {
            try
            {
                String line = ""; Int32 i = 0;
                String ruta = Environment.CurrentDirectory + "\\config.ini";
                StreamReader sr = new StreamReader(ruta);

                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                    if (i == j)
                    {
                        return line;
                    }
                }
                return "79";
            }
            catch
            {
                return "00";
            }
        }
        public SqlConnection getConec()
        {
            return null;
        }
        public DateTime fechaSevidor()
        {
            try
            {
                string strCommand = "SELECT localtimestamp";
                SqlCommand command = new SqlCommand(strCommand, cn);
                DateTime fecha = Convert.ToDateTime(command.ExecuteScalar());
                return (fecha);
            }
            catch
            {
                return DateTime.Now;
            }

        }
        public void inicarTransaccion()
        {
            t = cn.BeginTransaction();
        }
        public void terminarTransaccion()
        {
            t.Commit();
        }
        public void cancelarTransaccion()
        {
            t.Rollback();
        }
        /// <summary>
        /// Retorna un dataTable de un consulta hecha en un procedimiento almacenado. Solo tiene que ingresar el 
        /// nombre del procedimiento almacenados y sus parametros almacenados en un array de objetos, si el array
        /// de objetos(donde estan los parametros del sp) es null, entonces se ejecutara el sp sin parametros.
        /// </summary>
        /// <param name="nombreStoredProcedure">Nombre del StoredProcedure.</param>
        /// <param name="parametros">Array de parametros del sp (puede tener valor de null.)</param>
        /// <returns>DataTable.</returns>
        public static DataTable ejecutarStoredProcedure(string nombreStoredProcedure, Object[] parametros)
        {
            clsConec conexCls = new clsConec();//cn esta abierto
            conexCls.conectar();
            using (SqlConnection conexion = conexCls.Cn)
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = nombreStoredProcedure.Trim();
                    comando.CommandTimeout = 500;
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                        for (int i = 0; i < parametros.Length; i++)
                            comando.Parameters.Add(new SqlParameter("$" + (i + 1), parametros[i]));
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    dataAdapter.SelectCommand = comando;
                    dataAdapter.Fill(table);
                    return table;
                }
            }
        }

        /// <summary>
        /// Ejecuta procedimientos almacenados para Inserción, Edición o Eliminación, el cual retornará un objeto,
        /// normalmente cuando es Inserción retornará una cadena con el codigo de la fila seleccionada (siempre y cuando 
        /// la inserción sea existosa de lo contrario retorna una cadena vacía) y en los casos de edición y eliminación
        /// normalmente retornan un objeto boolean el cual es 'true' si la edición o eliminación fue efectuada, de lo
        /// contrario retornará 'false'.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Prodecimiento Almacenado para mantenimiento.</param>
        /// <param name="parametros">Arreglo de parametros que necesita el procedimiento almacenado para su ejecución.</param>
        /// <returns></returns>
        public static Object ejecutarStoredProcedureMantenimiento(String nombreProcedimiento, Object[] parametros)
        {
            clsConec conexCls = new clsConec();
            conexCls.conectar();
            using (SqlConnection conexion = conexCls.Cn)
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = nombreProcedimiento.Trim();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandTimeout = 3000;
                    if (parametros != null)
                        for (int i = 0; i < parametros.Length; i++)
                            comando.Parameters.Add(new SqlParameter("$" + (i + 1), parametros[i]));

                    return comando.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Retorna un dataTable de un consulta hecha en un procedimiento almacenado. Solo tiene que ingresar el 
        /// nombre del procedimiento almacenados y sus parametros almacenados en un array de objetos, si el array
        /// de objetos(donde estan los parametros del sp) es null, entonces se ejecutara el sp sin parametros.
        /// </summary>
        /// <param name="nombreStoredProcedure">Nombre del StoredProcedure.</param>
        /// <param name="parametros">Array de parametros del sp (puede tener valor de null.)</param>
        /// <returns>DataTable.</returns>
        public static DataTable ejecutarStoredProcedure(clsConec conec, string nombreStoredProcedure, Object[] parametros)
        {
            if (conec.cn == null) conec.conectar();
            if (conec.Cn.State == ConnectionState.Closed) conec.conectar();
            using (SqlConnection conexion = conec.Cn)
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = nombreStoredProcedure.Trim();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandTimeout = 3000;
                    if (parametros != null)
                        for (int i = 0; i < parametros.Length; i++)
                            comando.Parameters.Add(new SqlParameter("$" + (i + 1), parametros[i]));
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    dataAdapter.SelectCommand = comando;
                    dataAdapter.Fill(table);
                    return table;
                }
            }
        }

        /// <summary>
        /// Ejecuta procedimientos almacenados para Inserción, Edición o Eliminación, el cual retornará un objeto,
        /// normalmente cuando es Inserción retornará una cadena con el codigo de la fila seleccionada (siempre y cuando 
        /// la inserción sea existosa de lo contrario retorna una cadena vacía) y en los casos de edición y eliminación
        /// normalmente retornan un objeto boolean el cual es 'true' si la edición o eliminación fue efectuada, de lo
        /// contrario retornará 'false'.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Prodecimiento Almacenado para mantenimiento.</param>
        /// <param name="parametros">Arreglo de parametros que necesita el procedimiento almacenado para su ejecución.</param>
        /// <returns></returns>
        public static Object ejecutarStoredProcedureMantenimiento(clsConec conec, String nombreProcedimiento, Object[] parametros)
        {
            try
            {
                if (conec.cn == null) conec.conectar();
                if (conec.Cn.State == ConnectionState.Closed) conec.conectar();
                using (SqlConnection conexion = conec.Cn)
                {
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = nombreProcedimiento.Trim();
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandTimeout = 1000;
                        if (parametros != null)
                            for (int i = 0; i < parametros.Length; i++)
                            {
                                Object obj = parametros[i];
                                ///if()
                                if (obj.GetType().ToString().ToLower().Equals("system.timespan"))
                                {
                                    TimeSpan tiempo = (TimeSpan)obj;
                                    comando.Parameters.Add(new SqlParameter("$" + (i + 1), tiempo.Hours + ":" + tiempo.Minutes + ":" + tiempo.Seconds));
                                }
                                else
                                    comando.Parameters.Add(new SqlParameter("$" + (i + 1), parametros[i]));
                            }

                        return comando.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public static DataTable getTabla(clsConec conec, string nombreStoredProcedure, Object[] parametros)
        {
            if (conec.cn == null) conec.conectar();
            if (conec.Cn.State == ConnectionState.Closed) conec.conectar();
            using (SqlConnection conexion = conec.Cn)
            {
                using (SqlCommand comando = new SqlCommand())
                {                    
                    comando.Connection = conexion;
                    comando.CommandText = nombreStoredProcedure.Trim();
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlTransaction t = conexion.BeginTransaction();
                    if (parametros != null)
                        for (int i = 0; i < parametros.Length; i++)
                            comando.Parameters.Add(new SqlParameter("$" + (i + 1), parametros[i]));

                    SqlDataReader reader = null;
                    try
                    {
                        reader = comando.ExecuteReader();
                        DataTable table = new DataTable();
                                            table.Load(reader);
                                            t.Commit();
                                            return table;
                    }
                    catch (Exception)
                    {
                        t.Rollback();
                        return null;
                    }
                    
                }
            }
        }
    }
}
