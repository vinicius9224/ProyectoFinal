using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Nominas
    {
        private ConexionBD conexion = new ConexionBD();
        // intanciar los comandos sqlClient para poder utilizar las funciones
        SqlCommand comando = new SqlCommand();

        public DataTable GenerarNominas( DateTime FechaPago_Nomina, string pagoDesde_Nomina, string pagoHasta_Nomina)
        {
            //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "GenerarNominas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha_pagoNomina", FechaPago_Nomina);
            comando.Parameters.AddWithValue("@fech_Nom_Desde", pagoDesde_Nomina);
            comando.Parameters.AddWithValue("@fech_Nom_Hasta", pagoHasta_Nomina);
            SqlDataReader reader = comando.ExecuteReader();
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();
            return tabla;
        }
        public DataTable DetalleNomina(float viatico, float pago_Hora, int totalHoras, int nominaid,int sesionid)
        {
            //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "GenerarDetaNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@viaticos", viatico);
            comando.Parameters.AddWithValue("@valor_pHoras", pago_Hora);
            comando.Parameters.AddWithValue("@total_Horas", totalHoras);
            comando.Parameters.AddWithValue("@NominaId", nominaid);
            comando.Parameters.AddWithValue("@SesionId", sesionid);
            SqlDataReader reader = comando.ExecuteReader();
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();
            return tabla;
        }


        //public DataTable TotalHoras()
        //{
        //    // intanciar los comandos sqlClient para poder utilizar las funciones
        //    SqlCommand comando = new SqlCommand();
        //    // abrir la db
        //    comando.Connection = conexion.Abrir();
        //    //hacer la consulta sql
        //    comando.CommandText = " select SUM(S.cantHoras_Sesion)AS TotalHoras"
        //        +"from DetalleNominas D"
        //        +"INNER JOIN Sesiones S ON S.Id=S.Id"
        //        +"INNER JOIN Facturas F ON D.Id=F.Id"
        //        +"INNER JOIN Trabajadores T ON D.Id=T.Id"
        //        + "WHERE T.Id=F.Id";
        //    //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    // intanciar los comandos sqlClient para poder utilizar las funciones
        //    DataTable tabla = new DataTable();
        //    SqlDataAdapter ada = new SqlDataAdapter(comando);
        //    ada.Fill(tabla);
        //    conexion.Cerrar();

        //    return tabla;

        //}

    }
}
