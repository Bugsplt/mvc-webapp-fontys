using System.Collections.Generic;
using LogicLayer.Classes;
using LogicLayer.Enums;

namespace WebAppProftS2.Models
{
    public class ContactView
    {
        public List<CustomerSelect> PremiumCustomers = new();
        public List<CustomerSelect> FreeCustomers = new();
        public List<CustomerSelect> Prospects = new();
        public Dropdown Dropdown;
        
        public ContactView(IReadOnlyList<Customer> customers, IReadOnlyList<Prospect> prospects)
        {
            // foreach (var prospect in prospects)
            // {
            //     var customerSelect = new CustomerSelect()
            //     {
            //         Id = prospect.ProspectNr,
            //         Email = prospect.Email,
            //         Name = "Cat: " + prospect.CatName,
            //         PhoneNr = prospect.PhoneNr
            //     };
            //     Prospects.Add(customerSelect);
            // }
            
            foreach (var customer in customers)
            {
                FilterPremium(customer);
            }

            Dropdown = Dropdown.All;
        }
        
        private void FilterPremium(Customer customer)
        {
            var customerSelect = new CustomerSelect()
            {
                Id = customer.Id,
                Email = customer.Email,
                Name = "Name: " + customer.FirstName,
                PhoneNr = customer.PhoneNr
            };
            foreach (var search in customer.GetSearches())
            {
        
                if (search.AdStatus == AdStatus.Review || search.AdStatus == AdStatus.Active)
                {
                    PremiumCustomers.Add(customerSelect);
                    return;
                }
            }
        
            FreeCustomers.Add(customerSelect);
        }
    }

    public enum Dropdown
    {
        Premium,
        Free,
        Prospects,
        All
    }
}