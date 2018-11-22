using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// Se debe usar todo bajo el mismo namespace

public class BDHelper
{
    private string string_conexion = @"Data Source=localhost;Initial Catalog=luchiProyecto;Integrated Security=True";
    // STRING CONEXION DANILO @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PAV1_AO_2018;User ID=sa;Password=sistemas2018"

    private static BDHelper instance; //Unica instancia de la clase
    public static BDHelper getBDHelper()
    {
        if (instance == null)
            instance = new BDHelper();
        return instance;
    }

    public DataTable ConsultaSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }

    public DataTable ConsultaSQLConParametros(string strSql, List<object> sqlParam)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            var indice = 0;
            foreach (var param in sqlParam)
            {
                if (param != null)
                {
                    var n_param = "param" + Convert.ToString(indice + 1);
                    cmd.Parameters.AddWithValue(n_param, param);
                }
                indice++;
            }

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }

    public int EjecutarSQL(string strSql)
    {
        // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
        int rtdo = 0;

        // Try Catch Finally
        // Trata de ejecutar el código contenido dentro del bloque Try - Catch
        // Si hay error lo capta a través de una excepción
        // Si no hubo error
        try
        {
            // Establece que conexión usar
            conexion.ConnectionString = string_conexion;
            // Abre la conexión
            conexion.Open();
            t = conexion.BeginTransaction();
            cmd.Connection = conexion;
            cmd.Transaction = t;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucción a ejecutar
            cmd.CommandText = strSql;
            // Retorna el resultado de ejecutar el comando

            rtdo = cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (Exception ex)
        {
            if (t != null)
                t.Rollback();
        }
        finally
        {
            // Cierra la conexión 
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            conexion.Dispose();
        }
        return rtdo;
    }
    
    //TRANSACCION
    enum ResultadoTransaccion
    {
        exito, fracaso
    }
    enum tipoConexion
    {
        simple, transaccion
    }

    // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
    private SqlConnection miConexion = new SqlConnection();
    private SqlCommand miCmd = new SqlCommand();
    private SqlTransaction miTransaccion = null;/* TODO Change to default(_) if this is not a reference type */
    private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
    private tipoConexion miTipo = tipoConexion.simple;

    private SqlConnection conexion;
        private SqlCommand comando;

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }
    private void conectarBD()
    {
        conexion = new SqlConnection();
        conexion.ConnectionString = this.string_conexion;
        conexion.Open();
        comando = new SqlCommand();
        comando.Connection = conexion;
        comando.CommandType = CommandType.Text;
    }

    public void desconectar()
    {
        if (miTipo == tipoConexion.transaccion)
        {
            if (miEstado == ResultadoTransaccion.exito)
            {
                miTransaccion.Commit();
                MessageBox.Show("La transaccion resulto con exito..");
            }
            else
            {
                miTransaccion.Rollback();
                MessageBox.Show("La transaccion no pudo realizarce..");
            }
            miTipo = tipoConexion.simple;
        }

        if (miConexion.State == ConnectionState.Open)
        {
            miConexion.Close();
        }
        //liberar recursos usados x la conecccion
        miConexion.Dispose();

    }
    private void desconectarBD()
    {
        conexion.Close();
    }
    public void EjecutarSQLConTransaccion(string strSql)
    {
        // Try Catch Finally
        // Trata de ejecutar el código contenido dentro del bloque Try - Catch
        // Si hay error lo capta a través de una excepción
        // Si no hubo error
        try
        {
            miCmd.CommandType = CommandType.Text;
            // Establece la instrucción a ejecutar
            miCmd.CommandText = strSql;
            miCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            miEstado = ResultadoTransaccion.fracaso;
        }
    }
    public void conectarConTransaccion()
    {
        miTipo = tipoConexion.transaccion;
        miEstado = ResultadoTransaccion.exito;
        miConexion.ConnectionString = string_conexion;
        // Abre la conexión
        miConexion.Open();
        miTransaccion = miConexion.BeginTransaction();
        miCmd.Transaction = miTransaccion;
        miCmd.Connection = miConexion;

    }

}
