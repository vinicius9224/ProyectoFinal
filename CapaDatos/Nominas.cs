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

        public DataTable GenerarNominas( DateTime FechaPago_Nomina, DateTime pagoDesde_Nomina, DateTime pagoHasta_Nomina)
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

    }
}
