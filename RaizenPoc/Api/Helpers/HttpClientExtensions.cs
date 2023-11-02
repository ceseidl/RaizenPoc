using ConsoleApp1;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api.Helpers
{
    public  static class HttpClientExtensions
    {
        public static  async Task<Endereco> GetEnderecoAsync(string Cep)

        {
            string rota = @$"https://viacep.com.br/ws/{Cep}/json/";
            using (HttpClient client = new())
            {
                HttpResponseMessage response = await client.GetAsync(rota);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(content);

                    if (endereco != null)
                        return endereco;


                }
            }
            return null;


        }
    }
}
