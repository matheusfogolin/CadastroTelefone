namespace CadastrarTelefone
{
    public class Cadastro
    {
        public Cadastro(string nome, string telefone)
        {
            Nome = nome;
            Telefone = Telefone;
        }
        public string Nome { get; private set;}
        public string Telefone { get; private set; }

        public string CadastrarNumeroTelefone()
        {
            return "Cadastro realizado com sucesso.";
        }
    }
}