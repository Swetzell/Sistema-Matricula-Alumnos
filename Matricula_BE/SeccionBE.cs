using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BE
{
    public class SeccionBE
    {
        public String seccionNRC { get; set; }
        public String codCurso { get; set; }
        public String dniDocente { get; set; }
        public String Id_AulaDR { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public String modalidad { get; set; }
        public String diaSemana { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFin { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public String Usuario_Registro { get; set; }
        public DateTime Fecha_Ult_Modificacion { get; set; }
        public String Usuario_Ult_Modificacion { get; set; }
        public Boolean EstadoSeccion { get; set; }

        public String Modalidad { get; set; }


    }
}
