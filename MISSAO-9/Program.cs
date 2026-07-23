using System;
namespace MISSAO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = LerQtdNmr();
            string[] produtos = LerProdutos(qtd);
            BuscarProduto(produtos);
        }
        static int LerQtdNmr()
        {
            do
            {
                try{
                    Console.Write("Quantos produtos serão cadastrados: ");
                    int qtd = int.Parse(Console.ReadLine()!);

                    if(qtd <= 0)
                    {
                        Console.WriteLine("Quantidade de produtos deve ser maior que 0");
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
        static string[] LerProdutos(int qtd)
        {
            string[] produtos = new string[qtd];

            for(int i = 0; i < qtd; i++)
            {
                do
                {
                    Console.Write($"Informe o nome do {i + 1}º produto: ");
                    string produto = Console.ReadLine()!.ToUpper();
                    if(string.IsNullOrWhiteSpace(produto))
                    {
                        Console.WriteLine("Nome não pode ser vazio");
                    }
                    else
                    {
                        int indice = ProdutoExiste(produtos, produto, i);

                        if(indice == -1)
                        {
                            produtos[i] = produto;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Produto já foi cadastrado. Informe um nome diferente.");
                        }
                    }
                }while(true);
            }

            return produtos;
        }
        static int ProdutoExiste(string[] produtos, string produto, int qtd)
        {
            for(int i = 0; i < qtd; i++)
            {
                if(produtos[i] == produto)
                {
                    return i;
                }
            }
            return -1;
        }
        static void BuscarProduto(string[] produtos)
        {
            Console.Write("Informe o nome do produto que deseja buscar: ");
            string produto = Console.ReadLine()!.ToUpper();

            int indice = ProdutoExiste(produtos, produto, produtos.Length);
            if(indice != -1)
            {
                Console.WriteLine($"O produto {produto} foi encontrado na {indice + 1}º posição da lista.");
            }
            else
            {
                Console.WriteLine($"O produto {produto} não foi encontrado");
            }
        }

    }
}