using LiskovSubstitution.Birds;
using System;

namespace LiskovSubstitution
{
    public class Hawk : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Hawk eats.");
        }

        public override void Fly()
        {
            Console.WriteLine("Hawk flies around.");
        }
    }
}