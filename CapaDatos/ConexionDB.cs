using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class ConexionDB
    {
        // esta clase envia a las demas clases la cadena de conexion que tenemos almacenada dentro de App.Config

        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();





    }
}
