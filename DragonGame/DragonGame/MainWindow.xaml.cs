using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAnimatedGif;
using System.IO;

namespace DragonGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Monster monster = new Monster("");
        Player player = new Player("", "");
        public string select_gender;
        public string choose_role;
        public bool confirmed;
        public bool creategame;
        public int EnemysDMG;
        public string ChooseDamage;
        public bool InventClicker;
        public int page; //Snažím se o jakýsi identifikátor, podle kterého díky jedinému tlačítku se budu vracet na různé stránky (stavy) -> Experiment
        public MainWindow()
        {
            InitializeComponent();
            //Předem ukrytí připraveného menu včetně dalších možností
            EventManager.RegisterClassHandler(typeof(MainWindow), UIElement.KeyDownEvent, new KeyEventHandler(KeyDownHandler));
            creategame = false;
            NewGame.Content = "Nová hra";
            LoadGame.Content = "Načíst existující hru";
            ExitGame.Content = "Ukončit aplikaci";
            ChooseBoy.Content = "Chlapec";
            ChooseGirl.Content = "Dívka";
            NO1_Role.Content = "Mág";
            NO2_Role.Content = "Lovec";
            NO3_Role.Content = "Rytíř";
            NO4_Role.Content = "Devil";
            ConfirmMyResult.Content = "Zpět do hry";
            //invis(NO3Champ);
            GetToFight.Content = "Pustit se do boje!";
            ContinueToMenu();
            //Úvod do hry

        }

        //Obchod
        private void BuyItem_Click(object sender, RoutedEventArgs e)
        {
            shop.IsSelected = true;
            Gold.Content = "Aktuálně máte: " + player.Coin + " c";
            ManaPotionBuy.Content = "Koupit mana potion (50c)";
            HealPotionBuy.Content = "Koupit heal potion (50c)";
            
        }
        //Obchod
        private void BuyMana_Click(object sender, RoutedEventArgs e)
        {
            if (player.Coin <= 0)
            {
                ManaPotionBuy.Content = "Nemáte dostatek coinů!";
            }
            else
            {
                player.Mana += 1;
                player.Coin -= 50;
                Gold.Content = "Aktuálně máte: " + player.Coin + " coinů!";

            }
            /*
            string ManaItemCounter = ManaItemNumber.Content.ToString();
            int ManaItemCounterInt = Int32.Parse(ManaItemCounter);
            ManaItemNumber.Content = ManaItemCounterInt++;*/
        }
        //Obchod
        private void BuyHeal_Click(object sender, RoutedEventArgs e)
        {
            if (player.Coin <= 0)
            {
                HealPotionBuy.Content = "Nemáte dostatek coinů!";
            }
            else
            {
                player.Coin -= 50;
                player.Heal += 1;
                Gold.Content = "Aktuálně máte: " + player.Coin + " coinů!";

            }

           
        }

        private void OpenInvent()
        {
            player.Level(player.XP);
            vis(HealItemNumber);
            vis(ManaItemNumber);
            vis(AmmountOfGold);
            HealItemNumber.Content = "Vlastníte " + player.Heal + " lektvarů doplňujících 100 hp";
            ManaItemNumber.Content = "Vlastníte " + player.Mana + " lektvarů doplňujících 100 many";
            AmmountOfGold.Content = "Právě máte " + player.Coin + " c!";
            PlayerStats.Text = "Pohlaví: " + player.gender + Environment.NewLine + "Role: " + player.role + Environment.NewLine + "XP: " + player.XP + Environment.NewLine + "HP: " + player.HP + Environment.NewLine + "MP: " + player.MP + Environment.NewLine + "Útočná síla: " + player.AttackDamage + Environment.NewLine + "Level: " + player.Level_Check(player.XP);
        }
        
        

        private void GetToFight_Click(object sender, RoutedEventArgs e)
        {
            map.IsSelected = true;
        }

        private void ReturnGame_Click(object sender, RoutedEventArgs e)
        {
            game.IsSelected = true;
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            int select_menu = 1;
            InsideMenu(select_menu);
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            int select_menu = 2;
            InsideMenu(select_menu);
        }

        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            int select_menu = 3;
            InsideMenu(select_menu);
        }

        //Metody
        public void ContinueToMenu()
        {
            invis(NO1_Role);
            invis(NO2_Role);
            invis(NO3_Role);
            invis(NO4_Role);
            invis(BackToPreviousPage);
            invis(ChooseBoy);
            invis(ChooseGirl);
            invis(GirlFromMenu);
            invis(BoyFromMenu);
            ConfirmMyResult.Content = "Zpět do hry";
            invis(NO1Champ);
            invis(NO2Champ);
            invis(NO3Champ);
            invis(NO4Champ);
            invis(LoadCharacter);
            invis(StatsLoad);
            InformationTab.Visibility = Visibility.Hidden;
            NewGame.Visibility = Visibility.Visible;
            LoadGame.Visibility = Visibility.Visible;
            ExitGame.Visibility = Visibility.Visible;
        }

        public void InsideMenu(int select_menu)
        {
            switch (select_menu)
            {
                //Zobrazení možnosti vytvoření nové hry
                case 1:
                    invis(NewGame);
                    invis(LoadGame);
                    invis(ExitGame);

                    InformationTab.Text = "Vyberte své pohlaví";
                    vis(InformationTab);
                    vis(ChooseBoy);
                    vis(ChooseGirl);
                    vis(GirlFromMenu);
                    vis(BoyFromMenu);
                    vis(BackToPreviousPage);
                    break;

                //Zobrazení možnosti načtení existující hry
                case 2:
                    invis(NewGame);
                    invis(LoadGame);
                    invis(ExitGame);


                    string FileName = "save.txt";
                    string loaded_gender = File.ReadLines(FileName).Skip(0).Take(1).First();
                    string loaded_role = File.ReadLines(FileName).Skip(1).Take(1).First();
                    string loaded_xp_string = File.ReadLines(FileName).Skip(2).Take(1).First();
                    string loaded_hp_string = File.ReadLines(FileName).Skip(3).Take(1).First();
                    string loaded_mp_string = File.ReadLines(FileName).Skip(4).Take(1).First();
                    int loaded_xp = Int32.Parse(loaded_xp_string);
                    int loaded_hp = Int32.Parse(loaded_hp_string);
                    int loaded_mp = Int32.Parse(loaded_mp_string);

                    if(loaded_gender == "Boy")
                    {
                        if((loaded_role == "Mage") || (loaded_role == "Devil") || (loaded_role == "Hunter"))
                        {
                            ImageSource Source421 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + loaded_role + "_" + loaded_gender + ".png"));
                            ImageBehavior.SetAnimatedSource(GirlFromMenu, Source421);
                        }else
                        {
                            ImageSource Source423 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + loaded_role + "_" + loaded_gender + ".gif"));
                            ImageBehavior.SetAnimatedSource(GirlFromMenu, Source423);
                        }
                    }
                    if(loaded_gender == "Girl")
                    {
                        if(loaded_role == "Warrior")
                        {
                            ImageSource Source425 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + loaded_role + "_" + loaded_gender + ".png"));
                            ImageBehavior.SetAnimatedSource(GirlFromMenu, Source425);
                        }else
                        {
                            ImageSource Source420 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + loaded_role + "_" + loaded_gender + ".gif"));
                            ImageBehavior.SetAnimatedSource(GirlFromMenu, Source420);
                        }
                    }
                    

                    //Generování načetené postavy do konstruktoru
                    int loaded_level = player.Level_Check(loaded_xp);

                    vis(StatsLoad);
                    vis(LoadCharacter);
                    LoadCharacter.Content = "Načíst uloženou postavu";
                    StatsLoad.Text = "Pohlaví: " + loaded_gender + Environment.NewLine  + "Role: " + loaded_role + Environment.NewLine + "XP: " + loaded_xp + Environment.NewLine + "HP: " + loaded_hp + Environment.NewLine + "MP: " + loaded_mp + Environment.NewLine + "Level: " + loaded_level;
                    vis(GirlFromMenu);
                    vis(BackToPreviousPage);
                    break;

                //Vypnutí hry 
                case 3:

                    Application.Current.Shutdown();
                    break;

            };
        }

        //Načíst uloženou hru
        private void LoadCharacter_Click(object sender, RoutedEventArgs e)
        {
            string FileName = "save.txt";
            string loaded_gender = File.ReadLines(FileName).Skip(0).Take(1).First();
            string loaded_role = File.ReadLines(FileName).Skip(1).Take(1).First();
            string loaded_xp_string = File.ReadLines(FileName).Skip(2).Take(1).First();
            string loaded_hp_string = File.ReadLines(FileName).Skip(3).Take(1).First();
            string loaded_mp_string = File.ReadLines(FileName).Skip(4).Take(1).First();
            string loaded_coin_string = File.ReadLines(FileName).Skip(5).Take(1).First();
            string loaded_heal_string = File.ReadLines(FileName).Skip(6).Take(1).First();
            string loaded_mana_string = File.ReadLines(FileName).Skip(7).Take(1).First();
            string loaded_locations_string = File.ReadLines(FileName).Skip(8).Take(1).First();
            string loaded_won_string = File.ReadLines(FileName).Skip(9).Take(1).First();
            int loaded_xp = Int32.Parse(loaded_xp_string);
            int loaded_hp = Int32.Parse(loaded_hp_string);
            int loaded_mp = Int32.Parse(loaded_mp_string);
            int loaded_coins = Int32.Parse(loaded_coin_string);
            int loaded_heal = Int32.Parse(loaded_heal_string);
            int loaded_mana = Int32.Parse(loaded_mana_string);
            int loaded_cleared_location = Int32.Parse(loaded_locations_string);
            int loaded_won = Int32.Parse(loaded_won_string);

            //Generování načetené postavy do konstruktoru
            player = new Player(loaded_gender, loaded_role, loaded_xp, loaded_hp, loaded_mp, loaded_coins, loaded_heal, loaded_mana, loaded_cleared_location, loaded_won);
            select_gender = loaded_gender;
            choose_role = loaded_role;

            //Načtení spráného obrázku postavy
            if (select_gender == "Boy")
            {
                if ((choose_role == "Hunter") || (choose_role == "Mage") || (choose_role == "Devil"))
                {
                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    game.IsSelected = true;
                }
                else
                {
                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    game.IsSelected = true;
                }
            }
            if (select_gender == "Girl")
            {
                if (choose_role == "Warrior")
                {

                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    game.IsSelected = true;
                    //Content.NavigationService.Navigate(new Game(this));
                }
                else
                {

                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    game.IsSelected = true;

                }
            }
        }

        private void ChooseGirl_Click(object sender, RoutedEventArgs e)
        {
            select_gender = "Girl";
            InformationTab.Text = "Vyberte si svou postavu";
            invis(ChooseBoy);
            invis(ChooseGirl);
            invis(GirlFromMenu);
            invis(BoyFromMenu);
            CharacterSelection();
            vis(BackToPreviousPage);
            ImageSource NO1 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Mage_Girl.gif"));
            ImageBehavior.SetAnimatedSource(NO1Champ, NO1);
            ImageSource NO2 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Hunter_Girl.gif"));
            ImageBehavior.SetAnimatedSource(NO2Champ, NO2);
            ImageSource NO3 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Warrior_Girl.png"));
            ImageBehavior.SetAnimatedSource(NO3Champ, NO3);
            ImageSource NO4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Devil_Girl.gif"));
            ImageBehavior.SetAnimatedSource(NO4Champ, NO4);
            vis(BackToPreviousPage);
        }

        private void ChooseBoy_Click(object sender, RoutedEventArgs e)
        {
            select_gender = "Boy";
            InformationTab.Text = "Vyberte si svou postavu";
            invis(ChooseBoy);
            invis(ChooseGirl);
            invis(GirlFromMenu);
            invis(BoyFromMenu);
            CharacterSelection();
            ImageSource NO1 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Mage_Boy.png"));
            ImageBehavior.SetAnimatedSource(NO1Champ, NO1);
            ImageSource NO2 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Hunter_Boy.png"));
            ImageBehavior.SetAnimatedSource(NO2Champ, NO2);
            ImageSource NO3 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Warrior_Boy.gif"));
            ImageBehavior.SetAnimatedSource(NO3Champ, NO3);
            ImageSource NO4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/Devil_Boy.png"));
            ImageBehavior.SetAnimatedSource(NO4Champ, NO4);
            vis(BackToPreviousPage);

        }

        private bool NO1_RoleClicked = false;
        private bool NO2_RoleClicked = false;
        private bool NO3_RoleClicked = false;
        private bool NO4_RoleClicked = false;

        private void NO1_Role_Checked(object sender, RoutedEventArgs e)
        {
            choose_role = "Mage";
            NO1_RoleClicked = true;
            CharacterSelection();
        }

        private void NO2_Role_Checked(object sender, RoutedEventArgs e)
        {
            choose_role = "Hunter";
            NO2_RoleClicked = true;
            CharacterSelection();
        }

        private void NO3_Role_Checked(object sender, RoutedEventArgs e)
        {
            choose_role = "Warrior";
            NO3_RoleClicked = true;
            CharacterSelection();
        }

        private void NO4_Role_Checked(object sender, RoutedEventArgs e)
        {
            choose_role = "Devil";
            NO4_RoleClicked = true;
            CharacterSelection();
        }

        public void CharacterSelection()
        {
            InformationTab.Text = "Dokončete svou postavu";

            vis(NO1_Role);
            vis(NO1Champ);
            vis(NO2_Role);
            vis(NO2Champ);
            vis(NO3_Role);
            vis(NO3Champ); //Než bude znovu vytvořen -> gif s debilnějším rozlišením jsem neviděl, NEPOUŽÍVEJ
            vis(NO4_Role);
            vis(NO4Champ);
            vis(BackToPreviousPage);
            if (NO1_RoleClicked == true || NO2_RoleClicked == true || NO3_RoleClicked == true || NO4_RoleClicked == true)
            {
                NO1_RoleClicked = false;
                NO2_RoleClicked = false;
                NO3_RoleClicked = false;
                NO4_RoleClicked = false;
                CreateCharacter(choose_role, select_gender);
            }
        }

        public void CreateCharacter(string choose_role, string select_gender)
        {
            //Zapsání veškerých dat o postavě
            player = new Player(select_gender, choose_role);
            //Generování postavy do hry
            if (select_gender == "Boy")
            {
                if ((choose_role == "Hunter") || (choose_role == "Mage") || (choose_role == "Devil"))
                {
                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    TellMeStory();
                }
                else
                {
                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    TellMeStory();
                }
            }
            if (select_gender == "Girl")
            {
                if (choose_role == "Warrior")
                {

                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".png"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    TellMeStory();
                    //Content.NavigationService.Navigate(new Game(this));
                }
                else
                {

                    ImageSource PlayerCharacterSource = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(PlayersCharacter, PlayerCharacterSource);
                    //Generování postavy do inventáře
                    ImageSource enSource4 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(InventoryCharacterPic, enSource4);
                    //Generování postavy do boje
                    ImageSource enSource5 = new BitmapImage(new Uri("pack://application:,,,/Pictures/Characters/" + choose_role + "_" + select_gender + ".gif"));
                    ImageBehavior.SetAnimatedSource(Player, enSource5);
                    TellMeStory();

                }
            }
        }

        //Konfigurace menu, co se kdy má zavřít, co se má kdy blokovat atd
        private void MenuChanged(object sender, SelectionChangedEventArgs e)
        {
            if (menu.IsSelected)
            {
                menu.IsSelected = true; //vynuceně otevře
                inv.IsEnabled = false; // zakáže přístup
                lore.IsEnabled = false;
                game.IsEnabled = false;
                fight.IsEnabled = false;
                result.IsEnabled = false;
                shop.IsEnabled = false;
                invis(shop);
                invis(result);
                invis(fight);
            }

            if (game.IsSelected)
            {
                game.IsSelected = true;
                game.IsEnabled = true;
                fight.IsEnabled = false;
                lore.IsEnabled = true;
                menu.IsEnabled = false;
                inv.IsEnabled = true;
                result.IsEnabled = false;
                invis(fight);
                invis(result);
                player.Level(player.XP);

            }
            if (inv.IsSelected)
            {
                inv.IsSelected = true;
                fight.IsEnabled = false;
                result.IsEnabled = false;
                result.Visibility = Visibility.Hidden;
                fight.Visibility = Visibility.Hidden;
                game.IsEnabled = true;
                menu.IsEnabled = false;
                OpenInvent();

            }
            if (lore.IsSelected)
            {
                lore.IsSelected = true;
                fight.IsEnabled = false;
                result.IsEnabled = false;
                game.IsEnabled = true;
                result.Visibility = Visibility.Hidden;
                fight.Visibility = Visibility.Hidden;
                menu.IsEnabled = false;
                TellMeStory();
            }
            if (fight.IsSelected)
            {
                fight.Visibility = Visibility.Hidden;
                fight.IsSelected = true;
                menu.IsEnabled = false;
                inv.IsEnabled = false;
                lore.IsEnabled = false;
                game.IsEnabled = false;
                result.IsEnabled = false;
                result.Visibility = Visibility.Hidden;
                invis(UseHeal);
                invis(UseMana);
                invis(BattleHealPotion);
                invis(BattleManaPotion);
               // StartOfFight();
            }
        }

        public void TellMeStory()
        {
            lore.IsSelected = true;
            invis(Lore2);
            invis(Lore3);
            invis(Lore4);
            invis(LoreGif3);
            invis(LoreGif2);
            invis(LoreGif4);
            invis(NextLore3);
            invis(NextLore4);
            invis(BackLore1);
            invis(BackLore2);
            invis(BackLore3);
            invis(ToGameButton);
            vis(Lore1);
            vis(LoreGif1);
            vis(NextLore2);
            //invis(LoreGif3);
        }

        //Funkce, kde nastavuji začínající zápas (kdo hráče vyzval, nastavuji gif v boji, aby byl přizpůsoben)
        public void StartOfFight(string location)
        {
            fight.IsSelected = true;

            monster = new Monster(location);
            ImageSource enSource = new BitmapImage(new Uri(monster.Url));
            ImageBehavior.SetAnimatedSource(Monster, enSource);

            //Bojový systém
            EnemyHP.Maximum = monster.HP;
            EnemyHP.Value = monster.HP;
            PlayerHP.Maximum = player.HP;
            PlayerHP.Value = player.HP;
            PlayerMP.Maximum = player.MP;
            PlayerMP.Value = player.MP;

            FightSystem(monster);
        }

        //Přepnutí v boji do batohu (inventáře)
        private void Invent_Click(object sender, RoutedEventArgs e)
        {
            UseHeal.Content = "Uzdravit (" + player.Heal + "x)";
            UseMana.Content = "Doplnit manu (" + player.Mana + "x)";
            if (InventClicker == true)
            {
                InventClicker = false;
                vis(UseHeal);
                vis(UseMana);
                vis(BattleHealPotion);
                vis(BattleManaPotion);
            }else
            {
                InventClicker = true;
                invis(UseHeal);
                invis(UseMana);
                invis(BattleManaPotion);
                invis(BattleHealPotion);
            }
        }

        private void UseHeal_Click(object sender, RoutedEventArgs e)
        {
            if (player.Heal >= 1)
            {
                player.Heal -= 1;
                player.HP += 100;
                PlayerHP.Value = player.HP;
                UseHeal.Content = "Doplnit životy: (" + player.Heal + "x)";
            }else
            {
                UseHeal.Content = "Nemáte elixíry!";
            }
        }

        private void UseMana_Click(object sender, RoutedEventArgs e)
        {
            if (player.Mana >= 1)
            {
                player.Mana -= 1;
                player.MP += 100;
                PlayerMP.Value = player.MP;
                UseMana.Content = "Doplnit manu: (" + player.Mana + "x)";
            }else
            {
                UseMana.Content = "Nemáte elixíry!";
            }
        }

        private void FightSystem(Monster monster)
        {
            //Připravení WPF
            invis(attack_1);
            invis(attack_2);
            invis(attack_3);
            invis(attack_back);
            vis(invent);
            vis(attack);

            if (PlayerHP.Value == 0)
            {
                result.IsSelected = true;
                result_fight.Content = "Zemřel jsi! Budeš oživen v nejbližším městě!";
                player = new Player(select_gender, choose_role, player.XP, player.Coin, player.Heal, player.Mana);
                player.XP += 25;
            }
        }
        //Interakce s buttony v boji -> Bojový interface pro ovládání postavy v boji

        //Pokud hráč klikne na tlačítko, kde vybírá způsob boje
        private void attack_Click(object sender, RoutedEventArgs e)
        {
            invis(invent);
            invis(attack);

            vis(attack_1);
            vis(attack_2);
            vis(attack_3);
            vis(attack_back);
        }

        private void attack_1_Click(object sender, RoutedEventArgs e)
        {
            attack_1.Content = "Základní útok";
            if (EnemyHP.Value <= 5)
            {
                switch (player.role)
                {
                    case "Mage":
                        ILoot loot_mage = new LootMage();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_mage.generateLoot();
                        player.XP += 50;
                        player.Coin += 200;
                        result.IsSelected = true;

                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Devil":
                        ILoot loot_devil = new LootDevil();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_devil.generateLoot();
                        player.XP += 50;
                        player.Coin += 200;
                        break;

                    case "Warrior":
                        ILoot loot_warrior = new LootWarrior();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_warrior.generateLoot();
                        player.XP += 50;
                        player.Coin += 200;
                        break;

                    case "Hunter":
                        ILoot loot_hunter = new LootHunter();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_hunter.generateLoot();
                        player.XP += 50;
                        player.Coin += 200;
                        break;
                }
            }
            List<string> LuckyShot = new List<string>(); //List, který udává v boji prvek náhody (jaký útok nepřítel použije)
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            Random Luckyshot = new Random();
            int RandomTypeOfDamage = Luckyshot.Next(0, 8);
            ChooseDamage = LuckyShot[RandomTypeOfDamage];

            IPlayerAttack PlayerAttack = new BasicPlayerAttack();
            EnemyHP.Value = PlayerAttack.DoDamage(player, monster);
            if (ChooseDamage == "SpecialAttackMonster")
            {
                IAttackMonster Attack = new SpecialAttackMonster();
                PlayerHP.Value = Attack.GetDamage(player, monster);
            }
            else
            {
                IAttackMonster Attack = new BasicAttackMonster();
                PlayerHP.Value = Attack.GetDamage(player, monster);
            }
            if (PlayerHP.Value == 0)
            {
                result.IsSelected = true;
                result_fight.Content = "Zemřel jsi! Budeš oživen v nejbližším městě!";
                player = new Player(select_gender, choose_role, player.XP, player.Coin, player.Heal, player.Mana);
                player.XP += 25;
            }
        }

        private void attack_2_Click(object sender, RoutedEventArgs e)
        {
            attack_2.Content = "Silný útok";
            PlayerMP.Value = player.MP;
            List<string> LuckyShot = new List<string>(); //List, který udává v boji prvek náhody (jaký útok nepřítel použije)
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            Random Luckyshot = new Random();
            int RandomTypeOfDamage = Luckyshot.Next(0, 8);
            ChooseDamage = LuckyShot[RandomTypeOfDamage];
            //Když vykástí spell, na který nemá dostatek many
            if (PlayerMP.Value < 10)
            {
                attack_2.Content = "Nemáš dostatek many!";
            }
            else
            {
                if (ChooseDamage == "SpecialAttackMonster")
                {
                    IAttackMonster Attack = new SpecialAttackMonster();
                    PlayerHP.Value = Attack.GetDamage(player, monster);
                }
                else
                {
                    IAttackMonster Attack = new BasicAttackMonster();
                    PlayerHP.Value = Attack.GetDamage(player, monster);
                }
                IPlayerAttack PlayerAttack = new StrongerPlayerAttack();
                EnemyHP.Value = PlayerAttack.DoDamage(player, monster);
                PlayerMP.Value -= 10;
                player.MP -= 10;

                if (PlayerHP.Value == 0)
                {
                    result.IsSelected = true;
                    result_fight.Content = "Zemřel jsi! Budeš oživen v nejbližším městě!";
                    player = new Player(select_gender, choose_role, player.XP, player.Coin, player.Heal, player.Mana);
                    player.XP += 25;
                    player.Coin -= 100;
                }

            }

            if (EnemyHP.Value <= 5)
            {
                switch (player.role)
                {
                    case "Mage":
                        ILoot loot_mage = new LootMage();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_mage.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Devil":
                        ILoot loot_devil = new LootDevil();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_devil.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Warrior":
                        ILoot loot_warrior = new LootWarrior();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_warrior.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Hunter":
                        ILoot loot_hunter = new LootHunter();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + " " + loot_hunter.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;
                }
            }
        }

        private void attack_3_Click(object sender, RoutedEventArgs e)
        {
            PlayerMP.Value = player.MP;
            attack_3.Content = "Speciální útok";
            List<string> LuckyShot = new List<string>(); //List, který udává v boji prvek náhody (jaký útok nepřítel použije)
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("SpecialAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            LuckyShot.Add("BassicAttackMonster");
            Random Luckyshot = new Random();
            int RandomTypeOfDamage = Luckyshot.Next(0, 8);
            ChooseDamage = LuckyShot[RandomTypeOfDamage];
            if (PlayerMP.Value < 60)
            {
                attack_3.Content = "Nemáš dostatek many!";
            }
            else
            {
                if (ChooseDamage == "SpecialAttackMonster")
                {
                    IAttackMonster Attack = new SpecialAttackMonster();
                    PlayerHP.Value = Attack.GetDamage(player, monster);
                }
                else
                {
                    IAttackMonster Attack = new BasicAttackMonster();
                    PlayerHP.Value = Attack.GetDamage(player, monster);
                }
                IPlayerAttack PlayerAttack = new SpecialPlayerAttack();
                EnemyHP.Value = PlayerAttack.DoDamage(player, monster);
                PlayerMP.Value -= 60;
                player.MP -= 60;

            }

            if (PlayerHP.Value == 0)
            {
                result.IsSelected = true;
                result_fight.Content = "Zemřel jsi! Budeš oživen v nejbližším městě!";
                player = new Player(select_gender, choose_role, player.XP, player.Coin, player.Heal, player.Mana);
                player.XP += 25;
                player.Coin -= 100;
            }

            if (EnemyHP.Value == 0)
            {
                switch (player.role)
                {
                    case "Mage":
                        ILoot loot_mage = new LootMage();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + loot_mage.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Devil":
                        ILoot loot_devil = new LootDevil();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + loot_devil.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Warrior":
                        ILoot loot_warrior = new LootWarrior();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + loot_warrior.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;

                    case "Hunter":
                        ILoot loot_hunter = new LootHunter();
                        result_fight.Content = "Vyhrál jsi bitvu! Z bitvy si odnášíš tyto itemy:" + loot_hunter.generateLoot();
                        result.IsSelected = true;
                        player.XP += 50;
                        player.Coin += 200;
                        fight.Visibility = Visibility.Hidden;
                        break;
                }
            }
        }
        private void attack_back_Click(object sender, RoutedEventArgs e)
        {
            invis(attack_1);
            invis(attack_2);
            invis(attack_3);
            invis(attack_back);
            vis(invent);
            vis(attack);
        }

        private void ConfirmMyResult_Click(object sender, RoutedEventArgs e)
        {
            game.IsSelected = true;
        }

        //Systém pohybu postavy

        //xml detekce - KeyDown="KeyDownHandler"
        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            UIElement element = PlayersCharacter;

            if (element != null)
            {
                double left = Canvas.GetLeft(element);
                if (Double.IsNaN(left)) left = 0;
                double top = Canvas.GetTop(element);
                if (Double.IsNaN(top)) top = 0;

                if(!(Canvas.GetTop(PlayersCharacter) < 20))
                {
                    if (e.Key == Key.Up) { top -= 40; }
                }
               /* int widthPL = (Convert.ToInt32(myAwesomeCanvas.ActualWidth));
                if (!(Convert.ToInt32(myAwesomeCanvas.ActualWidth) < (Canvas.GetLeft(PlayersCharacter) + widthPL)))
                {
                    if (e.Key == Key.Right) { left += 40; }
                }*/
                if (e.Key == Key.Right) { left += 40; }
                if (e.Key == Key.Left) { left -= 40; }
               // else if (e.Key == Key.Up) { top -= 40; }
                if (e.Key == Key.Down) { top += 40; }

                Canvas.SetLeft(element, left);
                Canvas.SetTop(element, top);
            }

            e.Handled = true;
        }
        /*
int widthPL = (Convert.ToInt32(myAwesomeCanvas.ActualWidth));
if || (Canvas.GetLeft(PlayersCharacter) < 0)))
{
    Canvas.SetLeft(element, left);
}

        Canvas.SetLeft(element, left);
                Canvas.SetTop(element, top);

                
             herní plocha 200
             šířka hráče 20

            == max odražení od leva hráče 180 == herní plocha - šířka hráče

            if(!(maximální pozice < pozice hráče + šířka hráče)){
             
                
             */


        //Inventář

        //Metody pro skrytí a odkrytí buttonů / inputů
        void invis(UIElement el)
        {
            el.Visibility = Visibility.Hidden;
        }

        void vis(UIElement el)
        {
            el.Visibility = Visibility.Visible;
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            // Create a file to write to. 
            string path = "save.txt";
            string createText = player.gender + Environment.NewLine + player.role + Environment.NewLine + player.XP + Environment.NewLine + player.HP + Environment.NewLine + player.MP + Environment.NewLine + player.Coin + Environment.NewLine + player.Heal + Environment.NewLine + player.Mana + Environment.NewLine + player.Cleared_Locations + Environment.NewLine + player.Won;
            File.WriteAllText(path, createText);
        }

        private void BackToPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            ContinueToMenu();
        }

        private void NextLore2_Click(object sender, RoutedEventArgs e)
        {
            vis(Lore2);
            vis(LoreGif2);
            vis(NextLore3);
            vis(BackLore1);
            invis(Lore1);
            invis(LoreGif1);
            invis(LoreGif3);
            invis(Lore3);
            invis(NextLore2);
            invis(Lore4);
            invis(LoreGif4);
            invis(NextLore4);
        }

        private void NextLore3_Click(object sender, RoutedEventArgs e)
        {
            vis(NextLore4);
            vis(BackLore2);
            vis(Lore3);
            vis(LoreGif3);
            invis(Lore2);
            invis(LoreGif2);
            invis(NextLore3);
            invis(Lore4);
            invis(LoreGif4);
            invis(Lore1);
            invis(LoreGif1);
            invis(BackLore3);
            invis(BackLore1);
        }

        private void NextLore4_Click(object sender, RoutedEventArgs e)
        {
            vis(Lore4);
            vis(LoreGif4);
            vis(ToGameButton);
            vis(BackLore3);
            invis(Lore3);
            invis(LoreGif3);
            invis(NextLore4);
            invis(Lore2);
            invis(LoreGif2);
            invis(Lore1);
            invis(LoreGif1);
            invis(BackLore1);
            invis(BackLore2);
        }

        private void BackLore3_Click(object sender, RoutedEventArgs e)
        {
            vis(Lore3);
            vis(LoreGif3);
            vis(BackLore2);
            vis(NextLore4);
            invis(Lore4);
            invis(LoreGif4);
            invis(ToGameButton);
            invis(BackLore3);
            invis(Lore2);
            invis(LoreGif2);
            invis(Lore1);
            invis(LoreGif1);

        }

        private void BackLore2_Click(object sender, RoutedEventArgs e)
        {
            invis(Lore1);
            invis(LoreGif1);
            invis(Lore3);
            invis(LoreGif3);
            vis(BackLore1);
            invis(BackLore2);
            invis(BackLore3);
            invis(NextLore4);
            vis(Lore2);
            vis(LoreGif2);
            vis(NextLore3);
        }

        private void BackLore1_Click(object sender, RoutedEventArgs e)
        {
            vis(Lore1);
            vis(LoreGif1);
            invis(Lore2);
            invis(LoreGif2);
            invis(BackLore1);
            vis(NextLore2);
            invis(NextLore3);
            invis(NextLore4);
            invis(Lore3);
            invis(LoreGif3);
            invis(BackLore2);
            invis(BackLore3);
        }

        private void ToGameButton_Click(object sender, RoutedEventArgs e)
        {
            game.IsSelected = true;
        }

        private void Reach_Explore_Click(object sender, RoutedEventArgs e)
        {
            string location = "Reach";
            StartOfFight(location); //Posílat data o lokaci boje
        }

        private void WhiteRun_Explore_Click(object sender, RoutedEventArgs e)
        {
            string location = "WhiteRun";
            StartOfFight(location); //Posílat data o lokaci boje
        }

        private void WinterHold_Explore_Click(object sender, RoutedEventArgs e)
        {
            string location = "WinterHold";//Posílat data o lokaci boje
            StartOfFight(location);
        }

        private void Rift_Explore_Click(object sender, RoutedEventArgs e)
        {
            string location = "Rift";
            StartOfFight(location);
        }
    }
}

    

