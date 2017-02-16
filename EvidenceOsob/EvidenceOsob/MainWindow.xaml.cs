using EvidenceOsob.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace EvidenceOsob
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private bool wtf = false;
        Persona person = new Persona(" ", " ", "111111", 0);
        private ObservableCollection<TodoItem> itemsFromDb;
        private TodoItem item = new TodoItem();
        private static TodoItemDatabase _database;
        private string NewFirstName;
        private string NewSecondName;
        private string NewRC;
        private int NewGender;
        private int backID;

        public MainWindow()
        {
            InitializeComponent();
            //Definování otevření této stránky při prvním spuštění
            Menu.IsSelected = true;
        }

        //Primární funkce na switchování mezi záložkami (TabItem)
        private void MenuChanged(object sender, SelectionChangedEventArgs e)
        {
            //Schování všech záložek / stránek
            Menu.Visibility = Visibility.Hidden;
            Add.Visibility = Visibility.Hidden;
            Edit.Visibility = Visibility.Hidden;
            Show.Visibility = Visibility.Hidden;
        }


        //Buttony v primárním menu
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            New_Accept_Edit.Visibility = Visibility.Hidden;
            New_Accept.Visibility = Visibility.Visible;
            Add.IsSelected = true;
            wtf = true;
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Buttony, textové pole, radiusy pro vytvoření nového profilu
        private void New_FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewFirstName = New_First_Name.Text;
        }

        private void New_Second_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewSecondName = New_Second_Name.Text;
        }

        private void New_Male_Click(object sender, RoutedEventArgs e)
        {
            NewGender = 1;
        }

        private void New_Female_Click(object sender, RoutedEventArgs e)
        {
            NewGender = 2;
        }

        private void New_RC_TextChanged(object sender, RoutedEventArgs e)
        {
            NewRC = New_RC.Text;
        }

        private void New_Accept_Click(object sender, RoutedEventArgs e)
        {
            New_Accept_Edit.Visibility = Visibility.Visible;
            New_Accept.Visibility = Visibility.Hidden;
            Write();
            ShowItems();
        }

        private void Editation()
        {
            TodoItem item = new TodoItem();
            New_Accept.Visibility = Visibility.Hidden;
            New_Accept_Edit.Visibility = Visibility.Visible;
            long perNum2;
            Add.IsSelected = true;

            if ((!(String.IsNullOrEmpty(New_First_Name.Text) && String.IsNullOrEmpty(New_Second_Name.Text) && String.IsNullOrEmpty(New_RC.Text) && long.TryParse(New_RC.Text, out perNum2))))
            {
                //pro editaci získat id pomocí rodného čísla a dát itemu získané id
                person = new Persona(New_First_Name.Text.ToString(), New_Second_Name.Text.ToString(), New_RC.Text, NewGender);

                item.ID = backID;
                item.FirstName = person.FirstName;
                item.SecondName = person.SecondName;
                item.PrivateID = person.PrivateID;
                item.Age = person.Age;
                item.Gender = person.Gender;

                ClearBoxes();

                Database.SaveItemAsync(item);
                ShowItems();

            }
            ShowItems();
        }
    

        private void Write()
        {
            New_Accept_Edit.Visibility = Visibility.Hidden;
            New_Accept.Visibility = Visibility.Visible;

            //Zapsání do databáze
            Persona person = new Persona(NewFirstName, NewSecondName, NewRC, NewGender);
            item.ID = person.ID;
            item.FirstName = person.FirstName;
            item.SecondName = person.SecondName;
            item.PrivateID = person.PrivateID;
            item.Gender = person.Gender;
            item.Age = person.Age;

            ClearBoxes();
            Database.SaveItemAsync(item);
            Menu.IsSelected = true;
        }

        private void fillComboBox()
        {
            // ... A List.
            List<string> data = new List<string>();
            var itemsFromDb = Database.GetItemsAsync().Result;

            foreach (TodoItem Item in itemsFromDb)
            {
                data.Add(Item.PrivateID);
            }

            data.Add("Clear");

            // ... Get the ComboBox reference.
            var comboBox = myComboBox;

            // ... Assign the ItemsSource to the List.
            comboBox.ItemsSource = data;

            // ... Make the first item selected.
            comboBox.SelectedIndex = 0;
        }

        private void ClearBoxes()
        {
            person.FirstName = "";
            person.SecondName = "";
            person.PrivateID = "";
            person.Gender = "";
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            var comboBox = myComboBox;

            string value = comboBox.SelectedItem as string;

            var itemsFromDb = Database.GetItemsAsync().Result;

            foreach (TodoItem Item in itemsFromDb)
            {
                if (Item.PrivateID == value)
                {
                    New_First_Name.Text = Item.FirstName;
                    New_Second_Name.Text = Item.SecondName;
                    New_RC.Text = Item.PrivateID;
                    backID = Item.ID;
                }
            }

            if (value == "Clear")
            {
                ClearBoxes();
            }

        }

        public static TodoItemDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var fileHelper = new FileHelper();
                    _database = new TodoItemDatabase(fileHelper.GetLocalFilePath("SQLite.db3"));
                }
                return _database;
            }
        }

        private async void ShowItems()
        {
            Show.IsSelected = true;
            await Task.Delay(50);

            var itemsFromDb = Database.GetItemsAsync().Result;

            foreach (TodoItem Item in itemsFromDb)
            {
                Debug.WriteLine(Item);
            }

            ItemsCount.Content = "Lidé uložení v databázi " + itemsFromDb.Count;
            ItemsListView.ItemsSource = itemsFromDb;
            fillComboBox();
        }

        private void ShowList_Click(object sender, RoutedEventArgs e)
        {
            Show.IsSelected = true;
            ShowItems();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add.IsSelected = true;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var it = Database.GetItemAsync(backID).Result;
            Database.DeleteItemAsync(it);
            ClearBoxes();
            ShowItems();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            wtf = false;
            Add.IsSelected = true;
        }

        private void New_Accept_Edit_Click(object sender, RoutedEventArgs e)
        {
            Editation();
            ShowItems();
        }
    }
}
