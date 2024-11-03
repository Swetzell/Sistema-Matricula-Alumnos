using System;
using System.Data;
using System.Data.SqlClient;
using Matricula_BE;

namespace Matricula_ADO
{
    public class UserADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

       

        public UserBE ValidarUsuario(string strUsuario, string strContrasena)
        {
            UserBE objUserBE = new UserBE();

            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ValidarUsuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario", strUsuario);
            cmd.Parameters.AddWithValue("@contrasena", strContrasena);

            try
            {
                SqlParameter esValidoParam = new SqlParameter("@esValido", SqlDbType.Bit);
                esValidoParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(esValidoParam);

                cnx.Open();
                cmd.ExecuteNonQuery();

                bool esValido = Convert.ToBoolean(esValidoParam.Value);

                if (esValido)
                {
                    dtr = cmd.ExecuteReader();
                    if (dtr.HasRows)
                    {
                        dtr.Read();
                        objUserBE = new UserBE
                        {
                            User_id = dtr["User_id"].ToString(),
                            User_email = dtr["User_email"].ToString(),
                            User_password = dtr["User_password"].ToString(),
                            Fecha_Registro = Convert.ToDateTime(dtr["Fecha_Registro"]),
                            Fecha_Conexion = Convert.ToDateTime(dtr["Fecha_Conexion"]),
                            Rol = Convert.ToInt16(dtr["Rol"])
                        };
                    }
                    dtr.Close();
                }

                return objUserBE;
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
    }
}
