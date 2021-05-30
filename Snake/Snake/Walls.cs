using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine hLine1 = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine hLine2 = new HorizontalLine(0, mapWidth-2, mapHeight-1, '+');

            VerticalLine vLine1 = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine vLine2 = new VerticalLine(0, mapHeight - 1, mapWidth-2, '+');

            wallList.Add(vLine2);
            wallList.Add(vLine1);
            wallList.Add(hLine1);
            wallList.Add(hLine2);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
