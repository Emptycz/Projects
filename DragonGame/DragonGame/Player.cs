using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragonGame
{
    class Player
    {
        private string _gender;
        private string _role;
        private int _xp;
        private int _hp;
        private int _mp;
        private int _attackDamage;
        private int _armor;
        private int _level;
        private int _coin;
        private int _heal;
        private int _mana;
        private int _won;
        private int _cleared_locations;
        private string _error;

        public Player(string Gender, string Role)
        {
            switch (Role)
            {
                case "Devil":
                    _hp = 600;
                    _mp = 300;
                    _attackDamage = 70;
                    _armor = 4;
                    break;

                case "Mage":
                    _hp = 600;
                    _mp = 600;
                    _attackDamage = 45;
                    _armor = 2;
                    break;

                case "Warrior":
                    _hp = 1000;
                    _mp = 200;
                    _attackDamage = 50;
                    _armor = 10;
                    break;

                case "Hunter":
                    _hp = 500;
                    _mp = 450;
                    _attackDamage = 40;
                    _armor = 2;
                    break;
            }
            _gender = Gender;
            _role = Role;
            _xp = 0;
            _level = 1;
            _coin = 100;
            _cleared_locations = 0;
            _won = 0;
        }

        public Player(string Gender, string Role, int xp, int coin, int heal, int mana)
        {
            switch (Role)
            {
                case "Devil":
                    _hp = 600;
                    _mp = 300;
                    _attackDamage = 70;
                    _armor = 4;
                    break;

                case "Mage":
                    _hp = 600;
                    _mp = 600;
                    _attackDamage = 45;
                    _armor = 2;
                    break;

                case "Warrior":
                    _hp = 1000;
                    _mp = 200;
                    _attackDamage = 50;
                    _armor = 10;
                    break;

                case "Hunter":
                    _hp = 500;
                    _mp = 450;
                    _attackDamage = 40;
                    _armor = 2;
                    break;
            }
            _gender = Gender;
            _role = Role;
            _xp = xp;
            _coin = coin;
        }

        //Generování postavy při načtení hry
        public Player(string Gender, string Role, int xP, int hP, int mP, int coin, int heal, int mana, int cleared_locations, int won)
        {
            _gender = Gender;
            _role = Role;
            _xp = xP;
            _hp = hP;
            _mp = mP;
            _coin = coin;
            _heal = heal;
            _mana = mana;
            _cleared_locations = cleared_locations;
            _won = won;

         /*ImageBrush weaponBrush = new ImageBrush();//založení
           weaponBrush.ViewboxUnits = BrushMappingMode.Absolute; //nastvení
           weaponBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/items/items2.png")); //zdroj spritu
           my_Rectangle.Fill = weaponBrush; //změní brush
           // new Rect(left,top,width,height)
           weaponBrush.Viewbox = new System.Windows.Rect(0,0,20,20); // nastaví pozici ve spritu
           */

            switch (Role)
            {
                case "Devil":
                    _armor = 4;
                    _attackDamage = 70;
                    break;

                case "Mage":
                    _armor = 2;
                    _attackDamage = 45;
                    break;

                case "Warrior":
                    _armor = 5;
                    _attackDamage = 50;
                    break;

                case "Hunter":
                    _armor = 2;
                    _attackDamage = 40;
                    break;
            }
       
        }
    
        public void Level(int XP)
        {       
                if (XP <= 0) { _level = 1; }  
                else if (XP <= 100) { _level = 2; }
                else if (XP <= 250) { _level = 3; }
                else if (XP <= 450) { _level = 4; }
                else if (XP <= 650) { _level = 5; }
                else if (XP <= 900) { _level = 6; }
                else if (XP >= 1200) { _level = 7; }

            switch (_level)
            {
                case 2:
                    _hp += 100;
                    _mp += 100;
                    _attackDamage += 10;                   
                    break;

                case 3:
                    _hp += 150;
                    _mp += 150;
                    _attackDamage += 10;
                    break;

                case 4:
                    _hp += 200;
                    _mp += 200;
                    _attackDamage += 15;
                    break;

                case 5:
                    _hp += 350;
                    _mp += 350;
                    _attackDamage += 15;
                    break;

                case 6:
                    _hp += 200;
                    _mp += 200;
                    _attackDamage += 15;
                    break;

                case 7:
                    _hp = _xp;
                    _mp = _xp;
                    _attackDamage = _xp / 10;
                    break;
            }
                
         }

        public int Level_Check(int XP)
        {
            if (XP <= 0) { _level = 1; }
            else if (XP <= 100) { _level = 2; }
            else if (XP <= 250) { _level = 3; }
            else if (XP <= 450) { _level = 4; }
            else if (XP <= 650) { _level = 5; }
            else if (XP <= 900) { _level = 6; }
            else if (XP >= 1200) { _level = 7; }

            return _level;
        }

        public int Advanced_Armory(List<int> Item_ID)
        {
            if(Armor <= 0)
            {
                return 0;
            }else
            {
                _armor += Armor;
                return _armor;
            }

        }

        public int Won { get { return _won; } set { _won = value; } }
        public int Cleared_Locations { get { return _cleared_locations; } set { _cleared_locations = value; } }
        public int Heal { get { return _heal; } set { _heal = value; } }
        public int Mana { get { return _mana; } set { _mana = value; } }
        public int Coin { get { return _coin; } set { _coin = value; } }
        public string gender { get { return _gender; } set { _gender = value; } }
        public string role { get { return _role; } set { _role = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int MP { get { return _mp; } set { _mp = value; } }
        public int AttackDamage { get { return _attackDamage; } set { _attackDamage = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }

    }
}
