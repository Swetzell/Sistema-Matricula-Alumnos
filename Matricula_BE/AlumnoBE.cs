using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BE
{
    public class AlumnoBE
    {
        public String dniAlum { get; set; }
        public String foto { get; set; }
        public String nombreAlum { get; set; }
        public String apellidolAlum { get; set; }
        public String generoAlum { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String correoAlum { get; set; }
        public Int64 celularAlum { get; set; }
        public String DireccionDomicilio { get; set; }
        public Boolean certificadoAlum { get; set; }
        public String idUbigeo { get; set; }

        public String idDepartamento { get; set; }
        public String idProvincia { get; set; }
        public String idDistrito { get; set; }
        public Int64 codCarrera { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public String Usuario_Registro { get; set; }
        public DateTime Fecha_Ult_Modificacion { get; set; }
        public String Usuario_Ult_Modificacion { get; set; }
        public Boolean EstadoAlum { get; set; }

    }
}
