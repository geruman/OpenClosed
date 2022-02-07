using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<INotification> notificaciones = new List<INotification>
            {
                new NotificationEmailService("german@nowhere.com","El motivo del correo"),
                new NotificationSmsService("+54234234234","El asunto del mensaje de texto")
            };
            NotificationService service = new NotificationService();
            service.Send(notificaciones);
            Console.ReadKey();
        }
    }
}
