using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    interface IPlayerAttack
    {
        string Name { get; set; }
        int DoDamage(Player player, Monster monster);
    }
}
