using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    [System.Serializable]
    class CustomerList
    {
        private List<Customer> customers;
        public CustomerList()
        {
            this.customers = new List<Customer>();
        }

        public int GetCount()
        {
            return customers.Count();
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
        public int GetCustomerIndexById(int id)
        {
            int i = -1;
            foreach(Customer c in customers)
            {
                if(c.Id == id)
                {
                    return customers.IndexOf(c);
                }
            }
            return i;
        }
        // Returns the customer list
        public List<Customer> GetCustomers()
        {
            return this.customers;
        }
        public Customer GetCustomerAtIndex(int i){
            if (i >= customers.Count)
            {
                throw new System.IndexOutOfRangeException("Number " + i.ToString() + " is out of range of current amount of customers");
            }
            return customers[i];
        }
         public List<string> GetCustomerNames()
        {
            List<string> names = new List<string>();
            foreach(Customer i in customers){
                names.Add(i.FirstName + " " + i.LastName);
            }                                           
            return names;
        }

        /*
         * Returns one larger string of all customers in list
         */
        public override string ToString()
        {
            string cl = "";
            foreach(Customer c in customers)
            {
                cl += c.LastName + ", " + c.FirstName + "\n  age: " + c.Id + "\n address: " + c.Address;
            }
            return cl;
        }
    }
}