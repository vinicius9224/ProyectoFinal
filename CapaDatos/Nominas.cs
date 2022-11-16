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

        public DataTable GenerarNominas(DateTime FechaPago_Nomina, string pagoDesde_Nomina, string pagoHasta_Nomina, string desc_Nomina)
        {
            //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "AgregarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaPago_Nomina", FechaPago_Nomina);
            comando.Parameters.AddWithValue("@pagoDesde_Nomina", pagoDesde_Nomina);
            comando.Parameters.AddWithValue("@pagoHasta_Nomina", pagoHasta_Nomina);
            comando.Parameters.AddWithValue("@desc_Nomina", desc_Nomina);
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

        //public DataTable MostrarIngresosTotales()
        //{
        //    //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
        //    DataTable tabla = new DataTable();
        //    comando.Connection = conexion.Abrir();
        //    comando.CommandText = "MostrarIngresosTotales";
        //    comando.CommandType = CommandType.StoredProcedure;
        //}
    }
}
