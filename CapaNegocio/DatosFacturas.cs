using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosFacturas
    {

        private Facturas obj = new Facturas();


        public string Facturas()
        {
            return obj.consultarFac();
        }


        public Tuple <string> alumnos (int id)
        {

            return obj.Alumno(id);
        }

        public void datosfact(string cod, string cant, string costo, DateTime fecha, string alumno, string estado, string servicio, string modalidad)
        {
            obj.Agregarfactura(cod, Convert.ToInt32(cant), Convert.ToDouble(costo), fecha, Convert.ToInt32(alumno), Convert.ToInt32(estado), Convert.ToInt32(servicio), Convert.ToInt32(modalidad));
        }

        public DataTable Serviciosfac()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarServicios();
            return tabla;
        }

        public DataTable Modalidadesfac()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrarmodalidades();
            return tabla;
        }

        public DataTable ListarDatosView1(string op)
        {
            DataTable tabla = new DataTable();
            tabla = obj.ListarDatosView(op);
            return tabla;
        }

        public DataTable ListarDatosViewdetalles(string op)
        {
            DataTable tabla = new DataTable();
            tabla = obj.ListarDatosView2(op);
            return tabla;
        }


        public DataTable ListarestSesion()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarestadoSesiones();
            return tabla;
        }





    }
}
