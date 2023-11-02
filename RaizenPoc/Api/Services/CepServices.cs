using ConsoleApp1;
using Api.Helpers;
using Api.Services.Interfaces;

namespace Api.Services
{
    public class CepServices :ICepServices
    {
        public CepServices()
        {
            
        }
        public async Task<Endereco> GetEndereco(string cep)
        {

            var endereco = await HttpClientExtensions.GetEnderecoAsync(cep);
            return endereco;

        }
    }
}
