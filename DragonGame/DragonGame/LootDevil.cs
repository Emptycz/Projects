using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class LootDevil : ILoot
    {
        public List<Loot> lgenerateLoot = new List<Loot>();
        private List<string> firstLootDevil = new List<string>();
        private List<string> secondLootDevil = new List<string>();

        public string generateLoot()
        {
            firstLootDevil.Add("Čepele");
            firstLootDevil.Add("Oblek");
            firstLootDevil.Add("Boty");
            Random l3 = new Random();
            int loot_type = l3.Next(0, 2);

            secondLootDevil.Add("hněvu");
            secondLootDevil.Add("satanáše");
            secondLootDevil.Add("síry");
            secondLootDevil.Add("krvavého boha");
            secondLootDevil.Add("opovržení");
            Random l4 = new Random();
            int loot_name = l4.Next(0, 4);

            lgenerateLoot.Add(new Loot(firstLootDevil[loot_type], secondLootDevil[loot_name], 1));
            string newLoot = firstLootDevil[loot_type] + secondLootDevil[loot_name];
            return newLoot;
        }
    }
}
