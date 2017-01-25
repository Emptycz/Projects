using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class BasicAttackMonster : IAttackMonster
    {
        public string Name
        {
            get{
                return "Základní útok";
            }
            set{

            }
        }

        public int GetDamage(Player player, Monster monster)
        {
            int dmg = monster.Damage;
            dmg /= player.Armor;
            player.HP -= dmg;
            return player.HP;
        }
    }
}
