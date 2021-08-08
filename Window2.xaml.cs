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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections;

namespace LabWorkQ2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public static ObservableCollection<string> bookIt = new ObservableCollection<string>(); //here we create a new object using this dynamic data collector in order to keep the selected item in it and pass it to the next window
        private void cnfromChkBox_Click(object sender, RoutedEventArgs e) //here if the checkbox is checked,  the user will confirm and be able to click next button. the button is not enabled to click in default in XAML code line
        {
            if (cnfromChkBox.IsChecked == true)
            {
                nextButton.IsEnabled = true;
            }
            else if (cnfromChkBox.IsChecked == false)
            {
                nextButton.IsEnabled = false;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e) //when the user is allowed and presses this button the user will be directed to the next page
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e) //when the user presses this button the created object will get the 
        {
            
            bookIt.Add(bookCmbBox.Text.ToString());
        }

        private void catCmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e) //here when the category is changed different books will be shown.
        {
            if(catCmbBox.SelectedItem == AdventureCat)
            {
                bookCmbBox.Items.Clear(); // the reason why I have wrote this is because when I changed the categories the category book combobox would combine the previous books with chosen category
                bookCmbBox.Items.Add("The Hobbit");
                bookCmbBox.Items.Add("Lord of the Rings");
                bookCmbBox.Items.Add("Gulliver's Travels");
            }
          
            else if (catCmbBox.SelectedItem == ClassicsCat)
            {
                bookCmbBox.Items.Clear();
                bookCmbBox.Items.Add("Jane Eyre");
                bookCmbBox.Items.Add("1984");
                bookCmbBox.Items.Add("Animal Farm");
            }
            
            else if (catCmbBox.SelectedItem == SciFiCat)
            {
                bookCmbBox.Items.Clear();
                bookCmbBox.Items.Add("The Martian");
                bookCmbBox.Items.Add("Red Mars");
                bookCmbBox.Items.Add("Fahrenheit 451");
            }

        }

       
    }
}
