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
        // Adds customer to end of list
        public void AddCustomer(Customer c)
        {
            customers.Add(c);
        }
        // Removes a customer at index provided
        public void RemoveCustomerAtIndex(int i)
        {
            customers.RemoveAt(i);
        }

        /*
         * Searches for a customer by lastname, firstname. 
         * returns index of a matched customer
         * else returns -1 if no matching name in list
         */
        public int GetCustomerIndex(string ln, string fn)
        {
            int i = -1;
            foreach(Customer c in customers)
            {
                if(c.LastName == ln && c.FirstName == fn)
                {
                    return customers.IndexOf(c);
                }
            }
            return i;
        }

        /*
         * Returns one larger string of all customers in list
         */
        public override string ToString()
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
