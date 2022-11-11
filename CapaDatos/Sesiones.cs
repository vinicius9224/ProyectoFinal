using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Runtime.Remoting.Contexts;
using System.Xml;

namespace CapaDatos
{
    public class Sesiones
    {
        //instanciar la clase conexion a la db
        private ConexionBD conexion = new ConexionBD();

        // intanciar los comandos sqlClient para poder utilizar las funciones
        SqlCommand comando = new SqlCommand();

        public DataTable AgregarSesiones(string CodSes, DateTime FechSes, int CantHorsSes, int TrabId, int FactId)
        {
            //Instrucciones que abren la conexion, y meten los parametros mandados del formulario, devuelven una tabla que si tiene datos el codigo dado es repetido. 
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "AgregarSesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod_Ses", CodSes);
            comando.Parameters.AddWithValue("@fech_Ses", FechSes);
            comando.Parameters.AddWithValue("@CantHors_Ses", CantHorsSes);
            comando.Parameters.AddWithValue("@Trab_Id", TrabId);
            comando.Parameters.AddWithValue("@Factur_Id", FactId);
            SqlDataReader reader = comando.ExecuteReader();
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();
            return tabla;

        }

        public Boolean ValidarDatos(ref string idfact, ref string idtrab, string codTrab, string CodFactur, DateTime FechSes)
        {
            //Metodo booleano que valida si los codigos ingresados existan, true = existen, false = no existen

            try
            {
                //Tomando primer id
                comando.Connection = conexion.Abrir();
                DataSet DS = new DataSet();
                //Busca mediante el codigo el id del trabajador con dicho codigo
                SqlDataAdapter DP = new SqlDataAdapter("Select t.Id FROM Trabajadores t WHERE t.cod_Trabajador = " + codTrab + "", comando.Connection);

                DP.Fill(DS);

                idtrab = DS.Tables[0].Rows[0]["Id"].ToString();

                //Siguiente id
                DS.Clear();

                DP = new SqlDataAdapter("Select f.Id FROM Facturas f WHERE f.cod_Factura = " + CodFactur + "", comando.Connection);
                DP.Fill(DS);

                idfact = DS.Tables[0].Rows[0]["Id"].ToString();

                comando.Connection = conexion.Cerrar();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public DataTable ListarDatosView(string op)
        {
            //Metodo que retorna la tabla de lista de datos dependiendo de la opcion dad

            DataTable tabla = new DataTable();

            switch (op)
            {
                case "Trabajadores":

                    //Se manda a llamar al procedimiento almacenado que lista todos los trabajadores.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "ListarTrabajadoresActivos";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    conexion.Cerrar();
                    break;

                case "Facturas":

                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "ListarFacturasActivas";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader readerr = comando.ExecuteReader();
                    tabla.Load(readerr);
                    conexion.Cerrar();
                    break;
            }

            return tabla;
        }

        public DataTable BuscarDato(string dato, string op)
        {
            //Metodo que busca a la opcion dada mediante el dato ingresado

            DataTable tabla = new DataTable();

            switch (op)
            {
                case "Trabajadores":
                    //Se selecciona a todos los trabajadores cuyo dato ingresado encaje en ellos
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "SELECT * FROM Trabajadores WHERE nom_Trabajador LIKE ('%" + dato + "%')";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    conexion.Cerrar();
                    break;

                case "Facturas":
                    //Se selecciona a todas las facturas cuyo dato ingresado encaje en ellas
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "SELECT * FROM Facturas WHERE cod_Factura LIKE ('%" + dato + "%')";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerr = comando.ExecuteReader();
                    tabla.Load(readerr);
                    conexion.Cerrar();
                    break;
            }

            return tabla;

        }

    }
}