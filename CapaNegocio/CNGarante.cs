using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNGarante
    {
        private CDGarante objcd_garante = new CDGarante();


        public List<Garante> Listar()
        {
            return objcd_garante.Listar();
        }

        

        public int Registrar(Garante obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Apellido == "" && obj.Mail == "" && obj.Nombre == "" && obj.Direccion == "" && obj.Telefono == "")
            {
                Mensaje += "¡Debe llenar los campos!";
            }
            else if (obj.Nombre == "") 
            {
                Mensaje += "Ingrese el nombre del garante\n";
            }
            else if (obj.Apellido == "")
            {
                Mensaje += "Ingrese el apellido del garante\n";
            }
            else if (obj.Mail == "")
            {
                Mensaje += "Ingrese el mail del garante\n";
            }                                                                // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION
            else if (obj.Telefono == "")
            {
                Mensaje += "Ingrese el teléfono del garante\n";
            }
            else if (obj.Direccion == "")
            {
                Mensaje += "Ingrese la dirección del garante\n";
            }
            
            
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_garante.Registrar(obj, out Mensaje);
            }


        }

        public bool Editar(Garante obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Apellido == "" && obj.Mail == "" && obj.Nombre == "" && obj.Direccion == "" && obj.Telefono == "")
            {
                Mensaje += "¡Debe llenar los campos!";
            }
            else if (obj.Nombre == "")
            {
                Mensaje += "Ingrese el nombre del garante\n";
            }
            else if (obj.Apellido == "")
            {
                Mensaje += "Ingrese el apellido del garante\n";
            }
            else if (obj.Mail == "")
            {
                Mensaje += "Ingrese el mail del garante\n";
            }                                                                // ALGUNAS REGLAS, OTRAS EN CAPA DE PRESENTACION
            else if (obj.Telefono == "")
            {
                Mensaje += "Ingrese el teléfono del garante\n";
            }
            else if (obj.Direccion == "")
            {
                Mensaje += "Ingrese la dirección del garante\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_garante.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Garante obj, out string Mensaje)
        {
            return objcd_garante.Eliminar(obj, out Mensaje);
        }




    }
}
