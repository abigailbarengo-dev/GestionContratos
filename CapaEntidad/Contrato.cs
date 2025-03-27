using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public decimal Monto { get; set; }

        // un inquilino puede tener solo un contrato????
        public Inquilino Inquilino { get; set; }

        public int IdInquilino { get; set; }



    }
}
