using System;
namespace PRIMEIRA_MISSAO_GPT
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine()!;
            
            int idade = 0;
            bool validacao = false;
            do{
                try{
                    Console.WriteLine("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine()!);
                    validacao = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Idade inválida. Por favor, insira um número inteiro.");
                }
            }while(!validacao);

            if (idade >= 18)
            {
                Console.WriteLine("Entrada permitida.");
                Console.WriteLine($"Bem-vindo(a), {nome}!");
            }
            else
            {
                Console.WriteLine("Entrada não permitida.");
                Console.WriteLine($"Desculpe, {nome}, você precisa ter pelo menos 18 anos para entrar. Até a próxima!");
            }
        }
    }
}