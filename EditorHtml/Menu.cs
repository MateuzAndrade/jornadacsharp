using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen(30,10);
            WriteOptions();


            var Option = short.Parse(Console.ReadLine());
            HandleMenuOption(Option);
        }

        public static void DrawScreen(int colum , int lines) {
            //contrução das colunas superior
            Console.Write("+");
            for (int i = 1; i <= colum; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
            //Construir linhas e espaços entre elas baseado no número de colunas .
            for (int i = 1; i <= lines; i++)
            {
                Console.Write("|");
                for (int x = 1; x <= colum; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            //contrução das colunas inferior.
            for (int i = 1; i <= colum; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
            
        public static void WriteOptions() {
            //Construção do menu exibição inteiro com writeline
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============="); 
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma Opção abaixo");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short Option){
            //aqui eu crio uma opção para selecionar os itens do menu com SWITCH 
            switch (Option)
            {
                case 1: 
                    Console.WriteLine("Editor");
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0:{
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();
                    break;
            }
        }
    
        
    }
    
}