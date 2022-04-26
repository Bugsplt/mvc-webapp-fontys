using System.Collections.Generic;
using InterfaceLayer.Interface;
using LogicLayer.Classes;

namespace LogicLayer.Containers
{
    public class ProspectContainer
    {
        private IApiCallManager _apiCallManager;
        public List<Prospect> Prospects = new();

        public IReadOnlyList<Prospect> GetProspects()
        {
            return Prospects;
        }

        public void Add(Prospect customer)
        {
            Prospects.Add(customer);
        }
        
        public void Remove(Prospect customer)
        {
            Prospects.Remove(customer);
        }

        public void Clear()
        {
            Prospects.Clear();
        }

        public void SetProspects(List<Prospect> prospects)
        {
            Prospects = prospects;
        }
        
        public void Load()
        {
            Clear();
            var (prospects, customers) = _apiCallManager.LoadCustomerView();
            foreach (var prospectDto in prospects)
            {
                Prospects.Add(new Prospect(prospectDto));
            }
        }

        public ProspectContainer(IApiCallManager apiCallManager)
        {
            _apiCallManager = apiCallManager;
        }
    }
}