using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Minions
{
    public class Owlbear : Minion
    {
        public Owlbear(int hp, int attack, int defense)
        {
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
        }

        public override void Battle(Hero hero)
        {
            hero.Run();
        }
    }
}
