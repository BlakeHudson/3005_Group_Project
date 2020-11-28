using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            this.customers = new List<Customer>();
        }

        public string show()
        {
            string cl = "";
            foreach(Customer c in customers)
            {
                cl += c.LastName + ", " + c.FirstName + " age: " + c.Age + " address: " + c.Address;
            }
            return cl;
        }
    }
}
