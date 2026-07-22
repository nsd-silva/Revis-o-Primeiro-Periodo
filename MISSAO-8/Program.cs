using System; 
namespace MISSAO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = LerQtdNmr();
            string[] nomes = LerNomes(qtd);
            BuscarNome(nomes);
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
                    Console.Write($"Informe o nome do {i + 1}º aluno: ");
                    string nome = Console.ReadLine()!;
                    nome = nome.ToUpper();
                    if(string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome não pode ser vazio");
                    }
                    else
                    {
                        if(!NomeExiste(nomes, nome, i))
                        {
                            nomes[i] = nome;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nome já foi informado. Informe um nome diferente.");
                        }
                    }
                }while(true);
            }
            return nomes;
        }
        static bool NomeExiste(string[] nomes, string nome, int i)
        {
            for(int j = 0; j < i; j++)
            {
                if(nome == nomes[j])
                {
                    return true;
                }
            }
            return false;
        }
        static void BuscarNome(string[] nomes)
        {
            Console.Write("Informe o nome que deseja buscar: ");
            string nomeBuscado = Console.ReadLine()!;
            nomeBuscado = nomeBuscado.ToUpper();

            if(NomeExiste(nomes, nomeBuscado, nomes.Length))
            {
                Console.WriteLine("O nome informado foi encontrado na lista.");
            }
            else
            {
                Console.WriteLine("O nome informado não foi cadastrado.");
            }
        }
    }
}