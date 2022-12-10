using System;
using System.Net.Http.Json;

namespace Fifa22.Library
{
    public class HttpClientHelper
    {
        public static T ExecuteRequest<T>(string requestUrl)
        {
            HttpClient httpClient = new HttpClient();
            T result = httpClient.GetFromJsonAsync<T>(requestUrl).Result;
            return result;
        }
    }
}
