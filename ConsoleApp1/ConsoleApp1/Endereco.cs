using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string Cep;

        [JsonProperty("logradouro")]
        public string Logradouro;

        [JsonProperty("complemento")]
        public string Complemento;

        [JsonProperty("bairro")]
        public string Bairro;

        [JsonProperty("localidade")]
        public string Localidade;

        [JsonProperty("uf")]
        public string Uf;

        [JsonProperty("ibge")]
        public string Ibge;

        [JsonProperty("gia")]
        public string Gia;

        [JsonProperty("ddd")]
        public string Ddd;

        [JsonProperty("siafi")]
        public string Siafi;
    }
}
