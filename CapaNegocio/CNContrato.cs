using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNContrato
    {
        private CDContrato objcd_contrato = new CDContrato();


        public List<Contrato> Listar()
        {
            return objcd_contrato.Listar();
        }



        public int Registrar(Contrato obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Monto == 0)
            {
                Mensaje += "Ingrese el monto del contrato de alquiler\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_contrato.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Contrato obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Monto == 0)
            {
                Mensaje += "Ingrese el monto del contrato de alquiler\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_contrato.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Contrato obj, out string Mensaje)
        {
            return objcd_contrato.Eliminar(obj, out Mensaje);
        }




    }
}
