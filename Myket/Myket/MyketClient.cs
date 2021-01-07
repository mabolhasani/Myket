using Myket.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Myket
{
    public class MyketClient
    {
        private readonly MyketConfiguration _configuration;
        private readonly HttpClient _client;
        private const string BaseUrl = "https://developer.myket.ir/";
        public MyketClient(MyketConfiguration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
        }

        public async Task<VerifyPurchaseResult> VerifyPurchaseAsync(string sku, string token)
        {
            _client.DefaultRequestHeaders.Add("X-Access-Token", _configuration.AccessToken);

            var response = await _client.GetAsync(
                $"{BaseUrl}/api/applications/" +
                $"{_configuration.PackageName}/purchases/products/{sku}/tokens/" +
                $"{token}");

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<PurchaseResult>(
                    await response.Content.ReadAsStringAsync());

                return new VerifyPurchaseResult(result);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<Error>(
                    await response.Content.ReadAsStringAsync());

                return new VerifyPurchaseResult(result);
            }
        }
    }
}
