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
    public class CursoBL
    {
        CursoADO objCursoADO = new CursoADO();

        public DataTable ListarCursos()
        {
            return objCursoADO.ListarCursos();
        }
        public Boolean EliminarCursos(String strCodigo)
        {
            return objCursoADO.EliminarCursos(strCodigo);
        }
        public Boolean ActualizarCurso(CursoBE objCursoBE)
        {
            return objCursoADO.ActualizarCurso(objCursoBE);
        }
        public CursoBE ConsultarCurso(String strCurso)
        {
            return objCursoADO.ConsultarCurso(strCurso);
        }

        public DataTable ListaCarreras()
        {
            return objCursoADO.ListaCarrera();
        }

        public Boolean RegistrarCurso(CursoBE strCurso)
        {
            return objCursoADO.RegistrarCurso(strCurso);
        }

    }
}
