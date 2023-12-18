using OpenClosed.Minions;
using System;

namespace OpenClosed
{
    public class Hero
    {
        private int attack;

        private int defense;

        private int hp;

        private int magic;

        private Minion minion;

        public Hero(int hp, int attack, int defense, int magic)
        {
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.magic = magic;
        }

        public int Attack { get => this.attack; set => this.attack = value; }

        public int Defense { get => this.defense; set => this.defense = value; }

        public int HP { get => this.hp; set => this.hp = value; }

        public int Magic { get => this.magic; set => this.magic = value; }

        public void Battle(Minion minion)
        {
            this.minion = minion;
            Console.WriteLine();
            Console.WriteLine(this.ToString());
            Console.WriteLine(minion.ToString());

            if (minion.GetType().Name == "Goblin")
            {
                //this.hp -= 10;
                //this.HackNSlash();
                minion.Battle(this);
            }
            else if (minion.GetType().Name == "Ogre")
            {
                //this.PutUpShield();
                //this.hp -= 20;
                minion.Battle(this);

            }
            else if (minion.GetType().Name == "Zombie")
            {
                //this.PerformMagic();
                //this.hp -= 5;
                minion.Battle(this);
            }
            else if (minion.GetType().Name == "Owlbear")
            {
                //this.Run();
                minion.Battle(this);
            }

            //minion.Battle(this);

            Console.WriteLine(this.ToString());
            Console.WriteLine(minion.ToString());
        }

        public void HackNSlash()
        {
            Console.WriteLine($"\nHero hacks n' slashes at the {minion.GetType().Name}.");
        }

        public void PerformMagic()
        {
            Console.WriteLine($"\nHero performs a spell on the {minion.GetType().Name}.");
        }

        public virtual void PutUpShield()
        {
            Console.WriteLine($"\nHero defends against the {minion.GetType().Name} with their shield.");
        }

        public virtual void Run()
        {
            Console.WriteLine($"\nHero runs away from the {minion.GetType().Name}.");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} HP: {this.hp}";
        }
    }
}