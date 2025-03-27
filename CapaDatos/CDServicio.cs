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
    public class CDServicio
    {
        public List<Servicio> Listar()
        {
            List<Servicio> lista = new List<Servicio>();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {

                try
                {

                    string query = /*"SELECT IdServicio, Tipo, Costo, IdContrato FROM Servicio"*/
                        @"SELECT s.IdServicio, s.Tipo, s.Costo, C.IdContrato, 
                                    I.Apellido 
                             FROM Servicio s
                             INNER JOIN Contrato C ON s.IdContrato = C.IdContrato
                             INNER JOIN Inquilino I ON C.IdInquilino = I.IdInquilino";

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);   
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Servicio()
                            {
                                IdServicio = Convert.ToInt32(dr["IdServicio"]),
                                Tipo = dr["Tipo"].ToString(),
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
                    lista = new List<Servicio>();

                }

            }

            return lista;

        }






        // METODO REGISTRAR: PROCEDIMIENTO ALMANCENADO
        /*parametro de salida Mensaje para obtener procedimientos almacenados*/
        public int Registrar(Servicio obj, out string Mensaje)
        {
            int idServiciogenerado = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARSERVICIO", conexion);
                    cmd.Parameters.AddWithValue("tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("costo", obj.Costo);
                    cmd.Parameters.AddWithValue("idContrato", obj.Contrato.IdContrato);


                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();        /*abrimos conexion*/
                    cmd.ExecuteNonQuery();

                    idServiciogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idServiciogenerado = 0;
                Mensaje = ex.Message;

            }



            return idServiciogenerado;

        }







        // METODO EDITAR: PROCEDIMIENTO ALMANCENADO
        /*el metodo ya no es int, es bool */
        public bool Editar(Servicio obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;



            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARSERVICIO", conexion);
                    cmd.Parameters.AddWithValue("idServicio", obj.IdServicio);
                    cmd.Parameters.AddWithValue("tipo", obj.Tipo);
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
        public bool Eliminar(Servicio obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;



            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARSERVICIO", conexion);
                    cmd.Parameters.AddWithValue("idServicio", obj.IdServicio);                             /*solo necesitamos el id para borrar*/
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

