internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine("1 - Abrir um documento");
            Console.WriteLine("2 - Criar um novo documento");
            Console.WriteLine("0 - Fechar programa");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;

                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            System.Console.WriteLine("Digite o caminho do aquivo");
            System.Console.WriteLine("--------------------------");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                System.Console.WriteLine(text);
            };

            System.Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto (presione ESC para sair)");
            Console.WriteLine("----------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Save(text);

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual Caminho para salvar o documento?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            System.Console.WriteLine($"Documento {path} alvo com sucesso!");
            
            Console.ReadLine();
            
            Menu();
        }
    }
}
}