using System;
namespace MISSAO_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = LerQtdAlunos();
            string[] alunos = LerAlunos(qtd);
            double[] notas = LerNotas(qtd, alunos);
            BuscarAluno(alunos, notas);
        }
        static int LerQtdAlunos()
        {
            do
            {
                try{
                    Console.Write("Informe a quantidade de alunos que tem na turma: ");
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
        static string[] LerAlunos(int qtd)
        {
            string[] alunos = new string[qtd];

            for(int i = 0; i < qtd; i++)
            {
                do
                {
                    Console.Write($"Informe o nome do {i + 1}º aluno: ");
                    string nome = Console.ReadLine()!.ToUpper();
                    if(string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome não pode ser vazio");
                    }
                    else
                    {
                        int indice = AlunoExiste(alunos, nome, i);
                        if(indice == -1)
                        {
                            alunos[i] = nome;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Aluno já cadastrado. Informe um aluno diferente.");
                        }
                    }
                }while(true);
            }
            return alunos;
        }
        static int AlunoExiste(string[] alunos, string nome, int i)
        {
            for(int j = 0; j < i; j++)
            {
                if(nome == alunos[j])
                {
                    return j;
                }
            }
            return -1;
        }
        static double[] LerNotas(int qtd, string[] alunos)
        {
            double[] notas = new double[qtd];

            for(int i = 0; i < qtd; i++)
            {
                do
                {
                    try{
                        Console.Write($"Informe a nota do aluno {alunos[i]}: ");
                        double nota = double.Parse(Console.ReadLine()!);

                        if(nota < 0 || nota > 10)
                        {
                            Console.WriteLine("Nota deve ser entre 0 e 10");
                        }
                        else
                        {
                            notas[i] = nota;
                            break;
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Valor informado não é um número válido");
                    }
                }while(true);
            }
            return notas;
        }
        static void BuscarAluno(string[] alunos, double[] notas)
        {
            Console.Write("Informe o nome do aluno que deseja buscar: ");
            string nome = Console.ReadLine()!.ToUpper();

            int indice = AlunoExiste(alunos, nome, alunos.Length);
            if(indice != -1)
            {
                Console.WriteLine($"Aluno: {nome}");
                Console.WriteLine($"Nota: {notas[indice]}");
            }
            else
            {
                Console.WriteLine($"O aluno {nome} não foi encontrado");
            }
        }
    }
}