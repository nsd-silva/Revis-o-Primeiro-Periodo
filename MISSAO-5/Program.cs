using System;
namespace MISSAO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = LerNome();
            int qtd = LerQtdNota();
            double[] notas = LerNotas(qtd);
            double media = CalcularMedia(notas);

            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"Quantidade de notas informadas: {qtd}");
            Console.WriteLine($"Média das notas: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                if(media >= 5)
                {
                    Console.WriteLine("Situação: Recuperação");
                }
                else
                {
                    Console.WriteLine("Situação: Reprovado");
                }
            }
        }
        static string LerNome()
        {
            do{
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine()!;
                
                if(string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Nome não pode ser vazio");
                }
                else
                {
                    return nome;
                }
            }while(true);
        }
        static int LerQtdNota()
        {
            do
            {
                try{
                    Console.Write("Informe a quantidade de notas que serão informadas: ");
                    int qtd = int.Parse(Console.ReadLine()!);

                    if(qtd <= 0)
                    {
                        Console.WriteLine("Quantidade de notas deve ser maior que 0");
                    }
                    else 
                    {
                        return qtd;
                    }
                }
                catch
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                }
            }while(true);
        }
        static double[] LerNotas(int qtd)
        {
            double[] notas = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                do
                {
                    try
                    {
                        Console.Write($"Informe a nota {i + 1}: ");
                        double nota = double.Parse(Console.ReadLine()!);

                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("Nota deve ser entre 0 e 10.");
                        }
                        else
                        {
                            notas[i] = nota;
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Digite um número válido.");
                    }

                } while (true);
            }

            return notas;
        }
        static double CalcularMedia(double[] notas)
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }
    }
}