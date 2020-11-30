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

namespace WPF_Group_Project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddPrompt : Window
    {
        public bool buildFlag = false;
        public AddPrompt()
        {
            InitializeComponent();
        }
        public AddPrompt(string first ,string last, int age,string address )
        {
            InitializeComponent();
            FirstNameBox.Text = first;
            LastNameBox.Text = last;
            BirthdayBox.Text = ""+age;
            AddressBox.Text = address;
        }

        public void CustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();            
        }
    }
}
