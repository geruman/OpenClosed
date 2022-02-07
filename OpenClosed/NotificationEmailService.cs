using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class NotificationEmailService:INotification
    {
        private readonly string to;
        private readonly string subject;
        public NotificationEmailService(string to, string subject)
        {
            this.to = to;
            this.subject = subject;
        }
        public async Task Notify()
        {
            await Task.Delay(1000);
            Random rand = new Random();
            await Task.Delay(rand.Next(1000));
            Console.WriteLine("Enviando mail a " + to+ " con texto:");
            Console.WriteLine(subject);
        }
    }
}
