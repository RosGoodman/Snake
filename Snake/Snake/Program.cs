using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hLine1 = new HorizontalLine(5, 45, 8, '#');
            HorizontalLine hLine2 = new HorizontalLine(5, 45, 28, '#');
            hLine1.Drow();
            hLine2.Drow();

            VerticalLine vLine1 = new VerticalLine(8, 28, 5, '#');
            VerticalLine vLine2 = new VerticalLine(8, 28, 45, '#');
            vLine1.Drow();
            vLine2.Drow();

            Console.ReadLine();
        }
    }
}
