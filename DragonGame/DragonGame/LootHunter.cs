using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class LootHunter : ILoot
    {
        public List<Loot> lgenerateLoot = new List<Loot>();
        private List<string> firstLootHunter = new List<string>();
        private List<string> secondLootHunter = new List<string>();

        public string generateLoot()
        {
            firstLootHunter.Add("Klobouk");
            firstLootHunter.Add("Luk");
            firstLootHunter.Add("Lovecký oblek");
            firstLootHunter.Add("Boty");
            firstLootHunter.Add("Rukavice");
            Random l5 = new Random();
            int loot_type = l5.Next(0, 4);

            secondLootHunter.Add("kuroliška");
            secondLootHunter.Add("bílého vlka");
            secondLootHunter.Add("jezerní panny");
            secondLootHunter.Add("větného jezdce");
            secondLootHunter.Add("Artemis");
            Random l6 = new Random();
            int loot_name = l6.Next(0, 4);

            lgenerateLoot.Add(new Loot(firstLootHunter[loot_type], secondLootHunter[loot_name], 1));
            string newLoot = firstLootHunter[loot_type] + secondLootHunter[loot_name];
            return newLoot;
        }
    }
}
