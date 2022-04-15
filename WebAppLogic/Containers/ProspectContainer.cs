using System.Collections.Generic;
using LogicLayer.Classes;

namespace LogicLayer.Containers
{
    public class ProspectContainer
    {
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
            //todo get list content from api
        }
    }
}