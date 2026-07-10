using System;
namespace QUINTA_MISSAO_E_MEIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Console.WriteLine("Informe a quantidade de números que serão informados: ");
            qtd = int.Parse(Console.ReadLine()!);

            double[] numeros = new double[qtd];
            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Informe o número: ");
                numeros[i] = double.Parse(Console.ReadLine()!);
            }
            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Número {i + 1}: {numeros[i]}");
            }
        }
    }
}