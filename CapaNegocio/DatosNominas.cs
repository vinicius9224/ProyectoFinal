using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosNominas
    {
        private Nominas nominas=new Nominas();

        public void GenerarNominas(DateTime FechaPago_Nomina, string pagoDesde_Nomina, string pagoHasta_Nomina, float SalarioNeto, float Viatico, float GastosMensuales, int TotalHoras, float PagoxHoras)
        {
            nominas.GenerarNominas( FechaPago_Nomina,  pagoDesde_Nomina,  pagoHasta_Nomina, SalarioNeto, Viatico, GastosMensuales, TotalHoras, PagoxHoras);            
        }

        //public DataTable ListarNominas()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Nominas.ListarNominas();
        //    return tabla;
        //}

        //public DataTable MostrarEgresosTotales()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Nominas.MostrarEgresosTotales();
        //    return tabla;
        //}
        public DataTable BuscarMaestros(string parametro)
        {
            DataTable tabla = new DataTable();
            tabla = nominas.Buscar(parametro);
            return tabla;
        }

    }
}
