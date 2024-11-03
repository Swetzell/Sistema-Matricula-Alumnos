using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matricula_ADO;
using Matricula_BE;

namespace Matricula_BL
{
    public class DocenteBL
    {
        DocenteADO objDocenteADO = new DocenteADO();

        public DataTable ListarDocente()
        {
            return objDocenteADO.ListarDocente();
        }
        public DataTable ListarDocenteC()
        {
            return objDocenteADO.ListarDocenteC();
        }
        public Boolean EliminarDocente(String strCodigo)
        {
            return objDocenteADO.EliminarDocente(strCodigo);
        }
        public DocenteBE ConsultarDocente(String strDocente)
        {
            return objDocenteADO.ConsultarDocente(strDocente);
        }
        public Boolean ActualizarDocente(DocenteBE objDocenteBE)
        {
            return objDocenteADO.ActualizarDocente(objDocenteBE);
        }

        public Boolean RegistrarDocente(DocenteBE objDocenteBE)
        {
            return objDocenteADO.RegistrarDocente(objDocenteBE);
        }
    }
}
