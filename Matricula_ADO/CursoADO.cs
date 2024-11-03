using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Matricula_BE;
using System.Security.Cryptography;
namespace Matricula_ADO

{
    public class CursoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarCursos()
        {
            DataSet dts = new DataSet();

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCursos";
                cmd.Parameters.Clear();

 
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Curso");
                return dts.Tables["Curso"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListaCarrera()
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCarreras";
                cmd.Parameters.Clear();

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Carrera");
                return dts.Tables["Carrera"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarCursos(String strCodigo)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdCurso", strCodigo);
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
        public CursoBE ConsultarCurso(String strCurso)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCursoPorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCurso", strCurso);
                cnx.Open();
                CursoBE objCursoBE = new CursoBE();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCursoBE.codCurso = dtr["CodCurso"].ToString();
                    objCursoBE.codCarrera = Convert.ToInt16(dtr["codCarrera"]);
                    objCursoBE.nomCurso = dtr["nomCurso"].ToString();
                    objCursoBE.ciclo = Convert.ToInt16(dtr["ciclo"]);
                    objCursoBE.EstadoCurso = Convert.ToBoolean(dtr["EstadoCurso"]);
                }
                else
                {
                    objCursoBE.codCurso = String.Empty;
                }
                dtr.Close();
                return objCursoBE;
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

        public Boolean ActualizarCurso (CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCurso", objCursoBE.codCurso);
                cmd.Parameters.AddWithValue("@NuevoCodCarrera", objCursoBE.codCarrera);
                cmd.Parameters.AddWithValue("@NuevoNombre", objCursoBE.nomCurso);
                cmd.Parameters.AddWithValue("@NuevoCiclo", objCursoBE.ciclo);
                cmd.Parameters.AddWithValue("@NuevoUsuarioUltModif", objCursoBE.Usuario_Ult_Modificacion);
                cmd.Parameters.AddWithValue("@NuevoEstadoCurso", objCursoBE.EstadoCurso);
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

        public Boolean RegistrarCurso(CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCarrera", objCursoBE.codCarrera);
                cmd.Parameters.AddWithValue("@nomCurso", objCursoBE.nomCurso);
                cmd.Parameters.AddWithValue("@ciclo", objCursoBE.ciclo);
                cmd.Parameters.AddWithValue("@Usuario_Registro", objCursoBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@EstadoCurso", objCursoBE.EstadoCurso);
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
