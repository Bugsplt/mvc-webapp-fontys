using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Interface;
using LogicLayer.Containers;
using WebAppDAL;

namespace LogicLayer
{
    public class Toolbox
    {
        public IApiClient ApiClient;
        public IRequestBuilder RequestBuilder;
        public IApiCallManager ApiCallManager;
        public CustomerContainer CustomerContainer;
        public MapDataContainer MapDataContainer;
        public ProspectContainer ProspectContainer;

        public Toolbox()
        {
            ApiClient = new ApiClient();
            RequestBuilder = new RequestBuilder();
            ApiCallManager = new ApiCallManager(ApiClient, RequestBuilder);
            MapDataContainer = new MapDataContainer(ApiCallManager);
            CustomerContainer = new CustomerContainer(ApiCallManager);
            ProspectContainer = new ProspectContainer(ApiCallManager);
        }
    }
}