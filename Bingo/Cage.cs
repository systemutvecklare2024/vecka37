using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class Cage
    {

        List<int> taken = new List<int>();
        int[] cage = GenerateCage();

        public int PickBall()
        {
            Random rand = new Random();


            while (true)
            {
                var found = rand.Next(1, 75);
                if (!taken.Contains(found))
                {
                    taken.Add(found);
                    return found;
                }
            }
        }

        private static int[] GenerateCage()
        {
            int[] cage = new int[75];
            for (int i = 0; i < 75; i++)
            {
                cage[i] = i + 1;
            }

            return cage;
        }

        public void Display()
        {
            Console.WriteLine("----------------");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < taken.Count; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{taken[i].ToString().PadLeft(3)}");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
