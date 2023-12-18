using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Minions
{
    public class Ogre : Minion
    {
        public Ogre(int hp, int attack, int defense)
        {
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
        }

        public override void Battle(Hero hero)
        {
            base.Battle(hero);
            hero.PutUpShield();
        }
    }
}
