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
    public class Trabajadores
    {

        private ConexionBD conexion = new ConexionBD();

        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar_Trabajador()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "ListarTrabajadores";
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

        public void Agregar_Maestro(string cod, string nom, string ape, string domicilio, string telefono, int profesionId, int departamentoId, int municipioId, int Estado)
        {
            //abrimos la conexion
            comando.Connection = conexion.Abrir();
            // aca hacemos el transact sql (que es la consulta o el procedimiento almacenado)
            comando.CommandText = "insert into Trabajadores values ('" + cod + "','" + nom + "','" + ape + "','" + domicilio + "','" + telefono + "','" + profesionId + "','" + departamentoId + "','" + municipioId + "','" + Estado + "')";
            // aca especificamos el tipo de comando para indicar si es consulta o procedimiento almacenado
            comando.CommandType = CommandType.Text;
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
        }

        public DataTable MostrarProfesiones()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM Profesiones";
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


        public DataTable EstadoTrabajador()
        {
            DataTable tabla = new DataTable();
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "SELECT * FROM EstadoTrabajadores ";
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

        public DataTable BuscarTrabajador(string parametro)
        {

            // intanciar los comandos sqlClient para poder utilizar las funciones

            SqlCommand comando = new SqlCommand();

            // abrir la db
            comando.Connection = conexion.Abrir();

            //hacer la consulta sql
               comando.CommandText = " SELECT T.cod_Trabajador as [codigo], T.nom_Trabajador as [Nombre], T.ape_Trabajador as [Apellido], T.domicilio_Trabajador as [Domicilio],T.telefono_Trabajador as [Telefono], P.nom_Profesion as [Profesion], D.nom_Departamento[Departamento], M.nom_Municipio as [Municipio], E.nom_EstadoTrabajador as [Estado] "
                + "FROM Trabajadores T  "
                + " INNER JOIN Departamentos D ON D.Id = T.DepartamentoId"
                + " INNER JOIN Municipios M ON M.Id = T.MunicipioId "
                + " INNER JOIN Profesiones P ON P.Id = T.ProfesionId "
                + " INNER JOIN EstadoTrabajadores E ON E.Id = T.EstadoTrabajadorId "
                + " where nom_Trabajador like ('" + parametro + "%')";
            
  
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();

            // intanciar los comandos sqlClient para poder utilizar las funciones

            DataTable tabla = new DataTable();

            SqlDataAdapter ada = new SqlDataAdapter(comando);

            ada.Fill(tabla);

            conexion.Cerrar();

            return tabla;

        }

        public void Modificar_Maestro(string cod, string nom, string ape, string domicilio, string telefono, int profesionId, int departamentoId, int municipioId, int Estado,int id)
        {
            //abrimos la conexion
            comando.Connection = conexion.Abrir();

            comando.CommandText = "EditarTrabajador";

            comando.CommandType = CommandType.StoredProcedure;
            // se especifica el tipo de comando si es text o procedure
            comando.Parameters.AddWithValue("@id_Trab", id);
            comando.Parameters.AddWithValue("@Cod_Trab",cod);
            comando.Parameters.AddWithValue("@Nom_Trab", nom);
            comando.Parameters.AddWithValue("@Ape_Trab", ape);
            comando.Parameters.AddWithValue("@Domi_Trab", domicilio);
            comando.Parameters.AddWithValue("@Tel_Trab", telefono);
            comando.Parameters.AddWithValue("@Prof_Trab", profesionId);
            comando.Parameters.AddWithValue("@DepaId", departamentoId);
            comando.Parameters.AddWithValue("@MunId", municipioId);
            comando.Parameters.AddWithValue("@Est_Trab", Estado);
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
        }

        public void Eliminar_Trabajador(int id)
        {
            comando.Connection = conexion.Abrir();

            comando.CommandText = "EliminarTrabajador";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Trab", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            comando.Connection = conexion.Cerrar();

        }





    }
}
