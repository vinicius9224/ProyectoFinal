using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosTrabajadores
    {

        private Trabajadores obj = new Trabajadores();

        public void Agregar_Maestro(string cod, string nom, string ape, string domicilio, string salario, string telefono, int profesionId, int departamentoId, int municipioId, int Estado)
        {

            obj.Agregar_Maestro(cod, nom, ape, domicilio, Convert.ToDouble(salario), telefono, profesionId, departamentoId, municipioId, Estado);

        }

        public void Editar_Maestro(string cod, string nom, string ape, string domicilio, string salario, string telefono, int profesionId, int departamentoId, int municipioId, int Estado,string id)
        {

            obj.Modificar_Maestro(cod, nom, ape, domicilio, Convert.ToDouble(salario), telefono, profesionId, departamentoId, municipioId, Estado,Convert.ToInt32(id));

        }

        public void Eliminar_Trabajadores(string id)
        {

            obj.Eliminar_Trabajador(Convert.ToInt32(id));

        }


        public DataTable Mostrar_Profesiones()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.MostrarProfesiones();
            return tabla;
        }

        public DataTable Mostrar_EstadosMaestro()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.EstadoTrabajador();
            return tabla;
        }

        public DataTable Buscador(string parametro)
        {
            DataTable tabla = new DataTable();
            tabla = obj.BuscarTrabajador(parametro);
            return tabla;
        }

        public DataTable Mostrar_Trabajadores()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar_Trabajador();
            return tabla;
        }

    }
}
