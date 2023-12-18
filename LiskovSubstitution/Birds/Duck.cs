using LiskovSubstitution.Birds;
using System;

namespace LiskovSubstitution
{
    public class Duck : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Duck eats.");
        }

        public override void Fly()
        {
            Console.WriteLine("Duck flies around.");
        }
    }
}