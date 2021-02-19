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

        public Point(Point p)
        {
            _x = p._x;
            _y = p._y;
            _sym = p._sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                _x += offset;
            else if(direction == Direction.LEFT)
                _x -= offset;
            else if (direction == Direction.UP)
                _y += offset;
            else if (direction == Direction.DOWN)
                _y -= offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }
}
