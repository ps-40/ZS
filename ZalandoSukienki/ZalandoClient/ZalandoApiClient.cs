using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace ZalandoSukienki.ZalandoClient
{
    public class ZalandoApiClient
    {
        private HttpClient httpClient;

        public ZalandoApiClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.zalando.com/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.AcceptLanguage.Clear();
            httpClient.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pl-PL"));
        }

        public async Task<string> GetApiHome()
        {
            HttpResponseMessage response = await httpClient.GetAsync("/");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return null;
        }
    }
}