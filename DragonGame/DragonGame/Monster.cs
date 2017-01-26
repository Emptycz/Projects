using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class Monster
    {
        private string _name;
        private int _hp;
        private int _mp;
        private int _armor;
        private int _damage;
        private string _location;
        private List<string> WhatMonsterAtRift = new List<string>();
        private List<string> WhatMonsterAtWhiteRun = new List<string>();
        private List<string> WhatMonsterAtWinterHold = new List<string>();
        private List<string> WhatMonsterAtReach = new List<string>();
        private string _monster1;
        private string _monster2;
        private string _monster3;
        private string _monster4;
        private string _url;

        public Monster(string location)
        {
            
            _location = location;
            switch (_location)
            {
                case "Rift":
                    ILocation sss = new Rift(location);
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
                    break;

                case "WhiteRun":
                    WhatMonsterAtWhiteRun.Add("White_Bear");
                    WhatMonsterAtWhiteRun.Add("White_Fox");
                    WhatMonsterAtWhiteRun.Add("Enemy_Hunter");
                    WhatMonsterAtWhiteRun.Add("Snowman");
                    WhatMonsterAtWhiteRun.Add("Crows");
                    Random randomMonster2 = new Random();
                    int monster2 = randomMonster2.Next(0, 4);
                    if (monster2 == 0)
                    {
                        _monster2 = "White_Bear";
                    }
                    else if (monster2 == 1)
                    {
                        _monster2 = "White_Fox";
                    }
                    else if (monster2 == 2)
                    {
                        _monster2 = "Enemy_Hunter";
                    }
                    else if (monster2 == 3)
                    {
                        _monster2 = "Snowman";
                    }
                    else if (monster2 == 4)
                    {
                        _monster2 = "Crows";
                    }
                    break;

                case "Reach":
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
                    break;

                case "WinterHold":
                    WhatMonsterAtWinterHold.Add("Enemy_Mage");
                    WhatMonsterAtWinterHold.Add("Enemy_Dragon");
                    WhatMonsterAtWinterHold.Add("Enemy_Giant");
                    WhatMonsterAtWinterHold.Add("Wyvern");
                    WhatMonsterAtWinterHold.Add("Enemy_Raid");
                    Random randomMonster4 = new Random();
                    int monster4 = randomMonster4.Next(0, 4);
                    if( monster4 == 0)
                    {
                        _monster4 = "Enemy_Mage";
                    }else if( monster4 == 1){
                        _monster4 = "Enemy_Dragon";
                    }else if( monster4 == 2)
                    {
                        _monster4 = "Enemy_Giant";
                    }else if( monster4 == 3)
                    {
                        _monster4 = "Wyvern";
                    }else if( monster4 == 4)
                    {
                        _monster4 = "Enemy_Raid";
                    }
                    break;
            }

            if(_location == "Rift")
            {
                _name = _monster1;
            }else if(_location == "WhiteRun")
            {
                _name = _monster2;
            }else if(_location == "Reach")
            {
                _name = _monster3;
            }else if(_location == "WinterHold")
            {
                _name = _monster4;
            }

            switch (_name)
            {
                case "Wyvern":
                    _hp = 1000;
                    _mp = 1000;
                    _armor = 10;
                    _damage = 600;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wyvern.gif";
                    break;

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

                case "Snowman":
                    _hp = 100;
                    _mp = 1000;
                    _armor = 1;
                    _damage = 80;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Snowman.gif";
                    break;

                case "Crows":
                    _hp = 200;
                    _mp = 50;
                    _armor = 1;
                    _damage = 230;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Crows.gif";
                    break;

                case "Bear":
                    _hp = 400;
                    _mp = 200;
                    _armor = 3;
                    _damage = 420;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Bear.gif";
                    break;

                case "White_Bear":
                    _hp = 500;
                    _mp = 300;
                    _armor = 5;
                    _damage = 230;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Bear.gif";
                    break;

                case "Enemy_Mage":
                    _hp = 500;
                    _mp = 800;
                    _armor = 3;
                    _damage = 400;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Mage.gif";
                    break;

                case "Pirate":
                    _hp = 650;
                    _mp = 600;
                    _armor = 4;
                    _damage = 320;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Pirate.gif";
                    break;

                case "Fox":
                    _hp = 200;
                    _mp = 150;
                    _armor = 2;
                    _damage = 160;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wolf.gif";
                    break;

                case "White_Fox":
                    _hp = 300;
                    _mp = 250;
                    _armor = 3;
                    _damage = 260;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Wolf.gif";
                    break; 

                case "Enemy_Dragon":
                    _hp = 1000;
                    _mp = 1000;
                    _armor = 5;
                    _damage = 1000;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Dragon.gif";
                    break;

                case "Enemy_Giant":
                    _hp = 600;
                    _mp = 200;
                    _armor = 4;
                    _damage = 150;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Giant.gif";
                    break;

                case "Enemy_Hunter":
                    _hp = 200;
                    _mp = 200;
                    _armor = 2;
                    _damage = 300;
                    _url = "pack://application:,,,/Pictures/Monsters/Enemy_Hunter.gif";
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

        public string Name { get { return _name; } set { _name = value; } }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int MP { get { return _mp; } set { _mp = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public string Url { get { return _url; } set { _url = value; } }
    }

}
