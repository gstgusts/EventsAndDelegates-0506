using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_0506
{
    public class Order
    {
        public void Create()
        {
            Console.WriteLine("Order created");
            EmailService.Send();
            SmsService.Send();
        }
    }
}
