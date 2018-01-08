using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ButlerClient
{
    public class Butler : IButler
    {
        private ButlerOptions options;

        public Butler(IOptions<ButlerOptions> optionsAccessor)

        {
            options = optionsAccessor.Value;
        }

        public async Task<string> InstallAsync(WebhookRequest request)
        {
            var client = new HttpClient();
            var res = await client.PostAsync(new Uri(new Uri(options.ButlerEndpoint), "/api/v1/webhook"),
                new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            var result = await res.Content.ReadAsStringAsync();
            return result;
        }
    }
}
