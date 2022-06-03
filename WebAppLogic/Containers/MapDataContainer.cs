using System.Collections.Generic;
using InterfaceLayer.Interface;
using LogicLayer.Classes;


namespace LogicLayer.Containers
{
    public class MapDataContainer
    {
        private IApiCallManager _apiCallManager;
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
            foreach (var mapDataDto in _apiCallManager.LoadMapData())
            {
                MapDataList.Add(new MapData(mapDataDto));
            }
        }

        public MapDataContainer(IApiCallManager apiCallManager)
        {
            _apiCallManager = apiCallManager;
        }
    }
}