using System;
using static System.Console;

namespace Area_of_Overlapping_Rectangles
{
    class Program
    {
        //Link to the challenge https://edabit.com/challenge/Jj6S7qQgtfAo4L2QR

        public static bool DoRectanglesOverlap(Rectangle R1, Rectangle R2)
        {
            if (R1.GetX() + R1.GetWidth() <= R2.GetX() || R2.GetX() + R2.GetWidth() <= R1.GetX())
            {
                WriteLine("\nRectangles do not overlap each other.\n");
                return false; //When they're left to each other
            }

            if(R1.GetY() + R1.GetHeight() <= R2.GetY() || R2.GetY() + R2.GetHeight() <= R1.GetY())
            {
                WriteLine("\nRectangles do not overlap each other.\n");
                return false; //When they're above each other
            }

            return true;
        }
        public static int OverlappingRectanglesArea(Rectangle R1, Rectangle R2)
        {
            DoRectanglesOverlap(R1, R2);

            int x_dist = (Math.Min((R1.GetX() + R1.GetWidth()), (R2.GetX() + R2.GetWidth())) - Math.Max(R1.GetX(), R2.GetX()));
            int y_dist = (Math.Min((R1.GetY() + R1.GetHeight()), (R2.GetY() + R2.GetHeight())) - Math.Max(R1.GetY(), R2.GetY()));

            int area = 0;
            if (x_dist > 0 && y_dist > 0)
            {
                area = x_dist * y_dist;
            }

            return area;
        }
        

        static void Main(string[] args)
        {
            Rectangle Rec1 = new Rectangle(2, 1, 3, 4);
            Rectangle Rec2 = new Rectangle(3, 2, 2, 5);

            WriteLine(OverlappingRectanglesArea(Rec1, Rec2)); // = 6

            Rectangle Rec3 = new Rectangle(2, -9, 11, 5);
            Rectangle Rec4 = new Rectangle(5, -11, 2, 9);

            WriteLine(OverlappingRectanglesArea(Rec3, Rec4));// = 10

            Rectangle Rec5 = new Rectangle(-8, -7, 4, 7);
            Rectangle Rec6 = new Rectangle(-5, -9, 4, 7);

            WriteLine(OverlappingRectanglesArea(Rec5, Rec6));// = 5
        }
    }
}
