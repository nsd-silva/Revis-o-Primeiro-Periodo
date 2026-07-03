using System;
namespace SEGUNDA_MISSAO_E_MEIA
{
    class Program
    {
        static void Main(string[] args){
            string titulo = LerTitulo();
            string autor = LerAutor();
            string genero = LerGenero();
            string codigo = LerCodigo();

            Console.WriteLine("O cadastro foi concluído com sucesso!");
            Console.WriteLine($"--- Livro Cadastrado ---");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Código: {codigo}");
        }
        static string LerTitulo(){
            do
            {
                Console.WriteLine("Digite o título do livro: ");
                string titulo = Console.ReadLine()!;
                if(string.IsNullOrWhiteSpace(titulo))
                {
                    Console.WriteLine("Título inválido. O título não pode estar vazio ou conter apenas espaços.");
                }
                else
                {
                    return titulo;
                }
            }while(true);
        }
        static string LerAutor()
        {
            do
            {
                Console.WriteLine("Digite o autor do livro:");
                string autor = Console.ReadLine()!;

                if(string.IsNullOrWhiteSpace(autor))
                {
                    Console.WriteLine("Autor inválido. O autor não pode estar vazio ou conter apenas espaços.");
                }
                else
                {
                    return autor;
                    
                }
            }while(true);
        }
        static string LerGenero(){
            do
            {
                    Console.WriteLine("Digite o gênero do livro:");
                    string genero = Console.ReadLine()!;

                    if(string.IsNullOrWhiteSpace(genero))
                    {
                        Console.WriteLine("Gênero inválido. O gênero não pode estar vazio ou conter apenas espaços.");
                    }
                    else
                    {
                        if(genero.Length < 3)
                        {
                           Console.WriteLine("Gênero inválido. O gênero não pode ter menos que 3 caracteres.");
                        }
                        else
                        {
                            return genero;
                        }
                    }
            }while(true);
        }
        static string LerCodigo()
        {
            do
            {
                Console.WriteLine("Digite o código do livro:");
                string codigo = Console.ReadLine()!;

                if(string.IsNullOrWhiteSpace(codigo) || codigo.Contains(" "))
                {
                    Console.WriteLine("Código inválido. O código não pode estar vazio ou conter espaços.");
                }
                else
                {
                    if(codigo.Length != 6)
                    {
                        Console.WriteLine("Código inválido. O código deve ter exatamente 6 caracteres.");
                    }
                    else
                    {
                        return codigo;
                    }
                }
            }while(true);
        }
    }
}