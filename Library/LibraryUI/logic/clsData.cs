using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LibraryUI.logic
{
    public class clsData
    {
        //Creo la cadena de conexión
        string cadenaConexion = "Data Source = localhost; User ID = PROYECTO_BASESDATOS1; Password = oracle";
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            //Paso 1: creo una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            //Paso 2: creo un comando
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            //paso 3: abrir la conexión
            miConexion.Open();
            /*paso 4: ejecuto el comando, este me devuelve el 
             * número de filas que se afectaron ya sea con el
             * insert, update o delete que llegaba en la consulta
             */
            filasAfectadas = comando.ExecuteNonQuery();
            //Cerrar la conexión
            miConexion.Close();
            return filasAfectadas;
        }

        //Método para ejecutar sentencias select
        public DataSet ejecutarSELECT(string consulta)
        {
            //paso 1: creo un dataset vacío
            DataSet ds = new DataSet();
            //paso 2: creo un adaptador
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: lleno el dataset ds a través del adaptador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;

        }

        public DataTable researchValidate(string consulta)
        {
            //paso 1: creo un datatable vacío
            DataTable dt = new DataTable();
            //paso 2: creo un adaptador
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: lleno el datatable dt a través del adaptador
            adaptador.Fill(dt);
            return dt;
        }
    }
}
