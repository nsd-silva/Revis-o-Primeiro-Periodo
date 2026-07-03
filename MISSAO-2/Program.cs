using System;
namespace SEGUNDA_MISSAO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = LerNome();
            double peso = LerPeso();
            double altura = LerAltura();
            double imc = CalculoIMC(peso, altura);

            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"IMC: {imc:F2}");
        }
        static string LerNome()
        {
            do{
                    Console.WriteLine("Digite o nome do aluno: ");
                    string nome = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome inválido. O nome não pode estar vazio ou conter apenas espaços.");
                    }
                    else
                    {
                        return nome;
                    }                
            }while(true);
        }
        static double LerPeso()
        {
            do{
                try{
                    Console.WriteLine("Digite o peso do aluno (kg): ");
                    double peso = double.Parse(Console.ReadLine()!);
                    
                    if (peso <= 0){
                        Console.WriteLine("Peso inválido. Por favor, insira um valor que seja maior que 0.");
                    }
                    else{
                        return peso;
                    }
                }
                catch{
                    Console.WriteLine("Peso inválido. Por favor, insira um valor numérico válido.");
                }
            }while(true);
        }
        static double LerAltura()
        {
            do{
                try{
                    Console.WriteLine("Digite a altura do aluno (m): ");
                    double altura = double.Parse(Console.ReadLine()!);
                    if (altura <= 0 || altura > 3){
                        Console.WriteLine("Altura inválida. Por favor, insira um valor que seja maior que 0 e menor ou igual a 3 (digite em metros).");
                    }
                    else{
                        return altura;
                    }
                }
                catch{
                    Console.WriteLine("Altura inválida. Por favor, insira um valor numérico válido.");
                }
            }while(true);
        }
        static double CalculoIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}