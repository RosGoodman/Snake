using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(140, 50);

            HorizontalLine hLine1 = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 24, '#');
            hLine1.Draw();
            hLine2.Draw();

            VerticalLine vLine1 = new VerticalLine(0, 24, 0, '#');
            VerticalLine vLine2 = new VerticalLine(0, 24, 78, '#');
            vLine1.Draw();
            vLine2.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            bool escape = false;
            while (!escape)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                    if (key.Key == ConsoleKey.Escape) escape = true;
                }

                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
