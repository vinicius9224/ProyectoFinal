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
    public class Alumnos
    {
        //instanciar la clase conexion a la db
        private ConexionBD conexion = new ConexionBD();

        // intanciar los comandos sqlClient para poder utilizar las funciones
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "ListarAlumnos";
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

        // en este metodo se le pasa todos los atributos para que coincidan con los de la db (en orden a como estan en la tabla por ejemplo si es varchar tiene que ser string)
        public void Agregar_Alumnos(string cod, string nom, string ape, DateTime fecha, string nomRes, string telRes, string colegio, string grado, string domiPersona, string evaluacion, int DeparId, int MuniId,int estado)
        {
            comando.Connection = conexion.Abrir();
            comando.CommandText = "AgregarAlumno";
            // se especifica el tipo de comando si es text o procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod_Alum", cod);
            comando.Parameters.AddWithValue("@Nom_Alum", nom);
            comando.Parameters.AddWithValue("@Ape_Alum", ape);
            comando.Parameters.AddWithValue("@FechaNac_Alum", fecha);
            comando.Parameters.AddWithValue("@NomResp_Alum", nomRes);
            comando.Parameters.AddWithValue("@telfResp_Alum", telRes);
            comando.Parameters.AddWithValue("@Coleg_Alum", colegio);
            comando.Parameters.AddWithValue("@gradAcad_Alum ", grado);
            comando.Parameters.AddWithValue("@Domi_Alum", domiPersona);
            comando.Parameters.AddWithValue("@Eval_Alum", evaluacion);
            comando.Parameters.AddWithValue("@DepaId", DeparId);
            comando.Parameters.AddWithValue("@MunId", MuniId);
            comando.Parameters.AddWithValue("@Est_AlumId", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.Cerrar();

        }

        public void Editar_Alumnos(string cod, string nom, string ape, DateTime fecha, string nomRes, string telRes, string colegio, string grado, string domiPersona, string evaluacion, int DeparId, int MuniId, int id,int estado)
        {
            //abrimos la conexion
            comando.Connection = conexion.Abrir();
            comando.CommandText = "EditarAlumno";
            // se especifica el tipo de comando si es text o procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Alum", id);
            comando.Parameters.AddWithValue("@Cod_Alum", cod);
            comando.Parameters.AddWithValue("@Nom_Alum", nom);
            comando.Parameters.AddWithValue("@Ape_Alum", ape);
            comando.Parameters.AddWithValue("@FechaNac_Alum", fecha);
            comando.Parameters.AddWithValue("@NomResp_Alum", nomRes);
            comando.Parameters.AddWithValue("@TelfResp_Alum", telRes);
            comando.Parameters.AddWithValue("@Coleg_Alum", colegio);
            comando.Parameters.AddWithValue("@gradAcad_Alum ", grado);
            comando.Parameters.AddWithValue("@Domi_Alum", domiPersona);
            comando.Parameters.AddWithValue("@Eval_Alum", evaluacion);
            comando.Parameters.AddWithValue("@DepaId", DeparId);
            comando.Parameters.AddWithValue("@MunId", MuniId);
            comando.Parameters.AddWithValue("@Est_AlumId", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.Cerrar();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Eliminaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Alum", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();
        }

        public DataTable Buscar(string parametro)
        {
            // intanciar los comandos sqlClient para poder utilizar las funciones
            SqlCommand comando = new SqlCommand();
            // abrir la db
            comando.Connection = conexion.Abrir();
            //hacer la consulta sql
            comando.CommandText = "SELECT A.Id, A.cod_Alumno as[Codigo], A.nom_Alumno as [Nombres] , A.ape_Alumno as [Apellidos], A.fechaNac_Alumno as [Fecha], A.nomResp_Alumno as [Responsable], A.telfResp_Alumno as [Telefono],A.colegio_Alumno as [Colegio], A.gradoAcad_Alumno as [Grado], A.domicilio_Alumno as [Domicilio], A.evaluacion_Alumno as [Evaluacion], D.nom_Departamento as [Departamento], M.nom_Municipio as [Municipio],E.EstadoAlumnoId as [Estado] "
                + "FROM Alumnos A "
                + "INNER JOIN Departamentos D ON D.Id = A.DepartamentoId "
                + "INNER JOIN Municipios M ON M.Id = A.MunicipioId " 
                + "where nom_Alumno like ('" + parametro + "%')";
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
            // intanciar los comandos sqlClient para poder utilizar las funciones
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(comando);
            ada.Fill(tabla);
            conexion.Cerrar();
            return tabla;
        }

        public DataTable MostrarDepartamentos()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM Departamentos";
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

        public DataTable MostrarMunicipios()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM Municipios";
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

        public DataTable MostrarEstado()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM EstadoAlumnos";
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



        public DataTable llenarcombo(int parametro)
        {

            // intanciar los comandos sqlClient para poder utilizar las funciones
            SqlCommand comando = new SqlCommand();
            // abrir la db
            comando.Connection = conexion.Abrir();
            //hacer la consulta sql
            comando.CommandText = " SELECT * FROM Municipios M INNER JOIN Departamentos on M.Id= Departamentos.Id where M.Id = (" + parametro + ")";
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            // intanciar los comandos sqlClient para poder utilizar las funciones
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(comando);
            ada.Fill(tabla);
            conexion.Cerrar();

            return tabla;

        }


    }
}
