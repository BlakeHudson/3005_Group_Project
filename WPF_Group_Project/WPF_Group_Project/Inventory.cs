﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Group_Project
{
    class Inventory
    {
        private List<Truck> trucks;

        public Inventory()
        {
            this.trucks = new List<Truck>();
        }
        //Adds and sorts inventory list after every addition
        public void AddTruck(Truck t)
        {
            trucks.Add(t);
            this.SortTrucks();
        }
        // Removes a truck at index provided
        public void RemoveTruckAtIndex(int i)
        {
           trucks.RemoveAt(i);
        }

        /*
         * Searches for a Truck by ID 
         * returns index of a matched truck id num
         * else returns -1 if no matching name in list
         */
        public int GetTruckIndex(int id)
        {
            int i = -1;
            foreach (Truck t in trucks)
            {
                if (t.Id == id)
                {
                    return trucks.IndexOf(t);
                }
            }
            return i;
        }
        // Sorts inventory list by truck size
        public void SortTrucks()
        {
            List<Truck> sorted = new List<Truck>();
            foreach(Truck t in this.trucks)
            {
                if(t.Size == 2)
                {
                    sorted.Add(t);
                }
            }
            foreach (Truck t in this.trucks)
            {
                if (t.Size == 1)
                {
                    sorted.Insert(0, t);
                }
                else
                {
                    sorted.Add(t);
                }
            }
            this.trucks = sorted;
        }

        /*
         * Returns one larger string of all trucks in list
         */
        public override string ToString()
        {
            string inv = "";
            foreach (Truck t in trucks)
            {
                inv += t.Id + ": size: " + t.GetSize(t.Size) + " cost: " + t.cost + "\n";
            }
            return inv;
        }
    }
}