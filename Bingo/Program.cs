
namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board();
            Cage cage = new Cage();

            var won = false;
            var counter = 0;

            DisplaySplashScreen();
            Console.WriteLine("\r\n     Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                board.Display();
                Console.WriteLine("----------------");
                Console.WriteLine("   Press Enter");

                cage.Display();
                Console.ReadLine();

                if (won)
                {
                    Console.WriteLine("----------------");
                    DisplayBingo();
                    Console.WriteLine("----------------");
                    Console.WriteLine($"It took you {counter} balls to win.");
                    Console.WriteLine("Press Q to quit");

                    while (true)
                    {
                        if (Console.ReadKey().Key == ConsoleKey.Q)
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                var picked = cage.PickBall();
                Console.WriteLine("----------------");
                Console.WriteLine($" Picked ball {picked}");

                won = board.Update(picked);

                Console.ReadLine();
                Console.Clear();
                counter++;
            }
        }

        public static void DisplayBingo()
        {
            Console.Write("     ");
            var letters = "BINGO!";
            ConsoleColor[] colors = new ConsoleColor[]
            {
                ConsoleColor.Red,
                ConsoleColor.Cyan,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
            };

            for (int i = 0; i < letters.Length; i++)
            {
                Console.ForegroundColor = colors[i];
                Console.Write(letters[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void DisplaySplashScreen()
        {
            Console.WriteLine();
            Console.WriteLine();

            string[] bingo = {
                "***____**__*__**__**____***____*****" ,
                "***_____*__*__**__*______*______****",
                "***__*__*__*___*__*__**__*__**__****",
                "***__*__*__*___*__*__**__*__**__****",
                "***__*__*__*___*__*__*****__**__****",
                "***____**__*______*__*****__**__****",
                "***____**__*______*__*___*__**__****",
                "***__*__*__*__*___*__*___*__**__****",
                "***__*__*__*__*___*__**__*__**__****",
                "***__*__*__*__*___*__**__*__**__****",
                "***_____*__*__**__*______*______****",
                "***____**__*__**__**_____**____*****",
             };

            for (int i = 0; i < bingo.Length; i++)
            {
                foreach (char c in bingo[i])
                {
                    if (c == '*')
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
