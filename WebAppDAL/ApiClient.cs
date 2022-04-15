using System.IO;
using System.Net;
using System.Text;
using InterfaceLayer.Interface;

namespace WebAppDAL
{
    public class ApiClient : IApiClient
    {
        /// <summary>
        /// Post given data to specified address and returns response as string
        /// </summary>
        public string Post(string body, string postUrl)
        {
            var dataBytes = Encoding.UTF8.GetBytes(body);
            
            var request = (HttpWebRequest)WebRequest.Create(postUrl);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = "application/json";
            request.Method = "POST";
            
            using(var requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }
            using(var response = (HttpWebResponse)request.GetResponse())
            using(var stream = response.GetResponseStream())
            using(var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Gets data from specified url and returns response as string
        /// </summary>
        public string Get(string getUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create(getUrl);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using(var response = (HttpWebResponse)request.GetResponse())
            using(var stream = response.GetResponseStream())
            using(var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}