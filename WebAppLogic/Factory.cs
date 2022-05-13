using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Containers;
using WebAppDAL;


namespace LogicLayer
{
    public class Factory
    {
        public CustomerContainer CustomerContainer;
        public MapDataContainer MapDataContainer;
        public ProspectContainer ProspectContainer;

        public Factory()
        {
            IApiClient apiClient = new ApiClient();
            IRequestBuilder requestBuilder = new RequestBuilder();
            IApiCallManager apiCallManager = new ApiCallManager(apiClient, requestBuilder);
            MapDataContainer = new MapDataContainer(apiCallManager);
            CustomerContainer = new CustomerContainer(apiCallManager);
            ProspectContainer = new ProspectContainer(apiCallManager);
        }
    }
}