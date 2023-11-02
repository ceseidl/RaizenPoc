namespace Api.Data
{
    public class ClienteQueries
    {
        public const string SALVAR_CLIENTE = @"INSERT INTO Cliente
(
 Nome,Email,DataNascimento,CEP,Logradouro,Complemento,Bairro,Cidade,Uf
)
VALUES
(
@Nome,@Email,@DataNascimento,@CEP,@Logradouro,@Complemento,@Bairro,@Cidade@Uf
)";
        public const string OBTER_CLIENTE = @"select Id,Nome,Email,DataNascimento,CEP,Logradouro,Complemento,Bairro,Cidade,Uf from Cliente";
        public const string OBTER_CLIENTE_ID = @"select Id,Nome,Email,DataNascimento,CEP,Logradouro,Complemento,Bairro,Cidade,Uf from Cliente Where Id = @Id";
        public const string ATUALIZAR_CLIENTE = @"UPDATE Cliente
SET
    Nome = @Nome,
    Email = @email,
    DataNascimento=@DataNascimento,
    CEP=@CEP,
    Logradouro=@Logradouro,
    Complemento=@Complemento,
    Bairro=@Bairro,
    Cidade=@Cidade,
    Uf=@Uf
WHERE 	/* add search conditions here */
Id= @Id";
    }
}
