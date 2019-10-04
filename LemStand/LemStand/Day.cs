using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemStand
{
    class Day 
    {
        //member variables(Has a)
        public Weather weather;
        public List<Customer> customers;
        public string dayName;
        //constructor(Spawner)
        public Day(string dayName)
        {
            this.dayName = dayName;
            customers = new List<Customer>();
            
            
        }

        //member methods(Can Do)
        public void SpawnCustomers()
        {
             for(int i = 1; i < 21; i++)
            {
                Customer customer = new Customer();
                customer.name += "Customer " + i;
                customers.Add(customer);
                
                

            }
        }
    }
}
