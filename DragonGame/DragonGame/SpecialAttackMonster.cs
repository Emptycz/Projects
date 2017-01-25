using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class SpecialAttackMonster : IAttackMonster
    {
        public string Name
        {
            get
            {
                return "Speciální útok";
            }
            set
            {

            }
        }

        public int GetDamage(Player player, Monster monster)
        {
            int dmg = monster.Damage * 2;
            dmg /= player.Armor;
            player.HP -= dmg;
            return player.HP;
        }
        
    }
}
