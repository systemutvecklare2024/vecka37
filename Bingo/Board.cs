using Bingo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class Board
    {
        const int WIDTH = 5;
        const int HEIGHT = 5;


        Ball[,] balls = new Ball[WIDTH, HEIGHT];
        List<int> chosen = new List<int>();

        public Board()
        {
            var min = 1;
            var max = 15;

            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    balls[i, j] = GetRandomBall(min, max);
                }
                min += 15;
                max += 15;
            }
        }

        public void Display()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    balls[j, i].Display();
                    if (j == HEIGHT - 1)
                    {
                        Console.Write("\r\n");
                    }
                }
            }
        }

        public Ball GetRandomBall(int min, int max)
        {
            Random rand = new Random();


            while (true)
            {
                var found = rand.Next(min, max);
                if (!chosen.Contains(found))
                {
                    chosen.Add(found);
                    return new Ball(found);
                }
            }
        }

        internal bool Update(int picked)
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    if (balls[i,j].Value == picked)
                    {
                        balls[i, j].Picked = true;

                        return CheckVictory(); ;
                    }
                }
            }

            return false;
        }

        private bool CheckVictory()
        {
            // Check Vertical
            var vertical = 0;
            for(int i = 0;i < WIDTH;i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    if (balls[i,j].Picked == true)
                    {
                        vertical++;
                        if(vertical == 5 )
                        {
                            return true;
                        }
                    }
                }

                vertical = 0;
            }
            // Check Horizontal
            var horizontal = 0;
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    if (balls[j, i].Picked == true)
                    {
                        horizontal++;
                        if (horizontal == 5)
                        {
                            return true;
                        }
                    }
                }

                horizontal = 0;
            }
            // Overkill Diagonal


            return false;
        }
    }
}
