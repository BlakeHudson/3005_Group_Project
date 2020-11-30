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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WPF_Group_Project
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class TruckRental : Window
    {
        Inventory trucks = new Inventory();
        public TruckRental()
        {
            
            InitializeComponent();
            if (!File.Exists("Trucks.dat"))
            {
                trucks.AddTruck(new Truck(1234, 3, true, 20.00));
                trucks.AddTruck(new Truck(5678, 2, false, 18.00));
                trucks.AddTruck(new Truck(9101, 1, true, 15.00));
            } else
            {
                LoadTrucks();
            }
            UpdateDisplay();
        }
        public TruckRental(Customer customer):this()
        {
            
            UserTitle.Content = customer.FirstName + " " + customer.LastName;
        }

        public void LoadTrucks()
        {
            if (File.Exists("Trucks.dat"))
            {
                Stream s = File.OpenRead("Trucks.dat");
                BinaryFormatter b = new BinaryFormatter();
                trucks = (Inventory)b.Deserialize(s);
                s.Close();
            }
        }

        public void SaveTrucks()
        {
            Stream s = File.OpenWrite("Trucks.dat");
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, trucks);
            s.Close();
        }

        public void UpdateDisplay()
        {
            List<int> truckIDs= new List<int>();
            List<string> trucksize = new List<string> ();
            List<string> truckStatus = new List<string>();
            List<double> truckCost = new List<double>();
            foreach(Truck truck in trucks.GetTrucks())
            {
                truckIDs.Add(truck.Id);
                switch (truck.Size)
                {
                    case 1:
                        trucksize.Add("Small");
                        break;
                    case 2:
                        trucksize.Add("Medium");
                        break;
                    case 3:
                        trucksize.Add("Large");
                        break;
                    default:
                        trucksize.Add("UNKNOWN");
                        break;

                }
                if (truck.IsRented())
                {
                    truckStatus.Add("Available");
                }
                else
                {
                    truckStatus.Add("UnAvailable");
                }
                truckCost.Add(truck.cost);
            }

            TruckID.ItemsSource = truckIDs;
            TruckSize.ItemsSource = trucksize;
            TruckStatus.ItemsSource = truckStatus;
            TruckCost.ItemsSource = truckCost;
            SaveTrucks();
            TruckSize.SelectedIndex = TruckID.SelectedIndex;
            TruckStatus.SelectedIndex = TruckID.SelectedIndex;
            TruckCost.SelectedIndex = TruckID.SelectedIndex;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox box = e.Source as ListBox;
            TruckID.SelectedIndex = box.SelectedIndex;
            TruckSize.SelectedIndex = box.SelectedIndex;
            TruckStatus.SelectedIndex = box.SelectedIndex;
            TruckCost.SelectedIndex = box.SelectedIndex;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            TruckAddPrompt addPrompt = new TruckAddPrompt();

            
            addPrompt.ShowDialog();
            if (addPrompt.IDBox.Text == "" || addPrompt.SizeBox.SelectedIndex < 0 || addPrompt.CostBox.Text == "")
            {
                return;
            }
            trucks.AddTruck(new Truck(int.Parse(addPrompt.IDBox.Text), addPrompt.SizeBox.SelectedIndex+1, (addPrompt.AvailableButton.IsChecked==true), double.Parse( addPrompt.CostBox.Text)));
            SaveTrucks();
            UpdateDisplay();

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if(TruckID.SelectedIndex < 0)
            {
                return;
            }
            Truck truckItem = trucks.GetTruck(TruckID.SelectedIndex);
            TruckAddPrompt addPrompt = new TruckAddPrompt(truckItem.Id,truckItem.Size,truckItem.IsRented(),truckItem.cost);

            
            addPrompt.ShowDialog();

            trucks.RemoveTruckAtIndex(TruckID.SelectedIndex);
            trucks.AddTruck(new Truck(int.Parse(addPrompt.IDBox.Text), addPrompt.SizeBox.SelectedIndex+1, (addPrompt.AvailableButton.IsChecked == true), double.Parse(addPrompt.CostBox.Text)));
            SaveTrucks();
            UpdateDisplay();

        }
    }
}
