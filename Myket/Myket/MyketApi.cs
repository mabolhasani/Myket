using Myket.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Myket
{
    public class MyketApi
    {
        private readonly Configuration _configuration;
        private readonly HttpClient _client;
        private const string BaseUrl = "https://developer.myket.ir/";
        public MyketApi(Configuration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
        }

        public async Task<VerifyPurchaseResult> VerifyPurchase(string sku, string token)
        {
            _client.DefaultRequestHeaders.Add("X-Access-Token", _configuration.AccessToken);

            var response = await _client.GetAsync(
                $"{BaseUrl}/api/applications/" +
                $"{_configuration.PackageName}/purchases/products/{sku}/tokens/" +
                $"{token}");

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<Result>(
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
