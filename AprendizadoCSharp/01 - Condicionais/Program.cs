using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Treinando Condicionais");
            Console.WriteLine("======================");
            Console.WriteLine("Entrada em Festa");
            Console.WriteLine("======================");


            Console.WriteLine("Bem Vindo, Qual seu Nome?");
            string nome = Console.ReadLine();
            Console.WriteLine($"{nome}, preciso que informe sua idade:");
            int idade= int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine($"{nome},você pode entrar na Festa");
            }
            else
            {
                Console.WriteLine($"{nome}, devido a sua idade sua entrada na festa não foi permitida, volte novamente tiver 18 anos ou mais.");
            }

           
            Console.WriteLine("presione uma tecla para sair.");
            Console.ReadLine();

        }
    }
}
