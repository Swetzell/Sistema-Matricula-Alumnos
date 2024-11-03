using Matricula_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula_BL
{
    public class UbigeoBL
    {
        UbigeoADO objUbigeoADO = new UbigeoADO();
        
        public DataTable Ubigeo_Departamentos() {
            return objUbigeoADO.Ubigeo_Departamentos(); 
        }

        public DataTable Ubigeo_ProvinciasDepartamentos(String strIdDepartamento)
        {
            return objUbigeoADO.Ubigeo_ProvinciasDepartamento(strIdDepartamento);
        }
        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            return objUbigeoADO.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);
        }
    }
}
