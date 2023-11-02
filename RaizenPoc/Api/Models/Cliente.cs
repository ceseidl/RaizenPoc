using ConsoleApp1;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email {get;set;}
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set;}
        public Endereco Endereco { get; set; }
    }
}
