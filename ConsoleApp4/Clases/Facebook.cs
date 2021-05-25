using ConsoleApp4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    public class Facebook : NotificacionAbstract
    {
        public override string EnviarMensaje(string mensaje)
        {
            return $"El mensaje enviado fue: {mensaje} desde Facebook";
        }
     
    }
}
