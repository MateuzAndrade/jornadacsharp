using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine("Regras: Ser mario de 18 anos ou estar acompanhado de outra pessoa.");
            Console.WriteLine("======================");
            int idade, acompanhado;
            string nome, RespostaAcompanhado;

            Console.WriteLine("Bem Vindo, Qual seu Nome?");
            nome = Console.ReadLine();
            Console.WriteLine($"{nome}, preciso que informe sua idade:");
            idade= int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine($"{nome}, Você está acompanhado?");
                Console.WriteLine("S/N?");
                RespostaAcompanhado = Console.ReadLine().ToUpper(CultureInfo.InvariantCulture);
                if(RespostaAcompanhado == "N")
                {
                    Console.WriteLine($"{nome}, devido a sua idade e você não estar acompanhado sua entrada na festa não foi permitida, volte novamente tiver 18 anos ou mais.");
                }
                else
                {
                    Console.WriteLine($"{nome}, Você está acompanhado por quantas pessoas?");
                    acompanhado = int.Parse(Console.ReadLine());
                    if(acompanhado >= 1)
                    {
                    Console.WriteLine($"{nome},você pode entrar na Festa");
                    }
                }
            }
            if (idade >= 18)
            {
                Console.WriteLine($"{nome},você pode entrar na Festa");
            }
           
            
            Console.WriteLine("presione uma tecla para sair.");
            Console.ReadLine();
        }
    }

}
