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
            Clear();
            var (prospectDtos, customerDtos) = _apiCallManager.LoadCustomerView();
            foreach (var customerDto in customerDtos)
            {
                Customers.Add(new Customer(_apiCallManager.LoadCustomerDetailView(customerDto.Id)));
            }
            
            return Customers;
        }

        // public void Add(Customer customer)
        // {
        //     _apiCallManager.CreateCustomer(customer.ToDto());
        //     Customers.Add(customer);
        // }
        
        public void Remove(CustomerDTO customer)
        {
            _apiCallManager.RemoveCustomer(customer);
            Customers.Remove(Customers.Find(c => c.Id == customer.Id));
        }
                        
        public void Update(CustomerDTO customer)
        {
            _apiCallManager.UpdateCustomerDetails(customer);
            var customerToUpdate = Customers.Find(c => c.Id == customer.Id);
            Customers.Remove(customerToUpdate);
            Customers.Add(new Customer(customer));
        }
        
        public void Clear()
        {
            Customers.Clear();
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
            throw new ArgumentException("Customer not found");
        }
        
        public CustomerDTO LoadCustomer(string id)
        {
            var customer = GetCustomer(id);
            if (customer != null)
            {
                Customers.Remove(customer);
            }
            var customerDto = _apiCallManager.LoadCustomerDetailView(id);
            Customers.Add(new Customer(customerDto));
            return customerDto;
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
            if (customer.Email == null)
            {
                throw new Exception("No email given");
            }
            int id;
            id = _apiCallManager.CreateCustomer(customer);
            customer.Id = id.ToString();
            Customers.Add(new Customer(customer));
            return id;
        }

        public CustomerContainer(IApiCallManager apiCallManager)
        {
            _apiCallManager = apiCallManager;
        }
    }
}