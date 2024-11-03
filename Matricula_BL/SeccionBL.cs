using Matricula_ADO;
using Matricula_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BL
{
    public class SeccionBL
    {
        SeccionADO objSeccionADO = new SeccionADO();

        public DataTable ListarSecciones()
        {
            return objSeccionADO.ListarSecciones();
        }
        public DataTable ListarAula()
        {
            return objSeccionADO.ListarAula();
        }
        public Boolean EliminarSeccion(String strCodigo)
        {
            return objSeccionADO.EliminarSeccion(strCodigo);
        }
        public Boolean ActualizarSeccion(SeccionBE objSeccionBE)
        {
            return objSeccionADO.ActualizarSeccion(objSeccionBE);
        }
        public SeccionBE ConsultarSeccion(String strCurso)
        {
            return objSeccionADO.ConsultarSeccion(strCurso);
        }

        public Boolean RegistrarSeccion(SeccionBE objSeccionBE2)
        {
            return objSeccionADO.RegistrarSeccion(objSeccionBE2);
        }
    }
}
