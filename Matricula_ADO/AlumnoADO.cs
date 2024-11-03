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
    public class AlumnoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarAlumno()
        {

            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();//obtenemos la cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAlumnos";
                cmd.Parameters.Clear();

                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Alumno");
                return dts.Tables["Alumno"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarAlumno(String strCodigo)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarAlumno";
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

        public AlumnoBE ConsultarAlumno(String strAlumno)
        {
            try
            {
                AlumnoBE objAlumnoBE = new AlumnoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAlumnoPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlumno", strAlumno);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objAlumnoBE.dniAlum = dtr["Dni"].ToString();
                    objAlumnoBE.nombreAlum = dtr["Nombre"].ToString();
                    objAlumnoBE.apellidolAlum = dtr["Apellido"].ToString();
                    objAlumnoBE.generoAlum = dtr["Genero"].ToString();
                    objAlumnoBE.foto = dtr["foto"].ToString();
                    objAlumnoBE.fechaNacimiento = Convert.ToDateTime(dtr["Fecha_Nacimiento"]);
                    objAlumnoBE.correoAlum = dtr["Correo"].ToString();
                    objAlumnoBE.celularAlum = Convert.ToInt64(dtr["Celular"]);
                    objAlumnoBE.DireccionDomicilio = dtr["Direccion"].ToString();
                    objAlumnoBE.idDepartamento = dtr["IdDepa"].ToString();
                    objAlumnoBE.idProvincia = dtr["IdProv"].ToString();
                    objAlumnoBE.idDistrito = dtr["IdDist"].ToString();
                    objAlumnoBE.codCarrera = Convert.ToInt64(dtr["Carrera"]);
                    objAlumnoBE.certificadoAlum = Convert.ToBoolean(dtr["Certificado"]);
                    objAlumnoBE.EstadoAlum = Convert.ToBoolean(dtr["Estado"]);
                }
                else
                {
                    objAlumnoBE.dniAlum = String.Empty;
                }
                dtr.Close();

                return objAlumnoBE;
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
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlumno", objAlumnoBE.dniAlum);
                cmd.Parameters.AddWithValue("@NuevoNombre", objAlumnoBE.nombreAlum);
                cmd.Parameters.AddWithValue("@foto", objAlumnoBE.foto);
                cmd.Parameters.AddWithValue("@NuevoApellido", objAlumnoBE.apellidolAlum);
                cmd.Parameters.AddWithValue("@NuevoGenero", objAlumnoBE.generoAlum);
                cmd.Parameters.AddWithValue("@NuevaFechaNacimiento", objAlumnoBE.fechaNacimiento);
                cmd.Parameters.AddWithValue("@NuevoCorreo", objAlumnoBE.correoAlum);
                cmd.Parameters.AddWithValue("@NuevoCelular", objAlumnoBE.celularAlum);
                cmd.Parameters.AddWithValue("@NuevoCertificado", objAlumnoBE.certificadoAlum);
                cmd.Parameters.AddWithValue("@IdDepartamento", objAlumnoBE.idDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", objAlumnoBE.idProvincia);
                cmd.Parameters.AddWithValue("@IdDistrito", objAlumnoBE.idProvincia);
                cmd.Parameters.AddWithValue("@NuevoCodCarrera", objAlumnoBE.codCarrera);
                cmd.Parameters.AddWithValue("@NuevaDireccionDomicilio", objAlumnoBE.DireccionDomicilio);
                cmd.Parameters.AddWithValue("@NuevoUsuarioUltimaModificacion", objAlumnoBE.Usuario_Ult_Modificacion);
                cmd.Parameters.AddWithValue("@NuevoEstado", objAlumnoBE.EstadoAlum);
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


        public Boolean RegistrarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dniAlum", objAlumnoBE.dniAlum);
                cmd.Parameters.AddWithValue("@foto", objAlumnoBE.foto);
                cmd.Parameters.AddWithValue("@nombreAlum", objAlumnoBE.nombreAlum);
                cmd.Parameters.AddWithValue("@apellidolAlum", objAlumnoBE.apellidolAlum);
                cmd.Parameters.AddWithValue("@generoAlum", objAlumnoBE.generoAlum);
                cmd.Parameters.AddWithValue("@fechaNacimiento", objAlumnoBE.fechaNacimiento);
                cmd.Parameters.AddWithValue("@correoAlum", objAlumnoBE.correoAlum);
                cmd.Parameters.AddWithValue("@celularAlum", objAlumnoBE.celularAlum);
                cmd.Parameters.AddWithValue("@certificadoAlum", objAlumnoBE.certificadoAlum);
                cmd.Parameters.AddWithValue("@Departamento", objAlumnoBE.idDepartamento);
                cmd.Parameters.AddWithValue("@Provincia", objAlumnoBE.idProvincia);
                cmd.Parameters.AddWithValue("@Distrito", objAlumnoBE.idDistrito);
                cmd.Parameters.AddWithValue("@codCarrera", objAlumnoBE.codCarrera);
                cmd.Parameters.AddWithValue("@DireccionDomicilio", objAlumnoBE.DireccionDomicilio);
                cmd.Parameters.AddWithValue("@Usuario_Registro", objAlumnoBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@EstadoAlum", objAlumnoBE.EstadoAlum);
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
