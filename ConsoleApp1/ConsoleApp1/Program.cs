using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public static class Program
    {

        private const string _address = @"https://viacep.com.br/ws/80320190/json/";
        private const string _userAgent = "TestApp";
        static async Task Main(string[] args)
        {
            var a = await GetAsync(_address);
        }


        public static async Task<Endereco> GetAsync(string rota)

        {
            using (HttpClient client = new())
            {
                HttpResponseMessage response = await client.GetAsync(rota);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                   Endereco jokes = JsonConvert.DeserializeObject<Endereco>(content);

                    if (jokes != null)
                        return jokes;

                    
                }
            }
            return null;


        }
    }
}