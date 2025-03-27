using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNServicio
    {
        private CDServicio objcd_Servicio = new CDServicio();


        public List<Servicio> Listar()
        {
            return objcd_Servicio.Listar();
        }



        public int Registrar(Servicio obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Tipo == "")
            {
                Mensaje += "Ingrese el nombre del servicio a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Costo == 0)
            {
                Mensaje += "Ingrese costo del servicio a registrar\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Servicio.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Servicio obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Tipo == "")
            {
                Mensaje += "Ingrese el nombre del servicio a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Costo == 0)
            {
                Mensaje += "Ingrese costo del servicio a registrar\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Servicio.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Servicio obj, out string Mensaje)
        {
            return objcd_Servicio.Eliminar(obj, out Mensaje);
        }



    }
}
