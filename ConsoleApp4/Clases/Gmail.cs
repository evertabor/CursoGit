using ConsoleApp4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    public class Gmail : INotificacion
    {
        public string EnviarNoficacion(string message)
        {
            return $"Notificacion enviada desde Gmail {message}";
        }
    }
}
