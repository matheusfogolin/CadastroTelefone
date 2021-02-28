using System;

namespace CadastrarTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu número de telefone: ");
            string telefone = Console.ReadLine();

            Cadastro cadastro = new Cadastro(nome, telefone);
            Console.WriteLine(cadastro.CadastrarNumeroTelefone());

        }
    }
}
