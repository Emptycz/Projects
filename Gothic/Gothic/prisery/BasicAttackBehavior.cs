using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic.prisery
{
    class BasicAttackBehavior : IAttackBehavior
    {
        public void Attack(Player p, int attackStrenght)
        {
            p.Lives -= attackStrenght;
            
        }
    }
}
