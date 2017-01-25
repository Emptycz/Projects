using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic.prisery
{
    interface IAttackBehavior
    {
        void Attack(Player p, int AttackStrenght);  
    }
}
