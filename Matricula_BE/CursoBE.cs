using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BE
{
    public class CursoBE
    {
        public String codCurso { get; set; }
        public Int16 codCarrera { get; set; }
        public String nomCarrera { get; set; }
        public String nomCurso { get; set; }
        public Int16 ciclo { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public String Usuario_Registro { get; set; }
        public DateTime Fecha_Ult_Modificacion { get; set; }
        public String Usuario_Ult_Modificacion { get; set; }
        public Boolean EstadoCurso { get; set; }


    }
}
