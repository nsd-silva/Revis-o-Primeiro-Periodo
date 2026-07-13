using System;
namespace MISSAO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = LerQtdNmr();
            int[] numeros = LerNmr(qtd);
        }
        static int LerQtdNmr()
        {
            do
            {
                try{
                    Console.Write("Informe a quantidade de números que serão sorteados: ");
                    int qtd = int.Parse(Console.ReadLine()!);

                    if(qtd <= 0)
                    {
                        Console.WriteLine("Quantidade de números deve ser maior que 0");
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
        static int[] LerNmr(int qtd)
        {
            int[] numeros = new int[qtd];

            for(int i = 0; i < qtd; i++)
            {
                do
                {
                    try{
                        Console.Write($"Informe o {i + 1}º número: ");
                        int numero = int.Parse(Console.ReadLine()!);
                        if(numero <= 0 || numero > 75)
                        {
                            Console.WriteLine("Número deve ser de 1 a 75");
                        }
                        else
                        {
                            bool repetido = false;
                            for(int j = 0; j < i; j++)
                            {
                                if(numero == numeros[j])
                                {
                                    repetido = true;
                                    break;
                                }
                            }
                            if(!repetido)
                            {
                                numeros[i] = numero;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Número já foi informado. Informe outro número.");
                            }
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Valor informado não é um número inteiro");
                    }
                }while(true);
            }

            return numeros;
        }
    }
}