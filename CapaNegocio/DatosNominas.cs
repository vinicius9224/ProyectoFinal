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

        public void GenerarNominas(DateTime FechaPago_Nomina, string pagoDesde_Nomina, string pagoHasta_Nomina, string desc_Nomina)
        {
            DataTable tabla = new DataTable();
            tabla = nominas.GenerarNominas( FechaPago_Nomina,  pagoDesde_Nomina,  pagoHasta_Nomina,  desc_Nomina);            
        }

        //public DataTable ListarNominas()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Nominas.ListarNominas();
        //    return tabla;
        //}

        //public DataTable MostrarIngresosTotales()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = Nominas.MostrarIngresosTotales();
        //    return tabla;
        //}

    }
}
