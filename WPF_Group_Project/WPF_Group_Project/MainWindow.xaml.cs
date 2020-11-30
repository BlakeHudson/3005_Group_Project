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
        CustomerList customers = new CustomerList();
        public MainWindow()
        {
          
           customers.AddCustomer(new Customer("Erin", "Stock", 17, "3817 benjamin drive"));
           customers.AddCustomer(new Customer("James", "Default", 22, "3818 benjamin drive"));
           customers.AddCustomer(new Customer("Michael", "LastName", 21, "3819 benjamin drive"));
           InitializeComponent();
           UpdateDisplay();
            
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            //new TruckWindow truckWindow(customers.GetCustomerAtIndex(CustomersDisplay.SelectedIndex));

            //this will open the truck rental window for the selected listbox member
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer selected = customers.GetCustomerAtIndex(CustomersDisplay.SelectedIndex);
            customers.RemoveCustomerAtIndex(CustomersDisplay.SelectedIndex);
            AddPrompt addPrompt = new AddPrompt(selected.FirstName,selected.LastName,selected.Age,selected.Address);
            
            addPrompt.ShowDialog();
  
            customers.AddCustomer(new Customer(addPrompt.FirstNameBox.Text, addPrompt.LastNameBox.Text, int.Parse(addPrompt.BirthdayBox.Text), addPrompt.AddressBox.Text));

            UpdateDisplay();
              
            //this function will open the add window with the variables from the selected listbox member
            //It will probably have to delete the old member and just make a copy of it
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

            customers.RemoveCustomerAtIndex(CustomersDisplay.SelectedIndex);
            UpdateDisplay();
            //this function removes the highlighted customer
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPrompt addPrompt = new AddPrompt();

            addPrompt.ShowDialog();

            customers.AddCustomer(new Customer(addPrompt.FirstNameBox.Text, addPrompt.LastNameBox.Text, int.Parse(addPrompt.BirthdayBox.Text), addPrompt.AddressBox.Text));

            UpdateDisplay();
            //This function opens a new window to add a new customer to the listbox source
        }

       
        private void CustomersDisplay_SelectionChanged(object sender,RoutedEventArgs e){
            UpdateDisplay();
        }
      
        private void UpdateDisplay(){
            
           if(CustomersDisplay.SelectedIndex < customers.GetCustomers().Count){
                Customerinfo.Text = "";
                if(CustomersDisplay.SelectedIndex >= 0 )
                    Customerinfo.Text = customers.GetCustomerAtIndex(CustomersDisplay.SelectedIndex).ToString();
           }
           CustomersDisplay.ItemsSource = customers.GetCustomerNames();
             
        }
    }
}
