using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Minions
{
    public abstract class Minion
    {
        protected int hp;
        protected int attack;
        protected int defense;

        public int HP { get { return hp; } set { hp = value; } }

        public int Attack { get { return attack; } }

        public int Defense { get { return defense; } }

        public virtual void Battle (Hero hero)
        {
            hero.HP -= (int)Math.Round(this.attack - hero.Defense * .20);
            this.hp -= (int)Math.Round(hero.Attack - this.defense * .10);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} HP: {this.hp}";
        }
    }
}
