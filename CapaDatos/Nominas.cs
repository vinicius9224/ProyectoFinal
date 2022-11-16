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

        //public DataTable GenerarNominas()
        //{
        //    //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
        //    DataTable tabla = new DataTable();
        //    comando.Connection = conexion.Abrir();
        //    comando.CommandText = "AgregarSesion";
        //    comando.CommandType = CommandType.StoredProcedure;
        //}
    }
}
