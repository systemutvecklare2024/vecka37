using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class Ball
    {
        public int Value { get; set; }
        public bool Picked { get; set; }

        public Ball(int value)
        {
            this.Value = value;
        }

        internal void Display()
        {
            if (Picked)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.Write(Value.ToString().PadLeft(3));

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
