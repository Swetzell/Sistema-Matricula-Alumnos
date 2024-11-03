using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregado
using Matricula_ADO;
using Matricula_BE;

namespace Matricula_BL
{
    public class AlumnoBL
    {
        AlumnoADO objAlumnoADO = new AlumnoADO();

        public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumno();
        }
        public Boolean EliminarAlumno(String strCodigo)
        {
            return objAlumnoADO.EliminarAlumno(strCodigo);
        }
        public AlumnoBE ConsultarAlumno(String strAlumno)
        {
            return objAlumnoADO.ConsultarAlumno(strAlumno);
        }
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }

        public Boolean RegistrarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.RegistrarAlumno(objAlumnoBE);
        }
    }
}
