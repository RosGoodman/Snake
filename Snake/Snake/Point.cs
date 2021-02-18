using System;

namespace Snake
{
    class Point
    {
        private int _x;
        private int _y;
        private char _sym;

        public Point()
        {
        }

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }
}
