using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BE
{
    public class DocenteBE
    {
            public String dniDocente { get; set; }
            public String FotoDocente { get; set; }
            public String nombreDoc { get; set; }
            public String apellidoDoc { get; set; }
            public String generoDoc { get; set; }
            public DateTime fechaNacimiento { get; set; }
            public String correoDoc { get; set; }
            public Int64 celularDoc { get; set; }
            public String idUbigeo { get; set; }
            public String idDepartamento { get; set; }
            public String idProvincia { get; set; }
            public String idDistrito { get; set; }
            public Int64 codCarrera { get; set; }
            public String DireccionDomicilio { get; set; }
            public DateTime Fecha_Registro { get; set; }
            public String Usuario_Registro { get; set; }
            public DateTime Fecha_Ult_Modificacion { get; set; }
            public String Usuario_Ult_Modificacion { get; set; }
            public Boolean EstadoDoc { get; set; }
    }
}
