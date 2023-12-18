using System;

namespace InterfaceSegregation
{
    public class Cook : IWorker , ICook
    {
        public void MakeFood()
        {
            Console.WriteLine("Cook making food.");
        }

        public void PunchIn()
        {
            Console.WriteLine("Cook punching in.");
        }

        public void PunchOut()
        {
            Console.WriteLine("Cook punching out.");
        }

    }
}