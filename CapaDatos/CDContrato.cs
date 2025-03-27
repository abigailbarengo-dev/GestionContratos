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
    public class CDContrato
    {
        public List<Contrato> Listar()
        {
            List<Contrato> lista = new List<Contrato>();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {

                try
                {
                                                                             
                    string query = "SELECT \r\n    c.IdContrato, \r\n    c.FechaInicio, \r\n    c.FechaFin, \r\n    c.Monto, \r\n    \r\n    c.IdInquilino,\r\n    i.Apellido AS ApellidoInquilino\r\nFROM \r\n    Contrato c\r\nLEFT JOIN \r\n    Inquilino i ON c.IdInquilino = i.IdInquilino;\r\n";
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);            // verificar cadena para ver si anda
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Contrato()
                            {
                                IdContrato = Convert.ToInt32(dr["IdContrato"]),
                                FechaInicio = Convert.ToDateTime(dr["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(dr["FechaFin"]),
                                Monto = Convert.ToDecimal(dr["Monto"]),
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
                    lista = new List<Contrato>();

                }

            }

            return lista;

        }






        // METODO REGISTRAR: PROCEDIMIENTO ALMANCENADO
        /*parametro de salida Mensaje para obtener procedimientos almacenados*/
        public int Registrar(Contrato obj, out string Mensaje)
        {
            int idContratogenerado = 0;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCONTRATO", conexion);
                    cmd.Parameters.AddWithValue("fechaInicio", obj.FechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", obj.FechaFin);
                    cmd.Parameters.AddWithValue("montoContrato", obj.Monto);
                    cmd.Parameters.AddWithValue("idInquilino", obj.Inquilino.IdInquilino);


                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;             /*parametros de salida */

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();        /*abrimos conexion*/
                    cmd.ExecuteNonQuery();

                    idContratogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);   /*todos los datos se almacenan en esta variable*/
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idContratogenerado = 0;
                Mensaje = ex.Message;

            }



            return idContratogenerado;

        }







        // METODO EDITAR: PROCEDIMIENTO ALMANCENADO
        /*el metodo ya no es int, es bool */
        public bool Editar(Contrato obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCONTRATO", conexion);
                    cmd.Parameters.AddWithValue("idContrato", obj.IdContrato);
                    cmd.Parameters.AddWithValue("fechaInicio", obj.FechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", obj.FechaFin);
                    cmd.Parameters.AddWithValue("montoContrato", obj.Monto);
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
        public bool Eliminar(Contrato obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCONTRATO", conexion);
                    cmd.Parameters.AddWithValue("idContrato", obj.IdContrato);                             /*solo necesitamos el id para borrar*/
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

