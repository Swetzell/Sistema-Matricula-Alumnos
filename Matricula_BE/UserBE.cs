using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BE
{
    public class UserBE
    {
        public String User_id { get; set; }
        public String User_email { get; set; }
        public String User_password { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime Fecha_Conexion { get; set; }

        public Int16 Rol { get; set; }
    }
}
