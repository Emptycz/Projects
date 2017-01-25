using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class SpecialPlayerAttack : IPlayerAttack
    {
        public string Name
        {
            get { return "Silný magický útok"; }
            set { }
        }

        public int DoDamage(Player player, Monster monster)
        {
            int dmg = player.AttackDamage * 4;
            dmg /= monster.Armor;
            monster.HP -= dmg;
            return monster.HP;
        }
    }
}
