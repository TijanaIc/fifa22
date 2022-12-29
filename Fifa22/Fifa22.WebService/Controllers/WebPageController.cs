using Microsoft.AspNetCore.Mvc;

namespace Fifa22.WebService.Controllers
{
    public class WebPageController : Controller
    {
        public IHttpClientFactory HttpClientFactory { get; }

        public WebPageController(IHttpClientFactory httpClientFactory)
        {
            HttpClientFactory = httpClientFactory;
        }

        [HttpGet("mera-contact-us")]
        public Task<string> Get()
        {
            var httpClient = HttpClientFactory.CreateClient();
            var webPage =  httpClient.GetStringAsync("https://www.orioninc.com/contact-us/");
            return webPage;
        }
    }
}
