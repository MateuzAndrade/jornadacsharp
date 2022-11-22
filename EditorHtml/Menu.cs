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

        }

        public static void DrawScreen(int colum , int lines) {

            Console.Write("+");
            for (int i = 1; i <= colum; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
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
            for (int i = 1; i <= colum; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");


        }
        
    
        public static void WriteOptions() {
            Console.SetCursorPosition(3,2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 2);

        }
    }
    
}