using API_CORE.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
namespace API_CORE.Services
{
    public class APIService : IAPIService
    {
        private static string _user;
        private static string _pass;
        private static string _baseUrl;
        private static string _token;

        public APIService() 
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _user = builder.GetSection("apiSettings:user").Value;
            _pass = builder.GetSection("apiSettings:password").Value;
            _baseUrl = builder.GetSection("apiSettings:baseUrl").Value;
        }

        public async Task Authenticate()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var credentials = new modelCredentials() { Username = _user, Password = _pass };
            var content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Autenticacion/Validar", content);
            var json_response = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<modelResultCredential>(json_response);
            _token = result.token;
        }

        public Task<bool> Delete(int productID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(modelProduct product)
        {
            throw new NotImplementedException();
        }

        public Task<modelProduct> Get(int productID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<modelProduct>> List()
        {
            List<modelProduct> list = new List<modelProduct>();
            await Authenticate();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            var response = await client.GetAsync("api/Producto/Lista");

            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<modelAPIResult>(json_response);
                list = result.list;
            }

            return list;
        }

        public Task<bool> Save(modelProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
