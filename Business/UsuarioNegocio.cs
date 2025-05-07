using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.Utilities;

namespace ControlEscolar.Business
{
    public class UsuarioNegocio
    {
        public static bool EsCorreoValido(string correo)
        { 
            return Validaciones.EsCorreoValido(correo);
        }
    }
}
