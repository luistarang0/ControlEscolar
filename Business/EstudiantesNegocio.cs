using ControlEscolar.Utilities;
using System.Text.RegularExpressions;

namespace ControlEscolar.Business
{
    internal class EstudiantesNegocio
    {
        public static bool EsFormatoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo);
        }
        public static bool EsCURPValido(string curp)
        {
            return Validaciones.EsCURPValido(curp);
        }
        public static bool EsTelefonoValido(string telefono)
        {
            return Validaciones.EsTelefonoValido(telefono);
        }

        /// <summary> 
        /// Valida si el número de control es válido 
        ///Ejemplos validos: T-2021-1234, М-2021-1234 
        ///Ejemplos no validos: X-2025-123, T-25-123, M-2023-12 
        ///</summary> /
        // <param name="nocontrol">No de control a validar</param> /
        // <returns>Retorna un verdadero o falso</returns> 
        internal static bool EsNoControlValido(string nocontrol)
        {
            string patron = @"^(T|M)-\d{4}-\d{3,5}$";
            return Regex.IsMatch(nocontrol, patron);
        }
    }
}
