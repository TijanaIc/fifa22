using System.Net;
using System.Net.Http.Json;

namespace Fifa22.Common
{
    public class HttpClientHelper
    {
        public static T GetRequest<T>(string requestUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                T result = httpClient.GetFromJsonAsync<T>(requestUrl).Result;
                return result;
            }
        }
        public static HttpStatusCode PostRequest<T>(string requestUrl, T data)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.PostAsJsonAsync(requestUrl, data).Result;
                return result.StatusCode;
            }
        }
        public static HttpStatusCode PutRequest<T>(string requestUrl, T data)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.PutAsJsonAsync(requestUrl, data).Result;
                return result.StatusCode;
            }
        }
        public static HttpStatusCode DeleteRequest(string requestUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.DeleteAsync(requestUrl).Result;
                return result.StatusCode;
            }
        }
    }
}
