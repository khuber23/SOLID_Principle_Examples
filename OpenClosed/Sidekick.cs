using OpenClosed.Minions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Sidekick : Hero
    {
        public Sidekick(int hp, int attack, int defense, int magic)
            : base(hp, attack, defense, magic)
        {
        }

        public override void PutUpShield()
        {
            Console.WriteLine($"\nSidekick throws body in front of Hero.");
        }

        public override void Run()
        {
            Console.WriteLine($"\nSidekick hides in a corner.");
        }
    }
}
