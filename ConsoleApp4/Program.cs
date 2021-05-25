using ConsoleApp4.Clases;
using ConsoleApp4.Interfaces;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Empty;
            INotificacion notificacion = new Outlook();


            result = notificacion.EnviarNoficacion("Ever");
            Console.WriteLine(result);



            NotificacionAbstract facebook = new Facebook();

            result = facebook.EnviarMensaje("Helloooo!");

            Console.WriteLine(result);

            result = facebook.SolicitarClave("admin");

            Console.WriteLine(result);
        }
    }
}
