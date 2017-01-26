using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class Rift : ILocation
    {
        private int _hp;
        private int _mp;
        private int _armor;
        private int _damage;
        private string _url;
        private string _monster1;
        private List<string> WhatMonsterAtRift = new List<string>();

        public Rift(string location)
        {
            WhatMonsterAtRift.Add("Scorpion");
            WhatMonsterAtRift.Add("Snake");
            WhatMonsterAtRift.Add("Fox");
            WhatMonsterAtRift.Add("Bear");
            WhatMonsterAtRift.Add("Wyvern");
            Random randomMonster1 = new Random();
            int monster1 = randomMonster1.Next(0, 4);
            if (monster1 == 0)
            {
                _monster1 = "Scorpion";
            }
            else if (monster1 == 1)
            {
                _monster1 = "Snake";
            }
            else if (monster1 == 2)
            {
                _monster1 = "Fox";
            }
            else if (monster1 == 3)
            {
                _monster1 = "Bear";
            }
            else if (monster1 == 4)
            {
                _monster1 = "Wyvern";
            }
            switch (_monster1)
            {

                case "Snake":
                    _hp = 200;
                    _mp = 100;
                    _armor = 2;
                    _damage = 150;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Snake.gif";
                    break;

                case "Scorpion":
                    _hp = 150;
                    _mp = 50;
                    _armor = 2;
                    _damage = 200;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Scorpion.gif";
                    break;

                case "Wyvern":
                    _hp = 1000;
                    _mp = 1000;
                    _armor = 10;
                    _damage = 600;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wyvern.gif";
                    break;

                case "Bear":
                    _hp = 400;
                    _mp = 200;
                    _armor = 3;
                    _damage = 420;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Bear.gif";
                    break;

                case "Fox":
                    _hp = 200;
                    _mp = 150;
                    _armor = 2;
                    _damage = 160;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wolf.gif"; 
                    break;
            }
        }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int MP { get { return _mp; } set { _mp = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public string Url { get { return _url; } set { _url = value; } }
    }
}
