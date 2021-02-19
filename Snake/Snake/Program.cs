using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine hLine1 = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 24, '#');
            hLine1.Drow();
            hLine2.Drow();

            VerticalLine vLine1 = new VerticalLine(0, 24, 0, '#');
            VerticalLine vLine2 = new VerticalLine(0, 24, 78, '#');
            vLine1.Drow();
            vLine2.Drow();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }
}
