using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class BasicPlayerAttack : IPlayerAttack
    {
        public string Name
        {
            get
            {
                return "Základní útok";
            }
            set
            {

            }
        }

        public int DoDamage(Player player, Monster monster)
        {
            int dmg = player.AttackDamage;
            dmg /= monster.Armor;
            monster.HP -= dmg;
            return monster.HP;
        }
    }
}
