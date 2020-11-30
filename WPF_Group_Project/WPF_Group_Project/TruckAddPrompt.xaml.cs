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
    /// Interaction logic for TruckAddPrompt1.xaml
    /// </summary>
   
        
    public partial class TruckAddPrompt : Window
    {
        bool ischecked = false;
        public TruckAddPrompt()
        {
            InitializeComponent();
        }
        public TruckAddPrompt(int id,int size,bool status,double cost):this()
        {
            IDBox.Text = "" + id;
            SizeBox.SelectedIndex = size - 1;
            AvailableButton.IsChecked = status;
            ischecked = status;
            CostBox.Text = "" + cost;
        }
        public void BuildBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AvailableButton_Click(object sender, RoutedEventArgs e)
        {
            if (ischecked == true)
            {
                AvailableButton.IsChecked = false;
                ischecked = false;
            }
            else
            {
                ischecked = true;
            }

        }
    }
}
