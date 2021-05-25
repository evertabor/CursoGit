using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Interfaces
{
    public abstract class NotificacionAbstract
    {
        public abstract string EnviarMensaje(string mensaje);
        public string SolicitarClave(string usuario)
        {
            return $"La clave del {usuario} es: 1234";
        }
    }
}
