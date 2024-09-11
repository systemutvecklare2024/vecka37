
namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board();
            Cage cage = new Cage();

            var won = false;

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
                    Console.WriteLine("     BINGO!");
                    Console.ReadLine();
                    break;
                }

                var picked = cage.PickBall();
                Console.WriteLine("----------------");
                Console.WriteLine($" Picked ball {picked}");

                won = board.Update(picked);
                

                // PRINT PICKED NUMEROS
                 

                Console.ReadLine();
                Console.Clear();
            }
        }


        
    }
}
