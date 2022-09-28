using System;

namespace textadv
{
    class Program
    {
        public static Player player = new Player();
        public static bool running = true;
        static void Main(string[] args)
        {
            Start();
            Battle.FirstBattle();
            while (running)
            {
                Battle.randomBattle();
            }
        }

        static void Start()
        {
            Console.WriteLine(@" _____    _        _     _                        _             _                 _  ");
            Console.WriteLine(@"|_   _|  | |      | |   | |                      | |           | |               | | ");
            Console.WriteLine(@"  | | ___| | _____| |_  | |__   __ _ ___  ___  __| |   __ _  __| |_   _____ _ __ | |_ _   _ _ __ ___ ");
            Console.WriteLine(@"  | |/ _ \ |/ / __| __| | '_ \ / _` / __|/ _ \/ _` |  / _` |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \ ");
            Console.WriteLine(@"  | |  __/   <\__ \ |_  | |_) | (_| \__ \  __/ (_| | | (_| | (_| |\ V /  __/ | | | |_| |_| | | |  __/");
            Console.WriteLine(@"  \_/\___|_|\_\___/\__| |_.__/ \__,_|___/\___|\__,_|  \__,_|\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|");
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Wat is je naam: ");
            player.name = Console.ReadLine();
            Console.Clear();
            if (player.name == "")
            {
                Console.WriteLine("Je hebt geen naam in gevult");
            }
            else
            {
                Console.WriteLine("Je naam is: " + player.name);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lorem");
            Console.WriteLine("Lorem");
            Console.WriteLine("Battle test");
        }
    }
}
