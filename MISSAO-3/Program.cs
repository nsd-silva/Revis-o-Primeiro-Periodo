using System;
namespace MISSAO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = LerNome();
            int idade = LerIdade();
            double salario = LerSalario();
            string resultado = ValidarCriterios(idade, salario);

            Console.WriteLine("====Cadastro de Candidato====");
            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Pretensão Salarial: R${salario:F2}");
            Console.WriteLine($"\nResultado: {resultado}");
        }
        static string LerNome()
        {
            do{
                Console.WriteLine("Digite o nome do candidato: ");
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
        static int LerIdade()
        {
            do
            {
                try{
                    Console.WriteLine("Digite a idade do candidato: ");
                    int idade = int.Parse(Console.ReadLine()!);

                    if(idade <= 0)
                    {
                        Console.WriteLine("Idade deve ser um número maior que 0");
                    }
                    else 
                    {
                        if(idade < 16)
                        {
                            return idade;
                        }
                        else
                        {
                            return idade;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Idade deve ser um número inteiro");
                }    
            }while(true);
        }
        static double LerSalario()
        {
            do
            {
                try{
                    Console.WriteLine("Digite a pretensão salarial do candidato: ");
                    double salario = double.Parse(Console.ReadLine()!);

                    if(salario <= 0)
                    {
                        Console.WriteLine("Pretensão salarial deve ser um número maior que 0");
                    }
                    else 
                    {
                        return salario;
                    }
                }
                catch
                {
                    Console.WriteLine("Pretensão salarial deve ser um número válido");
                }    
            }while(true);
        }
        static string ValidarCriterios(int idade, double salario)
        {
            if(idade >= 18 && salario <= 5000)
            {
                return "Funcionário apto para contratação.";
            }
            else
            {
                return "Funcionário não apto para contratação.";
            }
        }
    }
}