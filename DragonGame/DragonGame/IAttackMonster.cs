using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    interface IAttackMonster
    {
       string Name { get; set; }
       int GetDamage(Player player, Monster monster);
    }
}
