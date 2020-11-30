using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public string Address { set; get; }

        public Customer(string fn, string ln, int id, string ad)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Id = id;
            this.Address = ad;
        }
        public override string ToString()
        {
            return LastName + ", " + FirstName + "\n Customer ID: " + Id + "\n Address: " + Address;
        }
    }
}
