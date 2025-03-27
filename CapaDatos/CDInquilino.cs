using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDInquilino
    {
        public List<Inquilino> Listar()
        {
            List<Inquilino> lista = new List<Inquilino>();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {

                try
                {
                                       // con esta sentencia los datos se pasan del dgv a la base y viceversa
                    string query = "select IdInquilino, Nombre, Apellido, Telefono, DNI from Inquilino;";
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Inquilino()
                            {
                                IdInquilino = Convert.ToInt32(dr["IdInquilino"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                DNI = dr["DNI"].ToString()
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Inquilino>();

                }

            }

            return lista;

        }






        // METODO REGISTRAR: PROCEDIMIENTO ALMANCENADO
        /*parametro de salida Mensaje para obtener procedimientos almacenados*/
        public int Registrar(Inquilino obj, out string Mensaje)
        {
            int idinquilinogenerado = 0;
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
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARINQUILINO", conexion);
                    cmd.Parameters.AddWithValue("nombreInquilino", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellidoInquilino", obj.Apellido);
                    cmd.Parameters.AddWithValue("telefonoInquilino", obj.Telefono);
                    cmd.Parameters.AddWithValue("dniInquilino", obj.DNI);               /*parametros de entrada de procedimientos almacenados*/

                    cmd.Parameters.Add("idInquilinoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();        /*abrimos conexion*/
                    cmd.ExecuteNonQuery();

                    idinquilinogenerado = Convert.ToInt32(cmd.Parameters["idInquilinoResultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();   

                }
            }
            catch(Exception ex)
            {
                idinquilinogenerado = 0;
                Mensaje = ex.Message;

            }



            return idinquilinogenerado;

        }







        // METODO EDITAR: PROCEDIMIENTO ALMANCENADO
        /*el metodo ya no es int, es bool */
        public bool Editar(Inquilino obj, out string Mensaje)
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
                    SqlCommand cmd = new SqlCommand("SP_EDITARINQUILINO", conexion);
                    cmd.Parameters.AddWithValue("idInquilino", obj.IdInquilino);
                    cmd.Parameters.AddWithValue("nombreInquilino", obj.Nombre);
                    cmd.Parameters.AddWithValue("apellidoInquilino", obj.Apellido);
                    cmd.Parameters.AddWithValue("telefonoInquilino", obj.Telefono);
                    cmd.Parameters.AddWithValue("dniInquilino", obj.DNI);               /*parametros de entrada de procedimientos almacenados*/

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);   /*todos los datos se almacenan en esta variable*/
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
        public bool Eliminar(Inquilino obj, out string Mensaje)
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
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARINQUILINO", conexion);
                    cmd.Parameters.AddWithValue("idInquilino", obj.IdInquilino);                             /*solo necesitamos el id para borrar*/
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;        
                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);   /*todos los datos se almacenan en esta variable*/
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
