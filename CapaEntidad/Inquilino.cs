using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Inquilino
    {
        public int IdInquilino {  get; set; }   
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }


        public ICollection<Garante> Garantes { get; set; }  // Un inquilino puede tener varios garantes



    }
}
