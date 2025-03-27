using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Tipo { get; set; }
        public decimal Costo { get; set; }


        public Contrato Contrato {  get; set; }

        public int IdContrato { get; set; }

    }
}
