using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNArreglo
    {
        private CDArreglo objcd_Arreglo = new CDArreglo();

                                                // arreglar servicio y arreglo editar e id contrato aparece en 0
        public List<Arreglo> Listar()
        {
            return objcd_Arreglo.Listar();
        }



        public int Registrar(Arreglo obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.TipoArreglo == "")
            {
                Mensaje += "Ingrese el nombre del arreglo a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Costo == 0)
            {
                Mensaje += "Ingrese costo del arreglo a registrar\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Arreglo.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Arreglo obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.TipoArreglo == "")
            {
                Mensaje += "Ingrese el nombre del arreglo a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Costo == 0)
            {
                Mensaje += "Ingrese costo del arreglo a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Arreglo.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Arreglo obj, out string Mensaje)
        {
            return objcd_Arreglo.Eliminar(obj, out Mensaje);
        }



    }
}
