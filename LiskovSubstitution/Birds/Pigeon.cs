using LiskovSubstitution.Birds;
using System;

namespace LiskovSubstitution
{
    public class Pigeon : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Pigeon eats.");
        }

        public override void Fly()
        {
            Console.WriteLine("Pigeon flies around.");
        }
    }
}