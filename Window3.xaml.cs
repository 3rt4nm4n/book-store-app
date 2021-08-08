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
using System.Collections;


namespace LabWorkQ2
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            foreach(string i in Window2.bookIt)
            {
                bookList.Items.Add(i.ToString()); //at this line previously created bookIt is executed and the object adds the books to the list
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e) //if this button is clicked the user will be directed to the window2
        {
            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) //if user selects a book in the list and clicks delete button, the selected item (book) will be removed.
        {

            bookList.Items.Remove(bookList.SelectedItem);

        }

        private void closeButton_Click(object sender, RoutedEventArgs e) //when this button is clicked the program will close
        {
            this.Close(); 
        }
    }
}
