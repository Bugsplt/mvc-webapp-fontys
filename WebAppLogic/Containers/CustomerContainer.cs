using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Classes;


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
        
        public void Remove(CustomerDTO customer)
        {
            try
            { 
                _apiCallManager.RemoveCustomer(customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Customers.Remove(Customers.Find(c => c.Id == customer.Id));
        }
                        
        public void Update(CustomerDTO customer)
        {
            try
            {
                _apiCallManager.UpdateCustomerDetails(customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            var customerToUpdate = Customers.Find(c => c.Id == customer.Id);
            Customers.Remove(customerToUpdate);
            Customers.Add(new Customer(customer));
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
                Customers.Remove(customer);
                var customerDto = _apiCallManager.LoadCustomerDetailView(id);
                Customers.Add(new Customer(customerDto));
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

        public int Create(CustomerDTO customer)
        {
            int id;
            try
            {
                id = _apiCallManager.CreateCustomer(customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Customers.Add(new Customer(customer));
            return id;
        }

        public CustomerContainer(IApiCallManager apiCallManager)
        {
            _apiCallManager = apiCallManager;
        }
    }
}