using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNInquilino
    {
        private CDInquilino objcd_inquilino = new CDInquilino();


        public List<Inquilino> Listar()
        {
            return objcd_inquilino.Listar();
        }



        public int Registrar(Inquilino obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.DNI == "")
            {
                Mensaje += "Ingrese el dni del inquilino\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Telefono == "")
            {
                Mensaje += "Ingrese el teléfono del inquilino\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Ingrese el nombre del inquilino\n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Ingrese el apellido del inquilino\n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_inquilino.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Inquilino obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.DNI == "")
            {
                Mensaje += "Ingrese el dni del inquilino\n";
            }                                                               // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION

            if (obj.Telefono == "")
            {
                Mensaje += "Ingrese el teléfono del inquilino\n";
            }

            if(obj.Apellido == "")
            {
                Mensaje += "Ingrese el apellido del inquilino\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Ingrese el nombre del inquilino";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_inquilino.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Inquilino obj, out string Mensaje)
        {
            return objcd_inquilino.Eliminar(obj, out Mensaje);
        }

    }
}
