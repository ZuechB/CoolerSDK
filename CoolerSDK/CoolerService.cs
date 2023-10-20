using CoolerSDK.Models;
using System.Net.Http.Json;

namespace CoolerSDK
{
    public interface ICoolerService
    {
        Task<HttpResponseWrapper<ResponsePayload>> RequestFootprint(string apiKey, List<ProductFootprintItem> products, string currency = "USD");
        Task<HttpResponseWrapper<ResponsePayload>> RequestFootprint(string apiKey, ProductFootprintItem product, string currency = "USD");
    }

    public class CoolerService : ICoolerService
    {
        /// <summary>
        /// Calculate footprint for products
        /// </summary>
        /// <returns></returns>
        public async Task<HttpResponseWrapper<ResponsePayload>> RequestFootprint(string apiKey, List<ProductFootprintItem> products, string currency = "USD")
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("COOLER-API-KEY", apiKey);
            var response = await client.PostAsJsonAsync("https://api2.cooler.dev/v1/footprint/products", new ProductFootprint()
            {
                currency = currency,
                items = products
            });

            var wrapper = new HttpResponseWrapper<ResponsePayload>();
            wrapper.httpStatusCode = response.StatusCode;

            if (response != null && response.Content != null)
            {
                wrapper.Content = await response.Content.ReadFromJsonAsync<ResponsePayload>();
            }

            return wrapper;
        }

        /// <summary>
        /// Calculate footprint for a given product
        /// </summary>
        /// <returns></returns>
        public async Task<HttpResponseWrapper<ResponsePayload>> RequestFootprint(string apiKey, ProductFootprintItem product, string currency = "USD")
        {
            var items = new List<ProductFootprintItem>();
            items.Add(product);

            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("COOLER-API-KEY", apiKey);
            var response = await client.PostAsJsonAsync("https://api2.cooler.dev/v1/footprint/products", new ProductFootprint()
            {
                currency = currency,
                items = items
            });

            var wrapper = new HttpResponseWrapper<ResponsePayload>();
            wrapper.httpStatusCode = response.StatusCode;

            if (response != null && response.Content != null)
            {
                wrapper.Content = await response.Content.ReadFromJsonAsync<ResponsePayload>();
            }

            return wrapper;
        }
    }
}