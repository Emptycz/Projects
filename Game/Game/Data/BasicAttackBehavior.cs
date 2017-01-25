using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    class BasicAttackBehavior : IAttackBehavior
    {
        public void Attack(Player p, int attackStrength)
        {
            p.Lives -= attackStrength;
        }
    }
}
