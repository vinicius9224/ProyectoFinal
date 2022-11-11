using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosSesiones
    {
        // se hace una instancia de la clase Sesiones que esta ubicada en la capa de datos
        private Sesiones Sesiones = new Sesiones();

        public DataTable AgregarSesiones(string CodSes, DateTime FechSes, string CantHorsSes, string TrabId, string FactId)
        {
            DataTable tabla = new DataTable();
            tabla = Sesiones.AgregarSesiones(CodSes, FechSes, int.Parse(CantHorsSes), int.Parse(TrabId), int.Parse(FactId));
            return tabla;
        }

        public Boolean ValidarDatos(ref string idfact, ref string idtrab, string codTrab, string CodFactur, DateTime FechSes)
        {
            return (Sesiones.ValidarDatos(ref idfact, ref idtrab, codTrab, CodFactur, FechSes));
        }

        public DataTable ListarDatosView(string op)
        {
            DataTable tabla = new DataTable();
            tabla = Sesiones.ListarDatosView(op);
            return tabla;
        }

        public DataTable BuscarDato(string dato, string op)
        {
            DataTable tabla = new DataTable();
            tabla = Sesiones.BuscarDato(dato, op);
            return tabla;
        }

    }
}
