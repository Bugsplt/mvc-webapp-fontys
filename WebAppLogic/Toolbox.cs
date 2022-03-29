using LogicLayer.Containers;
using WebAppDAL.DAL;

namespace LogicLayer
{
    public static class Toolbox
    {
        public static ApiClient ApiClient = new();
        public static RequestBuilder RequestBuilder = new();
        public static CustomerContainer CustomerContainer = new();
        public static MapDataContainer MapDataContainer = new();
        public static ProspectContainer ProspectContainer = new();
    }
}