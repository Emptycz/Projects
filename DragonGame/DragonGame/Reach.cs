using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class Reach : ILocation
    {

        private string _monster3;
        private int _hp;
        private int _mp;
        private int _armor;
        private int _damage;
        private string _url;
        private List<string> WhatMonsterAtReach = new List<string>();

        public Reach(string location)
        {
            WhatMonsterAtReach.Add("Crows");
            WhatMonsterAtReach.Add("Pirate");
            WhatMonsterAtReach.Add("Enemy_Hunter");
            WhatMonsterAtReach.Add("Wyvern");
            WhatMonsterAtReach.Add("Enemy_Raid");
            Random randomMonster3 = new Random();
            int monster3 = randomMonster3.Next(0, 4);
            if (monster3 == 0)
            {
                _monster3 = "Crows";
            }
            else if (monster3 == 1)
            {
                _monster3 = "Pirate";
            }
            else if (monster3 == 2)
            {
                _monster3 = "Enemy_Hunter";
            }
            else if (monster3 == 3)
            {
                _monster3 = "Wyvern";
            }
            else if (monster3 == 4)
            {
                _monster3 = "Enemy_Raid";
            }

            switch (_monster3)
            {
                case "Crows":
                    _hp = 200;
                    _mp = 50;
                    _armor = 1;
                    _damage = 230;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Crows.gif";
                    break;

                case "Pirate":
                    _hp = 650;
                    _mp = 600;
                    _armor = 4;
                    _damage = 320;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Pirate.gif";
                    break;

                case "Enemy_Hunter":
                    _hp = 200;
                    _mp = 200;
                    _armor = 2;
                    _damage = 300;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Hunter.gif";
                    break;

                case "Wyvern":
                    _hp = 1000;
                    _mp = 1000;
                    _armor = 10;
                    _damage = 600;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wyvern.gif";
                    break;

                case "Enemy_Raid":
                    _hp = 750;
                    _mp = 500;
                    _armor = 3;
                    _damage = 600;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Raid.gif";
                    break;
            }
        }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int MP { get { return _mp; } set { _mp = value; } }
        public int Armor { get { return _armor;} set { _armor = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public string Url { get { return _url; } set { _url = value; } }
    }
}
