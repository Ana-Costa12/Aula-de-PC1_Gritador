using System;

namespace Aula_de_PC1_Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;

            Console.WriteLine("Digite uma mensagem positiva para seus colegas:");
            mensagem = Console.ReadLine();
            Console.Clear();
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{mensagem}!!!".ToUpper());
            Console.ResetColor();

            //Incentivar os que estão a sua volta gera produtividade e construção de caráter pessoal//
            Console.WriteLine("\n Lembre-se que estamos todos em eterno processo de aprendizagem!\n\n Tecle enter para sair: ");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
