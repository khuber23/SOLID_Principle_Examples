using System;

namespace LiskovSubstitution
{
    public class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Penguin eats.");
        }
    }
}