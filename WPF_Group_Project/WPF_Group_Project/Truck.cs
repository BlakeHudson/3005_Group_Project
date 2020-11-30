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
            /*if(t.Status == true) This is unnessary complex since Status is a bool already
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return t.Status;
        }
        public bool IsRented()
        {
            return Status;
        }

        //Sets Status to false when truck is returned from being rented
        public void ReturnTruck()
        {
            Status = false;
        }
        public void ReturnTruck()
        {
            Status = false;
        }
        //Sets Status to true when truck is rented
        public void RentedTruck()
        {
            Status = true;
        }

        public void RentedTruck()
        {
            Status = true;
        }

        public void SetSize(string s)
        {
            s = s.ToLower();
            if(s == "small" || s == "s" || s == "1")
            {
                Size = 1;
            }
            if (s == "medium" || s=="m" || s == "2")
            {
                Size = 2;
            }
            if (s == "large" || s == "l" || s == "3")
            {
                Size = 3;
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

        public string GetSize()
        {
            if (Size == 1)
            {
                return "small";
            }
            if (Size == 2)
            {
                return "medium";
            }
            if (Size == 3)
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
            return "Id: " + this.Id + "size: " + GetSize(this.Size) + "Rate per day: " + this.cost;
        }
    }
}
