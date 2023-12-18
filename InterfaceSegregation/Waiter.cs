using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Waiter : IWorker , IWaiter
    {
        public void PunchIn()
        {
            Console.WriteLine("Waiter punching in.");
        }

        public void PunchOut()
        {
            Console.WriteLine("Waiter punching out.");
        }

        public void TakeOrder()
        {
            Console.WriteLine("Waiter is taking an order.");
        }
    }
}
