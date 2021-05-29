using System;

namespace Snake
{
    class Point
    {
        private int _x;
        private int _y;
        private char _sym;

        public char Sym
        {
            get => _sym;
            set => _sym = value;
        }

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
            switch (direction)
            {
                case Direction.RIGHT: 
                    _x += offset;
                    break;
                case Direction.LEFT:
                    _x -= offset;
                    break;
                case Direction.UP:
                    _y -= offset;
                    break;
                case Direction.DOWN:
                    _y += offset;
                    break;
            }
        }

        internal void Clear()
        {
            _sym = ' ';
            Draw();
        }

        /// <summary>Проверить, является ли следующая точка едой.</summary>
        /// <param name="food">Следующая точка.</param>
        /// <returns>Является / не является.</returns>
        internal bool IsHit(Point nextPoint)
        {
            return nextPoint._x == this._x && nextPoint._y == this._y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }

        public override string ToString()
        {
            return _x + ", " + _y + ", " + _sym;
        }
    }
}
