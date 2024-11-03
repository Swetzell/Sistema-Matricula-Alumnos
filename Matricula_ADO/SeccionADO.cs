using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregado
using System.Data;
using System.Data.SqlClient;
using Matricula_BE;
namespace Matricula_ADO
{
    public class SeccionADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarSecciones()
        {
            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSecciones";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Seccion");
                return dts.Tables["Seccion"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarAula()
        {
            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAulas";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Aulas");
                return dts.Tables["Aulas"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarSeccionesPor()
        {
            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSecciones";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Seccion");
                return dts.Tables["Seccion"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarSeccion(String strCodigo)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdSeccion", strCodigo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public SeccionBE ConsultarSeccion(String strSeccion)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarSeccionPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdSeccion", strSeccion);
                cnx.Open();
                SeccionBE objSeccionBE = new SeccionBE();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objSeccionBE.seccionNRC = dtr["seccionNRC"].ToString();
                    objSeccionBE.codCurso = dtr["codCurso"].ToString();
                    objSeccionBE.dniDocente = dtr["dniDocente"].ToString();
                    objSeccionBE.Id_AulaDR = dtr["Id_AulaDR"].ToString();
                    objSeccionBE.fechaInicio = Convert.ToDateTime(dtr["fechaInicio"]);
                    objSeccionBE.fechaFinal = Convert.ToDateTime(dtr["fechaFinal"]);
                    objSeccionBE.modalidad = dtr["modalidad"].ToString();
                    objSeccionBE.diaSemana = dtr["diaSemana"].ToString();
                    objSeccionBE.horaInicio = (TimeSpan)dtr["horaInicio"];
                    objSeccionBE.horaFin = (TimeSpan)dtr["horaFin"];
                    objSeccionBE.EstadoSeccion = Convert.ToBoolean(dtr["EstadoSeccion"]);
                }
                else
                {
                    objSeccionBE.seccionNRC = String.Empty;
                }
                dtr.Close();
                return objSeccionBE;
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean ActualizarSeccion(SeccionBE objSeccionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSeccion", objSeccionBE.seccionNRC);
                cmd.Parameters.AddWithValue("@NuevoCodigoCurso", objSeccionBE.codCurso);
                cmd.Parameters.AddWithValue("@NuevoDniDocente", objSeccionBE.dniDocente);
                cmd.Parameters.AddWithValue("@NuevoIdAulaDR", objSeccionBE.Id_AulaDR);
                cmd.Parameters.AddWithValue("@NuevaFechaInicio", objSeccionBE.fechaInicio);
                cmd.Parameters.AddWithValue("@NuevaFechaFinal", objSeccionBE.fechaFinal);
                cmd.Parameters.AddWithValue("@NuevaModalidad", objSeccionBE.modalidad);
                cmd.Parameters.AddWithValue("@NuevoDiaSemana", objSeccionBE.diaSemana);
                cmd.Parameters.AddWithValue("@NuevoHoraInicio", objSeccionBE.horaInicio);
                cmd.Parameters.AddWithValue("@NuevoHoraFin", objSeccionBE.horaFin);
                cmd.Parameters.AddWithValue("@NuevoUsuarioUltModificacion", objSeccionBE.Usuario_Ult_Modificacion);
                cmd.Parameters.AddWithValue("@NuevoEstadoSeccion", objSeccionBE.EstadoSeccion);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean RegistrarSeccion(SeccionBE objSeccionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCurso", objSeccionBE.codCurso);
                cmd.Parameters.AddWithValue("@dniDocente", objSeccionBE.dniDocente);
                cmd.Parameters.AddWithValue("@Id_AulaDR", objSeccionBE.Id_AulaDR);
                cmd.Parameters.AddWithValue("@fechaInicio", objSeccionBE.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinal", objSeccionBE.fechaFinal);
                cmd.Parameters.AddWithValue("@diaSemana", objSeccionBE.diaSemana);
                cmd.Parameters.AddWithValue("@horaInicio", objSeccionBE.horaInicio);
                cmd.Parameters.AddWithValue("@horaFin", objSeccionBE.horaFin);
                cmd.Parameters.AddWithValue("@modalidad", objSeccionBE.modalidad);
                cmd.Parameters.AddWithValue("@Usuario_Registro", objSeccionBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@EstadoSeccion", objSeccionBE.EstadoSeccion);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
