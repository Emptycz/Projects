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

        public Monster(string name)
        {
            _name = name;
            switch (_name)
            {
                case "Enemy_Dragon":
                    _hp = 1000;
                    _mp = 1000;
                    _armor = 5;
                    _damage = 100;
                    break;

                case "Enemy_Giant":
                    _hp = 600;
                    _mp = 200;
                    _armor = 4;
                    _damage = 20;
                    break;

                case "Enemy_Hunter":
                    _hp = 200;
                    _mp = 200;
                    _armor = 2;
                    _damage = 10;
                    break;

                case "Enemy_Raid":
                    _hp = 750;
                    _mp = 500;
                    _armor = 3;
                    _damage = 60;
                    break;
            }
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int MP { get { return _mp; } set { _mp = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
    }

}
