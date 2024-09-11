
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

                Console.WriteLine("Press Enter to Draw ball");

                if (won)
                {
                    Console.WriteLine("BINGO!");
                    Console.ReadLine();
                    break;
                }

                var picked = cage.PickBall();
                Console.WriteLine($" Picked ball {picked}");

                won = board.Update(picked);
                

                // PRINT PICKED NUMEROS
                cage.Display();    

                Console.ReadLine();
                Console.Clear();
            }
        }


        
    }
}
