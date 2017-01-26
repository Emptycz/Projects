using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class LootMage : ILoot
    {
        public List<Loot> lgenerateLoot = new List<Loot>();
        public List<string> firstLootMage = new List<string>();
        public List<string> secondLootMage = new List<string>();

        public string generateLoot()
        {
            firstLootMage.Add("Hůl ");
            firstLootMage.Add("Klobouk ");
            firstLootMage.Add("Rukavice ");
            firstLootMage.Add("Hábit ");
            firstLootMage.Add("Boty ");
            Random l1 = new Random();
            int loot_type = l1.Next(0, 4);

            secondLootMage.Add("děsu");
            secondLootMage.Add("závisti");
            secondLootMage.Add("prokletí");
            secondLootMage.Add("moci");
            secondLootMage.Add("větru");
            Random l2 = new Random();
            int loot_name = l2.Next(0, 4);

            lgenerateLoot.Add(new Loot(firstLootMage[loot_type], secondLootMage[loot_name], 1));
            string newLoot = firstLootMage[loot_type] + secondLootMage[loot_name];
            return newLoot;
        }
    }
}
