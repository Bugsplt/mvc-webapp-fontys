using System.Collections.Generic;
using LogicLayer.Classes;

namespace LogicLayer.Containers
{
    public class CustomerContainer
    {
        public List<Customer> Customers = new();

        public IReadOnlyList<Customer> GetCustomers()
        {
            return Customers;
        }

        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }
        
        public void Remove(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void Clear()
        {
            Customers.Clear();
        }

        public void Load()
        {
            //todo get list content from api
        }
    }
}