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
    public class CDArreglo
    {
        public List<Arreglo> Listar()
        {
            List<Arreglo> lista = new List<Arreglo>();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {
                try
                {
                    string query = @"SELECT A.IdArreglo, A.TipoArreglo, A.Costo, C.IdContrato, 
                                    I.Apellido 
                             FROM Arreglo A
                             INNER JOIN Contrato C ON A.IdContrato = C.IdContrato
                             INNER JOIN Inquilino I ON C.IdInquilino = I.IdInquilino";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Arreglo()
                            {
                                IdArreglo = Convert.ToInt32(dr["IdArreglo"]),
                                TipoArreglo = dr["TipoArreglo"].ToString(),
                                Costo = Convert.ToDecimal(dr["Costo"]),
                                Contrato = new Contrato()
                                {
                                    IdContrato = Convert.ToInt32(dr["IdContrato"]),
                                    Inquilino = new Inquilino()
                                    {
                                        Apellido = dr["Apellido"].ToString()
                                    }
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Arreglo>();
                }
            }

            return lista;
        }







        // METODO REGISTRAR: PROCEDIMIENTO ALMANCENADO
        /*parametro de salida Mensaje para obtener procedimientos almacenados*/
        public int Registrar(Arreglo obj, out string Mensaje)
        {
            int idArreglogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARARREGLO", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("tipo", obj.TipoArreglo);
                    cmd.Parameters.AddWithValue("costo", obj.Costo);
                    cmd.Parameters.AddWithValue("idContrato", obj.Contrato.IdContrato);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    idArreglogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idArreglogenerado = 0;
                Mensaje = ex.Message;
            }

            return idArreglogenerado;
        }









        // METODO EDITAR: PROCEDIMIENTO ALMANCENADO
        /*el metodo ya no es int, es bool */
        public bool Editar(Arreglo obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;



            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARARREGLO", conexion);
                    cmd.Parameters.AddWithValue("idArreglo", obj.IdArreglo);
                    cmd.Parameters.AddWithValue("tipo", obj.TipoArreglo);
                    cmd.Parameters.AddWithValue("costo", obj.Costo);
                    cmd.Parameters.AddWithValue("idContrato", obj.Contrato.IdContrato);

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
        public bool Eliminar(Arreglo obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;



            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARARREGLO", conexion);
                    cmd.Parameters.AddWithValue("idArreglo", obj.IdArreglo);                             /*solo necesitamos el id para borrar*/
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