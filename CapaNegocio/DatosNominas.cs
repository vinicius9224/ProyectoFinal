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

        public void GenerarNominas(DateTime FechaPago_Nomina, DateTime pagoDesde_Nomina, DateTime pagoHasta_Nomina)
        {
            nominas.GenerarNominas( FechaPago_Nomina,  pagoDesde_Nomina,  pagoHasta_Nomina);            
        }
        public void DetaNomina(string viatico,  string pago_Hora, string totalHoras, string nominaid, string sesionid)
        {
            nominas.DetalleNomina(float.Parse(viatico), float.Parse(pago_Hora), int.Parse(totalHoras),Convert.ToInt32(nominaid), Convert.ToInt32(sesionid));
        }
        //public DataTable Mostrar_Total()
        //{
        //    // instanceamos la clase datatable
        //    DataTable tabla = new DataTable();
        //    tabla = nominas.TotalHoras();
        //    return tabla;
        //}

    }
}
