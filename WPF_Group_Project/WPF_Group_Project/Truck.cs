using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    class Truck
    {
        public int Id { set; get;}
        public int Size { set; get; }
        private bool Status { set; get; }
        public double cost { set; get; }

        //Constructor
        public Truck(int id, int size, bool stat, double cost)
        {
            this.Id = id;
            this.Size = size;
            this.Status = stat;
            this.cost = cost;
        }
        // Returns true of truck is rented, false if available to be rented
        public bool IsRented(Truck t)
        {
            if(t.Status == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Sets Status to false when truck is returned from being rented
        public void ReturnTruck(Truck t)
        {
            t.Status = false;
        }
        //Sets Status to true when truck is rented
        public void RentedTruck(Truck t)
        {
            t.Status = true;
        }

        public void SetSize(string s)
        {
            if(s == "small")
            {
                this.Size = 1;
            }
            if (s == "medium")
            {
                this.Size = 2;
            }
            if (s == "large")
            {
                this.Size = 3;
            }
        }

        public string GetSize(int s)
        {
            if (s == 1)
            {
                return "small";
            }
            if (s == 2)
            {
                return "medium";
            }
            if (s == 3)
            {
                return "large";
            }
            else
            {
                return "unknown";
            }
        }

        public override string ToString()
        {
            return "Id: " + this.Id + "size: " + GetSize(this.Size) + "Cost: " + this.cost;
        }
    }
}
