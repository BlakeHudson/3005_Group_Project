using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    class RentalTrans
    {
        private Customer cust;
        private Truck truck;
        private int days;       // Days of rental

        public RentalTrans(Customer c, Truck t, int d)
        {
            this.cust = c;
            this.truck = t;
            this.days = d;
        }
        // computes total
        public double ComputeTotal()
        {
            return this.days * truck.cost;
        }

        // rent
        public void RentTruck()
        {
            this.truck.RentedTruck();  // Sets status to rented
        }

        // return

    }
}
