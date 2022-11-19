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

        public DataTable GenerarNominas( DateTime FechaPago_Nomina, string pagoDesde_Nomina, string pagoHasta_Nomina, float SalarioNeto, float Viatico, int TotalHoras, float PagoxHoras)
        {
            //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "GenerarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaPago_Nomina", FechaPago_Nomina);
            comando.Parameters.AddWithValue("@pagoDesde_Nomina", pagoDesde_Nomina);
            comando.Parameters.AddWithValue("@pagoHasta_Nomina", pagoHasta_Nomina);
            comando.Parameters.AddWithValue("@salario_Neto", SalarioNeto);
            comando.Parameters.AddWithValue("@viaticos", Viatico);
            comando.Parameters.AddWithValue("@total_Horas", TotalHoras);
            comando.Parameters.AddWithValue("@valor_pHoras", PagoxHoras);
            SqlDataReader reader = comando.ExecuteReader();
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();
            return tabla;
        }

        //public DataTable ListarNominas()
        //{
        //    //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
        //    DataTable tabla = new DataTable();
        //    comando.Connection = conexion.Abrir();
        //    comando.CommandText = "ListarNominas";
        //    comando.CommandType = CommandType.StoredProcedure;
        //}

        //public DataTable MostrarEgresosTotales()
        //{
        //    //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
        //    DataTable tabla = new DataTable();
        //    comando.Connection = conexion.Abrir();
        //    comando.CommandText = "MostrarEgresosTotales";
        //    comando.CommandType = CommandType.StoredProcedure;
        //}

        //public DataTable MostrarMaestros()
        //{
        //    Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
        //    DataTable tabla = new DataTable();
        //    comando.Connection = conexion.Abrir();
        //    comando.CommandText = "MostrarMaestros";
        //    comando.CommandType = CommandType.StoredProcedure;
        //}
        public DataTable Buscar(string parametro)
        {
            //Intanciar los comandos sqlClient para poder utilizar las funciones
            SqlCommand comando = new SqlCommand();
            //Abrir la db
            comando.Connection = conexion.Abrir();
            //Hacer la consulta sql
            comando.CommandText = "SELECT T.Id, T.cod_Trabajador as[Codigo], T.nom_Trabajador [Nombres] , T.ape_Trabajador as [Apellidos],T.salario_Trabajador as [SalarioBruto],P.nom_Profesion "
                + "FROM Trabajadores T "
                + "INNER JOIN Profesiones P ON P.Id = T.ProfesionId "
                + "where cod_Trabajador like ('" + parametro + "')";
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
            // intanciar los comandos sqlClient para poder utilizar las funciones
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(comando);
            ada.Fill(tabla);
            conexion.Cerrar();
            return tabla;
        }
    }
}
