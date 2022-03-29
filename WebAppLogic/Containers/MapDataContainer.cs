using System.Collections.Generic;
using LogicLayer.Classes;

namespace LogicLayer.Containers
{
    public class MapDataContainer
    {
        public List<MapData> MapDataList = new();
        
        public IReadOnlyList<MapData> GetMapDataList()
        {
            return MapDataList;
        }

        public void Add(MapData customer)
        {
            MapDataList.Add(customer);
        }
        
        public void Remove(MapData customer)
        {
            MapDataList.Remove(customer);
        }

        public void Clear()
        {
            MapDataList.Clear();
        }

        public void Load()
        {
            //todo get list content from api
        }
    }
}