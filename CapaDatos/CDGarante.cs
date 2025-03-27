using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaDatos
{
    public class CDGarante
    {
        public List<Garante> Listar()
        {
            List<Garante> lista = new List<Garante>();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {

                try
                {
                    // con esta sentencia los datos se pasan del dgv a la base y viceversa             ERROR RESUELTO, apellidos ahora se muestran en DGV
                    string query = "SELECT \r\n    g.IdGarante, \r\n    g.Nombre, \r\n    g.Apellido, \r\n    g.Telefono, \r\n    g.Mail, \r\n    g.Direccion, \r\n    g.IdInquilino,\r\n    i.Apellido AS ApellidoInquilino\r\nFROM \r\n    Garante g\r\nLEFT JOIN \r\n    Inquilino i ON g.IdInquilino = i.IdInquilino;\r\n";
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
 
                        while (dr.Read())
                        {
                            lista.Add(new Garante()
                            {
                                IdGarante = Convert.ToInt32(dr["IdGarante"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Mail = dr["Mail"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Inquilino = new Inquilino()
                                {
                                    IdInquilino = dr["IdInquilino"] != DBNull.Value ? Convert.ToInt32(dr["IdInquilino"]) : 0,       // error resuelto: no aparecian apellidos en DGV
                                    Apellido = dr["ApellidoInquilino"] != DBNull.Value ? dr["ApellidoInquilino"].ToString() : "No asignado"
                                }
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Garante>();

                }

            }

            return lista;

        }






        // METODO REGISTRAR: PROCEDIMIENTO ALMANCENADO
        /*parametro de salida Mensaje para obtener procedimientos almacenados*/
        public int Registrar(Garante obj, out string Mensaje)
        {
            int idgarantegenerado = 0;
            Mensaje = string.Empty;


            /*create PROC SP_REGISTRARINQUILINO(

                @nombreInquilino varchar(50),
                @apellidoInquilino varchar(50),	
                @telefonoInquilino varchar(50),
                @dniInquilino varchar(50),
                @idInquilinoResultado int output,
                @Mensaje varchar(500) output)
            */



            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARGARANTE", conexion);
                    cmd.Parameters.AddWithValue("nombreGarante", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellidoGarante", obj.Apellido);
                    cmd.Parameters.AddWithValue("telefonoGarante", obj.Telefono);
                    cmd.Parameters.AddWithValue("mailGarante", obj.Mail);
                    cmd.Parameters.AddWithValue("direccionGarante", obj.Direccion);
                    cmd.Parameters.AddWithValue("idInquilino", obj.Inquilino.IdInquilino);


                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();        /*abrimos conexion*/
                    cmd.ExecuteNonQuery();

                    idgarantegenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idgarantegenerado = 0;
                Mensaje = ex.Message;

            }



            return idgarantegenerado;

        }







        // METODO EDITAR: PROCEDIMIENTO ALMANCENADO
        /*el metodo ya no es int, es bool */
        public bool Editar(Garante obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            /*create PROC SP_REGISTRARINQUILINO(

                @idInquilino int,
                @nombreInquilino varchar(50),
                @apellidoInquilino varchar(50),	
                @telefonoInquilino varchar(50),
                @dniInquilino varchar(50),
                @idInquilinoResultado int output,
                @Mensaje varchar(500) output)
            */


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARGARANTE", conexion);
                    cmd.Parameters.AddWithValue("idGarante", obj.IdGarante);
                    cmd.Parameters.AddWithValue("nombreGarante", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellidoGarante", obj.Apellido);
                    cmd.Parameters.AddWithValue("telefonoGarante", obj.Telefono);
                    cmd.Parameters.AddWithValue("mailGarante", obj.Mail);
                    cmd.Parameters.AddWithValue("direccionGarante", obj.Direccion);          /*parametros de entrada de procedimientos almacenados*/
                    cmd.Parameters.AddWithValue("idInquilino", obj.Inquilino.IdInquilino);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;

            }

            return respuesta;

        }






        // METODO ELIMINAR: PROCEDIMIENTO ALMACENADO (tmb booleano)
        public bool Eliminar(Garante obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            /*create PROC SP_REGISTRARINQUILINO(

                @idInquilino int,
                @nombreInquilino varchar(50),
                @apellidoInquilino varchar(50),	
                @telefonoInquilino varchar(50),
                @dniInquilino varchar(50),
                @idInquilinoResultado int output,
                @Mensaje varchar(500) output)
            */


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARGARANTE", conexion);
                    cmd.Parameters.AddWithValue("idGarante", obj.IdGarante);                             /*solo necesitamos el id para borrar*/
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;

            }



            return respuesta;

        }


    }


}

