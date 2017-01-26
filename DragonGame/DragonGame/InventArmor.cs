using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class InventArmor : IInvent
    {
        public int CalculateArmor(Player player)
        {
            int armor = player.Armor;
            int updatedArmor = player.Armor + armor;
            return updatedArmor;
        }
    }
}
