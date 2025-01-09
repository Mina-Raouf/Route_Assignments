using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3_Models
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(int recipient, string message)
        {
            Console.WriteLine($"Push notification sent Successfully to {recipient} \n Content : {message}");
        }
    }
}
