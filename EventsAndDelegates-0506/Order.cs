using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_0506
{
    public delegate void OrderEventHandler();

    public class Order
    {
        public event OrderEventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("Order created");

            if (OnCreated != null) {
                OnCreated();
            }
        }
    }
}
