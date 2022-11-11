using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosAlumnos
    {
        // se hace una instancia de la clase alumno que esta ubicada en la capa de datos
        private Alumnos obj = new Alumnos();
        // con este metodo se puede mostrar todo los registros que estan en la consulta o prodecimiento que se detallo en la capa de datos
        public DataTable Mostrar_completo()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar();
            return tabla;
        }
        // agregamos los registros esto ya es para enviarselo mas facil a la capa de presentacion
        public void AgregarAlumno(string cod, string nom, string ape, string fecha, string nomRes, string telRes, string colegio, string grado, string domiPersona, string evaluacion, int DeparId, int MuniId)
        {
            obj.Agregar_Alumnos(cod, nom, ape, fecha, nomRes, telRes, colegio, grado, domiPersona, evaluacion, DeparId, MuniId);
        }

        public void Editar_Alumnos(string cod, string nom, string ape, string fecha, string nomRes, string telRes, string colegio, string grado, string domiPersona, string evaluacion, int DeparId, int MuniId, string id)
        {
            obj.Editar_Alumnos(cod, nom, ape, Convert.ToDateTime(fecha), nomRes, telRes, colegio, grado, domiPersona, evaluacion, DeparId, MuniId, Convert.ToInt32(id));
        }

        public void Eliminar_Alumnos(string id)
        {

            obj.Eliminar(Convert.ToInt32(id));

        }

        public DataTable Buscadir(string parametro)
        {
            DataTable tabla = new DataTable();
            tabla = obj.Buscar(parametro);
            return tabla;
        }

        public DataTable Mostrar_Depar()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.MostrarDepartamentos();
            return tabla;
        }

        public DataTable Mostrar_Muni()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.MostrarMunicipios();
            return tabla;
        }

        public DataTable Combox(int parametro)
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.llenarcombo(parametro);
            return tabla;
        }
    }
}
