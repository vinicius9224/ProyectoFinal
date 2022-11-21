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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    SqlDataReader readerTrab = comando.ExecuteReader();
                    tabla.Load(readerTrab);
                    conexion.Cerrar();
                    break;

                case "Facturas":
                    //Se manda a llamar al procedimiento almacenado que lista todas las facturas que aun estan vigentes.
                    comando.Connection = conexion.Abrir();
                    comando.CommandText = "ListarFacturasActivas";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader readerFact = comando.ExecuteReader();
                    tabla.Load(readerFact);
                    conexion.Cerrar();
                    break;
            }
            return tabla;
        }

        public DataTable BuscarDato(string dato, string op)
        {
            //Metodo que busca a la opcion dada mediante el dato ingresado

            DataTable Tabla = new DataTable();

            switch (op)
            {
                case "Trabajadores":
                    // abrir la db
                    comando.Connection = conexion.Abrir();
                    //hacer la consulta sql
                    comando.CommandText = "SELECT T.cod_Trabajador as[Código], T.nom_Trabajador as[Nombre], T.nom_Trabajador as[Apellido] , T.domicilio_Trabajador as[Domicilio], P.nom_Profesion as[Profesión], E.nom_EstadoTrabajador as[Estado] "
                         +"FROM Trabajadores T "
                         +"INNER JOIN Profesiones P ON P.Id = T.ProfesionId "
                         +"INNER JOIN EstadoTrabajadores E ON E.Id = T.EstadoTrabajadorId "
                         +"WHERE (T.nom_Trabajador LIKE ('%" + dato + "%') AND E.cod_EstadoTrabajador = '01') ";
                    comando.CommandType = CommandType.Text;
                    //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
                    comando.ExecuteNonQuery();
                    SqlDataAdapter reader = new SqlDataAdapter(comando);
                    reader.Fill(Tabla);
                    conexion.Cerrar();
                    break;

                case "Facturas":
                    // abrir la db
                    comando.Connection = conexion.Abrir();
                    //hacer la consulta sql
                    comando.CommandText = "SELECT F.cod_Factura as[Código], F.cantSesiones_Factura as[Sesiones_contratadas], F.costo_Factura as[Costo], F.fecha_Factura as[Fecha_emisión], A.nom_Alumno as[Alumno], E.nom_EstadoSesion as[Estado], S.nom_Servicio as[Servicio], M.nom_Modalidad as[Modalidad] "
                        + "FROM Facturas F "
                        + "INNER JOIN Alumnos A ON F.AlumnoId = A.Id "
                        + "INNER JOIN EstadoSesiones E ON F.EstadoSesionId = E.Id "
                        + "INNER JOIN Servicios S ON F.ServicioId = S.Id "
                        + "INNER JOIN Modalidades M ON F.ModalidadId = M.Id "
                        + "WHERE (E.cod_EstadoSesion = '01' AND F.cod_Factura LIKE ('%" + dato + "%')) ";
                    comando.CommandType = CommandType.Text;
                    //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
                    comando.ExecuteNonQuery();
                    // intanciar los comandos sqlClient para poder utilizar las funciones
                    SqlDataAdapter Reader = new SqlDataAdapter(comando);
                    Reader.Fill(Tabla);
                    conexion.Cerrar();
                    break;
            }
            return Tabla;
        }

        public DataTable ListSesiones(int Mes, int Año)
        {
            DataTable tabla = new DataTable();

            if (Mes==13)
            {
                comando.Connection = conexion.Abrir();
                //hacer la consulta sql
                comando.CommandText = "SELECT S.cod_Sesion as[Codigo], S.fecha_Sesion as[Fecha], cantHoras_Sesion as[Hora], A.nom_Alumno+ ' ' +A.ape_Alumno as[Alumno], T.nom_Trabajador+ ' ' + t.ape_Trabajador as[Trabajador], F.cod_Factura as[Factura] "
                    + "FROM Sesiones S "
                    + "INNER JOIN Trabajadores T ON T.Id = S.TrabajadorId "
                    + "INNER JOIN Facturas F ON F.Id = S.FacturaId "
                    + "INNER JOIN Alumnos A ON F.AlumnoId = A.Id "
                    + "ORDER BY S.fecha_Sesion DESC";
                comando.CommandType = CommandType.Text;
                //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
                comando.ExecuteNonQuery();
                // intanciar los comandos sqlClient para poder utilizar las funciones
                SqlDataAdapter Reader = new SqlDataAdapter(comando);
                Reader.Fill(tabla);
                conexion.Cerrar();
            }
            else
            {
                comando.Connection = conexion.Abrir();
                comando.CommandText = "ListarSesiones";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Mes", Mes);
                comando.Parameters.AddWithValue("@Año", Año);
                SqlDataReader reader = comando.ExecuteReader();
                tabla.Load(reader);
                comando.Parameters.Clear();
                conexion.Cerrar();
                
            }
            return tabla;
        }

    }
}