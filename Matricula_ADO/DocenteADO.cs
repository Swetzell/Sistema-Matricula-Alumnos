using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Matricula_BE;
namespace Matricula_ADO
{
    public class DocenteADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarDocente()
        {

            try
            { 
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDocentes";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Docente");
                return dts.Tables["Docente"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarDocenteC()
        {

            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDocentesCompleto";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Docente");
                return dts.Tables["Docente"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarDocente(String strCodigo)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarDocente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", strCodigo);
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
        public DocenteBE ConsultarDocente(String strDocente)
        {
            try
            {
                DocenteBE objDocenteBE = new DocenteBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarDocentePorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDocente", strDocente);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDocenteBE.dniDocente = dtr["Dni"].ToString();
                    objDocenteBE.nombreDoc = dtr["Nombre"].ToString();
                    objDocenteBE.FotoDocente = dtr["Foto"].ToString();
                    objDocenteBE.apellidoDoc = dtr["Apellido"].ToString();
                    objDocenteBE.generoDoc = dtr["Genero"].ToString();
                    objDocenteBE.fechaNacimiento = Convert.ToDateTime(dtr["Fecha_Nacimiento"]);
                    objDocenteBE.correoDoc = dtr["Correo"].ToString();
                    objDocenteBE.celularDoc = Convert.ToInt64(dtr["Celular"]);
                    objDocenteBE.DireccionDomicilio = dtr["Direccion"].ToString();
                    objDocenteBE.idDepartamento = dtr["IdDepa"].ToString();
                    objDocenteBE.idProvincia = dtr["IdProv"].ToString();
                    objDocenteBE.idDistrito = dtr["IdDist"].ToString();
                    objDocenteBE.EstadoDoc = Convert.ToBoolean(dtr["Estado"]);
                    objDocenteBE.codCarrera = Convert.ToInt64(dtr["Carrera"]);
                }
                else
                {
                    objDocenteBE.dniDocente = String.Empty;
                }
                dtr.Close();

                return objDocenteBE;
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
        public Boolean ActualizarDocente(DocenteBE objDocenteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarDocente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDocente", objDocenteBE.dniDocente);
                cmd.Parameters.AddWithValue("@NuevoNombre", objDocenteBE.nombreDoc);
                cmd.Parameters.AddWithValue("@NuevoApellido", objDocenteBE.apellidoDoc);
                cmd.Parameters.AddWithValue("@Foto", objDocenteBE.FotoDocente);
                cmd.Parameters.AddWithValue("@NuevoCorreo", objDocenteBE.correoDoc);
                cmd.Parameters.AddWithValue("@NuevoGenero", objDocenteBE.generoDoc);
                cmd.Parameters.AddWithValue("@NuevaFechaNacimiento", objDocenteBE.fechaNacimiento);
                cmd.Parameters.AddWithValue("@NuevoCelular", objDocenteBE.celularDoc);
                cmd.Parameters.AddWithValue("@IdDepartamento", objDocenteBE.idDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", objDocenteBE.idProvincia);
                cmd.Parameters.AddWithValue("@idDistrito", objDocenteBE.idDistrito);
                cmd.Parameters.AddWithValue("@NuevaDireccionDomicilio", objDocenteBE.DireccionDomicilio);
                cmd.Parameters.AddWithValue("@NuevoUsuario_Ult_Modificacion", objDocenteBE.Usuario_Ult_Modificacion);
                cmd.Parameters.AddWithValue("@NuevoEstadoDoc", objDocenteBE.EstadoDoc);
                cmd.Parameters.AddWithValue("@NuevoCodCarrera", objDocenteBE.codCarrera);
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

        public Boolean RegistrarDocente(DocenteBE objDocenteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarDocente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDocente", objDocenteBE.dniDocente);
                cmd.Parameters.AddWithValue("@Nombre", objDocenteBE.nombreDoc);
                cmd.Parameters.AddWithValue("@Apellido", objDocenteBE.apellidoDoc);
                cmd.Parameters.AddWithValue("@Correo", objDocenteBE.correoDoc);
                cmd.Parameters.AddWithValue("@Genero", objDocenteBE.generoDoc);
                cmd.Parameters.AddWithValue("@FechaNacimiento", objDocenteBE.fechaNacimiento);
                cmd.Parameters.AddWithValue("@Celular", objDocenteBE.celularDoc);
                cmd.Parameters.AddWithValue("@IdUbigeo", objDocenteBE.idUbigeo);
                cmd.Parameters.AddWithValue("@DireccionDomicilio", objDocenteBE.DireccionDomicilio);
                cmd.Parameters.AddWithValue("@FotoDocente", objDocenteBE.FotoDocente);
                cmd.Parameters.AddWithValue("@Usuario_Registro", objDocenteBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@EstadoDoc", objDocenteBE.EstadoDoc);
                cmd.Parameters.AddWithValue("@CodCarrera", objDocenteBE.codCarrera);
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
