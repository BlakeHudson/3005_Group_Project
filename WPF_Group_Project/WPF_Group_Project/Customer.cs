using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Address { set; get; }

        public Customer(string fn, string ln, int age, string ad)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = age;
            this.Address = ad;
        }
    }
}
