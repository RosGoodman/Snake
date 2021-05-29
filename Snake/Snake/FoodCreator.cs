using System;

namespace Snake
{
    class FoodCreator
    {
        private int _mapWidth;
        private int _mapHeight;
        private char _sym;

        Random random = new Random();

        /// <summary>Экземпляр класса FoodCreator.</summary>
        /// <param name="x">Размер экрана по оси X.</param>
        /// <param name="y">Размер экрана по оси Y.</param>
        /// <param name="sym">Символ еды.</param>
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, _mapWidth - 2);
            int y = random.Next(2, _mapHeight - 2);
            return new Point(x, y, _sym);
        }
    }
}
