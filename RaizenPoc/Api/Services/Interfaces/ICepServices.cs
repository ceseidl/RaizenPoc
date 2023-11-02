using ConsoleApp1;

namespace Api.Services.Interfaces
{
    public interface ICepServices
    {
        Task<Endereco> GetEndereco(string cep);
    }
}
