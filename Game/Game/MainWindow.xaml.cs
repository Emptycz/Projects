using Game.Data;
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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player p = new Player();
        public MainWindow()
        {
            InitializeComponent();
            //načtení

            MyHP.Value = 100;
            EnemyHP.Value = 100;
            function();
        }

        private void function()
        {

            List<string> Monsters = new List<string>();
            Monsters.Add(" Scorpion");
            Monsters.Add(" Minotaur");

            Random rnd = new Random();
            //string monster = rnd.Next(Monsters).ToString();
            
            string attack_msg = "You are attacked by" + Monsters[0] ;
            Attacker.Text = attack_msg;
            
        }

        private void fight_Click(object sender, RoutedEventArgs e)
        {
            string fighting = fight.Content.ToString();
            function();
            checkItOut(fighting);
        }

        private void ultimate_Click(object sender, RoutedEventArgs e)
        {
            string fighting = ultimate.Content.ToString();
            function();
            checkItOut(fighting);      
        }

        public void checkItOut(string fighting)
        {

            Random rnd = new Random();
            int randomed = rnd.Next(1, 15);

            Random lck = new Random();
            int lucky = lck.Next(1, 101);

            switch (randomed)
            {
                case 1:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 2:
                    Notifications.Text = "Vyhl jsi se";
                    break;


                case 3:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 6:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 7:
                    Notifications.Text = "Uskočil jsi";
                    break;

                case 8:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 11:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 12:
                    MyHP.Value = MyHP.Value - 10;
                    break;

                case 5:
                    MyHP.Value = MyHP.Value - 30;
                    Notifications.Text = "Dostal jsi kritický zásah!";
                    break;
            }

            //Bude fungovat na principu "štěstí" se změní postava protivníka
            switch (lucky)
            {
                case 20:
                    //Odřezání části těla
                    break;
            }     
            

            if (fighting == "Attack")
            {
                EnemyHP.Value = EnemyHP.Value - 10;
                SpecialAttackBar.Value = SpecialAttackBar.Value + 5;
            }
            else if (fighting == "Ultimate Attack")
                if (SpecialAttackBar.Value == 100)
                {
                    {
                        EnemyHP.Value = EnemyHP.Value - 1000;
                        SpecialAttackBar.Value = 0;
                    }
                }
            if(EnemyHP.Value == 0)
            {
                Attacker.Text = "You are defeated Scorpion!";
                EnemyHP.Value = 100;
                function();
            }

            if (MyHP.Value == 0)
            {            
                Attacker.Text = "You are dead";

            }
        }


    }
}
