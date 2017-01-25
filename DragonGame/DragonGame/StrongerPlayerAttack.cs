using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class StrongerPlayerAttack : IPlayerAttack
    {
        public string Name
        {
            get { return "Základní magický útok"; }
            set { }
        }
        public int DoDamage(Player player, Monster monster)
        {
                int dmg = player.AttackDamage * 2;
                dmg /= monster.Armor;
                monster.HP -= dmg;
                return monster.HP;
        }
    }
}
