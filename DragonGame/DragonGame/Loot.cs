using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class Loot
    {
        private string _lootType;
        private string _lootName;
        private int _lootNumber;

        public Loot(string lootType, string lootName, int lootNumber)
        {
            _lootType = lootType;
            _lootName = lootName;
            _lootNumber = lootNumber;
        }

        public string LootType { get { return _lootType; } set { _lootType = value; } }
        public string LootName { get { return _lootName; } set { _lootName = value; } }
        public int LootNumber { get { return _lootNumber; } set { _lootNumber = value; } }
    }
}
