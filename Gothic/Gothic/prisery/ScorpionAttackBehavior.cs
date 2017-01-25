using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic.prisery
{
    class ScorpionAttackBehavior : IAttackBehavior
    {
        public void Attack(Player p, int AttackStrenght)
        {
            p.Lives -= AttackStrenght * 2;
        }
    }
}
