using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    interface IAttackBehavior
    {
        void Attack(Player p, int attackStrenght);

    }
}
