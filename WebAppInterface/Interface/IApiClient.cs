namespace InterfaceLayer.Interface
{
    public interface IApiClient
    {
        public string Get(string getUrl);
        public string Post(string body, string postUrl);
    }
}