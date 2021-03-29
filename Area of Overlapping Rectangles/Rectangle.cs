using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_Overlapping_Rectangles
{
    class Rectangle
    {
        public Rectangle(int x, int y, int width, int height)
        {
            if (width != 0 && height != 0)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("Wrong input, height and/or width can not be equal to 0");
            }
        }

        public int GetX() { return x; }
        public int GetY() { return y; }
        public int GetHeight() { return height; }
        public int GetWidth() { return width; }

        public override string ToString()
        {
            return $"Rectangle start at [{x}, {y}] with width = {width} and height = {height}";
        }

        private int height = 1;
        private int width = 1;
        private int x = 0;
        private int y = 0;
    }
}
