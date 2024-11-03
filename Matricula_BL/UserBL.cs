using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matricula_ADO;
using Matricula_BE;

namespace Matricula_BL
{
    public class UserBL
    {
        UserADO objUserADO = new UserADO();

        public UserBE ValidarUsuario(string strUsuario, string strContrasena)
        {
            return objUserADO.ValidarUsuario(strUsuario, strContrasena);
        }

    }
}
