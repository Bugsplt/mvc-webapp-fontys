using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Classes;
using WebAppDAL;

namespace LogicLayer.Containers
{
    public class CustomerContainer
    {
        private IApiCallManager _apiCallManager;
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

        public void SetCustomers(List<Customer> customers)
        {
            Customers = customers;
        }

        public Customer GetCustomer(string id)
        {
            Load();
            foreach (var customer in Customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }
        
        public CustomerDTO LoadCustomer(string id)
        {
            var customer = GetCustomer(id);
            if (customer != null)
            {
                Remove(customer);
                var customerDto = _apiCallManager.LoadCustomerDetailView(id);
                Add(new Customer(customerDto));
                return customerDto;
            }
            else
            {
                return null;
            }
        }
        
        public void Load()
        {
            Clear();
            var (prospects, customers) = _apiCallManager.LoadCustomerView();
            foreach (var customerDto in customers)
            {
                Customers.Add(new Customer(customerDto));
            }
        }

        public CustomerContainer(IApiCallManager apiCallManager)
        {
            _apiCallManager = apiCallManager;
        }
    }
}