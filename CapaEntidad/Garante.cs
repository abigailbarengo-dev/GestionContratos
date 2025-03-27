using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Garante
    {
        public int IdGarante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Direccion {  get; set; }


        public Inquilino Inquilino { get; set; }

        public int IdInquilino { get; set; }

    }
}
