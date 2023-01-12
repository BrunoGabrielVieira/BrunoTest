using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BrunoTestApp.Models;
using Newtonsoft.Json;

namespace BrunoTestApp.Rest
{
    public class RestService
    {
        private readonly HttpClient _client;

        public RestService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(App.API_BASE_ADDRESS)
            };
        }

        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync("products");

                if (response.IsSuccessStatusCode)
                {
                    string productsJson = response.Content.ReadAsStringAsync().Result;
                    products = JsonConvert.DeserializeObject<List<Product>>(productsJson);
                }
            }
            catch (HttpRequestException e)
            {
                //TODO: Handle HttpRequestExceptions
            }

            return products;
        }
    }
}