using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(140, 50);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            bool escape = false;
            while (!escape)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) break;

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else 
                    snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                    if (key.Key == ConsoleKey.Escape) escape = true;
                }

                Thread.Sleep(300);
            }

            static void Draw(Figure figure)
            {
                figure.Draw();
            }

            Console.ReadLine();
        }
    }
}
