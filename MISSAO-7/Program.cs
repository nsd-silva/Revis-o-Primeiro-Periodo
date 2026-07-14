using System;
namespace MISSAO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = LerQtdNmr();
            string[] nomes = LerNomes(qtd);
            string PrimeiroNome = nomes[0];
            string UltimoNome = nomes[qtd - 1];

            Console.WriteLine("Nomes cadastrados:"); 
            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("{0}", nomes[i]);
            }
            Console.WriteLine("O primeiro nome informado foi: {0}", PrimeiroNome);
            Console.WriteLine("O último nome informado foi: {0}", UltimoNome);
            Console.WriteLine("A quantidade de nomes cadastrados foi: {0}", qtd);
        }
        static int LerQtdNmr()
        {
            do
            {
                try{
                    Console.Write("Informe a quantidade de alunos que serão cadastrados: ");
                    int qtd = int.Parse(Console.ReadLine()!);

                    if(qtd <= 0)
                    {
                        Console.WriteLine("Quantidade de alunos deve ser maior que 0");
                    }
                    else
                    {
                        return qtd;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Valor informado não é um número inteiro");
                }
            }while(true);
        }
        static string[] LerNomes(int qtd)
        {
            string[] nomes = new string[qtd];

            for(int i = 0; i < qtd; i++)
            {
                do
                {
                    try{
                        Console.Write($"Informe o {i + 1}º nome: ");
                        string nome = Console.ReadLine()!;
                        if(string.IsNullOrWhiteSpace(nome))
                        {
                            Console.WriteLine("Nome não pode ser vazio");
                        }
                        else
                        {
                            nomes[i] = nome;
                            break;
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Valor informado não é um nome válido");
                    }
                }while(true);
            }

            return nomes;
        }

    }
}