using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame
{
    class Inventory
    {
        private int armor = 0;
        private int damage = 0;

        public int ActiveHeadItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu")) {
                armor = 5;
                return armor;
            } else if (ActiveHeadItem.Contains("satanáše"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("síry"))
            {
                armor = 3;
                return armor;
            } else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                armor = 6;
                return armor;
            } else if (ActiveHeadItem.Contains("opovržení"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("árese"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                armor = 6;
                return armor;
            } else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                armor = 10;
                return armor;
            } else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                armor = 7;
                return armor;
            } else if (ActiveHeadItem.Contains("děsu"))
            {
                armor = 3;
                return armor;
            } else if (ActiveHeadItem.Contains("závisti"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("prokletí"))
            {
                armor = 5;
                return armor;
            } else if (ActiveHeadItem.Contains("moci"))
            {
                armor = 7;
                return armor;
            } else if (ActiveHeadItem.Contains("větru"))
            {
                armor = 2;
                return armor;
            } else if (ActiveHeadItem.Contains("kuroliška"))
            {
                armor = 4;
                return armor;
            } else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                armor = 6;
                return armor;
            } else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                armor = 2;
                return armor;
            } else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                armor = 3;
                return armor;
            } else if (ActiveHeadItem.Contains("Artemis"))
            {
                armor = 6;
                return armor;
            }
            return armor;
        }


        public int ActiveBodyItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("satanáše"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("síry"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("opovržení"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("árese"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                armor = 10;
                return armor;
            }
            else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("děsu"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("závisti"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("prokletí"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("moci"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větru"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("kuroliška"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("Artemis"))
            {
                armor = 6;
                return armor;
            }
            return armor;
        }

        public int ActiveLeftHandItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu"))
            {
                damage = 5;
                return damage;
            }
            else if (ActiveHeadItem.Contains("satanáše"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("síry"))
            {
                damage = 3;
                return damage;
            }
            else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                damage = 6;
                return damage;
            }
            else if (ActiveHeadItem.Contains("opovržení"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("árese"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                damage = 6;
                return damage;
            }
            else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                damage = 10;
                return damage;
            }
            else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                damage = 7;
                return damage;
            }
            else if (ActiveHeadItem.Contains("děsu"))
            {
                damage = 3;
                return damage;
            }
            else if (ActiveHeadItem.Contains("závisti"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("prokletí"))
            {
                 damage = 5;
                return damage;
            }
            else if (ActiveHeadItem.Contains("moci"))
            {
                damage = 7;
                return damage;
            }
            else if (ActiveHeadItem.Contains("větru"))
            {
                damage = 2;
                return damage;
            }
            else if (ActiveHeadItem.Contains("kuroliška"))
            {
                damage = 4;
                return damage;
            }
            else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                damage = 6;
                return damage;
            }
            else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                damage = 2;
                return damage;
            }
            else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                damage = 3;
                return damage;
            }
            else if (ActiveHeadItem.Contains("Artemis"))
            {
                damage = 6;
                return damage;
            }
            return damage;
        }

        public int ActiveRightHandItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("satanáše"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("síry"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("opovržení"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("árese"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                armor = 10;
                return armor;
            }
            else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("děsu"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("závisti"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("prokletí"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("moci"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větru"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("kuroliška"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("Artemis"))
            {
                armor = 6;
                return armor;
            }
            return armor;
        }

        public int ActiveTrousersItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("satanáše"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("síry"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("opovržení"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("árese"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                armor = 10;
                return armor;
            }
            else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("děsu"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("závisti"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("prokletí"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("moci"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větru"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("kuroliška"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("Artemis"))
            {
                armor = 6;
                return armor;
            }
            return armor;
        }


        public int ActiveBootsItem(string ActiveHeadItem)
        {

            if (ActiveHeadItem.Contains("hněvu"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("satanáše"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("síry"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("krvavého boha"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("opovržení"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("árese"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("měsíčního svitu"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z jakostního železa"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("z šupin ohvnivého draka"))
            {
                armor = 10;
                return armor;
            }
            else if (ActiveHeadItem.Contains("zastánců světla"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("děsu"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("závisti"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("prokletí"))
            {
                armor = 5;
                return armor;
            }
            else if (ActiveHeadItem.Contains("moci"))
            {
                armor = 7;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větru"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("kuroliška"))
            {
                armor = 4;
                return armor;
            }
            else if (ActiveHeadItem.Contains("bílého vlka"))
            {
                armor = 6;
                return armor;
            }
            else if (ActiveHeadItem.Contains("jezerní panny"))
            {
                armor = 2;
                return armor;
            }
            else if (ActiveHeadItem.Contains("větrného jezdce"))
            {
                armor = 3;
                return armor;
            }
            else if (ActiveHeadItem.Contains("Artemis"))
            {
                armor = 6;
                return armor;
            }
            return armor;
        }
    }
}
