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

namespace WPF_Group_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            //this will open the truck rental window for the selected listbox member
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPrompt addPrompt = new AddPrompt();
            addPrompt.Show();
            //this function will open the add window with the variables from the selected listbox member
            //It will probably have to delete the old member and just make a copy of it
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerList.Items.RemoveAt(CustomerList.SelectedIndex);
            //this function removes the highlighted customer
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerList.Items.Add("New Customer template");
            //This function opens a new window to add a new customer to the listbox source
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            //This function will update listbox with a new list based on search query
            Title = Search.Text;
        }
    }
}
