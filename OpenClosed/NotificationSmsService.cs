using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class NotificationSmsService:INotification
    {
        private readonly string phoneNumber;
        private readonly string subject;
        public NotificationSmsService(string phoneNumber, string subject)
        {
            this.phoneNumber = phoneNumber;
            this.subject = subject;
        }
        public async Task Notify()
        {
            await Task.Delay(1000);
            Random rand = new Random();
            await Task.Delay(rand.Next(1000));
            Console.WriteLine("Enviando sms a " + phoneNumber + " con texto:");
            Console.WriteLine(subject);
        }

    }
}
