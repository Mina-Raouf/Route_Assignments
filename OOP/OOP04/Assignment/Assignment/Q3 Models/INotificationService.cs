using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3_Models
{
    internal interface INotificationService
    {
        public void SendNotification(int recipient,string  message);
    }
}
