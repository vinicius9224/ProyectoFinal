using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class Facturas
    {

        public void Agregarfactura(string cod, int cant, double costo, string fecha, int alumno, int estado, int servicio, int modalidad)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();

            //abrimos la conexion
            comando.Connection = conexion.Abrir();
            // aca hacemos el transact sql (que es la consulta o el procedimiento almacenado)
            comando.CommandText = "insert into Facturas values ('" + cod + "','" + cant + "','" + costo + "','" + fecha + "','" + alumno + "','" + estado + "','" + servicio + "','" + modalidad + "')";
            // aca especificamos el tipo de comando para indicar si es consulta o procedimiento almacenado
            comando.CommandType = CommandType.Text;
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarServicios()
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();

            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM Servicios";
            // se especifica el tipo de comando si es text o procedure
            comando.CommandType = CommandType.Text;
            // comienza a leer todo lo que hay en la db y si coincide con el procedure o en la consulta todo ok
            SqlDataReader reader = comando.ExecuteReader();
            // si la tabla esta cargada con los datos leidos todo ok.
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();

            return tabla;
        }

        public DataTable Mostrarmodalidades()
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();

            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM Modalidades";
            // se especifica el tipo de comando si es text o procedure
            comando.CommandType = CommandType.Text;
            // comienza a leer todo lo que hay en la db y si coincide con el procedure o en la consulta todo ok
            SqlDataReader reader = comando.ExecuteReader();
            // si la tabla esta cargada con los datos leidos todo ok.
            tabla.Load(reader);
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();

            return tabla;
        }

        public Tuple<string> Alumno(int id)
        {
            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.Abrir();

            comando.CommandText = "select [nom_Alumno]+' '+[ape_Alumno] as Nombres from Alumnos where Id ='" + id + "'";

            string nombre = "NULL";

            SqlDataReader reader = comando.ExecuteReader();


            if (reader.Read())
            {
                nombre = reader["Nombres"].ToString();
            }
            conexion.Cerrar();
            return Tuple.Create(nombre);


        }

        public string consultarFac()
        {
            ConexionBD conexion = new ConexionBD();

            conexion.Abrir();

            string query = "select (select distinct top 1 cod_Factura from Facturas order by cod_Factura desc) +1 as cod_Factura";
            SqlCommand cmd = new SqlCommand(query,conexion.Abrir());

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {

                return reader["cod_Factura"].ToString();
            }
            else
            {

                return "NULL";
            }

            conexion.Cerrar();


        }

        public DataTable ListarDatosView(string op)
        {

            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();
            //Metodo que retorna la tabla de lista de datos dependiendo de la opcion dad
            DataTable tabla = new DataTable();

            switch (op)
            {
                case "Enero":
                    //Se manda a llamar al procedimiento almacenado que lista todos los trabajadores.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-01-01') AND FORMAT(GETDATE(),'yyyy-01-30');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerTrab = comando.ExecuteReader();
                    tabla.Load(readerTrab);
                    conexion.Cerrar();
                    break;

                case "Febrero":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-02-01') AND FORMAT(GETDATE(),'yyyy-02-01');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact1 = comando.ExecuteReader();
                    tabla.Load(readerFact1);
                    conexion.Cerrar();
                    break;

                case "Marzo":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-03-01') AND FORMAT(GETDATE(),'yyyy-03-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact2 = comando.ExecuteReader();
                    tabla.Load(readerFact2);
                    conexion.Cerrar();
                    break;
                case "Abril":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-04-01') AND FORMAT(GETDATE(),'yyyy-04-30');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact3 = comando.ExecuteReader();
                    tabla.Load(readerFact3);
                    conexion.Cerrar();
                    break;
                case "Mayo":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-05-01') AND FORMAT(GETDATE(),'yyyy-05-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact4 = comando.ExecuteReader();
                    tabla.Load(readerFact4);
                    conexion.Cerrar();
                    break;
                case "Junio":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-06-01') AND FORMAT(GETDATE(),'yyyy-06-30');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact6 = comando.ExecuteReader();
                    tabla.Load(readerFact6);
                    conexion.Cerrar();
                    break;
                case "Julio":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-07-01') AND FORMAT(GETDATE(),'yyyy-07-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact7 = comando.ExecuteReader();
                    tabla.Load(readerFact7);
                    conexion.Cerrar();
                    break;
                case "Agosto":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-08-01') AND FORMAT(GETDATE(),'yyyy-08-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact8 = comando.ExecuteReader();
                    tabla.Load(readerFact8);
                    conexion.Cerrar();
                    break;
                case "Septiembre":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-09-01') AND FORMAT(GETDATE(),'yyyy-09-30');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact9 = comando.ExecuteReader();
                    tabla.Load(readerFact9);
                    conexion.Cerrar();
                    break;

                case "Octubre":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-10-01') AND FORMAT(GETDATE(),'yyyy-10-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact10 = comando.ExecuteReader();
                    tabla.Load(readerFact10);
                    conexion.Cerrar();
                    break;

                case "Noviembre":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-11-01') AND FORMAT(GETDATE(),'yyyy-11-30');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact11 = comando.ExecuteReader();
                    tabla.Load(readerFact11);
                    conexion.Cerrar();
                    break;

                case "Diciembre":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select sum(PrecioTotal) as [total_Ingresos] from Facturas where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-12-01') AND FORMAT(GETDATE(),'yyyy-12-31');";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact12 = comando.ExecuteReader();
                    tabla.Load(readerFact12);
                    conexion.Cerrar();
                    break;


            }
            return tabla;
        }

        public DataTable ListarDatosView2(string op)
        {

            ConexionBD conexion = new ConexionBD();
            SqlCommand comando = new SqlCommand();
            //Metodo que retorna la tabla de lista de datos dependiendo de la opcion dad
            DataTable tabla = new DataTable();

            switch (op)
            {
                case "Enero":
                    //Se manda a llamar al procedimiento almacenado que lista todos los trabajadores.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "select F.cod_Factura as[#Fac], F.cantSesiones_Factura as [#Sesiones], F.fecha_Factura as[Fecha], F.precioTotal as [Total], A.nom_Alumno as [Cliente],E.nom_EstadoSesion as [Estado], S.nom_Servicio as [Servicio], M.nom_Modalidad as [Modalidad]"
                    + " FROM Facturas F "
                    + " INNER JOIN Alumnos A ON F.AlumnoId = A.Id "
                    + " INNER JOIN EstadoSesiones E ON F.EstadoSesionId = e.Id "
                    + " INNER JOIN Servicios S ON F.ServicioId = S.Id "
                    + " INNER JOIN Modalidades M ON F.ModalidadId = M.Id "
                    + " where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-11-01') AND FORMAT(GETDATE(),'yyyy-11-30') ";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    conexion.Cerrar();
                    break;

                case "Febrero":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();

                    comando.CommandText = "select F.cod_Factura, F.cantSesiones_Factura, F.costo_Factura, F.fecha_Factura, A.nom_Alumno,E.nom_EstadoSesion, S.nom_Servicio, M.nom_Modalidad"
                    + " FROM Facturas F "
                    + " INNER JOIN Alumnos A ON F.AlumnoId = A.Id "
                    + " INNER JOIN EstadoSesiones E ON F.EstadoSesionId = e.Id "
                    + " INNER JOIN Servicios S ON F.ServicioId = S.Id "
                    + " INNER JOIN Modalidades M ON F.ModalidadId = M.Id "
                    + " where fecha_Factura BETWEEN FORMAT(GETDATE(),'yyyy-02-01') AND FORMAT(GETDATE(),'yyyy-02-28') ";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader readerFact1 = comando.ExecuteReader();
                    tabla.Load(readerFact1);
                    conexion.Cerrar();
                    break;




            }
            return tabla;
        }













    }
}
