using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class LootWarrior : ILoot
    {
        public List<Loot> lgenerateLoot = new List<Loot>();
        private List<string> firstLootWarrior = new List<string>();
        private List<string> secondLootWarrior = new List<string>();

        public string generateLoot()
        {
            firstLootWarrior.Add("Helma");
            firstLootWarrior.Add("Kyrys");
            firstLootWarrior.Add("Nohavice");
            firstLootWarrior.Add("Boty");
            firstLootWarrior.Add("Štít");
            firstLootWarrior.Add("Meč");
            Random l7 = new Random();
            int loot_type = l7.Next(0, 5);

            secondLootWarrior.Add("Árese");
            secondLootWarrior.Add("měsíčního svitu");
            secondLootWarrior.Add("z jakostního železa");
            secondLootWarrior.Add("z šupin ohnivého draka");
            secondLootWarrior.Add("zastánců světla");
            Random l8 = new Random();
            int loot_name = l8.Next(0, 4);

            lgenerateLoot.Add(new Loot(firstLootWarrior[loot_type], secondLootWarrior[loot_name], 1));
            string newLoot = firstLootWarrior[loot_type] + secondLootWarrior[loot_name];
            return newLoot;
        }
    }
}
