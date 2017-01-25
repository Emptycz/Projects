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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int quest_true;
        int quest_false;
        public MainWindow()
        {
            InitializeComponent();

            //načtení
            Generate();
        }



        private void AnswerTrue_Click(object sender, RoutedEventArgs e)
        {
            int bullshit = int.Parse(AnswerTrue.Content.ToString());
            checkItOut(bullshit);
            Generate();
        }

        private void AnswerFalse_Click(object sender, RoutedEventArgs e)
        {
            int bullshit = int.Parse(AnswerFalse.Content.ToString());
            checkItOut(bullshit);
            Generate();
        }


        private void Generate()
        {
            Random rnd = new Random();
            int randomed = rnd.Next(1, 500); // creates a number between 1 and 12

            Random rnd2 = new Random();
            int randomed2 = rnd2.Next(1, 100);

            Random how2 = new Random();
            int row2 = how2.Next(1, 21);

            Random how = new Random();
            int row = how.Next(1, 5);


            if (row == 1)
            {
                quest_true = randomed - randomed2;
                quest_false = randomed - randomed2 - row2;
                label.Text = randomed + " - " + randomed2;
            }
            else if (row == 2)
            {

                quest_true = randomed + randomed2;
                quest_false = randomed + randomed2 + row2;
                label.Text = randomed + " + " + randomed2;

            }
            else if (row == 3)
            {
                quest_true = randomed / randomed2;
                quest_false = randomed / randomed2 - row2;
                label.Text = randomed + " / " + randomed2;
            }
            else if (row == 4)
            {
                quest_true = randomed * randomed2;
                quest_false = randomed * randomed2 + row2;
                label.Text = randomed + " * " + randomed2;
            }

            Random po = new Random();
            int d = po.Next(1, 3);

            /*            if (d == 1)
                        {
                            AnswerFalse.Content = quest_false;
                            AnswerTrue.Content = quest_true;
                        }
                        else
                        {
                            AnswerFalse.Content = quest_true;
                            AnswerTrue.Content = quest_false;
                        }
                        */
            switch (d)
            {

                case 1:
                    AnswerFalse.Content = quest_false;
                    AnswerTrue.Content = quest_true;
                    break;

                case 2:
                    AnswerFalse.Content = quest_true;
                    AnswerTrue.Content = quest_false;
                    break;
            }
        }

        private void checkItOut(int bullshit)
        {
            if(quest_true == bullshit)
            {
                if(progress.Value == 100)
                {
                    string text = textBlock.Text;
                    int wtf = int.Parse(text);
                    progress.Value = 0;
                    wtf++;
                    textBlock.Text = wtf.ToString();
                }
                progress.Value = progress.Value + 10; 
            }
        }
    }

    
}
