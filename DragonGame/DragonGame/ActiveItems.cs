using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class ActiveItems
    {
        public ActiveItems(ILoot loot)
        {
            string detected_loot = loot.generateLoot();

        }
    }
}
